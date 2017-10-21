using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen2doTrimestre
{
    public partial class Examen2doTrimestre : Form
    {
        string frase = "";

        public Examen2doTrimestre()
        {
            InitializeComponent();
        }

        private void btnCantPalabras_Click(object sender, EventArgs e)
        {
            frase = txtFrase.Text;
            if (frase == "")
            {
                MessageBox.Show("ERROR. Asegúrese de haber ingresado contenido en el campo de texto.");
            }
            else
            {
                int cantPalabras = Funciones.CantPalabras(frase);
                MessageBox.Show("La cantidad de palabras ingresadas fueron: " + cantPalabras + ".");
            }

        }

        private void btnCantPalabrasImpares_Click(object sender, EventArgs e)
        {
            frase = txtFrase.Text;
            int cantPalabras = Funciones.CantPalabras(frase);
            if (cantPalabras == 0)
            {
                MessageBox.Show("ERROR. Asegúrese de haber ingresado contenido en el campo de texto.");
            }
            else
            {
                int cantPalabrasImpares = Funciones.CantPalabrasImpares(frase);
                if (cantPalabrasImpares == 0)
                {
                    MessageBox.Show("No hubo ninguna palabra con cantidad de dígitos impares.");
                }
                else
                {
                    MessageBox.Show("La cantidad de palabras impares fueron: " + cantPalabrasImpares + ".");
                }
            }
        }

        private void btnCantNumeros_Click(object sender, EventArgs e)
        {
            frase = txtFrase.Text;
            int cantPalabras = Funciones.CantPalabras(frase);
            int cantNumeros = Funciones.CantNumeros(frase);
            
            if (cantPalabras == 0)
            {
                MessageBox.Show("ERROR. Asegúrese de haber ingresado contenido en el campo de texto.");
            }
            else
            {
                if (cantNumeros > 0)
                {
                    MessageBox.Show("La cantidad de números ingresados en el textBox fueron: " + cantNumeros + ".");
                }
                else
                {
                    MessageBox.Show("No se ha ingresado ningún número.");
                }
            }
        }

        private void btnNumerosPrimos_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(nud1.Value);
            int numero2 = Convert.ToInt32(nud2.Value);
            if (numero1 > numero2)
            {
                MessageBox.Show("ERROR. El primer número debe ser menor que el segundo.");
            }
            else
            {
                if (numero1 == 0 && numero2 == 0)
                {
                    MessageBox.Show("ERROR. Asegúrese de haber ingresado los números.");
                }
                else
                {
                    string numerosPrimos = Funciones.NumerosPrimos(numero1, numero2);

                    MessageBox.Show("Numeros primos entre los ingresados: " + numerosPrimos + ".");
                }
            }
        }
    }
}
