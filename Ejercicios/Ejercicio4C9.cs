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
    public partial class Ejercicio4C9 : Form
    {
        enum Neumatico {Invierno,Verano, Pax,Radial, AllSeason, Asimétricos,Direccionales,Tubuless,Recauchutados,Ecológicos
        }
        
        public Ejercicio4C9()
        {
            InitializeComponent();
        }

        private void SelecionarButton_Click(object sender, EventArgs e)
        {
            Neumatico N;
            if (TipoComboBox.Text.Equals("Neumático de  Verano"))
            {
                N = Neumatico.Verano;
                MostrarRichTextBox.Text = N.ToString()+ ": Puede circular con neumáticos de verano durante todo el año si la utilización de su vehículo, los desplazamientos realizados y el clima de su zona geográfica se lo permiten. Es muy importante que los neumáticos de verano estén siempre en muy buen estado.  ";
            }
            if (TipoComboBox.Text.Equals("Neumático de  Invierno"))
            {
                N = Neumatico.Invierno;
                MostrarRichTextBox.Text = N.ToString()+ ": Se recomienda montar neumáticos de invierno a partir del mes de noviembre hasta el mes de marzo inclusive. No obstante, el desgaste de los neumáticos de invierno varia en función de la utilización de su vehículo, de los desplazamientos realizados y del clima de su zona geográfica. Es muy importante que los neumáticos de invierno estén siempre en muy buen estado, ya que estos neumáticos desgastados no serán eficaces ni en la nieve ni en suelo mojado. ";
            }
            if (TipoComboBox.Text.Equals("Neumático Run Flat o Pax"))
            {
                N = Neumatico.Pax;
                MostrarRichTextBox.Text = N.ToString()+ ": Según los fabricantes, los neumáticos llamados 'antipinchazo', por ejemplo Run Flat de Pirelli, RFT de Bridgestone o Pax de Michelin, son obligatorios en ciertos vehículos que no tienen rueda de auxilio, y que tienen únicamente una bomba de aire antipinchazo. Si elige el tipo de neumáticos inadecuado, en caso de pinchazo su llanta corre el riesgo de desgastarse y necesitará una reparación en el lugar. ";
            }
            if (TipoComboBox.Text.Equals("Neumático Radial"))
            {
                N = Neumatico.Radial;
                MostrarRichTextBox.Text = N.ToString()+ ": Aquí, la armadura del neumático se compone de capas de tejido colocada en forma radial, directamente de un talón a otro del neumático, formando una especie de tubo que da forma a la carcasa, y se remata en su parte superior por telas de cables metálicos cruzadas. Así, el flanco es más ligero y aporta mayor flexibilidad, con ventajas añadidas en duración y seguridad al calentarse menos y garantizar mayor área de contacto con el suelo que los neumáticos diagonales.";
            }
            if (TipoComboBox.Text.Equals("Neumático asimétricos"))
            {
                N = Neumatico.Asimétricos;
                MostrarRichTextBox.Text = N.ToString()+ ": A diferencia de un neumático simétrico, con una banda de rodadura con el mismo perfil en la parte interior y exterior del neumático, por lo que no tienen sentido de montaje específico, los neumáticos asimétricos tienen diferente dibujo en la parte interior y la parte exterior del neumático, por ejemplo una parte optimizada para drenar el agua, y otra para mejorar el agarre en seco. Sólo tienen un sentido de montaje, y los flancos van marcados señalando el interior y el exterior.";
            }
            if (TipoComboBox.Text.Equals("Neumático direccionales"))
            {
                N = Neumatico.Direccionales;
                MostrarRichTextBox.Text = N.ToString()+ ": Los neumáticos direccionales suelen tener un dibujo en forma de V o de flecha, pensado principalmente para la buena evacuación del agua, por lo que sólo tienen un sentido de rotación.\n En la actualidad se utiliza mucho este tipo de construcción en neumáticos de invierno.";
            }
            if (TipoComboBox.Text.Equals("Neumático tubuless"))
            {
                N = Neumatico.Tubuless;
                MostrarRichTextBox.Text = N.ToString()+ ": Se llaman neumáticos tubuless a los que no necesitan una cámara interior para encerrar el aire. \nSon, por lo tanto, neumáticos sin cámara, en los que el interior cuenta con una capa de aislamiento realizada con un caucho especial, y existe hermeticidad en la unión del neumático con la llanta.\n Se desarrollaron a mediados de los años 50, estandarizándose a partir de los 70, y hoy en día ya no se utilizan neumáticos con cámara.";
            }
            if (TipoComboBox.Text.Equals("Neumático All Season"))
            {
                N = Neumatico.AllSeason;
                MostrarRichTextBox.Text = N.ToString()+": El neumático para toda temporada es una buena alternativa si utiliza su vehículo en verano y en invierno. Es un neumático conveniente para todo tipo de suelo, aunque algo generalista. \nUn neumático para toda temporada no será tan eficaz y no tendrá tanta adherencia en suelo seco como un neumático de verano.";
            }
            if (TipoComboBox.Text.Equals("Neumático recauchutados"))
            {
                N = Neumatico.Recauchutados;
                MostrarRichTextBox.Text = N.ToString()+ ": Se llaman neumáticos tubuless a los que no necesitan una cámara interior para encerrar el aire.\n Son, por lo tanto, neumáticos sin cámara, en los que el interior cuenta con una capa de aislamiento realizada con un caucho especial, y existe hermeticidad en la unión del neumático con la llanta.\n Se desarrollaron a mediados de los años 50, estandarizándose a partir de los 70, y hoy en día ya no se utilizan neumáticos con cámara.";
            }
            if (TipoComboBox.Text.Equals("Neumático  ecológicos "))
            {
                N = Neumatico.Ecológicos;
                MostrarRichTextBox.Text = N.ToString()+ ": Cada vez son más frecuentes en las gamas de los fabricantes de neumáticos los denominados neumáticos ecológicos, fabricados con compuestos especiales y con un diseño de su dibujo en la banda de rodadura pensado para mejorar la resistencia al rodamiento y disminuir así el consumo de combustible.";
            }





        }

      

        
    }
}
