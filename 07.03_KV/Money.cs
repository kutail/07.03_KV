using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03_KV
{
    public class Money
    {
        public double Sum { get; set; }
        public Money(double sum)
        {
            Sum = sum;
        }
        public static implicit operator Money(double sum)
        {
            return new Money(sum);
        }
        public static Money operator + (Money a, Money b)
        {
            return new Money(a.Sum + b.Sum);
        }
        public static Money operator + (Money a, double b)
        {
            Money res = a + b;
            return res;
        }
        public static Money operator - (Money a, Money b)
        {
            return new Money(a.Sum - b.Sum);
        }
        public static Money operator - (Money a, double b)
        {
            Money res = a - b;
            return res;
        }
        public static Money operator * (Money a, int b)
        {
            return new Money(a.Sum * b);
        }
        public static Money operator / (Money a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Нельзя делить на 0");
            }
            return new Money(a.Sum / b);
        }
        public static Money operator ++ (Money num)
        {
            return new Money(num.Sum + 0.1);
        }
        public static Money operator -- (Money num)
        {
            return new Money(num.Sum - 0.1);
        }
        public static bool operator > (Money a, Money b)
        {
            return a.Sum > b.Sum;
        }
        public static bool operator < (Money a, Money b)
        {
            return a.Sum < b.Sum;
        }
        public static bool operator == (Money a, Money b)
        {
            return a.Sum == b.Sum;
        }
        public static bool operator != (Money a, Money b)
        {
            return a.Sum != b.Sum;
        }
        public bool IsNegative()
        {
            return Sum < 0;
        }
    }
}
