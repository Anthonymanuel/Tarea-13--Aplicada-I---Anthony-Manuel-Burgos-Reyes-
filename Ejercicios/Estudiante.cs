using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Estudiante
    {
        public  string  Nombre { get; set; }
        public string Sesion { get; set; }
        public int Edad { get; set; }
        public string Grado { get; set; }

        public Estudiante()
        {
            this.Nombre = "";
            this.Sesion = "";
            this.Edad = 0;
            this.Grado = "";
        }

        public Estudiante(string Nom, string Ses, int Ed, string Gra)
        {
            this.Nombre = Nom;
            this.Sesion = Ses;
            this.Edad = Ed;
            this.Grado = Gra;
        }
        public override string ToString()
        {
            StringBuilder bs = new StringBuilder();
            bs.AppendFormat("{0}  {1}  {2}  {3}", this.Nombre, this.Sesion, this.Edad, this.Grado);
            return bs.ToString();
        }
    }
}
