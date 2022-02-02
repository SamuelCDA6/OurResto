using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace OurResto
{
    internal class Manager
    {
        /// <summary>
        /// Permet de redimensionner et placer une image sur un bouton a un emplacement spécifique
        /// </summary>
        /// <param name="bt">Bouton auquel ajouter l'image</param>
        /// <param name="bitmap">Image à ajouter</param>
        /// <param name="alignment">Emplacement de l'image</param>
        internal static void ResizeImage(Button bt, Bitmap bitmap, ContentAlignment alignment)
        {
            bt.Image = new Bitmap(bitmap, new Size(bt.Height - 6, bt.Height - 6));
            bt.ImageAlign = alignment;
        }

        /// <summary>
        /// Méthode pour récupérer une image d'un DataGridView
        /// </summary>
        /// <param name="dataGridView">DataGridView auquel récupérer l'image</param>
        /// <returns>Image du DataGridView</returns>
        public static Bitmap MakeImage(DataGridView dataGridView)
        {
            // Redimentionner le DataGridView à la taille de toute les lignes
            var height = dataGridView.Height;            
            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height;

            dataGridView.ClearSelection();

            // Créer une image et dessiner le DataGridView dessus
            var bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));

            // Remettre le DataGridView à la taille originale
            dataGridView.Height = height;

            return bitmap;
        }

        /// <summary>
        /// Affiche la fenêtre d'apercu du document
        /// </summary>
        /// <param name="printDocument">Document à imprimer</param>
        /// <param name="printPreviewDialog">Fenetre d'apercu</param>
        /// <param name="isLandscape">Afficher en mode paysage?</param>
        public static void ShowPrintPreview(PrintDocument printDocument, PrintPreviewDialog printPreviewDialog, bool isLandscape)
        {
            // Afficher le Fenêtre d'apercu du document
            printDocument.DefaultPageSettings.Landscape = isLandscape;
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Size = new Size(printPreviewDialog.Document.PrinterSettings.PaperSizes[^1].Width, printPreviewDialog.Document.PrinterSettings.PaperSizes[^1].Height);
            printPreviewDialog.PrintPreviewControl.Zoom = 0.75;
            printPreviewDialog.DesktopLocation = new Point(0, 0);
            printPreviewDialog.ShowDialog();
        }
    }
}
