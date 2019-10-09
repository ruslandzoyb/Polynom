using System;


namespace Polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Polynom polynom = new Polynom("-x^2-3x-4");
                polynom.Show();
            }
            catch (Exception)
            {

                throw;
            }

            finally {
                Console.ReadKey();
            }

          
            
        }
    }
}
