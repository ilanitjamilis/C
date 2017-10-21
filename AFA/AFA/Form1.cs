using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AFA
{
    public partial class Form1 : Form
    {
        List<Equipo>Equipos = new List<Equipo>();
        string error = "";
        Jugador oJugador = new Jugador();
        bool equipoEncontrado = false;
        int auxCantJugadores = 0;
        decimal auxSueldoEquipo = 0;
        int masJugadores = 0;
        string equipoMasJugadores = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarJugador_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                error += "Ingrese nombre";
            }
            else
            {
                if (txtApellido.Text=="")
                {
                    error += "ERROR";
                }
                else
                {
                    if (nudSueldo.Value<=0)
	                {
                        error += "ERROR";
                    }
                    else
                    {
                        if (nudEdad.Value<1)
	                    {
                            error += "ERROR";
                        }
                    }
                }		 
            }

            if (error == "")
            {
                equipoEncontrado = false;
                oJugador = new Jugador();
                oJugador.nombre = txtNombre.Text;
                oJugador.apellido = txtApellido.Text;
                oJugador.sueldo = nudSueldo.Value;
                oJugador.edad = Convert.ToInt32(nudEdad.Value);
                
                foreach (Equipo oEquipo in Equipos)
                {
                    if (oEquipo.nombre == txtEquipo.Text)
                    {
                        equipoEncontrado = true;
                        oEquipo.ListaJugadores.Add(oJugador);
                    }
                }
                if (equipoEncontrado == false)
                {
                    Equipo oequipo = new Equipo();
                    oequipo.nombre = txtEquipo.Text;
                    oequipo.ListaJugadores = new List<Jugador>();
                    oequipo.ListaJugadores.Add(oJugador);
                    Equipos.Add(oequipo);
                }
            }
            else
            {
                MessageBox.Show(error);
                error = "";
            }

            MessageBox.Show("Jugador ingresado correctamente.");

            txtEquipo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text="";
            nudSueldo.Value=0;
            nudEdad.Value=0;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Jugador jugadorMasCaro = new Jugador();
            Jugador jugadorMasViejo = new Jugador();
            foreach (Equipo oEquipo in Equipos)
            {

                foreach (Jugador oJugador in oEquipo.ListaJugadores)
                {
                    auxCantJugadores++;
                    auxSueldoEquipo += oJugador.sueldo;

                    if (oJugador.sueldo > jugadorMasCaro.sueldo)
                    {
                        jugadorMasCaro = oJugador;
                    }

                    if (oJugador.edad > jugadorMasViejo.edad)
                    {
                        jugadorMasViejo = oJugador;
                    }

                }
                if(auxCantJugadores>masJugadores)
                {
                    masJugadores=auxCantJugadores;
                    equipoMasJugadores=oEquipo.nombre;
                }

                MessageBox.Show("Equipo: " + oEquipo.nombre + ".\nSueldo total= " + auxSueldoEquipo + ".\nCantidad de jugadores: " + auxCantJugadores + ".");
                auxCantJugadores = 0;
                auxSueldoEquipo = 0;
            }

            MessageBox.Show("Jugador con mayor sueldo: "+jugadorMasCaro.nombre+" "+jugadorMasCaro.apellido+".\nSueldo: $"+jugadorMasCaro.sueldo+".");
            MessageBox.Show("Jugador más viejo: "+jugadorMasViejo.nombre+" "+jugadorMasViejo.apellido+".\nEdad: "+jugadorMasViejo.edad+".");
            MessageBox.Show("Equipo con más jugadores: "+equipoMasJugadores+".\nCantidad: "+masJugadores+".");
        }
    }
}
