using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Inventario
    {
        
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        public Inventario()
        {
            this.Articulo = "";
            this.Cantidad = 0;
            this.Descripcion = "";

        }
        public Inventario(string Art,int Cant, string Descrip)
        {
            this.Articulo = Art;
            this.Cantidad = Cant;
            this.Descripcion = Descrip;

        }
        public override string ToString()
        {
            StringBuilder bs = new StringBuilder();
            bs.AppendFormat("{0}  {1}  {2}", this.Articulo, this.Cantidad, this.Descripcion);
            return bs.ToString();
        }
    }
}
