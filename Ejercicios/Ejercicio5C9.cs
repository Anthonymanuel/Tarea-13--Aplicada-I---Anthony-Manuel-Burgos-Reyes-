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
    enum Estrella {ESPrincipal,ESGigantes,EGLuminosas,EBinarias }
    public partial class Ejercicio5C9 : Form
    {
        public Ejercicio5C9()
        {
            InitializeComponent();
        }
        
        private void SelecionarButton_Click(object sender, EventArgs e)
        {
            Estrella E;
            if (TipoComboBox.Text.Equals("Estrellas de la secuencia principal "))
            {
                E = Estrella.ESPrincipal;
                MostrarRichTextBox.Text = E.ToString() + ": En este tipo de estrellas podemos encontrar varias clases espectrales y su aumento de temperatura va relacionada con su aumento de tamaño tal y como se muestra la ilustración de abajo en una escala media. Hay pequeñas enanas rojas (tipo M), enanas naranjas (K), enanas amarillas (G) como el Sol, estrelllas blancas (F y A) y grandes estrellas azules (B y O).";
            }
            if (TipoComboBox.Text.Equals("Estrellas gigantes y luminosas "))
            {
                E = Estrella.EGLuminosas;
                MostrarRichTextBox.Text = E.ToString() + ": Hay estrellas gigantes en todos los espectros. Gigantes rojas, amarillas, naranjas, blancas y azules. La ilustración de abajo representa algunas estrellas gigantes comparadas con el Sol. Hay muchos tamaños para un mismo tipo espectral.";
            }
            if (TipoComboBox.Text.Equals("Estrellas supergigantes "))
            {
                E = Estrella.ESGigantes;
                MostrarRichTextBox.Text =E.ToString()+ ": Son estrellas mucho más grandes que el Sol y mucho más luminosas, auténticos monstruos en el espacio aunque muy escasas. Llegando incluso algunas a más de 1000 veces el tamaño del Sol. Una de ellas llenaría todo el sistema solar. Algunas de estas estrellas son el resultado de la evolución de una estrella de gran masa, pero otras son jóvenes como las de tipo O, aunque no permanecen en este estado mucho tiempo (unos pocos millones de años). Las hay de todos los espectros. La ilustración de abajo vemos la comparación de varias gigantes y supergigantes, de secuencia principal y el Sol.";
            }
            if (TipoComboBox.Text.Equals("Estrellas binarias"))
            {
                E = Estrella.EBinarias;
                MostrarRichTextBox.Text = E.ToString() + ":  Estrella doble Una estrella doble es de dos estrellas que aparecen cerca una de la otra en el cielo.Algunas son verdaderas binarias (dos estrellas que giran alrededor de la otra), mientras que otras sólo aparecen juntas desde la Tierra, ya que ambas están en la misma línea de visión. \nEstrellas binarias\nUna estrella binaria es un sistema de dos estrellas que giran alrededor de un centro común de masa (el baricentro). Alrededor de la mitad de todas las estrellas de la galaxia son estrellas binarias.";
            }
        }
    }
}
