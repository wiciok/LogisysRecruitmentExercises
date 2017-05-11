using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            CharInvertor charInvertor=new CharInvertor();

            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine(charInvertor.CharInversion(input));
            }
        }
    }
}
