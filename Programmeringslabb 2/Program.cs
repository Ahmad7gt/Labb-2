using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmeringslabb_2
{
  
        public sealed class IndexOutOfRangeException : SystemException
    {
        static void Main(string[] args)
        {
            int[] ages = new int[1];
            ages[0] = 0;
            ages[1] = 0;

            Console.WriteLine("Hur gammal är din äldsta släkting?");
            ages[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur gammal är din yngsta släkting?");
            ages[1] = int.Parse(Console.ReadLine());

            int ageDifference = ages[0] - ages[1]; 



            Console.WriteLine("Det skiljer " + ageDifference + " antal år mellan din älsta och yngsta släkting");
            Console.ReadKey();

        }
    }
}
