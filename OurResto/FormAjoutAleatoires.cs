using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace OurResto
{
    public partial class FormAjoutAleatoires : Form
    {
        private Thread thread;

        cda68_bd1DataSetTableAdapters.MenuTableAdapter menuTableAdapter = new cda68_bd1DataSetTableAdapters.MenuTableAdapter();
        cda68_bd1DataSetTableAdapters.MomentTableAdapter momentTableAdapter = new cda68_bd1DataSetTableAdapters.MomentTableAdapter();
        cda68_bd1DataSetTableAdapters.v_platsTableAdapter v_PlatsTableAdapter = new cda68_bd1DataSetTableAdapters.v_platsTableAdapter();
        cda68_bd1DataSetTableAdapters.v_affichermenuTableAdapter v_AffichermenuTableAdapter = new cda68_bd1DataSetTableAdapters.v_affichermenuTableAdapter();

        public FormAjoutAleatoires(DateTime dateMonday, DateTime dateFriday)
        {
            InitializeComponent();
            dTPDateDebut.Value = dateMonday;
            dTPDateFin.Value = dateFriday;
        }

        private void FormAjoutAleatoires_Load(object sender, EventArgs e)
        {
            Manager.ResizeImage(btAjouter, Properties.Resources.Add_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            menuTableAdapter.Fill(cda68_bd1DataSet.Menu);
            momentTableAdapter.Fill(cda68_bd1DataSet.Moment);
            v_PlatsTableAdapter.Fill(cda68_bd1DataSet.v_plats);
            v_AffichermenuTableAdapter.Fill(cda68_bd1DataSet.v_affichermenu);

            thread = new Thread(new ThreadStart(RandomWeekMeals))
            {
                IsBackground = true
            };
            thread.Start();
            while (thread.IsAlive)
            {
                Thread.Sleep(200);
            }
            Close();
            
        }

        private void RandomWeekMeals()
        {
            var random = new Random();
            List<int> days = new();

            for (int i = 0; i < cLBJours.Items.Count; i++)
            {
                if (cLBJours.GetItemChecked(i))
                {
                    days.Add(i);
                }
            }

            var dates = EachDay(dTPDateDebut.Value.Date, dTPDateFin.Value.Date, days).ToList();

            var moments = cda68_bd1DataSet.Moment.Select(r => r.Id_Moment).ToList();

            // Récupère tous les menus de la semaine en cours
            var menus = cda68_bd1DataSet.v_affichermenu.Where(r => r.RepasDate >= dTPDateDebut.Value.Date && r.RepasDate <= dTPDateFin.Value.Date).ToList();

            // Récupère tous les plats de chaque type et enleve ceux qui sont déjà dans les menus de la semaine
            var Entrees = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 1 && !menus.Any(m => m.Id_Plat_Entree == r.Id_Plat)).ToList();
            var PlatsPrincipaux = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 2 && !menus.Any(m => m.Id_Plat_Principal == r.Id_Plat)).ToList();
            var Accompagnements = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 3 && !menus.Any(m => m.Id_Plat_Accompagnement == r.Id_Plat)).ToList();
            var Fromages = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 4 && !menus.Any(m => m.Id_Plat_Fromage == r.Id_Plat)).ToList();
            var Desserts = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 5 && !menus.Any(m => m.Id_Plat_Dessert == r.Id_Plat)).ToList();

            // Les stocker dans un tableau de liste de plats
            List<cda68_bd1DataSet.v_platsRow>[] PlatsLists = { Entrees, PlatsPrincipaux, Accompagnements, Fromages, Desserts };

            int max = ((moments.Count * dates.Count) - menus.Count) * PlatsLists.Length;

            try
            {
                using var trans = new TransactionScope();

                // Pour chaque date de la semaine
                foreach (DateTime dt in dates)
                {
                    // Pour chaque moment repas
                    foreach (int idmoment in moments)
                    {
                        // Si il n'y a pas deja de menu à cette date et ce moment
                        if (!menus.Any(m => m.Id_Moment == idmoment && m.RepasDate == dt))
                        {
                            // Pour chaque type de plat
                            foreach (List<cda68_bd1DataSet.v_platsRow> plats in PlatsLists)
                            {
                                // Récupérer un plat aléatoire
                                int i = random.Next(0, plats.Count);

                                // Ajouter le plat dans le SGBD
                                if (menuTableAdapter.Insert(plats[i].Id_Plat, idmoment, dt) != 1)
                                {
                                    // Si le plat n'a pas pus être insérer, prévenir l'utilisateur et quitter la méthode 
                                    // pour ne pas continuer inutilement les insertions et ne pas valider la transaction
                                    MessageBox.Show(menus.Count == 49 ?
                                                        String.Format(Properties.Resources.TXTADDMENU,
                                                                      cda68_bd1DataSet.Moment.First(m => m.Id_Moment == idmoment).Nom,
                                                                      dt.ToString("D")) :
                                                        Properties.Resources.TXTADDMENUS);
                                    return;
                                }

                                // Enlever le plat de la liste pour ne pas le réutiliser
                                plats.RemoveAt(i);

                                // Incrémenter et mettre à jour la barre de progression
                                Progress(i * 100 / max);
                            }
                        }
                    }
                }

                // Si tous les plats on bien étés insérés, valider la transaction
                trans.Complete();
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTADDMENUS);
            }
        }

        private void Progress(int pourcentage)
        {
            lblProgressBar.Text = $"Ajouts à {pourcentage} % terminé";
            progressBar.Value = pourcentage;
            progressBar.Update();
        }

        private static IEnumerable<DateTime> EachDay(DateTime startDate, DateTime endDate, List<int> days)
        {
            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
            {
                if (days.Contains((int)day.DayOfWeek))
                {
                    yield return day;
                }
            }
        }

        private void DTP_CloseUp(object sender, EventArgs e)
        {
            if (dTPDateFin.Value < dTPDateDebut.Value)
            {
                dTPDateFin.Value = dTPDateDebut.Value;
            }
        }
    }
}
