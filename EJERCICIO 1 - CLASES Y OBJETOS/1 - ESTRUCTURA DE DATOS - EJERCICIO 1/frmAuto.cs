using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1___ESTRUCTURA_DE_DATOS___EJERCICIO_1
{
    public partial class frmAuto : Form
    {
        Auto auto;                                  // Llama a la CLASE Auto y al OBJETO auto
        public frmAuto(string Color)                //El constructor recibe COLOR como parametro y crea un auto
        {
            InitializeComponent();

            auto = new Auto(Color);                 // Instanciamos la clase Auto.
            CambiarColor(auto.DevolverColor());     // Llama a la funcio CambiarColor
        }
        //METODO COLOR DEL AUTO
        public void CambiarColor(string Color)      //Metodo que recibe el STRING del color elegido
        {
            if(Color == "Rojo")
            {
                this.BackColor = System.Drawing.Color.Red;  //Cambia el fondo del formulario por el color seleccionado
            }                                               //System.Drawing.Color accede a los colores disponibles del Sistema
            else if(Color == "Azul")
            {
                this.BackColor = System.Drawing.Color.Blue; 
            }
            else
            {
                this.BackColor = System.Drawing.Color.Yellow;
            }
        }
        //BOTON ACELERAR
        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            auto.Acelerar();                                    // Llama al metodo ACELERAR
            lbVelocidad.Text = auto.DevolverVelocidad();        // Llama al metodo Devolver Velocidad para modificar el VELOCIMETRO
        }

        //BOTON FRENAR
        private void btnFrenar_Click(object sender, EventArgs e)
        {
            auto.Frenar();                                      // Llama al metodo FRENAR
            lbVelocidad.Text = auto.DevolverVelocidad();        // Llama al metodo Devolver Velocidad para modificar el VELOCIMETRO
        }
    }
}
