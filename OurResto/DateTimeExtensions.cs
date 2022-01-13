using System;

namespace OurResto
{
    static class DateTimeExtensions
    {
        /// <summary>
        /// fonction pour une date qui retourne la date et l'heure du jour spécifié de la semaine
        /// </summary>
        /// <param name="date">date à partir de laquelle calculer le jour</param>
        /// <param name="day">jour de la semaine pour lequel on veut la date</param>
        /// <param name="hour">heure à laquelle l'on veux la date</param>
        /// <returns>la nouvelle date au jour et à l'heure de la semaine voulue</returns>
        public static DateTime WeekDay(this DateTime date, DayOfWeek day, int hour)
        {
            int nbDays = (int)day - date.JourSemaine();
            return date.Date.AddDays(nbDays).AddHours(hour);
        }

        public static int JourSemaine(this DateTime date)
        {
            return date.DayOfWeek switch
            {
                DayOfWeek.Monday => 1,
                DayOfWeek.Tuesday => 2,
                DayOfWeek.Wednesday => 3,
                DayOfWeek.Thursday => 4,
                DayOfWeek.Friday => 5,
                DayOfWeek.Saturday => 6,
                DayOfWeek.Sunday => 7,
                _ => 0,
            };
        }
    }
}
