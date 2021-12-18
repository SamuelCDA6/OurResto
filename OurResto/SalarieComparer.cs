using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public int Compare(cda68_bd1DataSet.SalarieRow x, cda68_bd1DataSet.SalarieRow y)
        {
            if (_sortOrder != SortOrder.Ascending)
            {
                var tmp = x;
                x = y;
                y = tmp;
            }

            switch (_memberName)
            {
                case "Nom":
                    return x.Nom.CompareTo(y.Nom);
                case "Prenom":
                    return x.Prenom.CompareTo(y.Prenom);
                case "Matricule":
                    return x.Matricule.CompareTo(y.Matricule);
                case "Email":
                    return x.Email.CompareTo(y.Email);
                default:
                    return x.Matricule.CompareTo(y.Matricule);
            }
        }
    }
}
