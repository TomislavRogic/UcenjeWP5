using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class InstrukcijeTryCatch
    {
        public static void Izvedi()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zabranjeno je djeljenje s nulom");
            }
            catch (Exception e)
            {
                Console.WriteLine("Doslo je do greske: " + e.Message);
            }


            Console.WriteLine("Kraj");
        }
    }
}
