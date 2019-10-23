using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Polynomial
{
    class Polynom : IComparable
    {
        private string line;
        const char plus = '+';
        const char minus = '-';
       
      
        List<string> elements = new List<string>();


        // private Dictionary<char, int> sign_coeff;
        // private Dictionary<char, int> var_expon;
        public int Length { get { return this.elements.Capacity; } }
        public string Variable { get; set; }
        public int Max { get; private set; }

      //  Dictionary<int, char> Signs = new Dictionary<int, char>();
       public Dictionary<int, int> Coefficient = new Dictionary<int, int>();
       public Dictionary<int, string> Variables = new Dictionary<int, string>();
       public Dictionary<int, int> Exponents = new Dictionary<int, int>();
        public Polynom()
        {

        }
        public Polynom(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                throw new ArgumentException("Строка пустая или не иниа", nameof(line));
            }
            this.line = line;
            Parser();
        }

        private void Parser()
        {
            int i = 0;
            int position=0;
            while (i<line.Length)
            {
                if (i == line.Length - 1)
                {
                    elements.Add(line.Substring(position, line.Length-position ));

                }

                if (line[i]=='+'||line[i]=='-')
                {
                    
                    if (i>0)
                    {
                        
                        elements.Add(line.Substring(position, i-position));
                       
                        
                    }
                    
                    position = i;

                }
                if (char.IsWhiteSpace(line[i]))
                {
                    throw new Exception("Первый пробел");
                }
                
                ++i;
            }
            
            for (int j = 0; j < elements.Count; j++)
            {
                char sign = plus;
                string digit = string.Empty;
                string variable = string.Empty;
                int ex = 1;
                i = 0;
                
                while (i<elements[j].Length)
                {
                    
                    if ( elements[j][i]==plus||elements[j][i]==minus)
                    {
                        sign = elements[j][i];

                    }
                    if (char.IsDigit(elements[j][i]))
                    {
                        
                        digit+=elements[j][i];
                    }
                     if (char.IsLetter(elements[j][i]))
                    {
                        if (variable == string.Empty)
                        {
                            variable = (elements[j][i].ToString());
                            Variable = variable;
                        }
                        else
                        {
                            throw new Exception("Повторение переменной");
                        }

                        
                    }
                    
                        
                    
                 
                    if (elements[j][i]=='^')
                    { 
                        int k = i;
                        string str = elements[j].Substring(++k, elements[j].Length - k);
                        ex = Int32.TryParse(str, out ex) ? ex : throw new Exception("Символ не является строкой");
                        

                        i = elements[j].Length-1;

                    }
                    if (i== elements[j].Length-1)
                    {
                        if (digit==string.Empty)
                        {
                            digit = "1";

                        }
                        int dig= Convert.ToInt32(digit);
                        dig = sign == plus ? dig : -dig;
                        //Signs[j] = sign;
                        Coefficient[j] = dig;
                        Variables[j] = variable;
                        Exponents[j] = ex;
                    }
                   
                    ++i;
                }
               

            }


            Max=Exponents.Values.Max();

        }

       
        public void Show()
        {
            int max;
            
            foreach (var item in Coefficient)
            {
                Console.WriteLine($"Coefficient {item} ");
            }
            foreach (var item in Variables)
            {
                Console.WriteLine($"Variable {item} ");
            }
            foreach (var item in Exponents)
            {
                
                Console.WriteLine($"Exponent  {item} ");


            }
          


           // Console.WriteLine(max);
           
        }

        public int CompareTo(object obj)
        {
            if (obj is Polynom polynom)
            {
                int max;
               return max = this.Max > polynom.Max ? Max : polynom.Max;
            }
            throw new NotImplementedException();
        }
    }
      


}



   
