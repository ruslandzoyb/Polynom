using System;


namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {

            Polynom polynom = new Polynom("x2+3x+4");
            polynom.Show();
            Console.ReadKey();
        }
    }
}
