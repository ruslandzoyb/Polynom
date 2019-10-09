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
        const string plus = "+";
        const string minus = "-";


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

            string digit = string.Empty;
            int i = 0;
            int k=-1;
            while (i < line.Length)
            {
                string str = line[i].ToString();
                if (string.IsNullOrEmpty(str) || str == plus)
                {
                    sign = '+';
                    if (str == plus)
                    {
                        ++k;

                        Add(sign, digit, variable, exponent,k);
                    }

                }
                else if  (str ==minus )
                {
                    sign = '-';
                }
                else if (char.IsDigit(Convert.ToChar(str))&&line[i-1]!='^')
                {
                    digit += str;

                }

                else if (char.IsLetter(Convert.ToChar(str)))
                {
                    if (string.IsNullOrEmpty(variable_type))
                    {
                        variable_type = str;
                        variable = str;

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
                    if (char.IsDigit(line[++j]))
                    {
                        exponent = line[j].ToString();
                    }
                    else
                    {
                        throw new Exception("Степень должна быть числом");
                    }
                    
                }

                ++i;
            }

        }
        private void Add(string variable, string exponent,int k, char sign = '', string list = "1")
        {

            Signs[k] = sign;
            Coefficient[k] = Convert.ToInt32(list);
            Variables[k] = variable;
            Exponents[k] = Convert.ToInt32(exponent);

           
            
        }

        public void Show()
        {
            foreach (var item in Signs)
            {
                Console.WriteLine(item);
            }
            foreach (var item in Coefficient)
            {
                Console.WriteLine(item);
            }

            
        }
        





    }

    }

