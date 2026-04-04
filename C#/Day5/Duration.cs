using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Day5
{
    internal class Duration
    {
        public int hours {  get; set; }
        public int minutes {  get; set; }
        public int seconds {  get; set; }


        // constructors
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Duration(int _seconds)
        {
            hours = _seconds / (60*60);
            _seconds = _seconds - (60 * 60) * hours;
            minutes = _seconds / 60;
            _seconds = _seconds - minutes * 60;
            seconds = _seconds;
        }
        public Duration():this(0,0,0)
        {
            
        }

        // private methods
        private static int ConvertToSeconds(Duration d)
        {
            return d.hours * 60 * 60 + d.minutes * 60 + d.seconds;
        }

        // override
        public override string ToString()
        {
            if (hours > 0)
                return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds} ";
            else if (minutes > 0)
                return $"Minutes: {minutes}, Seconds: {seconds} ";
            else
                return $"Seconds: {seconds} ";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is Duration)
            {
                return this == (Duration)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hours, minutes, seconds);
        }

        // operator overloading
        
        public static bool operator ==(Duration a, Duration b)
        {
            return ConvertToSeconds(a) == ConvertToSeconds(b);
        }
       
        public static bool operator !=(Duration a, Duration b)
        {
            return ConvertToSeconds(a) != ConvertToSeconds(b);
        }
       
        public static bool operator >(Duration a, Duration b)
        {
            return ConvertToSeconds(a) > ConvertToSeconds(b);
        }
       
        public static bool operator <(Duration a, Duration b)
        {
            return ConvertToSeconds(a) < ConvertToSeconds(b);
        }
       
        public static bool operator >=(Duration a, Duration b)
        {
            return ConvertToSeconds(a) >= ConvertToSeconds(b);
        }
       
        public static bool operator <=(Duration a, Duration b)
        {
            return ConvertToSeconds(a) <= ConvertToSeconds(b);
        }

        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration(ConvertToSeconds(a) + ConvertToSeconds(b));
        }
        public static Duration operator +(Duration a, int b)
        {
            return new Duration(ConvertToSeconds(a) + b);
        }
        public static Duration operator +(int a, Duration b)
        {
            return new Duration(a + ConvertToSeconds(b));
        }

        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration(ConvertToSeconds(a) - ConvertToSeconds(b));
        }
        public static Duration operator -(Duration a, int b)
        {
            return new Duration(ConvertToSeconds(a) - b);
        }
        public static Duration operator -(int a, Duration b)
        {
            return new Duration(a - ConvertToSeconds(b));
        }

        public static Duration operator -(Duration d)
        {
            return new Duration(-d.hours, -d.minutes, -d.seconds);
        }


        public static Duration operator ++(Duration d)
        {
            int h = d.hours;
            int m = d.minutes;
            int s = d.seconds;

            if (m + 1 == 60)
            {
                h++;
                m = 0;
            }
            else
                m++;
            return new Duration(h, m, s);
        }

        public static Duration operator --(Duration d)
        {
            int h = d.hours;
            int m = d.minutes;
            int s = d.seconds;

            if (m - 1 == -1)
            {
                h--;
                m = 59;


            }
            else
                m--;
            return new Duration(h, m, s);
        }

        public static implicit operator bool(Duration d)
        {
            return ConvertToSeconds(d) > 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddHours(d.hours).AddMinutes(d.minutes).AddSeconds(d.seconds);
        }
        


    }
}
