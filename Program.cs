using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Tasklar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x}+{y}={x + y}");
            //Console.WriteLine($"{x}-{y}={x - y}");
            //Console.WriteLine($"{x}*{y}={x * y}");
            #endregion

            #region task2
            //int x = int.Parse(Console.ReadLine());
            //int gun = x / 86400;
            //x = x % 86400;
            //int saat = x / 3600;
            //x = x % 3600;
            //int deqiqe = x / 60;
            //int saniye = x % 60;
            //Console.WriteLine($"gun={gun}");
            //Console.WriteLine($"saat={saat}");
            //Console.WriteLine($"deqiqe={deqiqe}");
            //Console.WriteLine($"saniye={saniye}");
            #endregion

            #region task3
            //int yas = int.Parse(Console.ReadLine());
            //if (yas >= 1 && yas <= 6)
            //{
            //    Console.WriteLine("Usaqdir");
            //}
            //else if (yas <= 17)
            //{
            //    Console.WriteLine("Sagirddir");
            //}
            //else if (yas <= 35)
            //{
            //    Console.WriteLine("Gencdir");
            //}
            //else if (yas <= 63)
            //{
            //    Console.WriteLine("Yetkinlik");
            //}
            //else {
            //    Console.WriteLine("Teqaudcudur"); 
            //}

            #endregion

            #region task4
            //int heftenin_gunu = int.Parse(Console.ReadLine());
            //switch (heftenin_gunu)
            //{
            //    case 1:
            //        Console.WriteLine("Bazar ertesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Cersenbe axsami");
            //        break;
            //    case 3:
            //        Console.WriteLine("Cersenbe");
            //        break;
            //    case 4:
            //        Console.WriteLine("Cume axsami");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cume");
            //        break;
            //    case 6:
            //        Console.WriteLine("Senbe");
            //        break;
            //    case 7:
            //        Console.WriteLine("Bazar");
            //        break;
            //}
            #endregion

            #region task5
            int ayin_nomresi = int.Parse(Console.ReadLine());
            switch (ayin_nomresi)
            {
                case 1:
                    Console.WriteLine("Yanvar, 31gun");
                    break;
                case 2:
                    Console.WriteLine("Fevral, 28gun");
                    break;
                case 3:
                    Console.WriteLine("Mart, 31gun");
                    break;
                case 4:
                    Console.WriteLine("Aprel, 30gun");
                    break;
                case 5:
                    Console.WriteLine("May, 31gun");
                    break;
                case 6:
                    Console.WriteLine("Iyun, 30gun");
                    break;
                case 7:
                    Console.WriteLine("Iyul, 31gun");
                    break;
                case 8:
                    Console.WriteLine("Avqust, 31gun");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr, 30gun");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr, 31gun");
                    break;
                case 11:
                    Console.WriteLine("Noyabr, 30gun");
                    break;
                case 12:
                    Console.WriteLine("Dekabr, 31gun");
                    break;
            }
            #endregion
        }
    }
}
