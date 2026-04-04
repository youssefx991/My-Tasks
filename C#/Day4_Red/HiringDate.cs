using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Red
{
    /// <summary>
    /// Represents a specific date used for hiring purposes.
    /// </summary>
    /// <remarks>
    /// hiring date is represented by three integer fields: day, month, and year.
    /// </remarks>
    public struct HiringDate : IComparable<HiringDate>
    {
        /// <summary>
        /// gets or sets the day of the date
        /// </summary>
        public int day { get; set; }

        /// <summary>
        /// gets or sets the month of the date
        /// </summary>
        public int month { get; set; }

        /// <summary>
        /// gets or sets the year of the date
        /// </summary>
        public int year { get; set;}


        /// <summary>
        /// initializes a new instance of the hiring date
        /// </summary>
        /// <param name="_day">day of the date</param>
        /// <param name="_month">month of the date</param>
        /// <param name="_year">year of the date</param>
        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }


        /// <summary>
        /// creates a string representation of the hiring date in the format "day/month/year"
        /// </summary>
        /// <returns>string representation of the hiring date</returns>
        public override string ToString(){
            return $"{day}/{month}/{year}";
        }


        /// <summary>
        /// compares hiring date based on datetime comparer function
        /// where the hiring date that was hired earlier is considered less than the one that was hired later
        /// </summary>
        /// <param name="other">other date to compare with</param>
        /// <returns>
        /// negative if this date was  before the other, 
        /// positive if this date was  after the other, 
        /// and zero if they were on the same date
        /// </returns>
        public int CompareTo(HiringDate other)
        {
            DateTime d1 = new DateTime(year, month, day);
            DateTime d2 = new DateTime(other.year, other.month, other.day);
            return d1.CompareTo(d2);
        }
    }
}
