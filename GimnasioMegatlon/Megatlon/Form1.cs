using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megatlon
{
    public partial class Form1 : Form
    {
        decimal recaudacionAerobics = 0;
        decimal recaudacionPilates = 0;
        decimal recaudacionPreparacionFisica = 0;
        decimal recaudacionYoga = 0;
        decimal recaudacionZumba = 0;
        int usuariosAerobics = 0;
        int usuariosPilates = 0;
        int usuariosPreparacionFisica = 0;
        int usuariosYoga = 0;
        int usuariosZumba = 0;
        int usuariosD = 0;
        int usuariosN = 0;
        int precio1 = 425;
        int precio2 = 300;
        int precio3 = 280;
        int precio4 = 415;
        int precio5 = 365;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal montoTotal = 0;
            decimal precioFinal = 0;

            if (txtNombre.Text != "" && (cmbActividades.Text == "1" || cmbActividades.Text == "2" || cmbActividades.Text == "3" || cmbActividades.Text == "4" || cmbActividades.Text == "5") && (cmbTurno.Text == "D" || cmbTurno.Text == "N"))
            {
                switch (cmbActividades.Text)
                {
                    case "1":
                        usuariosAerobics = usuariosAerobics + 1;
                        montoTotal = precio1;
                        if (cmbTurno.Text == "D")
                        {
                            precioFinal = montoTotal / 100 * 90;
                            MessageBox.Show("Su monto a pagar es $" + Math.Round(precioFinal,1) + " en vez de $" + montoTotal + " , debido a que se le hizo una bonificación del 10% por haber elegido turno diurno.", "Precio final con beneficio");
                            usuariosD = usuariosD + 1;
                            recaudacionAerobics = recaudacionAerobics + precioFinal;
                        }
                        else
                        {
                            precioFinal = montoTotal;
                            MessageBox.Show("Su monto a pagar es $" + montoTotal + ".", "Precio final");
                            usuariosN = usuariosN + 1;
                            recaudacionAerobics = recaudacionAerobics + precioFinal;
                        }
                        break;

                    case "2":
                        usuariosPilates = usuariosPilates + 1;
                        montoTotal = precio2;
                        if (cmbTurno.Text == "D")
                        {
                            precioFinal = montoTotal / 100 * 90;
                            MessageBox.Show("Su monto a pagar es $" + Math.Round(precioFinal,1) + " en vez de $" + montoTotal + " , debido a que se le hizo una bonificación del 10% por haber elegido turno diurno.", "Precio final con beneficio");
                            usuariosD = usuariosD + 1;
                            recaudacionPilates = recaudacionPilates + precioFinal;
                        }
                        else
                        {
                            precioFinal = montoTotal;
                            MessageBox.Show("Su monto a pagar es $" + montoTotal + ".", "Precio final");
                            usuariosN = usuariosN + 1;
                            recaudacionPilates = recaudacionPilates + precioFinal;
                        }
                        break;

                    case "3":
                        usuariosPreparacionFisica = usuariosPreparacionFisica + 1;
                        montoTotal = precio3;
                        if (cmbTurno.Text == "D")
                        {
                            precioFinal = montoTotal / 100 * 90;
                            MessageBox.Show("Su monto a pagar es $" + Math.Round(precioFinal) + " en vez de $" + montoTotal + " , debido a que se le hizo una bonificación del 10% por haber elegido turno diurno.", "Precio final con beneficio");
                            usuariosD = usuariosD + 1;
                            recaudacionPreparacionFisica = recaudacionPreparacionFisica + precioFinal;
                        }
                        else
                        {
                            precioFinal = montoTotal;
                            MessageBox.Show("Su monto a pagar es $" + montoTotal + ".", "Precio final");
                            usuariosN = usuariosN + 1;
                            recaudacionPreparacionFisica = recaudacionPreparacionFisica + precioFinal;
                        }
                        break;

                    case "4":
                        usuariosYoga = usuariosYoga + 1;
                        montoTotal = precio4;
                        if (cmbTurno.Text == "D")
                        {
                            precioFinal = montoTotal / 100 * 90;
                            MessageBox.Show("Su monto a pagar es $" + Math.Round(precioFinal,1) + " en vez de $" + montoTotal + " , debido a que se le hizo una bonificación del 10% por haber elegido turno diurno.", "Precio final con beneficio");
                            usuariosD = usuariosD + 1;
                            recaudacionYoga = recaudacionYoga + precioFinal;
                        }
                        else
                        {
                            precioFinal = montoTotal;
                            MessageBox.Show("Su monto a pagar es $" + montoTotal + ".", "Precio final");
                            usuariosN = usuariosN + 1;
                            recaudacionYoga = recaudacionYoga + precioFinal;
                        }
                        break;

                    case "5":
                        usuariosZumba = usuariosZumba + 1;
                        montoTotal = precio5;
                        if (cmbTurno.Text == "D")
                        {
                            precioFinal = montoTotal / 100 * 90;
                            MessageBox.Show("Su monto a pagar es $" + Math.Round(precioFinal,1) + " en vez de $" + montoTotal + " , debido a que se le hizo una bonificación del 10% por haber elegido turno diurno.", "Precio final con beneficio");
                            usuariosD = usuariosD + 1;
                            recaudacionZumba = recaudacionZumba + precioFinal;
                        }
                        else
                        {
                            precioFinal = montoTotal;
                            MessageBox.Show("Su monto a pagar es $" + montoTotal + ".", "Precio final");
                            usuariosN = usuariosN + 1;
                            recaudacionZumba = recaudacionZumba + precioFinal;
                        }
                        break;

                    default:
                        break;
                }
                txtNombre.Text = "";
                cmbActividades.Text = "";
                cmbTurno.Text = "";
                lblNumerosActividades.Text = "Actividades:";
                lblNumerosActividades.Hide();
            }
            else
            {
                MessageBox.Show("Por favor asegúrese de que haya completado todos los datos correctamente", "Error");
            }
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            lblNumerosActividades.Text = lblNumerosActividades.Text + Environment.NewLine + Environment.NewLine + "                    1 = Aerobics" + Environment.NewLine + "                    2 = Pilates" + Environment.NewLine + "                    3 = Preparación física" + Environment.NewLine + "                    4 = Yoga" + Environment.NewLine + "                    5 = Zumba";
            
            if (lblNumerosActividades.Visible == false)
            {
                lblNumerosActividades.Visible = true;
            }
            else
            {
                lblNumerosActividades.Visible = false;
                lblNumerosActividades.Text = "Actividades:";
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La recaudación final de Aerobics fue: $" + Math.Round(recaudacionAerobics,1) + "." + Environment.NewLine + "La recaudación final de Pilates fue: $" + Math.Round(recaudacionPilates,1) + "." + Environment.NewLine + "La recaudación final de Preparación Física fue: $" + Math.Round(recaudacionPreparacionFisica,1) + "." + Environment.NewLine + "La recaudación final de Yoga fue: $" + Math.Round(recaudacionYoga,1) + "." + Environment.NewLine + "La recaudación final de Zumba fue: $" + Math.Round(recaudacionZumba,1) + ".", "Recaudaciones finales");
            MessageBox.Show("Los usuarios que asistieron a Aerobics fueron " + usuariosAerobics + "." + Environment.NewLine + "Los usuarios que asistieron a Pilates fueron " + usuariosPilates + "." + Environment.NewLine + "Los usuarios que asistieron a Preparación Física fueron " + usuariosPreparacionFisica + "." + Environment.NewLine + "Los usuarios que asistieron a Yoga fueron " + usuariosYoga + "." + Environment.NewLine + "Los usuarios que asistieron a Zumba fueron " + usuariosZumba + ".", "Usuarios por actividad");
            
            if (usuariosD > usuariosN)
            {
                MessageBox.Show("Hubieron más usuarios en el turno diurno que en el nocturno.", "Usuarios D vs. usuarios N");
            }
            else
            {
                if (usuariosD < usuariosN)
                {
                    MessageBox.Show("Hubieron más usuarios en el turno nocturno que en el diurno.", "Usuarios D vs. usuarios N");
                }
                else
                {
                    MessageBox.Show("Hubo igual cantidad de usuarios en el turno diurno que en el nocturno.", "Usuarios D vs. usuarios N");
                }
            }
        }
    }
}
