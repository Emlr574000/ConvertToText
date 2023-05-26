using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 999 arası bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int birler = sayi % 10;
            int onlar = (sayi % 100) / 10;
            int yuzler = sayi / 100;
           
            switch (yuzler)
            {


                case 1:
                    {
                        Console.Write("yüz");
                        break;
                    }

                case 2:
                    {
                        Console.Write("ikiyüz");
                        break;
                    }
                case 3:
                    {
                        Console.Write("üçyüz");
                        break;
                    }
                case 4:
                    {
                        Console.Write("dörtyüz");
                        break;

                    }
                case 5:
                    {
                        Console.Write("beşyüz");
                        break;
                    }
                case 6:
                    {
                        Console.Write("altıyüz");
                        break;
                    }
                case 7:
                    {
                        Console.Write("yediyüz");
                        break;
                    }
                case 8:
                    {
                        Console.Write("sekizyüz");
                        break;
                    }
                case 9:
                    {
                        Console.Write("dokuzyüz");
                        break;
                    }


            }

            switch (onlar)
            {


                case 1:
                    {
                        Console.Write(" on");
                        break;
                    }

                case 2:
                    {
                        Console.Write(" yirmi");
                        break;
                    }
                case 3:
                    {
                        Console.Write(" otuz");
                        break;
                    }
                case 4:
                    {
                        Console.Write(" kırk");
                        break;

                    }
                case 5:
                    {
                        Console.Write(" elli");
                        break;
                    }
                case 6:
                    {
                        Console.Write(" atmış");
                        break;
                    }
                case 7:
                    {
                        Console.Write(" yetmiş");
                        break;
                    }
                case 8:
                    {
                        Console.Write(" seksen");
                        break;
                    }
                case 9:
                    {
                        Console.Write(" doksan");
                        break;
                    }


            }

            switch (birler)
            {


                case 1:
                    {
                        Console.WriteLine(" bir");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine(" iki");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(" üç");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(" dört");
                        break;

                    }
                case 5:
                    {
                        Console.WriteLine(" beş");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(" altı");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine(" yedi");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine(" sekiz");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine(" dokuz");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}