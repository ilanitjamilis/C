using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerosRomanos
{
    public partial class Form1 : Form
    {
        string error = "";
        int numeroDecimal = 0;
        int vecesM = 0;
        int vecesCM = 0;
        int vecesD = 0;
        int vecesCD = 0;
        int vecesC = 0;
        int vecesXC = 0;
        int vecesL = 0;
        int vecesXL = 0;
        int vecesX = 0;
        int vecesIX = 0;
        int vecesV = 0;
        int vecesIV = 0;
        int vecesI = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            numeroDecimal = Convert.ToInt32(txtNumeroDecimal.Text);
            if (numeroDecimal <= 0 || numeroDecimal > 1999)
            {
                error += "Error, ingrese un número válido.";
            }
            if (error == "")
            {
                    lblNumeroRomano.Text = "";

                    vecesM = numeroDecimal / 1000;
                    for (int i = 0; i < vecesM; i++)
                    {
                        lblNumeroRomano.Text += "M ";
                    }
                    vecesM = 0;
                    numeroDecimal = numeroDecimal % 1000;

                    vecesCM = numeroDecimal / 900;
                    for (int i = 0; i < vecesCM; i++)
                    {
                        lblNumeroRomano.Text += "C M ";
                    }
                    vecesCM = 0;
                    numeroDecimal = numeroDecimal % 900;
                
                    vecesD = numeroDecimal / 500;
                    for (int i = 0; i < vecesD; i++)
                    {
                        lblNumeroRomano.Text += "D ";
                    }
                    vecesD = 0;
                    numeroDecimal = numeroDecimal % 500;

                    vecesCD = numeroDecimal / 400;
                    for (int i = 0; i < vecesCD; i++)
                    {
                        lblNumeroRomano.Text += "C D ";
                    }
                    vecesCD = 0;
                    numeroDecimal = numeroDecimal % 400;
                
                    vecesC = numeroDecimal / 100;
                    for (int i = 0; i < vecesC; i++)
                    {
                        lblNumeroRomano.Text += "C ";
                    }
                    vecesC = 0;
                    numeroDecimal = numeroDecimal % 100;

                    vecesXC = numeroDecimal / 90;
                    for (int i = 0; i < vecesXC; i++)
                    {
                        lblNumeroRomano.Text += "X C ";
                    }
                    vecesXC = 0;
                    numeroDecimal = numeroDecimal % 90;

                    vecesL = numeroDecimal / 50;
                    for (int i = 0; i < vecesL; i++)
                    {
                        lblNumeroRomano.Text += "L ";
                    }
                    vecesL = 0;
                    numeroDecimal = numeroDecimal % 50;

                    vecesXL = numeroDecimal / 40;
                    for (int i = 0; i < vecesXL; i++)
                    {
                        lblNumeroRomano.Text += "X L ";
                    }
                    vecesXL = 0;
                    numeroDecimal = numeroDecimal % 40;

                    vecesX = numeroDecimal / 10;
                    for (int i = 0; i < vecesX; i++)
                    {
                        lblNumeroRomano.Text += "X ";
                    }
                    vecesX = 0;
                    numeroDecimal = numeroDecimal % 10;

                    vecesIX = numeroDecimal / 9;
                    for (int i = 0; i < vecesIX; i++)
                    {
                        lblNumeroRomano.Text += "I X ";
                    }
                    vecesIX = 0;
                    numeroDecimal = numeroDecimal % 9;

                    vecesV = numeroDecimal / 5;
                    for (int i = 0; i < vecesV; i++)
                    {
                        lblNumeroRomano.Text += "V ";
                    }
                    vecesV = 0;
                    numeroDecimal = numeroDecimal % 5;

                    vecesIV = numeroDecimal / 4;
                    for (int i = 0; i < vecesIV; i++)
                    {
                        lblNumeroRomano.Text += "I V ";
                    }
                    vecesIV = 0;
                    numeroDecimal = numeroDecimal % 4;

                    vecesI = numeroDecimal / 1;
                    for (int i = 0; i < vecesI; i++)
                    {
                        lblNumeroRomano.Text += "I ";
                    }
                    vecesI = 0;

            }
            else
            {
                MessageBox.Show(error);
                error = "";
            }
        }
    }
}
