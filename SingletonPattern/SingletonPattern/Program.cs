using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass.getInstance();

            Console.WriteLine(SingletonClass.i);

            SingletonClass.getInstance();

            SingletonClass.getInstance();

            Console.WriteLine(SingletonClass.i);

            Console.ReadKey();

        }
    }
}
