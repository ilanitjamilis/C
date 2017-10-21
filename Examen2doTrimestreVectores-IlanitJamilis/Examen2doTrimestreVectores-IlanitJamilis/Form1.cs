using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen2doTrimestreVectores_IlanitJamilis
{
    public partial class Form1 : Form
    {
        string[] nombresJugadores = new string [6];
        int[] puntosJugadores = new int [6];
        int i = 0;
        string error = "";
        int totalPuntos = 0;
        int posicionJugadorMasPuntos = 0;
        int posicionJugadorMenosPuntos = 0;
        string auxNombre = "";
        int auxPuntos = 0;
        string ordenJugadores = "";
        bool nombre = false;
        int posicionNombre = 0;
        int i2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarJugador_Click(object sender, EventArgs e)
        {
            error = "";

            nombre = false;
            foreach (var item in nombresJugadores)
            {
                if (txtNombre.Text == item)
                {
                    nombre = true;
                }
            }

            if (txtNombre.Text == "")
            {
                error += "Ingrese nombre del jugador.\n\n";
            }
            if (i==6 && nombre==false)
            {
                error += "No hay mas cupos para nuevos jugadores. Ingrese un nombre ya ingresado anteriormente.\n\n";
            }
            if (nudPuntos.Value < 1)
            {
                error += "Ingrese cantidad de puntos.\n\n";
            }

            if (error == "")
            {
                if (nombre == false)
                {
                    nombresJugadores[i] = txtNombre.Text;
                    puntosJugadores[i] = Convert.ToInt32(nudPuntos.Value);
                }
                else
                {
                    posicionNombre = 0;
                    i2 = 0;
                    foreach (var item in nombresJugadores)
	                {
		                if(txtNombre.Text==item)
                        {
                            posicionNombre=i2;
                        }
                        i2++;
	                }
                    puntosJugadores[posicionNombre] += Convert.ToInt32(nudPuntos.Value);
                }
                MessageBox.Show("Jugador cargado exitosamente.");
                txtNombre.Text = "";
                nudPuntos.Text = "0";
                i++;
            }
            else
            {
                MessageBox.Show(error,"ERROR");
            }
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            totalPuntos = 0;
            for (int i = 0; i < 6; i++)
            {
                totalPuntos+=puntosJugadores[i];
            }
            MessageBox.Show("Total de puntos = " + totalPuntos + ".");

            posicionJugadorMasPuntos = 0;
            posicionJugadorMenosPuntos = 0;
            for (int i = 1; i < 6; i++)
            {
                if (puntosJugadores[i] > puntosJugadores[posicionJugadorMasPuntos])
                {
                    posicionJugadorMasPuntos = i;
                }
                else
                {
                    if (puntosJugadores[i] < puntosJugadores[posicionJugadorMenosPuntos])
                    {
                        posicionJugadorMenosPuntos = i;
                    }
                }
            }
            MessageBox.Show("Jugador que anotó mas puntos: " + nombresJugadores[posicionJugadorMasPuntos] + ". Hizo " + puntosJugadores[posicionJugadorMasPuntos] + ".\n\nJugador que anotó menos puntos: " + nombresJugadores[posicionJugadorMenosPuntos] + ". Hizo " + puntosJugadores[posicionJugadorMenosPuntos] + ".","Maximos y minimos");

            auxNombre="";
            auxPuntos=0;
            for (int i = 0; i < 6; i++)
            {
                for (int f = 0; f < 6-1; f++)
                {
                    if (puntosJugadores[f] < puntosJugadores[f + 1])
                    {
                        auxPuntos = puntosJugadores[f+1];
                        puntosJugadores[f + 1] = puntosJugadores[f];
                        puntosJugadores[f] = auxPuntos;

                        auxNombre = nombresJugadores[f + 1];
                        nombresJugadores[f + 1] = nombresJugadores[f];
                        nombresJugadores[f] = auxNombre;

                    }
                }
            }
            ordenJugadores = "";
            for (int i = 0; i < 6; i++)
            {
                ordenJugadores += "Nombre jugador: " + nombresJugadores[i] + ". Puntos anotados: " + puntosJugadores[i] + ".\n\n";
            }
            MessageBox.Show(ordenJugadores,"Lista final");
        }
    }
}
