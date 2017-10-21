using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nudNum.Value);
            int cantDivisores = 0;
            string numerosPrimos = "";
            int nPrimos = 0;
            bool nPrimosPar = false;
            bool numeroPrimo = false;
            int siguienteDivisor = 0;

            for (int i = 2; i < numero; i++)
            {
                cantDivisores = 0;
                for (int i2 = 2; i2 < i; i2++)
                {
                    if (i % i2 == 0)
                    {
                        cantDivisores++;
                    }
                }
                if (cantDivisores == 0)
                {
                    nPrimos++;
                    numerosPrimos += i + ",";
                }
            }
            if (nPrimos % 2 == 0)
            {
                nPrimosPar = true;
            }

            
            cantDivisores = 0;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    cantDivisores++;
                }
            }
            if (cantDivisores == 0)
            {
                numeroPrimo = true;
            }
            else
            {
                int i=numero;
                while (cantDivisores!=0)
                {
                    cantDivisores = 0;
                    for (int i2 = 2; i2 < i; i2++)
                    {
                        if (i % i2 == 0)
                        {
                            cantDivisores++;
                        }
                    }
                    if (cantDivisores == 0)
                    {
                        siguienteDivisor = i;
                    }
                    i++;
                }
            }


                MessageBox.Show("Números primos entre 1 y el número ingresado: " + numerosPrimos + ".");
                if (nPrimosPar == false)
                {
                    MessageBox.Show("La cantidad de números primos entre 1 y el número ingresado es impar.");
                }
                else
                {
                    MessageBox.Show("La cantidad de números primos entre 1 y el número ingresado es par.");
                }
                if (numeroPrimo == true)
                {
                    MessageBox.Show("El número elegido es primo.");
                }
                else
                {
                    MessageBox.Show("El número elegido no es primo; el siguiente primo es " + siguienteDivisor + ".");
                }


                numero = 0;
                cantDivisores = 0;
                numerosPrimos = "";
                nPrimos = 0;
                nPrimosPar = false;
                numeroPrimo = false;
                siguienteDivisor = 0;

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    }