using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public class Polje
    {
        public int red { get; set; }
        public string kolona { get; set; }
        public Polje(string kolona, int red)
        {
            if (kolona.CompareTo("a") >= 0 && kolona.CompareTo("h") <= 0)
                this.kolona = kolona;
            if(red > 0 && red < 9)
                this.red = red;
        }

        public bool IstiRed(Polje drugoPolje)
        {
            return red == drugoPolje.red;
        }

        public bool IstiKolonu(Polje drugoPolje)
        {
            return kolona == drugoPolje.kolona;
        }

        public bool IstiDijagonalu(Polje drugoPolje)
        {
            int kolonaRazlika = Math.Abs(int.Parse(kolona) - int.Parse(drugoPolje.kolona));
            int redRazlika = Math.Abs(red - drugoPolje.red);
            return kolonaRazlika == redRazlika;
        }

        public int Rastojanje(Polje drugoPolje)
        {
            int kolonaRazlika = Math.Abs(int.Parse(kolona) - int.Parse(drugoPolje.kolona));
            int redRazlika = Math.Abs(red - drugoPolje.red);
            return kolonaRazlika + redRazlika;
        }

        public override string ToString()
        {
            return kolona.ToString() + red.ToString();
        }

        public int DajKolonu()
        {
            if (this.kolona == "a")
                return 1;
            else if (this.kolona == "b")
                return 2;
            else if (this.kolona == "c")
                return 3;
            else if (this.kolona == "d")
                return 4;
            else if (this.kolona == "e")
                return 5;
            else if (this.kolona == "f")
                return 6;
            else if (this.kolona == "g")
                return 7;
            else
                return 8;
        }
    }
}
