using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Warrior
    {
         int hp = 130;
         int att = 14;

        public int WarHp
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
        public int WarAtt
        {
            get
            {
                return att;
            }
        }




    }
}
