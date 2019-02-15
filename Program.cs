using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.Threading;

namespace Ex_3v13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rand, min = 0, max = 256, count = 0;

            int[] sout = new int[30];
            string str = "", strout = "";

            while (str.Length < 260)
            {
                rand = rnd.Next(min, max);
                if (rand % 2 == 0 && rand >= 'A' && rand <= 'Z')
                    str += Convert.ToString((char)(rand));
                else if (rand >= 'A' && rand <= 'Z')
                    str += Convert.ToString((char)(rand + 32));

                if (count < 30 && min == 0)
                {
                    sout[count] = rand;
                    count++;
                }
                else if (min == 0)
                {
                    min = 'A';
                    max = 'Z';
                    count = 0;
                }
            }

            for (; count < 30; count++)
            {
                strout += Convert.ToString(str[count]) + ' ';
            }
            
            Console.WriteLine(str + '\n');
            Console.WriteLine(strout);
        }
    }
}
