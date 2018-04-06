using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Warlock
    {
        int hp = 120;
        int att = 10;

        public int HpWarlock
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
        public int AttWarlock
        {
            
            get
            {
                return att;
            }
        }

    }
}
