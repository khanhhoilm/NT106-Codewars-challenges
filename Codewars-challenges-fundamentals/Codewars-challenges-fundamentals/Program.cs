using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            string bmi = codewars_fundamentals.Bmi(50, 150);
            Console.WriteLine("YOUR BMI: " + bmi);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
