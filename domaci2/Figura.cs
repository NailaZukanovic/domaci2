using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public abstract class Figura
    {
        public Figura(Polje polje, string boja)
        {
            this.polje = polje;
            if (this.boja == "C" || this.boja == "b")
                this.boja = boja;
        }

        public Polje polje { get; set; }

        public string boja { get; set; }

        public string Oznaka { get; set; }
        abstract public bool Pomeraj(Polje p2);

        public string DohvatiOznaku()
        {
            return this.Oznaka;
        }
        public override string ToString()
        {
            return boja+polje.ToString();
        }
    }
}
