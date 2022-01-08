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

            return _memberName switch
            {
                "Nom" => x.Nom.CompareTo(y.Nom),
                "Prenom" => x.Prenom.CompareTo(y.Prenom),
                "Matricule" => x.Matricule.CompareTo(y.Matricule),
                "Email" => x.Email.CompareTo(y.Email),
                _ => x.Matricule.CompareTo(y.Matricule),
            };
        }
    }
}
