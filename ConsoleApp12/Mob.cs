using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Mob
    {
        int hp = 60;

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
        public void MobCreate()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nИз тьмы был создан Моб!!");
            Console.ForegroundColor = ConsoleColor.White; ;
            Console.WriteLine("Жми 'Enter' чтоб убить Моба!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nМоб: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Здоровье = {0} ", Hp);
            Console.WriteLine();
        }
    }
}
