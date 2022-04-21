using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenges_fundamentals
{
    class group09_solution
    {
            public static string AlphabetPosition(string text)
            {
                text.Split(' ').join('');
                var chari = "";
                var arr = [];
                var alphabet = "abcdefghijklmnopqrstuvwxyz".Split('');
                for (var i = 0; i < text.len; i++)
                {
                    chari = text.charAt(i).toLowerCase();
                    if (alphabet.indexOf(chari) > -1)
                    {
                        arr.push(alphabet.indexOf(chari));
                    }
                }
                return arr;
            }
        
    }
}
