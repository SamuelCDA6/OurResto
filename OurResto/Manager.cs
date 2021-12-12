using System.Drawing;
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
    }
}
