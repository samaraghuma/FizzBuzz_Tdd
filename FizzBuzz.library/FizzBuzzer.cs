using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.library
{
    public class FizzBuzzer
    {
        public static string Getvalue(int input)
        {
            if (input == 3)
                return "Fizz";
            return input.ToString();
        }
    }
}
