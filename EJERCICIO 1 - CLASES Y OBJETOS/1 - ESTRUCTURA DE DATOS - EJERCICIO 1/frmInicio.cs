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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            //  Cargo los item a la lista
            cmbColores.Items.Add("Rojo");
            cmbColores.Items.Add("Azul");
            cmbColores.Items.Add("Amarillo");

            //  Dejo preseleccionado el primero
            cmbColores.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAuto player = new frmAuto(cmbColores.Text);    //    Nuevo NombreDelFormulario (String Color)
                                                              //    El nuevo formulario le enviamos el color seleccionado.
            player.Show();                                    //    Muestra la nueva interface
        }
    }
}
