using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JuegoDePalabras
{
        

    public partial class frmJuegoDePalabras : Form
    {
        int cantA = 0;
        int cantE = 0;
        int cantI = 0;
        int cantO = 0;
        int cantU = 0;
        int cantConso = 0;
        int cantiPalabras = 0;
        bool fraseCapicua = false;

        
        public frmJuegoDePalabras()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string frase = txtfrase.Text;
            frase = frase.Trim().ToLower();

            cantA = Funciones.CantA(frase);

            cantE = Funciones.CantE(frase);

            cantI = Funciones.CantI(frase);

            cantO = Funciones.CantO(frase);

            cantU = Funciones.CantU(frase);

            cantConso = Funciones.cantConsonantes(frase);

            cantiPalabras = Funciones.cantPalabras(frase);

            fraseCapicua = Funciones.fraseCapicua(frase);


        }

        private void vocalMasUsada_Click(object sender, EventArgs e)
        {
            if (cantA > cantE && cantA > cantI && cantA > cantO && cantA > cantU)
            {
                MessageBox.Show("La vocal más usada fue 'a'.","Vocal más usada");
            }
            if (cantE > cantA && cantE > cantI && cantE > cantO && cantE > cantU)
            {
                MessageBox.Show("La vocal más usada fue 'e'.","Vocal más usada");
            }
            if (cantI > cantA && cantI > cantE && cantI > cantO && cantI > cantU)
            {
                MessageBox.Show("La vocal más usada fue 'i'.","Vocal más usada");
            }
            if (cantO > cantA && cantO > cantE && cantO > cantI && cantO > cantU)
            {
                MessageBox.Show("La vocal más usada fue 'o'.","Vocal más usada");
            }
            if (cantU > cantA && cantU > cantE && cantU > cantI && cantU > cantO)
            {
                MessageBox.Show("La vocal más usada fue 'u'.","Vocal más usada");
            }
        }

        private void cantidadVocales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La vocal 'a' fue escrita " + cantA + " veces.\n\nLa vocal 'e' fue escrita " + cantE + " veces.\n\nLa vocal 'i' fue escrita " + cantI + " veces.\n\nLa vocal 'o' fue escrita " + cantO + " veces.\n\nLa vocal 'u' fue escrita " + cantU + " veces.","Cantidad de vocales");
        }

        private void cantPalabras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de palabras ingresadas fue: " + cantiPalabras + ".", "Cantidad palabras");
        }

        private void cantConsonantes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de consonantes ingresadas fueron: " + cantConso + ".", "Cantidad de consonantes");
        }

        private void frasesCapicua_Click(object sender, EventArgs e)
        {
            if (fraseCapicua == true)
            {
                MessageBox.Show("La frase es capicúa.", "Frase capicúa");
            }
            else
            {
                MessageBox.Show("La frase no es capicúa.", "Frase capicúa");
            }
        }



    }
}
