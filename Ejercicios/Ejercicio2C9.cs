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
    public partial class Ejercicio2C9 : Form
    {
        public struct Banco
        {

            int Numero;
            string Entidad;
            string Tipo;
            public Banco(int Num, string Ent,string Tip)
            {
                this.Numero= Num;
                this.Entidad = Ent;
                this.Tipo = Tip;
            }
            public override string ToString()
            {
                StringBuilder bs = new StringBuilder();
                bs.AppendFormat("{0}  {1}  {2}", this.Numero, this.Entidad, this.Tipo);
                return bs.ToString();
            }
        }
        public Ejercicio2C9()
        {
            InitializeComponent();
        }

        ArrayList lista = new ArrayList();
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Banco b = new Banco(Convert.ToInt32(numeroTextBox.Text),EntidadBTextBox.Text,CuentaTextBox.Text);
            lista.Add(b.ToString());
            numeroTextBox.Clear();
            EntidadBTextBox.Clear();
            CuentaTextBox.Clear();
            MostrarRichTextBox.Text = b.ToString();

                 
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
