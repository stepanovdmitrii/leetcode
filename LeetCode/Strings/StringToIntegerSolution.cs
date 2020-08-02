using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Strings
{
    public sealed class StringToIntegerSolution
    {
        private static readonly int Max = int.MaxValue / 10;
        private static readonly int Min = int.MinValue / 10;

        public int MyAtoi(string str)
        {
            int result = 0;

            if(false == TryGetSign(str, out int sign, out int index))
            {
                return 0;
            }

            while(index < str.Length && TryParse(str[index], out int value))
            {
                if(IsOverflow(result, sign, value))
                {
                    return result > 0 ? int.MaxValue : int.MinValue;
                }
                result = result * 10 + sign * value;
                ++index;
            }

            return result;
        }

        private static bool IsOverflow(int result, int sign, int value)
        {
            if (result < Max && result > Min) return false;
            if (result > Max) return true;
            if (result < Min) return true;
            if (sign > 0) return value > 7;
            else return value > 8;
        }

        private static bool TryParse(char ch, out int value)
        {
            switch (ch)
            {
                case '0': { value = 0; return true; };
                case '1': { value = 1; return true; };
                case '2': { value = 2; return true; };
                case '3': { value = 3; return true; };
                case '4': { value = 4; return true; };
                case '5': { value = 5; return true; };
                case '6': { value = 6; return true; };
                case '7': { value = 7; return true; };
                case '8': { value = 8; return true; };
                case '9': { value = 9; return true; };
                default: { value = 0; return false; };
            }
        }

        private bool TryGetSign(string str, out int sign, out int next)
        {

            for(int index = 0; index < str.Length; ++index)
            {
                if(str[index] == '+')
                {
                    sign = 1;
                    next = index + 1;
                    return true;
                }

                if(str[index] == '-')
                {
                    sign = -1;
                    next = index + 1;
                    return true;
                }

                if (Char.IsDigit(str[index]))
                {
                    sign = 1;
                    next = index;
                    return true;
                }

                if(str[index] == ' ')
                {
                    continue;
                }

                break;
            }

            sign = 0;
            next = str.Length;
            return false;
        }
    }
}
