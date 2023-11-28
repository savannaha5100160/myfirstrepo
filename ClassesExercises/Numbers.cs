using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercises
{
    internal class Numbers
    {
        static void main ()
        {
            int[] numbers = { -1, 2, 4, 6, 9 };

            int positivecount = 0;
            int negativecount = 0;

            foreach (int number in numbers )
            {
                if (number > 0)
                {
                    positivecount++;
                }
                else if (number <0)
                {
                    negativecount++;
                }
            }
            Console.WriteLine("array:{" + string.Join(",", numbers) + "}");
            Console.WriteLine("Total positive:" + positivecount);
            Console.WriteLine("Total negative:" + negativecount):
        }
    }
}
