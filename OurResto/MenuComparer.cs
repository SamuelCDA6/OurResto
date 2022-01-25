using System.Collections.Generic;
using System.Windows.Forms;

namespace OurResto
{
    class MenuComparer : IComparer<cda68_bd1DataSet.v_affichermenuRow>
    {
        private readonly string memberName = string.Empty;
        private readonly SortOrder sortOrder = SortOrder.None;

        public MenuComparer(string memberName, SortOrder sortingOrder)
        {
            this.memberName = memberName;
            sortOrder = sortingOrder;
        }

        public int Compare(cda68_bd1DataSet.v_affichermenuRow x, cda68_bd1DataSet.v_affichermenuRow y)
        {
            if (sortOrder != SortOrder.Ascending)
            {
                var tmp = x;
                x = y;
                y = tmp;
            }

            return memberName switch
            {
                "RepasDate" => x.RepasDate.CompareTo(y.RepasDate),
                "Moment" => x.Moment.CompareTo(y.Moment),
                "Entree" => x.Entree.CompareTo(y.Entree),
                "Plat" => x.Plat.CompareTo(y.Plat),
                "Accompagnement" => x.Accompagnement.CompareTo(y.Accompagnement),
                "Fromage" => x.Fromage.CompareTo(y.Fromage),
                "Dessert" => x.Dessert.CompareTo(y.Dessert),
                _ => x.RepasDate.CompareTo(y.RepasDate),
            };
        }
    }
}
