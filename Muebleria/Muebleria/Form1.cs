using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muebleria
{
    public partial class Form1 : Form
    {
        string[] material = new string[10];
        decimal[] precioDeLista = new decimal[10];
        decimal recaudacion = 0;
        int cantSillas = 0;
        int numCompras = 0;
        int[] cantProd = new int[10];
        decimal totalDescuentos = 0;


        public Form1()
        {
            InitializeComponent();
            nudCantSillas.Text = "";
            nudCodJuego.Text = "";
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            int prodMax = 0;
            int prodMin = 0;
            
            for (int i = 1; i <= 9; i++)
            {
                if (cantProd[i] > cantProd[prodMax])
                {
                    prodMax = i;
                }
                else
                {
                    if (cantProd[i] < cantProd[prodMin])
                    {
                        prodMin = i;
                    }
                }
            }

            MessageBox.Show("Producto más vendido \n\n      -Código: " + prodMax + ".\n      -Material: " + material[prodMax] + ".\n      -Precio: " + precioDeLista[prodMax] + ".");
            MessageBox.Show("Producto menos vendido \n\n      -Código: " + prodMin + ".\n      -Material: " + material[prodMin] + ".\n      -Precio: " + precioDeLista[prodMin] + ".");
            MessageBox.Show("Recaudación total: $" + Math.Round(recaudacion,2) + ".");
            MessageBox.Show("Descuentos totales realizados: $" + Math.Round(totalDescuentos,2) + ".");
            MessageBox.Show("Cantidad de sillas vendidas: " + cantSillas + ".");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string error = "";
            bool numFactura = Funciones1.ValidarFactura(txtNumFactura.Text);
            if (numFactura == false)
            {
                error = "Asegúrese de haber completado todos los datos correctamente.";
            }
            else
            {
                if (nudCodJuego.Value < 0 || nudCodJuego.Value > 9)
                {
                    error = "Asegúrese de haber completado todos los datos correctamente.";
                }
                else
                {
                    if (cmbTamano.Text != "CHICO" && cmbTamano.Text != "MEDIANO" && cmbTamano.Text != "GRANDE")
                    {
                        error = "Asegúrese de haber completado todos los datos correctamente.";
                    }
                    else
                    {
                        if (nudCantSillas.Value < 2 || nudCantSillas.Value > 12)
                        {
                            error = "Asegúrese de haber completado todos los datos correctamente.";
                        }
                    }
                }
            }

            if (error == "")
            {
                numCompras++;
                int numCodigo = Convert.ToInt32(nudCodJuego.Value);
                decimal paraDescuentos = 1;
                decimal precioFinal = 0;
                decimal precioAlCliente = precioDeLista[numCodigo];

                cantProd[numCodigo]++;

                cantSillas += Convert.ToInt32(nudCantSillas.Value);
                
                if (cmbTamano.Text == "CHICO" && nudCantSillas.Value > 8)
                {
                    paraDescuentos += 0.15M;
                }
                if (material[numCodigo] == "Metal")
                {
                    paraDescuentos += 0.15M;
                }
                if (material[numCodigo] == "Combinado")
                {
                    paraDescuentos -= 0.075M;
                }
                if (cmbTamano.Text == "GRANDE" && nudCantSillas.Value > 8)
                {
                    paraDescuentos -= 0.1M;
                }

                precioFinal = Math.Round((precioAlCliente * paraDescuentos),2);
                recaudacion+=precioFinal;

                totalDescuentos += (precioFinal - precioAlCliente);

                txtNumFactura.Text = "";
                nudCantSillas.Text = "";
                nudCodJuego.Text = "";
                cmbTamano.Text = "";
                MessageBox.Show("Producto cargado correctamente.");
            }
            else
            {
                MessageBox.Show(error,"ERROR");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            material[0] = "Metal";
            material[1] = "Madera";
            material[2] = "Combinado";
            material[3] = "Metal";
            material[4] = "Madera";
            material[5] = "Combinado";
            material[6] = "Metal";
            material[7] = "Madera";
            material[8] = "Combinado";
            material[9] = "Metal";

            precioDeLista[0] = 499.99M;
            precioDeLista[1] = 799.99M;
            precioDeLista[2] = 1100;
            precioDeLista[3] = 1400;
            precioDeLista[4] = 1700;
            precioDeLista[5] = 2000;
            precioDeLista[6] = 2300;
            precioDeLista[7] = 2600;
            precioDeLista[8] = 2900;
            precioDeLista[9] = 4999.99M;
        }
    }
}
