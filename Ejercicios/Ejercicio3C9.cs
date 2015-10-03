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
    public struct Mascota
    {
        string Nombre;
        string Raza;
        public Mascota(string Nom, string Raz)
        {
            Nombre = Nom;
            Raza = Raz;
        }
        public override string ToString()
        {
            StringBuilder bs = new StringBuilder();
            bs.AppendFormat("{0} {1} ", this.Nombre, this.Raza);
            return bs.ToString();
        }
    }
    public struct Dueno
    {
        string NombreD;
        string Telefono;
        string Direccion;
        Mascota m;

        public Dueno(string NomD,string Telef,string Direcc,string Nom, string Ra)
        {
            NombreD = NomD;
            Telefono = Telef;
            Direccion = Direcc;
            m = new Mascota( Nom,Ra);
        }
        public override string ToString()
        {
            StringBuilder bs = new StringBuilder();
           
            bs.AppendFormat("Dueno: {0} {1} {2} {3} ",this.NombreD,this.Telefono,this.Direccion,m);
            return bs.ToString();
        }
    }
    public partial class Ejercicio3C9 : Form
    {
        public Ejercicio3C9()
        {
            InitializeComponent();
        }
        ArrayList lista = new ArrayList();
        private void GuardarButton1_Click(object sender, EventArgs e)
        {
            Dueno d = new Dueno(DuenoTextBox.Text, TelefonoTextBox.Text,DireccionTextBox.Text,NombreMTextBox.Text,RazaTextBox.Text);
            
            lista.Add(d.ToString());
            MostrarRichTextBox.Text = d.ToString();
            DuenoTextBox.Clear();
            TelefonoTextBox.Clear();
            DireccionTextBox.Clear();
            NombreMTextBox.Clear();
            RazaTextBox.Clear();

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
