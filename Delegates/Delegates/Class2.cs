using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Class2
    {
        private int _value = 0;
        public Predicate<int> Calc(Func<int, int, int> multiply, int x, int y)
        {
            _value = multiply(x, y);
            Console.WriteLine(_value);
            Predicate<int> result = Result;
            return result;
        }

        public bool Result(int value)
        {
            int result = _value % value;
            Console.WriteLine(result);
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
