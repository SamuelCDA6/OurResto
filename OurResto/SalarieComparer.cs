using System.Collections.Generic;
using System.Windows.Forms;

namespace OurResto
{
    class SalarieComparer : IComparer<cda68_bd1DataSet.SalarieRow>
    {
        private readonly string _memberName = string.Empty;
        private readonly SortOrder _sortOrder = SortOrder.None;

        public SalarieComparer(string memberName, SortOrder sortingOrder)
        {
            _memberName = memberName;
            _sortOrder = sortingOrder;
        }

        /// <summary>
        /// Comparateur spécifique aux lignes de salariés
        /// </summary>
        /// <param name="firstRow">Première ligne à comparer</param>
        /// <param name="secondRow">Deuxième ligne à comparer</param>
        /// <returns>Résultat de la comparaison</returns>
        public int Compare(cda68_bd1DataSet.SalarieRow firstRow, cda68_bd1DataSet.SalarieRow secondRow)
        {
            if (_sortOrder != SortOrder.Ascending)
            {
                var tmp = firstRow;
                firstRow = secondRow;
                secondRow = tmp;
            }

            return _memberName switch
            {
                "Nom" => firstRow.Nom.CompareTo(secondRow.Nom),
                "Prenom" => firstRow.Prenom.CompareTo(secondRow.Prenom),
                "Matricule" => firstRow.Matricule.CompareTo(secondRow.Matricule),
                "Email" => firstRow.Email.CompareTo(secondRow.Email),
                "EstActif" => firstRow.EstActif.CompareTo(secondRow.EstActif),
                _ => firstRow.Matricule.CompareTo(secondRow.Matricule),
            };
        }
    }
}
