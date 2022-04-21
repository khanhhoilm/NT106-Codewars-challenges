using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Nhom 10
Lê Minh Hưng - 20521362
Phạm Chấn Huy - 20521411
Lương Đức Huy - 20521397
Ngô Viết Hiển - 20521306
Ngô Quốc Khôi - 20521478
*/
namespace Codewars_challenges_fundamentals
{
    internal class Group10
    {
        public static int Sum(int[] numbers)
        {
            /*Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).

    The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

    Mind the input validation.*/
            if (numbers != null)
            {
                if (numbers.Length == 1 || numbers.Length == 0)
                    return 0;
                else
                {
                    int min = numbers[0];
                    int max = numbers[0];
                    int sum = 0;
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (min > numbers[i])
                            min = numbers[i];
                        if (max < numbers[i])
                            max = numbers[i];
                    }
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    sum -= max + min;
                    return sum;
                }
            }
            return 0;

        }
    }
    
    
}
