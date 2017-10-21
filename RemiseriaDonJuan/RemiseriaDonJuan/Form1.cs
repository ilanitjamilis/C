using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemiseriaDonJuan
{
    public partial class Form1 : Form
    {
        int viajesJuan = 0;
        int viajesPedro = 0;
        int viajesJose = 0;
        decimal recaudacionJuan = 0;
        decimal recaudacionPedro = 0;
        decimal recaudacionJose = 0;
        decimal precioKilometroC = 1.4M;
        decimal precioKilometroP = 2.5M;

        public Form1()
        {
            InitializeComponent();
            lblChoferes.Text = "Choferes:\n\n                 1. Juan\n\n                 2. Pedro\n\n                 3. José";
        }

        private void btnCargarViaje_Click(object sender, EventArgs e)
        {
            decimal costoViaje = 0;
            //decimal kilometrosCliente = Convert.ToDecimal (txtKilometros);

            if ((cmbChoferes.Text == "1" || cmbChoferes.Text == "2" || cmbChoferes.Text == "3") && (txtDestino.Text == "C" || txtDestino.Text == "P") && nudKilometros.Value > 0)
            {
                if (txtDestino.Text == "C")
                {
                    costoViaje = 3 + nudKilometros.Value * precioKilometroC;

                    MessageBox.Show("Cliente, su monto a pagar es $" + costoViaje + ".", "Precio a pagar");

                    if (cmbChoferes.Text == "1")
                    {
                        recaudacionJuan += costoViaje;
                        viajesJuan += 1;
                    }
                    else
                    {
                        if (cmbChoferes.Text == "2")
                        {
                            recaudacionPedro += costoViaje;
                            viajesPedro += 1;
                        }
                        else
                        {
                            recaudacionJose += costoViaje;
                            viajesJose += 1;
                        }
                    }
                }

                if (txtDestino.Text=="P")
                {
                    costoViaje = 3 + nudKilometros.Value * precioKilometroP;

                    MessageBox.Show("Cliente, su monto a pagar es $" + costoViaje + ".", "Precio a pagar");

                    if (cmbChoferes.Text == "1")
                    {
                        recaudacionJuan += costoViaje;
                        viajesJuan += 1;
                    }
                    else
                    {
                        if (cmbChoferes.Text == "2")
                        {
                            recaudacionPedro += costoViaje;
                            viajesPedro += 1;
                        }
                        else
                        {
                            recaudacionJose += costoViaje;
                            viajesJose += 1;
                        }
                    }
                }

                costoViaje = 0;
                //txtKilometros.Text = "";
                nudKilometros.Value = 0;
                nudKilometros.Text = "";
                txtDestino.Text = "";
                cmbChoferes.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor asegúrese de que haya completado todos los datos correctamente.","Error");
            }
        }

        private void btnFinDelDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La recaudación del día de hoy de Juan fue $" + recaudacionJuan + "." + Environment.NewLine + "La recaudación del día de hoy de Pedro fue $" + recaudacionPedro + "." + Environment.NewLine + "La recaudación del día de hoy de José fue $" + recaudacionJose + ".","Recaudación por choferes");
            MessageBox.Show("La recaudación total del día de hoy fue $" + (recaudacionJuan + recaudacionPedro + recaudacionJose) + ".","Recaudación total");
            //MessageBox.Show("El día de hoy:" + Environment.NewLine + "Juan realizó " + viajesJuan + " viajes." + Environment.NewLine + "Pedro realizó " + viajesPedro + " viajes." + Environment.NewLine + "José realizó " + viajesJose + " viajes.","Viajes por chofer");

            if(viajesJuan > viajesPedro && viajesJuan > viajesJose)
            {
                MessageBox.Show("El chofer que más viajes realizó el día de hoy fue Juan." + Environment.NewLine + Environment.NewLine + "Ha realizado " + viajesJuan + " viajes, contra los " + viajesPedro + " de Pedro, y los " + viajesJose + " de José.", "Chofer del día");
            }

            if(viajesPedro>viajesJuan&&viajesPedro>viajesJose)
            {
                MessageBox.Show("El chofer que más viajes realizó el día de hoy fue Pedro." + Environment.NewLine + Environment.NewLine + "Ha realizado " + viajesPedro + " viajes, contra los " + viajesJuan + " de Juan, y los " + viajesJose + " de José.", "Chofer del día");
            }

            if(viajesJose > viajesJuan && viajesJose > viajesPedro)
            {
                MessageBox.Show("El chofer que más viajes realizó el día de hoy fue José." + Environment.NewLine + Environment.NewLine + "Ha realizado " + viajesJose + " viajes, contra los " + viajesJuan + " de Juan, y los " + viajesPedro + " de Pedro.", "Chofer del día");
            }

            viajesJuan = 0;
            viajesPedro = 0;
            viajesJose = 0;
            recaudacionJuan = 0;
            recaudacionPedro = 0;
            recaudacionJose = 0;
        }
    }
}
