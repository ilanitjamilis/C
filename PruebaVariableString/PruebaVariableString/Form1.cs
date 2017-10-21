using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaVariableString
{
    public partial class NombreApellido : Form
    {
        public NombreApellido()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            nombre = nombre.Trim();
            string apellido = txtApellido.Text;
            apellido = apellido.Trim();
            if (nombre.IndexOf(" ") > 0)
            {
                MessageBox.Show("Usted tiene dos nombres.");
                int posicionesEspacioNombre = nombre.IndexOf(" ");
                string primerNombre = nombre.Substring(0, posicionesEspacioNombre);
                string segundoNombre = nombre.Substring(posicionesEspacioNombre + 1);
                MessageBox.Show("Su primer nombre es " + primerNombre + ".");
                MessageBox.Show("Su segundo nombre es " + segundoNombre + ".");
            }
            else
            {
                MessageBox.Show("Usted tiene un solo nombre.\nÉste es " + nombre + ".");
            }
            if (apellido.IndexOf(" ") > 0)
            {
                MessageBox.Show("Usted tiene dos apellidos.");
                int posicionesEspacioApellido = apellido.IndexOf(" ");
                string primerApellido = apellido.Substring(0, posicionesEspacioApellido);
                string segundoApellido = apellido.Substring(posicionesEspacioApellido + 1);
                MessageBox.Show("Su primer apellido es " + primerApellido + ".");
                MessageBox.Show("Su segundo apellido es " + segundoApellido + ".");
            }
            else
            {
                MessageBox.Show("Usted tiene un solo apellido.\nÉste es " + apellido + ".");
            }
        }
    }
}
