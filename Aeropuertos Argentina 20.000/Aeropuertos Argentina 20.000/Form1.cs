using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aeropuertos_Argentina_20._000
{
    public partial class Form1 : Form
    {
        List<vuelo> ListVuelos = new List<vuelo>();
        vuelo ovuelo = new vuelo();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnCargarVuelo_Click(object sender, EventArgs e)
        {
            string error = "";
            bool verificadoVuelo = Funciones.ValidarNumeroVuelo(txtNumVuelo.Text);
            if (verificadoVuelo == false)
            {
                error += "Número de vuelo incorrecto.\n";
            }

            if (txtOrigen.Text == "")
            {
                error += "Origen incorrecto.\n";
            }

            if (txtDestino.Text == "")
            {
                error += "Destino incorrecto.\n";
            }

            if (dtpPartida.Value != DateTime.Today)
            {
                error += "Fecha de partida incorrecta. Debe ser la fecha de hoy.\n";
            }

            if (txtAerolinea.Text == "")
            {
                error += "Aerolinea incorrecta.\n";
            }

            bool verificarPuerta = Funciones.ValidarPuerta(Convert.ToInt32(nudPuerta.Value), ListVuelos);
            if(verificarPuerta==true)
            {
                error+="Puerta incorrecta.";
            }

            if (nudPasaje.Value <0)
            {
                error += "Precio de pasaje incorrecto.\n";
            }

            if (nudCantPasajeros.Value <0)
            {
                error += "Cantidad de pasajeros incorrecta.\n";
            }



            if (error == "")
            {
                ovuelo.num = txtNumVuelo.Text;
                ovuelo.origen = txtOrigen.Text;
                ovuelo.destino = txtDestino.Text;
                ovuelo.partida = dtpPartida.Value;
                ovuelo.aerolinea = txtAerolinea.Text;
                ovuelo.numPuerta = nudPuerta.Value;
                ovuelo.precioPasaje = nudPasaje.Value;
                ovuelo.cantPasajeros = nudCantPasajeros.Value;

                ListVuelos.Add(ovuelo);
                ovuelo = new vuelo();

                MessageBox.Show("Vuelo ingresado correctamemte.");
                txtNumVuelo.Text = "";
                txtOrigen.Text = "";
                txtDestino.Text = "";
                txtAerolinea.Text = "";
                nudPuerta.Value = 0;
                nudPasaje.Value = 0;
                nudCantPasajeros.Value = 0;
            }
            else
            {
                MessageBox.Show(error,"ERROR");
                error = "";
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            vuelo vueloMasPasajeros = new vuelo();
            foreach (vuelo ovuelo in ListVuelos)
            {
                if(ovuelo.cantPasajeros>vueloMasPasajeros.cantPasajeros)
                {
                    vueloMasPasajeros=ovuelo;
                }
            }

            vuelo vueloMasRecaudacion = new vuelo();
            decimal recaudacionMayor = 0;
            foreach (vuelo ovuelo in ListVuelos)
	        {
                decimal recaudacionVuelo = ovuelo.cantPasajeros*ovuelo.precioPasaje;
                if (recaudacionVuelo > recaudacionMayor)
                {
                    vueloMasRecaudacion = ovuelo;
                    recaudacionMayor = recaudacionVuelo;
                }
	        }


            MessageBox.Show("El número de vuelo del avión con más pasajeros es: " + vueloMasPasajeros.num + ". Tiene " + vueloMasPasajeros.cantPasajeros + ".\n\nEl número de vuelo del avión con mayor recaudación es: " + vueloMasRecaudacion.num + ". Su recaudación fue $" + recaudacionMayor + ".","Informacion final");
        }

    }
}
