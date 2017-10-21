using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TiendaDeCafe
{
    public partial class frmTiendaDeCafe : Form
    {
        string error = "";
        decimal gasesosaCliente=0;
        decimal cafeCliente=0;
        decimal teCliente=0;
        decimal sandwichCliente=0;
        decimal tortasCliente=0;
        decimal medialunaCliente=0;
        decimal compraCliente=0;
        decimal ingresosEfectivoDia = 0;
        decimal ingresosEfectivoMes = 0;
        decimal ingresosCreditoDia = 0;
        decimal ingresosCreditoMes = 0;
        decimal ingresosDebitoDia = 0;
        decimal ingresosDebitoMes = 0;
        decimal costosBYADia = 0;
        decimal costosBYAMes = 0;
        decimal costosEmpleadosDia = 0;
        decimal costosEmpleadosMes = 0;

        public frmTiendaDeCafe()
        {
            InitializeComponent();
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            int ventas = 0;

            if (cmbBebida.Text == "" && cmbComida.Text == "")
            {
                error += "Asegúrese de que haya elegido que comprar.\n";
            }
            if ((cmbBebida.Text == "Gaseosa $20" || cmbBebida.Text == "Cafe $15" || cmbBebida.Text == "Te $10") && nudBebida.Value <= 0)
            {
                error += "Asegúrese de que haya elegido la cantidad de su bebida.\n";
            }
            if ((cmbComida.Text == "Sandwich $40" || cmbComida.Text == "Tortas $30" || cmbComida.Text == "Medialunas $8") && nudComida.Value <= 0)
            {
                error += "Asegúrese de que haya elegido la cantidad de su comida.\n";
            }
            if (rbtEfectivo.Checked == false && rbtTarjetaCredito.Checked == false && rbtTarjetaDebito.Checked == false)
            {
                error += "Asegúrese de que haya seleccionado su medio de pago.\n";
            }
            if (error == "")
            {
                switch (cmbBebida.Text)
                {
                    case "Gaseosa $20":
                        gasesosaCliente += nudBebida.Value;
                        compraCliente += nudBebida.Value * 20;
                        costosBYADia = costosBYADia + (nudBebida.Value * (20 - 7));
                        costosBYAMes = costosBYAMes + (nudBebida.Value * (20 - 7));
                        break;
                    case "Cafe $15":
                        cafeCliente += nudBebida.Value;
                        compraCliente += nudBebida.Value * 15;
                        costosBYADia = costosBYADia + (nudBebida.Value * (15 - 4));
                        costosBYAMes = costosBYAMes + (nudBebida.Value * (15 - 4));
                        break;
                    case "Te $10":
                        teCliente += nudBebida.Value;
                        compraCliente += nudBebida.Value * 10;
                        costosBYADia = costosBYADia + (nudBebida.Value * (10 - 2));
                        costosBYAMes = costosBYAMes + (nudBebida.Value * (10 - 2));
                        break;
                    default:
                        break;
                }
                switch (cmbComida.Text)
                {
                    case "Sandwich $40":
                        sandwichCliente += nudComida.Value;
                        compraCliente += nudComida.Value * 40;
                        costosBYADia = costosBYADia + (nudComida.Value * (40 - 10));
                        costosBYAMes = costosBYAMes + (nudComida.Value * (40 - 10));
                        break;
                    case "Tortas $30":
                        tortasCliente += nudComida.Value;
                        compraCliente += nudComida.Value * 30;
                        costosBYADia = costosBYADia + (nudComida.Value * (30 - 15));
                        costosBYAMes = costosBYAMes + (nudComida.Value * (30 - 15));
                        break;
                    case "Medialunas $8":
                        medialunaCliente += nudComida.Value;
                        compraCliente += nudComida.Value * 8;
                        costosBYADia = costosBYADia + (nudComida.Value * (8 - 2));
                        costosBYAMes = costosBYAMes + (nudComida.Value * (8 - 2));
                        break;
                    default:
                        break;
                }

                if (ventas == 10)
                {
                    costosEmpleadosDia = costosEmpleadosDia + 200;
                    costosEmpleadosMes = costosEmpleadosMes + 200;
                    ventas = 0;
                }
                else
                {
                    ventas = ventas + 1;
                }


                if (cafeCliente >= 2)
                {
                    compraCliente = compraCliente / 100 * 90;
                }

                if (medialunaCliente >= 6)
                {
                    compraCliente = compraCliente - (medialunaCliente * 2);
                }

                if (gasesosaCliente == 1 && sandwichCliente == 1)
                {
                    compraCliente = 50;
                }

                if (rbtEfectivo.Checked)
                {
                    compraCliente = compraCliente / 100 * 90;
                    ingresosEfectivoDia = ingresosEfectivoDia + compraCliente;
                    ingresosEfectivoMes += compraCliente;
                }

                if (rbtTarjetaDebito.Checked)
                {
                    compraCliente = compraCliente / 100 * 95;
                    ingresosDebitoDia = ingresosDebitoDia + compraCliente;
                    ingresosDebitoMes += compraCliente;
                }

                if (rbtTarjetaCredito.Checked)
                {
                    ingresosCreditoDia = ingresosCreditoDia + compraCliente;
                    ingresosCreditoMes += compraCliente;
                }

                MessageBox.Show("Cliente, su monto a pagar es $" + Math.Round(compraCliente,2) + ".", "Monto a pagar");

                compraCliente = 0;
                gasesosaCliente = 0;
                cafeCliente = 0;
                teCliente = 0;
                sandwichCliente = 0;
                tortasCliente = 0;
                medialunaCliente = 0;
                cmbBebida.Text = "";
                cmbComida.Text = "";
                nudBebida.Value = 0;
                nudBebida.Text = "";
                nudComida.Value = 0;
                nudComida.Text = "";
                if (rbtEfectivo.Checked)
                {
                    rbtEfectivo.Checked = false;
                }
                if (rbtTarjetaCredito.Checked)
                {
                    rbtTarjetaCredito.Checked = false;
                }
                if (rbtTarjetaDebito.Checked)
                {
                    rbtTarjetaDebito.Checked = false;
                }
            }

            else
            {
                MessageBox.Show(error, "Error");
                error = "";
            }



        }

        private void btnIngresosDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los ingresos totales del día de hoy fueron $" + (ingresosEfectivoDia + ingresosDebitoDia + ingresosCreditoDia) + "." + Environment.NewLine + "De los cuales:" + Environment.NewLine + ingresosEfectivoDia + "$ se pagó en efectivo;" + Environment.NewLine + ingresosDebitoDia + "$ se pagó con tarjeta de débito, y;" + Environment.NewLine + ingresosCreditoDia + "$ se pagó con tarjeta de crédito.", "Ingresos del día");
        }

        private void btnGananciasDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las ganacias del día de hoy fueron $" + (ingresosEfectivoDia + ingresosDebitoDia + ingresosCreditoDia - costosBYADia - costosEmpleadosDia) + ".", "Ganancias del día");
            
            ingresosEfectivoDia = 0;
            ingresosDebitoDia = 0;
            ingresosCreditoDia = 0;
            costosBYADia = 0;
            costosEmpleadosDia = 0;
        }

        private void btnGananciasMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las ganancias del mes fueron $" + (ingresosEfectivoMes + ingresosDebitoMes + ingresosCreditoMes - costosBYAMes - costosEmpleadosMes - 1000) + ".", "Ganancias del mes");
            
            if ((costosBYAMes + costosEmpleadosMes + 1000) < (ingresosEfectivoMes + ingresosDebitoMes + ingresosCreditoMes))
            {
                MessageBox.Show("Este mes se ganó plata. La suma ganada fue $" + (ingresosEfectivoMes + ingresosDebitoMes + ingresosCreditoMes - costosBYAMes - costosEmpleadosMes - 1000) + ".");
            }
            if ((costosBYAMes + costosEmpleadosMes + 1000) > (ingresosEfectivoMes + ingresosDebitoMes + ingresosCreditoMes))
            {
                MessageBox.Show("Este mes se perdió plata. La suma perdida fue $" + (costosBYAMes + costosEmpleadosMes + 1000 - ingresosEfectivoMes - ingresosDebitoMes - ingresosCreditoMes));
            }

            ingresosEfectivoMes = 0;
            ingresosDebitoMes = 0;
            ingresosCreditoMes = 0;
            costosBYAMes = 0;
            costosEmpleadosMes = 0;
        }
    }
}
