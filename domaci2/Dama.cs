using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public class Dama : Figura
    {
        public Dama(Polje polje, string boja) : base(polje, boja)
        {
            this.Oznaka = "D";
        }

        public override bool Pomeraj(Polje p2)
        {
            // Provera da li se pomeramo po koloni, redu ili dijagonali
            if (this.polje.kolona == p2.kolona ||
                this.polje.red == p2.red ||
                Math.Abs(int.Parse(this.polje.kolona) - int.Parse(p2.kolona)) == Math.Abs(this.polje.red - p2.red))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
