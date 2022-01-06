﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            switch (memberName)
            {
                case "RepasDate":
                    return x.RepasDate.CompareTo(y.RepasDate);
                case "Moment":
                    return x.Moment.CompareTo(y.Moment);
                case "Entree":
                    return x.Entree.CompareTo(y.Entree);
                case "Plat":
                    return x.Plat.CompareTo(y.Plat);
                case "Accompagnement":
                    return x.Accompagnement.CompareTo(y.Accompagnement);
                case "Fromage":
                    return x.Fromage.CompareTo(y.Fromage);
                case "Dessert":
                    return x.Dessert.CompareTo(y.Dessert);
                default:
                    return x.RepasDate.CompareTo(y.RepasDate);
            }
        }
    }
}
