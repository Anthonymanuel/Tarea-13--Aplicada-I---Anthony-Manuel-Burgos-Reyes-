using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio1C9 : Form
    {
        public struct Tienda
        {
            
            string Articulo;
            int Cantidad;
            int Precio;
            public Tienda(string Art, int Cant, int Prec)
            {
                this.Articulo = Art;
                this.Cantidad = Cant;
                this.Precio = Prec;
            }
            public override string ToString()
            {
                StringBuilder bs = new StringBuilder();
                bs.AppendFormat("{0}  {1}  {2}",this.Articulo,this.Cantidad,this.Precio);
                return bs.ToString();
            }
        }
        public Ejercicio1C9()
        {
            InitializeComponent();
        }
        ArrayList lista = new ArrayList();
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Tienda ti = new Tienda(ArticuloTextBox.Text,Convert.ToInt32(CantidadTextBox.Text),Convert.ToInt32(PrecioTextBox.Text));
            MostrarRichTextBox.Text = ti.ToString();
            lista.Add(ti.ToString());
            ArticuloTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MostrarRichTextBox.Clear();
            foreach (string n in lista)
            {
                MostrarRichTextBox.Text += "\n" + n;
            }
        }
    }
}
