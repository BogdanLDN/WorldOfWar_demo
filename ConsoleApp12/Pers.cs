using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Pers
    {
        int hp;
        int att;
        public Pers(int att,int hp)
        {
            this.hp = hp;
            this.att = att;
        }

        public int HpPers
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
        public int AttPers
        {

            get
            {
                return att;
            }
        }

    }
}
