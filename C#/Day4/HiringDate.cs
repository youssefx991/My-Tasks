using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    internal struct HiringDate
    {
        public int day;
        public int month;
        public int year;

        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }

        public override string ToString(){
            return $"{day}/{month}/{year}";
        }
    }
}
