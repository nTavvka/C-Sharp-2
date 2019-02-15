using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[9, 4];
            for (int i = 0, value = 2; i < 9; i++, value++)
            {
                if (value == 5)
                {
                    i--;
                    continue;
                }
                arr[i, 0] = value;
                arr[i, 1] = value;
                arr[i, 2] = value;
                arr[i, 3] = value;
            }

            Random rand = new Random();
            int pbank, cbank, num = 0, plcard = 1, cmcard = 1, x1, y1, x2, y2;

            while (true)
            {
                x1 = rand.Next(9); y1 = rand.Next(4);
                pbank = arr[x1, y1];
                x2 = rand.Next(9); y2 = rand.Next(4);
                cbank = arr[x2, y2];
                if (pbank != 0 && cbank != 0)
                {
                    num = 2;
                    arr[x1, y1] = 0;
                    arr[x2, y2] = 0;
                    break;
                }
            }
            Console.WriteLine(" Карта: " + plcard);
            while (true)
            {
                cbank = computer(arr, cbank, ref num, ref cmcard);
                pbank = player(arr, pbank, ref num, ref plcard);
                Console.Clear();
                if (pbank > 21 && cbank <= 21 && plcard <= 5 && cmcard <= 5)
                {
                    Console.WriteLine(" Вы проиграли \n" + " счет: " + pbank); break;
                }
                else if (pbank == 21 && plcard <= 5 && cmcard <= 5)
                {
                    Console.WriteLine(" Вы выйграли!!! \n" + " счет: " + pbank); break;
                }
                else if (pbank == 21 && cbank == 21 && plcard <= 5 && cmcard <= 5)
                {
                    Console.WriteLine(" Вы ничья  \n" + " счет: " + pbank); break;
                } 
            }
            Console.WriteLine(" Компьютер: " + cbank);
        }

        static int player(int[,] arr, int pbank, ref int num, ref int plcard)
        {
            while (true)
            {
                Console.WriteLine("Взять карту?");
                string key = Console.ReadLine();
                if (key.Equals("1"))
                {
                    Random rnd = new Random();
                    int card = 0, x, y;

                    while (true)
                    {
                        if (num >= 36) return pbank;

                        x = rnd.Next(9);
                        y = rnd.Next(4);
                        card = arr[x, y];

                        if (card != 0)
                        {
                            plcard++;
                            if (plcard == 5) return pbank;

                            arr[x, y] = 0;
                            pbank += card;
                            num++;

                            Console.Clear();
                            if (card == 11) Console.WriteLine("Туз");
                            else Console.WriteLine(" Карта: " + card);
                            Console.WriteLine(" сумма: " + pbank);

                            if (pbank >= 21) return pbank;
                            break;
                        }
                    }
                }
                else break;
            }

            return pbank;
        }

        static int computer(int[,] arr, int cbank, ref int num, ref int cmcard)
        {
            Random rnd = new Random();
            int card, x, y;

            while (true)
            {
                x = rnd.Next(9);
                y = rnd.Next(4);
                card = arr[x, y];

                if (card != 0)
                {
                    if (cbank + card <= 21 && num != 36 && cmcard < 5)
                    {
                        num++;
                        cmcard++;
                        cbank += card;
                    }
                    else return cbank;
                }
                
            }
        }
    }
}
