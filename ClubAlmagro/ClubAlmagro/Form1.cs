using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClubAlmagro
{
    public partial class Form1 : Form
    {
        int recaudacion = 0;
        int jugadoresBackgammon = 0;
        int jugadoresHockey = 0;
        int jugadoresFutbol = 0;
        int jugadoresPelotaPaleta = 0;
        int jugadoresBurako = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int anos = DateTime.Today.Year - dtpNacimiento.Value.Year;
            int cuota = 0;
            int cuotaDeporte = 0;

            if (anos >= 0 && anos <= 120 && nudAntiguedad.Value >= 0 && DateTime.Today.Year - dtpNacimiento.Value.Year >= nudAntiguedad.Value && cmbDeportes.Text == "Backgammon" || cmbDeportes.Text == "Hockey" || cmbDeportes.Text == "Futbol" || cmbDeportes.Text == "Pelota-paleta" || cmbDeportes.Text == "Burako")
            {
                if (anos >= 0 && anos < 12)
                {
                    MessageBox.Show("Con respecto a la cuota, no se agrega dinero a la recaudación debido a que el socio es menor.", "Valor cuota mensual");
                    cuota = 0;
                }

                if (anos >= 12 && anos < 21)
                {
                    if (nudAntiguedad.Value >= 10 && nudAntiguedad.Value < 20)
                    {
                        MessageBox.Show("Con respecto a la cuota del socio, se agregan $100 a la recaudación debido a su antigüedad en el club.", "Valor cuota mensual");
                        recaudacion = recaudacion + 100;
                        cuota = 100;
                    }

                    if (nudAntiguedad.Value > 20)
                    {
                        MessageBox.Show("Con respecto a la cuota, no se agrega dinero a la recaudación debido a que el socio es vitalicio.", "Valor cuota mensual");
                        cuota = 0;
                    }

                    if (nudAntiguedad.Value < 10)
                    {
                        MessageBox.Show("Con respecto a la cuota, se agregan $200 a la recaudación.", "Valor cuota mensual");
                        recaudacion = recaudacion + 200;
                        cuota = 200;
                    }
                }


                if (anos >= 21 && anos < 45)
                {
                    if (nudAntiguedad.Value >= 10 && nudAntiguedad.Value < 20)
                    {
                        MessageBox.Show("Con respecto a la cuota del socio, se agregan $50 a la recaudación debido a su antigüedad en el club.", "Valor cuota mensual");
                        recaudacion = recaudacion + 50;
                        cuota = 50;
                    }
                    if (nudAntiguedad.Value > 20)
                    {
                        MessageBox.Show("Con respecto a la cuota, no se agrega dinero a la recaudación debido a que el socio es vitalicio.", "Valor cuota mensual");
                        cuota = 0;
                    }

                    if (nudAntiguedad.Value < 10)
                    {
                        MessageBox.Show("Con respecto a la cuota, agregan $100 a la recaudación.", "Valor cuota mensual");
                        recaudacion = recaudacion + 100;
                        cuota = 100;
                    }
                }

                if (anos >= 45 && anos <= 120)
                {
                    if (nudAntiguedad.Value >= 10 && nudAntiguedad.Value < 20)
                    {
                        MessageBox.Show("Con respecto a la cuota del socio, se agregan $40 a la recaudación debido a su antigüedad en el club.", "Valor cuota mensual");
                        recaudacion = recaudacion + 40;
                        cuota = 40;
                    }
                    if (nudAntiguedad.Value > 20)
                    {
                        MessageBox.Show("Con respecto a la cuota, no se agrega dinero a la recaudación debido a que el socio es vitalicio.", "Valor cuota mensual");
                        cuota = 0;
                    }

                    if (nudAntiguedad.Value < 10)
                    {
                        MessageBox.Show("Con respecto a la cuota, se agregan $80 a la recaudación.", "Valor cuota mensual");
                        recaudacion = recaudacion + 80;
                        cuota = 80;
                    }
                }

                switch (cmbDeportes.Text)
                {
                    case "Backgammon":
                        recaudacion = recaudacion + 50;
                        jugadoresBackgammon = jugadoresBackgammon + 1;
                        MessageBox.Show("Con respecto al deporte que el socio practica, se agregan $50 a la recaudación.", "Valor del deporte elegido");
                        cuotaDeporte = 50;
                        break;
                    case "Futbol":
                        recaudacion = recaudacion + 25;
                        jugadoresFutbol = jugadoresFutbol + 1;
                        MessageBox.Show("Con respecto al deporte que el socio practica, se agregan $25 a la recaudación.", "Valor del deporte elegido");
                        cuotaDeporte = 25;
                        break;
                    case "Hockey":
                        recaudacion = recaudacion + 30;
                        jugadoresHockey = jugadoresHockey + 1;
                        MessageBox.Show("Con respecto al deporte que el socio practica, se agregan $30 a la recaudación.", "Valor del deporte elegido");
                        cuotaDeporte = 30;
                        break;
                    case "Pelota-paleta":
                        recaudacion = recaudacion + 60;
                        jugadoresPelotaPaleta = jugadoresPelotaPaleta + 1;
                        MessageBox.Show("Con respecto al deporte que el socio practica, se agregan $60 a la recaudación.", "Valor del deporte elegido");
                        cuotaDeporte = 60;
                        break;
                    case "Burako":
                        recaudacion = recaudacion + 30;
                        jugadoresBurako = jugadoresBurako + 1;
                        MessageBox.Show("Con respecto al deporte que el socio practica, se agregan $30 a la recaudación.", "Valor del deporte elegido");
                        cuotaDeporte = 30;
                        break;
                    default:
                        MessageBox.Show("Error, ingrese datos válidos.");
                        break;
                }

                MessageBox.Show("Informele al socio que debe pagar $" + (cuota + cuotaDeporte) + ".", "Informe para el socio");

                MessageBox.Show("La recaudación a esperar del club es $" + recaudacion + ".", "Futura recaudación");

                if (jugadoresBackgammon > jugadoresBurako && jugadoresBackgammon > jugadoresFutbol && jugadoresBackgammon > jugadoresHockey && jugadoresBackgammon > jugadoresPelotaPaleta)
                {
                    MessageBox.Show("El deporte con más socios es backgammon.", "Deporte más elegido");
                }
                if (jugadoresBurako > jugadoresBackgammon && jugadoresBurako > jugadoresFutbol && jugadoresBurako > jugadoresHockey && jugadoresBurako > jugadoresPelotaPaleta)
                {
                    MessageBox.Show("El deporte con más socios es burako.", "Deporte más elegido");
                }
                if (jugadoresFutbol > jugadoresBackgammon && jugadoresFutbol > jugadoresBurako && jugadoresFutbol > jugadoresHockey && jugadoresFutbol > jugadoresPelotaPaleta)
                {
                    MessageBox.Show("El deporte con más socios es fútbol.", "Deporte más elegido");
                }
                if (jugadoresHockey > jugadoresBackgammon && jugadoresHockey > jugadoresFutbol && jugadoresHockey > jugadoresBurako && jugadoresHockey > jugadoresPelotaPaleta)
                {
                    MessageBox.Show("El deporte con más socios es hockey.", "Deporte más elegido");
                }
                if (jugadoresPelotaPaleta > jugadoresBackgammon && jugadoresPelotaPaleta > jugadoresBurako && jugadoresPelotaPaleta > jugadoresFutbol && jugadoresPelotaPaleta > jugadoresHockey)
                {
                    MessageBox.Show("El deporte con más socios es pelota-paleta.", "Deporte más elegido");
                }
            }
            else
            {
                MessageBox.Show("Error, por favor ingrese datos válidos.", "Error!");
            }
        }
    }
}