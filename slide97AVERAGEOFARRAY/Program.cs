using System;

namespace slide97AVERAGEOFARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] nbrs =
                {
               754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
               187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
               460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
               690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
               435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };

                var highest = 0;
                var lowest = 1000;
                var sum = 0;
                var count = 0;


                foreach (var nbr in nbrs)
                {
                    if (nbr > highest)
                    {
                        highest = nbr;
                    }
                    if (nbr < lowest)
                    {
                        lowest = nbr;
                    }
                    count = count + 1;
                    sum = sum + nbr;
                }
                Console.WriteLine($"The average of the {count} numbers is {sum / count}");
                Console.WriteLine($"Highest us {highest } and the lowest is {lowest}");
                
            }
        }
    }

}
    

/* 
      count = count + 1; is same as count++
  for loop as opposed to the foreach loop
            for(var idx = 0; idx < nbrs.Lenght; id++) 
        {var nbr = nbrs[idx];           
*/