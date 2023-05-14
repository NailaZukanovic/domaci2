using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domaci2
{
    public class Tabla
    {
        private Figura[,] tabla;

        public Tabla()
        {
            tabla = new Figura[8, 8];
        }

        public bool PomeriFiguru(Polje poljeOd, Polje poljeDo)
        {
            Figura figuraOd = DohvatiFiguru(poljeOd);
            Figura figuraDo = DohvatiFiguru(poljeDo);

            if (figuraOd == null) // na polju od nema figure
            {
                return false;
            }

            if (figuraOd.Pomeraj(poljeDo) == false) // figura se ne moze pomeriti na poljeDo
            {
                return false;
            }

            if (figuraDo != null && figuraDo.boja == figuraOd.boja) // na polju do je figura iste boje
            {
                return false;
            }

            tabla[poljeOd.red, int.Parse(poljeOd.kolona)] = null; // uklanjamo figuru sa polja od

            if (figuraDo != null && figuraDo.boja != figuraOd.boja) // ako je na polju do neka figura, onda se ona pojede
            {

                tabla[poljeDo.red, int.Parse(poljeDo.kolona)] = figuraOd; // postavljamo figuru na novo polje
                return false;
            }


            return true;
        }

        public Figura DohvatiFiguru(Polje polje)
        {
            return tabla[polje.red, int.Parse(polje.kolona)];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Figura figura = tabla[i, j];

                    if (figura == null)
                    {
                        sb.Append("_");
                    }
                    else
                    {
                        sb.Append(figura.Oznaka);
                    }
                }

                sb.Append("\n");
            }

            return sb.ToString();
        }
    }

}
