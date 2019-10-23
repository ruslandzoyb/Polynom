using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Operations
    {
        //public static int i=0;

        public static void Sum(Polynom one, Polynom two)
        {
            if (one.Variable == two.Variable)
            {


                int i = one.CompareTo(two);
                var variable = one.Variable;
                Dictionary<int, int> Coefficient = new Dictionary<int, int>();
                Dictionary<int, string> Variables = new Dictionary<int, string>();
                Dictionary<int, int> Exponents = new Dictionary<int, int>();



                int j = 0;
                int k = 0;
                bool check = false;
                while (i > 0)
                {
                    foreach (var item in one.Exponents)
                    {
                        k = 0;
                        if (item.Value == i)
                        {
                            Coefficient[j] = item.Value;
                            Variables[j] = variable;
                            Exponents[j] = i;
                            check = true;
                        }
                        if ( one.Variables[k]==null&&i==1)
                        {
                            Console.WriteLine(item.Value);
                        }
                        k++;
                        
                    }

                   /* foreach (var item in two.Exponents)
                    {
                        if (item.Value == i)
                        {
                            Coefficient[j] += item.Value;
                            Variables[j] = variable;
                            Exponents[j] = i;
                            check = true;
                        }
                    }*/

                    if (check == true)
                    {
                        j++;
                        check = false;
                    }
                   

                   // Console.WriteLine(Coefficient[0]);
                   // Console.WriteLine(Variables[0]);


                 
                    --i;
                }
            }
            else
            {
                throw new Exception("Different variables");
            }
        }
    }
}
