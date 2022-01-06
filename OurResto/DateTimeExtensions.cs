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
        /// <param name="hour">heure à laquelle l'on veux la date</param>
        /// <returns>la nouvelle date au jour de la semaine voulue</returns>
        public static DateTime WeekDay(this DateTime date, DayOfWeek day, int hour)
        {
            int nbDays = (date.DayOfWeek == DayOfWeek.Sunday) ? (int)day - 7 : day - date.DayOfWeek;
            return date.AddDays(nbDays).AddHours(hour);
        }
    }
}
