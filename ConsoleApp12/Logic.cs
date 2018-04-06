using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Logic
    {
       public int hpchange;      
        public int AttackLogik(int attpers, int hpmob)
        {         
            hpchange = hpmob - attpers;
            Mob mob = new Mob();
            mob.Hp = hpchange;
            return mob.Hp;
        }                
    }
}
