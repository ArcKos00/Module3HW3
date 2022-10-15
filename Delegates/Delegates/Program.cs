using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    public class Program
    {
        private static int _x = 10;
        private static int _y = 10;
        private static int _z = 4;
        public static void Main(string[] args)
        {
            new Class1().Execute(_x, _y, _z);
        }

        public static void Show(bool success)
        {
            Console.WriteLine(success);
        }
    }
}