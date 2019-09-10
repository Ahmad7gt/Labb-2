using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDifference
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] ages = new int[2];
                ages[0] = 0;
                ages[1] = 0;
                //Be användaren att mata in ålder och spara i array//
                Console.WriteLine("Hur gammal är din äldsta släkting?");
                ages[0] = int.Parse(Console.ReadLine());


                Console.WriteLine("\nHur gammal är din yngsta släkting?");
                ages[1] = int.Parse(Console.ReadLine());

                //Räkna ut antalet år som skiljer mellan de två inmatade värdena samt hur många timmar det är på ett år//
                int ageDifference = ages[0] - ages[1];
                int hoursInAYear = 365 * 24;
                int secondsInAYear = hoursInAYear * 3600;
                int minutesInAYear = hoursInAYear * 60;
                

                //Skriv ut svaret till användaren//
                Console.WriteLine("\nDet skiljer cirka " + ageDifference * hoursInAYear + " timmar i ålder mellan din äldsta och yngsta släkting");
                Console.WriteLine("Tryck Enter...");
                Console.ReadLine();
                Console.WriteLine("\nDet motsvarar " + minutesInAYear * ageDifference + " minuter");
                Console.WriteLine("Hur många sekunder kan det bli? Tryck Enter");
                Console.ReadLine();
                
                

                Console.WriteLine("\nI sekunder blir det " + secondsInAYear * ageDifference + " sekunder");
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + " \nDu måste skriva in svaret med siffror.");
            }

            Console.ReadKey();
            
        }
    }
}
