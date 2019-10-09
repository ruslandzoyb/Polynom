﻿using System;
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
       
      
        List<string> elements = new List<string>();


        // private Dictionary<char, int> sign_coeff;
        // private Dictionary<char, int> var_expon;
        private int Length { get { return this.elements.Capacity; } }
        private string Variable { get; set; }

        Dictionary<int, char> Signs = new Dictionary<int, char>();
        Dictionary<int, int> Coefficient = new Dictionary<int, int>();
        Dictionary<int, string> Variables = new Dictionary<int, string>();
        Dictionary<int, int> Exponents = new Dictionary<int, int>();
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
                        Signs[j] = sign;
                        Coefficient[j] = dig;
                        Variables[j] = variable;
                        Exponents[j] = ex;
                    }
                   
                    ++i;
                }
               

            }



        }

       
        public void Show()
        {
            foreach (var item in Signs)
            {
                Console.WriteLine(item);
            }

            
              
            

        }

    }
      


}



   
