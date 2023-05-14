using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public class Top : Figura
    {
        public Top(Polje polje, string boja) : base(polje, boja)
        {
            this.Oznaka = "T";
        }

        public override bool Pomeraj(Polje p2)
        {
            if (this.polje.kolona == p2.kolona || this.polje.red == p2.red)
                return true;
            else
            {
                Environment.Exit(0);
                return false;
            }

        }
    }
}
