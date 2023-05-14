using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public class Skakac : Figura
    {

        public Skakac(Polje polje, string boja) : base(polje, boja)
        {
            this.Oznaka = "S";
        }

        public override bool Pomeraj(Polje p2)
        {
            // Provjeri da li se p2 nalazi na nekom od mogućih položaja
            int kolonaRazlika = Math.Abs(int.Parse(p2.kolona) - int.Parse(this.polje.kolona));
            int redRazlika = Math.Abs(p2.red - this.polje.red);
            if ((kolonaRazlika == 2 && redRazlika == 1) || (kolonaRazlika == 1 && redRazlika == 2))
            {
                return true;
            }

            // Ukoliko se skakač ne može pomeriti na polje p2, vrati false
            return false;
        }

        
    }
}
