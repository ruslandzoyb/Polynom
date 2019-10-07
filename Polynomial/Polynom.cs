using System;
using System.Collections;
using System.Collections.Generic;


using System.Threading.Tasks;

namespace Polynomial
{
    class Polynom
    {
        private string line;
        private char sign;
        private string variable;
        private string coefficient;
        private string variable_type;
        private string exponent;

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

            string list = "";
            int i = 0;
            while (i < line.Length)
            {
                string str = line[i].ToString();
                if (string.IsNullOrEmpty(str) || Convert.ToChar(str) == '+')
                {
                    sign = '+';
                    if (Convert.ToChar(str) == '+')
                    {
                       // Add(sign, list, variable, exponent);
                    }

                }
                else if (Convert.ToChar(str) == '-')
                {
                    sign = '-';
                }
                else if (Int32.TryParse(str, out int n))
                {
                    list += str;

                }

                else if (char.IsLetter(line[i]))
                {
                    if (string.IsNullOrEmpty(variable_type))
                    {
                        variable_type = str;

                    }
                    if (variable_type == str)
                    {
                        variable = str;
                    }
                    else if (variable_type != str)
                    {
                        throw new Exception("Введенная переменная не является идентичной попередней");
                    }



                }
                else if (Convert.ToChar(str) == '^')
                {
                    // TODO: Проверка инкремента 
                    int j = i;
                    exponent = list[++j].ToString();
                }

                ++i;
            }

        }
        private void Add(char sign, string coeff, string var, string ecs)
        {


           
            
        }
            
           
        public void Show()
        {
            //IEnumerator enumerator = polinom.Keys.GetEnumerator();
            


        }
        
    
       

        }

    }

