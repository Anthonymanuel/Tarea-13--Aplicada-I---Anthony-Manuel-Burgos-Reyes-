using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Poligono
    {
        //Ejercicio 4
        private int lado;
        private int longitud;
        public int Lado {
            get
            {
                return lado;
            }
            set {
                if (value <= 0)
                    lado = 1;
                else
                    lado = value;
            } }
        public int Longitud {
            get
            {
                return longitud;
            }
            set
            { 
             if (value <= 0)
                    longitud = 1;
            else
                    longitud = value ;
            }
        }
        //Ejercicio 3
        public Poligono()
        {
            this.lado = 0;
            this.longitud = 0;
        }
        public Poligono(int Lad, int Long)
        {
            this.lado = Lad;
            this.longitud = Long;
        }
        //Ejercicio 5
        public override string ToString()
        {
            StringBuilder bs = new StringBuilder();
            bs.AppendFormat("{0}  {1} ",Lado,Longitud);
            return bs.ToString();
        }
    }
}
