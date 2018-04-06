using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Ork
    {
         int hp = 105;
         int att = 20;

        public int OrkHp
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

        public int OrkAtt
        {
            get
            {
                return att;
            }
        }

    }
}
