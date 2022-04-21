using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{
    class codewars_fundamentals
    {
        /*Write function bmi that calculates body mass index (bmi = weight / height2).

           if bmi <= 18.5 return "Underweight"

           if bmi <= 25.0 return "Normal"

           if bmi <= 30.0 return "Overweight"

           if bmi > 30 return "Obese"*/
        public static string Bmi(double weight, double height)
        {
            double body_mass_index = weight / (height * 2);


            if (body_mass_index <= 18.5)
                return "Underweight";
            else if (body_mass_index <= 25.0)
                return "Normal";
            else if (body_mass_index <= 30.0)
                return "Overweight";
            else if (body_mass_index > 30)
                return "Obese";
            return "";
        }
    }
}
