using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hamburguesas_MC_Donalds
{
    public partial class Form1 : Form
    {
        string[] nombreCombo = new string[6];
        int[] hamburguesasCombo = new int[6];
        decimal[] precioCombo = new decimal[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int auxHambur = 0;
            decimal auxPrecio = 0;
            string auxNombre = "";
            for (int i = 0; i < hamburguesasCombo.Length; i++)
            {
                for (int f = 0; f < hamburguesasCombo.Length-1; f++)
                {
                    if (hamburguesasCombo[f] > hamburguesasCombo[f + 1])
                    {
                        auxHambur = hamburguesasCombo[f + 1];
                        hamburguesasCombo[f + 1] = hamburguesasCombo[f];
                        hamburguesasCombo[f] = auxHambur;

                        auxNombre = nombreCombo[f + 1];
                        nombreCombo[f + 1] = nombreCombo[f];
                        nombreCombo[f] = auxNombre;

                        auxPrecio = precioCombo[f + 1];
                        precioCombo[f + 1] = precioCombo[f];
                        precioCombo[f] = auxPrecio;
                    }
                }
            }

            for (int k = 0; k<6; k++)
            {
                MessageBox.Show("Nombre: " + nombreCombo[k] + ".\nPrecio: $" + precioCombo[k] + ".\nCantidad de hamburguesas: " + hamburguesasCombo[k] + ".");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nombreCombo[0] = "Mc Cajita Feliz";
            nombreCombo[1] = "Super mega hiper mega hamburguesa";
            nombreCombo[2] = "Super hamburguesa";
            nombreCombo[3] = "Hamburguesa triple";
            nombreCombo[4] = "Mega hamburguesa";
            nombreCombo[5] = "Quintuple hamburguesa";

            hamburguesasCombo[0] = 1;
            hamburguesasCombo[1] = 9;
            hamburguesasCombo[2] = 6;
            hamburguesasCombo[3] = 3;
            hamburguesasCombo[4] = 7;
            hamburguesasCombo[5] = 5;

            precioCombo[0] = 19.99M;
            precioCombo[1] = 232.25M;
            precioCombo[2] = 197;
            precioCombo[3] = 176.83M;
            precioCombo[4] = 107;
            precioCombo[5] = 96.73M;
            
        }
    }
}
