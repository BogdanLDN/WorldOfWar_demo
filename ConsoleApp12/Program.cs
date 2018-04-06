 using System;
using System.Threading;

namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Добро пожаловать в игру, выберите героя!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nWarlock - введите");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" 1, ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Warrior - введите");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 2, ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ork - введите");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" 3");
            Console.WriteLine();


            Warlock warlock = new Warlock();
            Ork ork = new Ork();
            Warrior warrior = new Warrior();

            Pers pers = new Pers(0, 0);

            M:
            string vuborPersa = Console.ReadLine();
            switch (vuborPersa)
            {
                case "1":
                    Pers persCreate = new Pers(warlock.AttWarlock, warlock.HpWarlock);
                    pers = persCreate;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nТвой выбор - Warlock!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case "2":
                    Pers persCreate1 = new Pers(warrior.WarAtt, warrior.WarHp);
                    pers = persCreate1;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nТвой выбор - Warrior!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case "3":
                    Pers persCreate2 = new Pers(ork.OrkAtt, ork.OrkHp);
                    pers = persCreate2;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nТвой выбор - Ork!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                default:
                    Console.WriteLine("Сделайте выбор");
                    goto M;
            }

            Console.WriteLine("Hp = {0} Att = {1}", pers.HpPers, pers.AttPers);

            Mob mob = new Mob();
            mob.MobCreate();
            Logic logic = new Logic();
            Random randomAtt = new Random();


            do
            {
                logic.AttackLogik(pers.AttPers, mob.Hp);
                if (Console.ReadKey().Key == ConsoleKey.Enter & mob.Hp > 0)
                {
                    int attmob = pers.AttPers + randomAtt.Next(0, 4);
                    mob.Hp = logic.AttackLogik(attmob, mob.Hp);
                    Console.Write("\nТы ударил моба на {0} HP, здоровье =", attmob);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" {0}", mob.Hp);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (mob.Hp < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nТы убил моба");
                    break;
                }
                else if (mob.Hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nТы убил моба");
                    break;
                }

            } while (true);
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nУровень 2. Отгадай загадку, в случае не верного ответа\nбудет отниматся -15 твоего HP");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВ илюминаторе ?");
            string slovo = "трава";
            string otvet = Console.ReadLine();
            do
            {

                switch (otvet)
                {
                    case "":
                        pers.HpPers -= 15;
                        Console.WriteLine("Ответ не верный, - 15 НР. Твое HP = {0}", pers.HpPers);
                        otvet = Console.ReadLine();
                        break;
                    case "трава":
                        break;

                    default:
                        pers.HpPers -= 15;
                        Console.WriteLine("Ответ не верный, - 15 НР. Твое HP = {0}", pers.HpPers);
                        otvet = Console.ReadLine();
                        break;
                }

                if (pers.HpPers <= 0)
                {
                    break;
                }
                if (otvet == slovo)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nВы угадали!!");
                    break;
                }

            } while (true);

            if (pers.HpPers <= 0)
            {
                Console.WriteLine("Вы проиграли!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nУровень 3. Убей босса!");
            }
            Boss boss = new Boss();

            boss.BossCreate();

            do
            {
                logic.AttackLogik(pers.AttPers, boss.Hp);
                if (Console.ReadKey().Key == ConsoleKey.Enter & boss.Hp > 0)
                {
                    int attBoss = pers.AttPers + randomAtt.Next(0, 4);
                    boss.Hp = logic.AttackLogik(attBoss, boss.Hp);
                    Console.Write("\nТы ударил BOSS на {0} HP, здоровье =", attBoss);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" {0}", boss.Hp);
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else if (Console.ReadKey().Key == ConsoleKey.Tab & boss.Hp > 0)
                {
                    Console.WriteLine("\nУдар Грома!");
                    for (int i = 4; i >= 1; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);

                    }
                    int attBoss = pers.AttPers + randomAtt.Next(100, 200);
                    boss.Hp = logic.AttackLogik(attBoss, boss.Hp);
                    Console.Write("\nТы ударил BOSS на {0} HP, здоровье =", attBoss);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" {0}", boss.Hp);
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else if (boss.Hp <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nТы убил BOSS");
                    break;
                }
            } while (true);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                         END GAME!!!");
            Console.ReadKey();
        }


    }
}

