
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pos = 1;
            Z4m3tk1 zametka1 = new Z4m3tk1();
            zametka1.name = "  blazer)";
            zametka1.data = new DateTime(2007, 11, 21);
            zametka1.description = "  pit' blazer posle 4 yroka";
            Z4m3tk1 zametka2 = new Z4m3tk1();
            zametka2.name = "  стать эмо)";
            zametka2.data = new DateTime(2007, 7, 20);
            zametka2.description = "  послушать токиохотель и резать вены";
            Z4m3tk1 zametka3 = new Z4m3tk1();
            zametka3.name = "  поехать на казантип";
            zametka3.data = new DateTime(2007, 7, 25);
            zametka3.description = "  словить трип в рейве";
            Z4m3tk1 zametka4 = new Z4m3tk1();
            zametka4.name = "  школа...";
            zametka4.data = new DateTime(2007, 7, 23);
            zametka4.description = "  сходи на уроки и выучить уроки";
            Z4m3tk1 zametka5 = new Z4m3tk1();
            zametka5.name = "  получить по башке от скинов";
            zametka5.data = new DateTime(2007, 7, 23);
            zametka5.description = "  получить по башке а потом в травмпункт и к маме домой зато в школу не иду)))))";
            Z4m3tk1[] zametki = new Z4m3tk1[] { zametka1, zametka2, zametka3, zametka4, zametka5 };
            DateTime date = new DateTime(2007, 7, 23);
            ConsoleKeyInfo key = new ConsoleKeyInfo((char)ConsoleKey.A, ConsoleKey.A, false, false, false);
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();

                var sortedZam = zametki.Where(x => x.data.Date == date.Date).ToList();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos == 0)
                        pos = sortedZam.Count;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos == sortedZam.Count+1)
                        pos = 1;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }

                Console.Clear();
                Console.WriteLine(date.Date);
                foreach (var item in sortedZam)
                {
                    Console.WriteLine(item.name);
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

            }
        }
        /*        static DateTime left(DateTime zxc)
                {
                    Console.Clear();
                    Console.WriteLine("  "+zxc.ToString("yyy.MM.dd"));
                    return (zxc);
                }*/
    }

}

