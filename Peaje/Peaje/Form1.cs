using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Peaje
{
    public partial class Form1 : Form
    {
        decimal recaudacion = 0;
        int cantidad = 0;
        int cantidadAuto = 0;
        int cantidadMoto = 0;
        int cantidadCamioneta = 0;
        int cantidadCamión = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cantidad == 100)
            {
                cantidad = 0;

                MessageBox.Show("Usted pasa gratis.");

                if (cmbVehiculos.Text == "Auto")
                {
                    cantidadAuto = cantidadAuto + 1;
                }

                if (cmbVehiculos.Text == "Moto")
                {
                    cantidadMoto = cantidadMoto + 1;
                }

                if (cmbVehiculos.Text == "Camioneta")
                {
                    cantidadCamioneta = cantidadCamioneta + 1;
                }

                if (cmbVehiculos.Text == "Camión")
                {
                    cantidadCamión = cantidadCamión + 1;
                }
            }
            else
            {

                if (cmbVehiculos.Text == "Auto")
                {
                    MessageBox.Show("Usted debe pagar $10.");
                    recaudacion = recaudacion + 10;
                    cantidadAuto = cantidadAuto + 1;
                }


                if (cmbVehiculos.Text == "Moto")
                {
                    MessageBox.Show("Usted debe pagar $4.");
                    recaudacion = recaudacion + 4;
                    cantidadMoto = cantidadMoto + 1;
                }
                if (cmbVehiculos.Text == "Camioneta")
                {
                    MessageBox.Show("Usted debe pagar $18.50");
                    recaudacion = recaudacion + 18.50M;
                    cantidadCamioneta = cantidadCamioneta + 1;
                }
                if (cmbVehiculos.Text == "Camión")
                {
                    MessageBox.Show("Usted debe pagar $32.40");
                    recaudacion = recaudacion + 32.40M;
                    cantidadCamión = cantidadCamión + 1;
                }
            }
            cantidad = cantidad + 1;
        }

           

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoy pasaron " + (cantidadAuto+cantidadMoto+cantidadCamión+cantidadCamioneta)+ " vehículos.");

            MessageBox.Show("La recaudación del día de hoy fue $" + recaudacion+".");

            if (cantidadAuto > cantidadCamión && cantidadAuto > cantidadMoto && cantidadAuto > cantidadCamioneta)
            {
                MessageBox.Show("El vehículo más transitado el día de hoy fueron los autos.");
            }
            if (cantidadMoto > cantidadAuto && cantidadMoto > cantidadCamión && cantidadMoto > cantidadCamioneta)
            {
                MessageBox.Show("El vehículo más transitado el día de hoy fueron las motos.");
            }
            if (cantidadCamión > cantidadAuto && cantidadCamión > cantidadMoto && cantidadCamión > cantidadCamioneta)
            {
                MessageBox.Show("El vehículo más transitado el día de hoy fueron los camiones.");
            }
            if (cantidadCamioneta > cantidadAuto && cantidadCamioneta > cantidadCamión && cantidadCamioneta > cantidadMoto)
            {
                MessageBox.Show("El vehículo más transitado el día de hoy fueron las camionetas.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
