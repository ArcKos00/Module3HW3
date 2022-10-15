using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Class1
    {
        private Action<bool> _action = Program.Show;
        private Func<int, int, int> _toDo = Multiply;

        public static int Multiply(int x, int y) => x * y;

        public void ARARAT()
        {
            _action(new Class2().Calc(_toDo, ReturnValue(), ReturnValue())(ReturnValue()));
        }

        public int ReturnValue()
        {
            int x = 0;
            Console.WriteLine("Введите число: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }

                Console.WriteLine("Введите корректное значение: ");
            }

            return x;
        }
    }
}
