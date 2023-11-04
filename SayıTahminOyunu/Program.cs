using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {

          //  Swtich Case
            int gun;
            Console.WriteLine("Lütfen 1-7 arası bir tuşlama yapınız");
            gun = int.Parse(Console.ReadLine());
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı tuşlama yaptınız");
                    break;
            }

            Console.ReadKey();
        }
    }
}
