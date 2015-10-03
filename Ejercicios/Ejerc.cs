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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1C10 ejercicio = new Ejercicio1C10();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }
        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio2C10 ejercicio = new Ejercicio2C10();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }
        private void ejercicio345ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3C10 ejercicio = new Ejercicio3C10();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }
        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio1C9 ejercicio = new Ejercicio1C9();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2C9 ejercicio = new Ejercicio2C9();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3C9 ejercicio = new Ejercicio3C9();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4C9 ejercicio = new Ejercicio4C9();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio5C9 ejercicio = new Ejercicio5C9();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }
    }
}
