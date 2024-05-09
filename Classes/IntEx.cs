using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestManager.Classes
{
    public class IntEx : IEquatable<IntEx>
    {
        private int _value;

        public IntEx() { 
            _value = 0;
        }
        public IntEx(int value)
        {
            _value = value;

            if (_value < -1) _value = -1;
        }

        public static IntEx operator + (IntEx x, IntEx y)
        {
            return new IntEx(x._value + y._value);
        }

        public static IntEx operator -(IntEx x, IntEx y)
        {
            return new IntEx(x._value - y._value);
        }

        public static IntEx operator *(IntEx x, IntEx y)
        {
            return new IntEx(x._value * y._value);
        }

        public static IntEx operator /(IntEx x, IntEx y)
        {
            return new IntEx(x._value / y._value);
        }

        public static IntEx operator +(IntEx a) => a;
        public static IntEx operator -(IntEx a) => new IntEx(-a._value);

        public static IntEx operator +(IntEx x, int y)
        {
            return new IntEx(x._value + y);
        }

        public static IntEx operator -(IntEx x, int y)
        {
            return new IntEx(x._value - y);
        }

        public static IntEx operator *(IntEx x, int y)
        {
            return new IntEx(x._value * y);
        }

        public static IntEx operator /(IntEx x, int y)
        {
            return new IntEx(x._value / y);
        }

        public static implicit operator int (IntEx x) => x._value;
        public static implicit operator IntEx(int x) => new IntEx(x);

        public static bool operator ==(IntEx left, IntEx right)
        {
            return EqualityComparer<IntEx>.Default.Equals(left, right);
        }

        public static bool operator !=(IntEx left, IntEx right)
        {
            return !(left == right);
        }

        public static bool operator ==(IntEx left, int right)
        {
            return EqualityComparer<IntEx>.Default.Equals(left, right);
        }

        public static bool operator !=(IntEx left, int right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IntEx);
        }

        public bool Equals(IntEx other)
        {
            return !(other is null) &&
                   _value == other._value;
        }

        public override int GetHashCode()
        {
            return -1939223833 + _value.GetHashCode();
        }
    }
}
