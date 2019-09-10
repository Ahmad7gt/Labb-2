using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] arr4 = new string[3];

                arr4[0] = "one";

                arr4[1] = "two";

                arr4[2] = "three";

                //Be användaren att skriva in två meningar//
                Console.WriteLine("Skriv en mening");
                arr4[0] = Console.ReadLine();

                Console.WriteLine("\nSkriv en till mening");
                arr4[1] = Console.ReadLine();

                //Slå ihop dom två inmatade meningarna//
                string wholeSentence;
                wholeSentence = arr4[0] + arr4[1];

             
                //Räkna ut och visa hur många tecken dom innehåller//
                Console.WriteLine("\nMeningarna som du skrev innehåller " + wholeSentence.Length + " tecken");
                Console.WriteLine("\nDen första meningen innehåller " + arr4[0].Length + " tecken och den andra innehåller " + arr4[1].Length + " tecken");
                Console.ReadLine();

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + "\nDu måste skriva något för att komma vidare..Försök igen!");

            }
            

            Console.ReadKey();
            
        }
    }
}
