using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1v3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str16 = Console.ReadLine() + ' ';
            int lenght = str16.Length;

            string str10 = "";
            for (int i = 0; i < lenght; i++)
            {
                if (str16[i] >= 'a' && str16[i] <= 'f' || str16[i] >= 'A' && str16[i] <= 'F' || str16[i] >= '0' && str16[i] <= '9')
                {
                        str10 += str16[i];
                }
                else if (str16[i] != ' ' && str10.Length >= 0)
                {
                    str10 = "";
                    while (str16[i] != ' ')
                        i++;
                }

                if (str16[i] == ' ' && str10.Length > 0)
                {
                    int a = Convert.ToInt32(str10, 16);
                    Console.WriteLine(a);
                    str10 = "";
                }   
            }
        }
    }
}
