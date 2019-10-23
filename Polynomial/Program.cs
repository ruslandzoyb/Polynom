using System;
using System.Linq;

namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // Polynom polynom = new Polynom("-x^2g-3x-4");
                 Polynom polynom = new Polynom("x^2-3x-8");
            Polynom polynom1 = new Polynom("3x+5x");

           // Console.WriteLine(polynom.Max);
           // Console.WriteLine(polynom1.Max);
            Console.WriteLine("dvd");
            Operations.Sum(polynom, polynom1);
           
            //polynom.Show();

           // polynom.Show();
              Console.WriteLine();
          //  polynom1.Show();
            //polynom1.Show();
          //  Console.WriteLine(Operations.Sum(polynom, polynom1)); 
            
                Console.ReadKey();
            

          
            
        }
    }
}
