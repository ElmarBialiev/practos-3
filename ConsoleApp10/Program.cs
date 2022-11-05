using System;

namespace Codick
{
    internal class Program
    {
        static DateTime vremya = DateTime.Now;
        /// <summary>
        /// Влево вправо
        /// </summary>
        static int TudaSuda = 0;
        static int Dela = 2;
        static void Main(string[] args)
        {
            Zametka a = new Zametka()
            {
                Day = 6,
                name = "жрать",
                description = "хочу жрать, пожрал"
            };
            Zametka.zametks.Add(a);
            Zametka b = new Zametka()
            {
                Day = 6,
                name = "спать",
                description = "я просто хочу!!!!!!!!!"
            };
            Zametka.zametks.Add(b);
            Zametka c = new Zametka()
            {
                Day = 6,
                name = "чилл",
                description = "поехать погонять футбол, хочу чтобы мне сломали ноги "
            };
            Zametka.zametks.Add(c);
            Zametka d = new Zametka()
            {
                Day = 7,
                name = "Музло Тупака",
                description = "ну Тупак крутой чел и легенда рэпа, почему бы и нет?)"
            };
            Zametka.zametks.Add(d);
            Zametka e = new Zametka()
            {
                Day = 8,
                name = "снова на пары",
                description = "прийти на пары, чтобы ныть о том как ты хочешь спать и кушать"
            };
            Zametka.zametks.Add(e);
            Zametka f = new Zametka()
            {
                Day = 8,
                name = "сгонять в монголию и купить покушать",
                description = "купить нашей дорогой и горячо любимой Софие Алексеевне что нибудь покушац"
            };
            Zametka.zametks.Add(f);
            Zametka g = new Zametka()
            {
                Day = 9,
                name = "футбол",
                description = "футбол - лучший вид спорта в мире"
            };
            Zametka.zametks.Add(g);
            Zametka h = new Zametka()
            {
                Day = 9,
                name = "жрать",
                description = "хочу жрать, значит буду"
            };
            Zametka.zametks.Add(h);
            Zametka i = new Zametka()
            {
                Day = 10,
                name = "прийти на пары",
                description = "поною о том, как хочу спать и как болят "
            };
            Zametka.zametks.Add(i);

            while (true)
            {
                Alfavite();
                Clavishka();
                Strelochechka();
            }
        }


        private static void Alfavite()
        {
            int mestniiyNomerok = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Дела на:{vremya.AddDays(TudaSuda).Day}.{vremya.AddDays(TudaSuda).Month}.{vremya.AddDays(TudaSuda).Year}");
            foreach (var elementik in Zametka.zametks)
            {
                if (elementik.Day == vremya.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    Console.SetCursorPosition(4, mestniiyNomerok + 1);
                    elementik.Number = mestniiyNomerok;
                    Console.Write($"{elementik.Number}.{elementik.name}\n");
                }
            }

        }
        private static void Clavishka()
        //метод отрисовки задач
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    TudaSuda--;
                    break;
                case ConsoleKey.RightArrow:
                    TudaSuda++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Dela < 3)
                    {
                        Dela = 2;
                    }
                    else
                    {
                        Dela--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Dela > 3)
                    {
                        Dela = 4;
                    }
                    else
                    {
                        Dela++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Pometochkka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("Пока покаа!");
                    System.Environment.Exit(0);
                    break;
            }
        }

        private static void Pometochkka()
        {
            int mestniiyNomerok = 0;
            Console.Clear();
            foreach (var elementik in Zametka.zametks)
            {
                if (elementik.Day == vremya.AddDays(TudaSuda).Day)
                {
                    mestniiyNomerok++;
                    elementik.Number = mestniiyNomerok;
                    if (mestniiyNomerok == Dela - 1)
                    {
                        Console.Write($"  {elementik.name}\n");
                        Console.Write(" " + elementik.description);
                    }
                }
            }
        }

        private static void Strelochechka()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Dela);
            Console.Write("-->");
        }
    }
}