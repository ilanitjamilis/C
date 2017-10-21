using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Garbarino
{
    public partial class Form1 : Form
    {
        decimal cantidadNotebookCliente = 0;
        decimal cantidadTelefonoCliente = 0;
        decimal cantidadMicroondaCliente = 0;
        decimal cantidadTelevisorCliente = 0;
        decimal precioNotebook = 5000;
        decimal precioTelefono = 4800;
        decimal precioMicroondas = 900;
        decimal precioTelevisor = 8800;
        decimal precioCompraTotal = 0;
        decimal precioCompraTotalFinal = 0;
        decimal recaudacionTotal = 0;
        decimal cantidadTotalNotebooks = 0;
        decimal cantidadTotalTelefonos = 0;
        decimal cantidadTotalMicroondas = 0;
        decimal cantidadTotalTelevisores = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nudCantidadProducto.Value >= 1)
            {
                switch (cmbProductos.Text)
                {
                    case ("Notebook Toshiba"):
                        cantidadNotebookCliente = nudCantidadProducto.Value;
                        precioCompraTotal = precioCompraTotal + (cantidadNotebookCliente * precioNotebook);
                        cantidadTotalNotebooks += cantidadNotebookCliente;
                        lblCarrito.Text += Environment.NewLine + Environment.NewLine + "     " + cantidadNotebookCliente + " Notebook/s Toshiba = $" + (cantidadNotebookCliente * precioNotebook);
                        cmbProductos.Text = "";
                        nudCantidadProducto.Value = 0;
                        break;

                    case ("Telefono Samsung S3 Mini"):
                        cantidadTelefonoCliente = nudCantidadProducto.Value;
                        precioCompraTotal = precioCompraTotal + (cantidadTelefonoCliente * precioTelefono);
                        cantidadTotalTelefonos = cantidadTotalTelefonos + cantidadTelefonoCliente;
                        lblCarrito.Text = lblCarrito.Text + Environment.NewLine + Environment.NewLine + "     " + cantidadTelefonoCliente + " Telefono/s Samsung S3 Mini = $" + (cantidadTelefonoCliente * precioTelefono);
                        cmbProductos.Text = "";
                        nudCantidadProducto.Value = 0;
                        break;

                    case ("Microondas Dream"):
                        cantidadMicroondaCliente = nudCantidadProducto.Value;
                        precioCompraTotal = precioCompraTotal + (cantidadMicroondaCliente * precioMicroondas);
                        cantidadTotalMicroondas = cantidadTotalMicroondas + cantidadMicroondaCliente;
                        lblCarrito.Text = lblCarrito.Text + Environment.NewLine + Environment.NewLine + "     " + cantidadMicroondaCliente + " Microondas Dream = $" + (cantidadMicroondaCliente * precioMicroondas);
                        cmbProductos.Text = "";
                        nudCantidadProducto.Value = 0;
                        break;


                    case ("Televisor Samsung LED 32´"):
                        cantidadTelevisorCliente = nudCantidadProducto.Value;
                        precioCompraTotal = precioCompraTotal + (cantidadTelevisorCliente * precioTelevisor);
                        cantidadTotalTelevisores = cantidadTotalTelevisores + cantidadTelevisorCliente;
                        lblCarrito.Text = lblCarrito.Text + Environment.NewLine + Environment.NewLine + "     " + cantidadTelevisorCliente + " Televisor/es Samsung LED 32´ = $" + (cantidadTelevisorCliente * precioTelevisor);
                        cmbProductos.Text = "";
                        nudCantidadProducto.Value = 0;
                        break;

                    default:
                        MessageBox.Show("Por favor ingrese datos válidos.", "Error");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese datos válidos.", "Error");
            }

            lblTotal.Text = "La suma total es $" + (cantidadNotebookCliente * precioNotebook + cantidadTelefonoCliente * precioTelefono + cantidadMicroondaCliente * precioMicroondas + cantidadTelevisorCliente * precioTelevisor);

        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (lblCarrito.Text == "Productos en el carrito:" || (rbtEfectivo.Checked == false && rbtTarjetaGarbarino.Checked == false && rbtTarjetaSantander.Checked == false))
            {
                MessageBox.Show("Asegurese de que tenga productos en su carrito de compra y que haya seleccionado su método de pago.", "Error");
            }
            else
            {
                if (rbtEfectivo.Checked || rbtTarjetaGarbarino.Checked)
                {
                    if (precioCompraTotal > 10000)
                    {
                        precioCompraTotalFinal = precioCompraTotal / 100 * 90;
                        recaudacionTotal = recaudacionTotal + precioCompraTotalFinal;
                        MessageBox.Show("Debido a que su compra superó los $10.000 se le hizo una bonificación del 10% sobre el total." + Environment.NewLine + Environment.NewLine + "En vez de tener que abonar $" + precioCompraTotal + ", ahora su monto a abonar es $" + precioCompraTotalFinal + "." + Environment.NewLine + Environment.NewLine + "                                      Gracias por elegirnos nuevamente, tus amigos de Garbarino.", "Precio final con beneficio");
                    }
                    else
                    {
                        recaudacionTotal = recaudacionTotal + precioCompraTotal;
                        MessageBox.Show("Por el total de su compra usted debe abonar $" + precioCompraTotal + "." + Environment.NewLine + Environment.NewLine + "                                      Gracias por elegirnos nuevamente, tus amigos de Garbarino.", "Precio final");
                    }
                }
                else
                {
                    precioCompraTotalFinal = precioCompraTotal / 100 * 85;
                    recaudacionTotal = recaudacionTotal + precioCompraTotalFinal;
                    MessageBox.Show("Debido a que usted es usuario de la tarjeta Santander Río se le hizo una bonificación del 15% sobre el total de su compra." + Environment.NewLine + Environment.NewLine + "En vez de tener que abonar $" + precioCompraTotal + ", ahora su monto a abonar es $" + precioCompraTotalFinal + "." + Environment.NewLine + Environment.NewLine + "                                      Gracias por elegirnos nuevamente, tus amigos de Garbarino.", "Precio final con beneficio");
                }

                cantidadNotebookCliente = 0;
                cantidadTelefonoCliente = 0;
                cantidadMicroondaCliente = 0;
                cantidadTelevisorCliente = 0;
                precioCompraTotal = 0;
                precioCompraTotalFinal = 0;
                lblCarrito.Text = "Productos en el carrito: ";
                lblTotal.Text = "";
                lblCarrito.Hide();
                lblTotal.Hide();

                if (rbtEfectivo.Checked == true)
                {
                    rbtEfectivo.Checked = false;
                }
                else
                {
                    if (rbtTarjetaGarbarino.Checked == true)
                    {
                        rbtTarjetaGarbarino.Checked = false;
                    }
                    else
                    {
                        if (rbtTarjetaSantander.Checked == true)
                        {
                            rbtTarjetaSantander.Checked = false;
                        }
                    }
                }
                
            }
        }

        private void btnInformacionGarbarino_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La recaudación del día de hoy fue $"+ recaudacionTotal +".", "Recaudación final");

            if (cantidadTotalNotebooks > cantidadTotalTelefonos && cantidadTotalNotebooks > cantidadTotalMicroondas && cantidadTotalNotebooks > cantidadTotalTelevisores)
            {
                MessageBox.Show("El producto más vendido el día de hoy fueron las notebooks Toshiba." + Environment.NewLine + Environment.NewLine + "Se han vendido " + cantidadTotalNotebooks + ".", "Producto más vendido");
            }
            else
            {
                if (cantidadTotalTelefonos > cantidadTotalNotebooks && cantidadTotalTelefonos > cantidadTotalMicroondas && cantidadTotalTelefonos > cantidadTotalTelevisores)
                {
                    MessageBox.Show("El producto más vendido el día de hoy fueron los teléfonos Samsung S3 Mini." + Environment.NewLine + Environment.NewLine + "Se han vendido " + cantidadTotalTelefonos + ".", "Producto más vendido");
                }
                else
                {
                    if (cantidadTotalMicroondas > cantidadTotalNotebooks && cantidadTotalMicroondas > cantidadTotalTelefonos && cantidadTotalMicroondas > cantidadTotalTelevisores)
                    {
                        MessageBox.Show("El producto más vendido el día de hoy fueron los microondas Dream." + Environment.NewLine + Environment.NewLine + "Se han vendido " + cantidadTotalMicroondas + ".", "Producto más vendido");
                    }
                    else
                    {
                        if (cantidadTotalTelevisores > cantidadTotalNotebooks && cantidadTotalTelevisores > cantidadTotalTelefonos && cantidadTotalTelevisores > cantidadTotalMicroondas)
                        {
                            MessageBox.Show("El producto más vendido el día de hoy fueron los televisores Samsung LED 32´." + Environment.NewLine + Environment.NewLine + "Se han vendido " + cantidadTotalTelevisores + ".", "Producto más vendido");
                        }
                    }
                }
            }

            cantidadTotalNotebooks = 0;
            cantidadTotalTelefonos = 0;
            cantidadTotalMicroondas = 0;
            cantidadTotalTelevisores = 0;

        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (lblCarrito.Visible == true)
            {
                lblCarrito.Hide();
                lblTotal.Hide();
            }
            else
            {
                lblCarrito.Show();
                lblTotal.Show();
            }
        }
    }
}