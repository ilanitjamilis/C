using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string error = "";
        
        private void btnVeces_Click(object sender, EventArgs e)
        {
            if (nudNumero.Value < 1)
            {
                error = "Error, ingrese un número válido.";
            }

            if (error == "")
            {
                int cantidad = Convert.ToInt32(nudNumero.Value);
                string resultado = Funciones.vecesNumero(cantidad);
                MessageBox.Show(resultado,"Veces Número");
                resultado = "";
            }
            else
            {
                MessageBox.Show(error);
                error = "";
            }
        }

        private void btnHastaNumero_Click(object sender, EventArgs e)
        {
            if (nudNumero.Value < 0)
            {
                error = "Error, ingrese un número válido.";
            }

            if (error == "")
            {
                int cantidad = Convert.ToInt32(nudNumero.Value);
                string resultado = Funciones.hastaX(cantidad);
                MessageBox.Show(resultado, "Hasta número");
            }
            else
            {
                MessageBox.Show(error);
            }
            error = "";
        }

        private void btnSiEsta_Click(object sender, EventArgs e)
        {
            if (nudNumero.Value < 0)
            {
                error = "Error, ingrese un número válido.";
            }

            if (error == "")
            {
                int cantidad = Convert.ToInt32(nudNumero.Value);
                bool resultado = Funciones.existeN(cantidad);
                if(resultado==true)
                {
                    MessageBox.Show("El número ingresado pertenece a la sucesión de Fibonacci.", "Existencia del número");
                }
                if (resultado == false)
                {
                    MessageBox.Show("El número ingresado no pertenece a la sucesión de Fibonacci.", "Existencia del número");
                }
            }
            else
            {
                MessageBox.Show(error);
                error = "";
            }
        }
    }
}
