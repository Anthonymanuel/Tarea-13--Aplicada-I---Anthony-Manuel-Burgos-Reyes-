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
    public partial class Ejercicio2C10 : Form
    {
        public Ejercicio2C10()
        {
            InitializeComponent();
        }
        ArrayList lista = new ArrayList();
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante(NombreTextBox.Text,SesionTextBox.Text,Convert.ToInt32(EdadTextBox.Text),GradoTextBox.Text);
            lista.Add(es.ToString());
            MostrarRichTextBox.Text = es.ToString();
            NombreTextBox.Clear();
            SesionTextBox.Clear();
            EdadTextBox.Clear();
            GradoTextBox.Clear();
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
