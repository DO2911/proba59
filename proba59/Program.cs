using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace proba59
{
    class Program
    {
        static void Main(string[] args)
        {
            //nev10
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hegyi Roland");
            }
            */
            //ismetlesN
            /*
            Console.WriteLine("Mennyiszer:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Szöveg:");
            string f = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
            */
            //visszaszamol
            /*
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Lejárt az időd");
            Thread.Sleep(5000);
            */
            //nev_mozog
            /*
            for (int i = 0; i < 120; i++)
            {
               
                    Console.SetCursorPosition(i, 0);
                    Console.WriteLine("Roland");
                    Thread.Sleep(10);
                    Console.Clear();
               
                
            }
            Console.ReadKey(true);
            */
            //randomcsillag
            /*
            Random rnd = new Random();
            
            
            for (int i = 0; i < 200; i++)
            {
                int x = rnd.Next(0, 120);
                int y = rnd.Next(0, 31);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
            }
            Console.ReadKey();
            */

            //randomszin 
            /*

            Random rnd = new Random();


            for (int i = 0; i < 200; i++)
            {
                int z = rnd.Next(0, 16);
                int x = rnd.Next(0, 120);
                int y = rnd.Next(0, 30);
                Console.SetCursorPosition(x, y);
                if (z==1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if(z==2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (z == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (z == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (z == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (z == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (z == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (z == 8)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else if (z == 9)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (z == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (z == 11)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else if (z == 12)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                else if (z == 13)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (z == 14)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (z == 15)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
            */
            //negyzetszamok
            /*
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(Math.Pow(i, 2)); 
            }
            Console.ReadKey();
            */
            //2hatvanyok
            /*
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
            Console.ReadKey();
            */
            //paratlan
            /*
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                
            }
            */
            //paratlan2
            /*
            for (int i = 100; i > 0; i--)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            */
            //szamtanisor1
            /*
            int d = 10;
            for (int i = 0; i < 50; i++)
            {

                Console.WriteLine(d);
                d += 7;
            }
            Console.ReadKey();
            */
            //szamtanisor2
            /*
            Console.WriteLine("első tag:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("differenciál:");
            int d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 20; i++)
            {
                
                x += d;
                Console.WriteLine(x);
            }
            Console.ReadKey(true);
            */






        }
    }
}
