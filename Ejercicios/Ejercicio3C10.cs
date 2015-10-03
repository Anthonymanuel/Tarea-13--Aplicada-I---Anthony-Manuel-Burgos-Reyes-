using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio3C10 : Form
    {
        public Ejercicio3C10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poligono pol = new Poligono();
            pol.Lado = Convert.ToInt32(LadoTextBox.Text);
            pol.Longitud = Convert.ToInt32(LongitudTextBox.Text);
            MostrarRichTextBox.Text = pol.Lado+"  "+pol.Lado;
            LadoTextBox.Clear();
            LongitudTextBox.Clear();

        }
    }
}
