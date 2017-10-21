using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class Form1 : Form
    {
        string[] direccion = new string[6];
        int[] cantAmbientes = new int[6];
        decimal[] precio = new decimal[6];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string error = "";
            int ambientes = Convert.ToInt32(cmbAmbientes.Text);
            if (txtDireccion.Text == "")
            {
                error = "Asegurese de haber completado todos los datos correctamente.";
            }
            else
            {
                if (ambientes < 1 || ambientes > 6 )
                {
                    error = "Asegurese de haber completado todos los datos correctamente.";
                }
                else
                {
                    if (nudPrecio.Value > 2000000 || nudPrecio.Value < 500000)
                    {
                        error = "Asegurese de haber completado todos los datos correctamente.";
                    }
                }
            }

            if (error == "")
            {
                txtDireccion.Text = "";
                cmbAmbientes.Text = "";
                nudPrecio.Text = "";
                direccion[i] = txtDireccion.Text;
                cantAmbientes[i] = ambientes;
                precio[i] = nudPrecio.Value;
                if (i == 5)
                {
                    MessageBox.Show("Ya ha ingresado información correspondiente a 6 propiedades. Vea la información.");
                }
                else
                {
                    i++;
                }
            }
            else
            {
                MessageBox.Show(error);
                error = "";
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            int posMasCara = 0;
            string direccionMasCara = direccion[0];
            decimal precioMasCaro = precio[0];

            for (int i = 1; i < precio.Length; i++)
            {
                if (precio[i]>precio[posMasCara])
                {
                    posMasCara = i;
                }
            }
            MessageBox.Show("La dirección de la propiedad más cara es: " + direccion[posMasCara] + ", su valor es: $" + precio[posMasCara] + ".");

            int posMasAmbientes = 0;
            string direccionesMasAmbientes = direccion[0];
            int cantidadAmbientesPropMasAmbientes = cantAmbientes[0];
            for (int i = 1; i < precio.Length; i++)
            {
                if (cantAmbientes[i] > cantAmbientes[posMasAmbientes])
                {
                    direccionesMasAmbientes = direccion[i];
                    cantidadAmbientesPropMasAmbientes = cantAmbientes[i];
                }
                else
                {
                    if (cantAmbientes[i] == cantAmbientes[posMasAmbientes])
                    {
                        direccionesMasAmbientes += ", " + direccion[i];
                    }
                }
            }
            MessageBox.Show("La propiedad/es con más ambientes es/son: " + direccionesMasAmbientes + ".\nLa cantidad de ambientes que tiene/n es: " + cantidadAmbientesPropMasAmbientes + ".");
            
            decimal totalVendido = 0;
            for (int i = 0; i < precio.Length; i++)
            {
                totalVendido += precio[i];
            }
            MessageBox.Show("El total vendido fue: $" + totalVendido + ".");



        }
    }
}


