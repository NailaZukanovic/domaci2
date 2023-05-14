using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public class Kralj : Figura
    {
        public Kralj(Polje polje, string boja) : base(polje, boja)
        {
            this.Oznaka = "K";
        }

        public override bool Pomeraj(Polje p2)
        {
            int kolonaRazlika = Math.Abs(int.Parse(this.polje.kolona) - int.Parse(p2.kolona));
            int redRazlika = Math.Abs(this.polje.red - p2.red);

            if (kolonaRazlika > 1 || redRazlika > 1)
            {
                return false;
            }

            return true;
        }

        public bool NapadaPolje(Polje p, List<Figura> figure)
        {
            foreach (Figura figura in figure)
            {
                if (figura.boja != this.boja)
                {
                    if (figura.Pomeraj(p))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
