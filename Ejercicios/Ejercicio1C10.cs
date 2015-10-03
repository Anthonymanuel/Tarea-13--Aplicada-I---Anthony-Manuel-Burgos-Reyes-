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
    public partial class Ejercicio1C10 : Form
    {
        public Ejercicio1C10()
        {
            InitializeComponent();
        }

        ArrayList lista = new ArrayList();
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inventario inve = new Inventario(ArticuloTextBox.Text, Convert.ToInt32(CantidadTextBox.Text), DescripcionTextBox.Text);
            MostrarRichTextBox.Text = inve.ToString();
            lista.Add(inve.ToString());
            ArticuloTextBox.Clear();
            CantidadTextBox.Clear();
            DescripcionTextBox.Clear();

        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MostrarRichTextBox.Clear();
            foreach (string n in lista)
            {
                MostrarRichTextBox.Text += "\n"+n;
            }
            
        }
    }
}
