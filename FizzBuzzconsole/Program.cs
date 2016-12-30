using FizzBuzz.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=30; i++)
            {
                Console.WriteLine(FizzBuzzer.Getvalue(i));
            }
            Console.ReadLine();
        }
    }
}
