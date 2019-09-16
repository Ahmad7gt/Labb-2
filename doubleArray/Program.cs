
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
               try
            {
                double[] height = new double[3];
                height[0] = 0;
                height[1] = 0;
                height[2] = 0;
                
                //How tall are family members?//
                Console.WriteLine("How tall is your father?");
                height[0] = double.Parse(Console.ReadLine());


                Console.WriteLine("How tall is your mother?");
                height[1] = double.Parse(Console.ReadLine());

                Console.WriteLine("How tall is your old sister?");
                height[2] = double.Parse(Console.ReadLine());

                //Calculate total height and  the average  for family members //
                double TotalHeight = height[0] + height[1] + height[2];
                double HeightAverage = height[0] + height[1] + height[2] / 3;
               


                //Write the anserws to the member//
                Console.WriteLine("The total height of the famille is " + TotalHeight+ ".");
                Console.WriteLine("Click Enter...");
                Console.ReadLine();
                Console.WriteLine("The average height of the famille is" + HeightAverage+".");
                
                Console.ReadLine();



                
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Please type in numbers instead of letters.");
            }

            Console.ReadKey();
        }
    }
}
