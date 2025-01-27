using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOPAssignment
{
    public class Duration : IComparable<Duration>, ICloneable
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Timing(hours, minutes, seconds);
        }
        public Duration(int totalSeconds)
        {
            Timing(0, 0, totalSeconds);
        }
        public int CompareTo(Duration compare)
        {
            if (this > compare) return 1;
            if (this < compare) return -1;
            return 0;
        }
        public object Clone()
        {
            return new Duration(Hours, Minutes, Seconds);
        }
        private void Timing(int hours, int minutes, int seconds)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration equality)
            {
                return Hours == equality.Hours && Minutes == equality.Minutes && Seconds == equality.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (Hours * 3600 + Minutes * 60 + Seconds).GetHashCode();
        }
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(left.Hours + right.Hours, left.Minutes + right.Minutes, left.Seconds + right.Seconds);
        }
        public static Duration operator +(Duration left, int seconds)
        {
            return new Duration(left.Hours, left.Minutes, left.Seconds + seconds);
        }
        public static Duration operator +(int seconds, Duration right)
        {
            return right + seconds;
        }
        public static Duration operator -(Duration left, Duration right)
        {
            int totalSeconds = (left.Hours * 3600 + left.Minutes * 60 + left.Seconds) -
                               (right.Hours * 3600 + right.Minutes * 60 + right.Seconds);
            return new Duration(totalSeconds);
        }
        public static Duration operator ++(Duration left)
        {
            return new Duration(left.Hours, left.Minutes + 1, left.Seconds);
        }
        public static Duration operator --(Duration left)
        {
            return new Duration(left.Hours, left.Minutes - 1, left.Seconds);
        }
        public static bool operator >(Duration left, Duration right)
        {
            return (left.Hours * 3600 + left.Minutes * 60 + left.Seconds) >
                   (right.Hours * 3600 + right.Minutes * 60 + right.Seconds);
        }
        public static bool operator <(Duration left, Duration right)
        {
            return right > left;
        }
        public static bool operator >=(Duration left, Duration right)
        {
            return !(left < right);
        }
        public static bool operator <=(Duration left, Duration right)
        {
            return !(left > right);
        }
        public static explicit operator DateTime(Duration left)
        {
            return new DateTime(01, 01, 01, left.Hours, left.Minutes, left.Seconds);
        }
    }
}
