using System;

namespace OurResto
{
    static class DateTimeExtensions
    {
        /// <summary>
        /// fonction pour une date qui retourne la date du jour spécifié de la semaine
        /// </summary>
        /// <param name="date">date à partir de laquelle calculer le jour</param>
        /// <param name="day">jour de la semaine pour lequel on veut la date</param>
        /// <returns>la nouvelle date au jour de la semaine voulue</returns>
        public static DateTime WeekDay(this DateTime date, DayOfWeek day)
        {
            //int diff = (7 + (date.DayOfWeek - day)) % 7;
            //return date.AddDays(-1 * diff).Date;
            return date.AddDays(day - date.DayOfWeek).Date;
        }
    }
}
