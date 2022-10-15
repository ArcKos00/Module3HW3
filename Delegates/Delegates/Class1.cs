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

        public void Execute(int x, int y, int z)
        {
            _action(new Class2().Calc(_toDo, x, y)(z));
        }
    }
}
