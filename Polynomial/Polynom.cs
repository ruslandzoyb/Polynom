using System;
using System.Collections;
using System.Collections.Generic;


using System.Threading.Tasks;

namespace Polynomial
{
    class Polynom
    {
        private string line;
        const char plus = '+';
        const char minus = '-';
        char sign;
        string[] positive;
        string[] negative;
        List<string> elements = new List<string>();


        // private Dictionary<char, int> sign_coeff;
        // private Dictionary<char, int> var_expon;
        Dictionary<int, char> Signs = new Dictionary<int, char>();
        Dictionary<int, int> Coefficient = new Dictionary<int, int>();
        Dictionary<int, string> Variables = new Dictionary<int, string>();
        Dictionary<int, int> Exponents = new Dictionary<int, int>();

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


        }
        public void Show()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(elements[i]);
              
            }
            Console.WriteLine(elements.Count);
        }

    }
      


}



   
