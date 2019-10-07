using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Polynomial
{
    class Polynom
    {
        private string line;
        private char sign;
        private string variable;
        private string coefficient;
        private  string variable_type;
      // private Dictionary<char, int> sign_coeff;
      // private Dictionary<char, int> var_expon;
        private Dictionary<Dictionary<char,int>,Dictionary<string,int>> polinom;
        Regex regex;
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
           
            List<int> list = new List<int>();
            int i = 0;
            while (i<line.Length)
            {
                string str = line[i].ToString();
                if (string.IsNullOrEmpty(str)||Convert.ToChar(str)=='+')
                {
                    sign = '+';
                    if (Convert.ToChar(str) == '+')
                    {
                       // Add()
                    }
                   
                }
                else if (Convert.ToChar(str) == '-')
                {
                    sign = '-';
                }
                else if (Int32.TryParse(str,out int  n))
                {
                    list.Add(n);

                }
                
                else if (char.IsLetter(line[i]))
                {
                    if (string.IsNullOrEmpty(variable_type))
                    {
                        variable_type = str;

                    }
                    if (variable_type==str)
                    {
                        variable = str;
                    }
                    else if (variable_type!=str)
                    {
                        throw new Exception("Введенная переменная не является идентичной попередней");
                    }
                    
                    

                }


            }

        }
       /* private void Add(char sign,int coeff,int var,)
        {

        }*/

    }
}
