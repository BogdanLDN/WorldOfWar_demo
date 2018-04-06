using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Boss
    {
        int hp = 1000;
        public int Hp
        {
            set
            {
                hp = value;
            }
            get
            {
                return hp;
            }
        }
        public void BossCreate()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White; ;
            Console.WriteLine("Жми 'Enter' чтоб убить BOSS!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nТебе доступен Удар Грома! Нажми Tab Tab , чтоб активировать сверх удар!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nBOSS: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Здоровье = {0} ", Hp);
            Console.WriteLine();
        }

    }
}
