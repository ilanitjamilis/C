using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransporteUrbano
{
    public partial class Form1 : Form
    {
        string error = "";
        bool pasajeroEncontrado = false;
        Pasajero oPasajero = new Pasajero();
        List<Pasajero> ListaPasajeros = new List<Pasajero>();
        Viaje oViaje = new Viaje();
        List<Colectivo> listaColectivos = new List<Colectivo>();
        Colectivo oColectivo = new Colectivo();
        bool colectivoEncontrado = false;
        int auxMaxPasajeros = 0;
        int auxMinPasajeros = 999999;
        Colectivo colectivoMinPasajeros = new Colectivo();
        Colectivo colectivoMaxPasajeros = new Colectivo();
        decimal auxMaxGananciaColectivo = 0;
        decimal auxMinGananciaColectivo = 999999;
        Colectivo colectivoMinGanancia = new Colectivo();
        Colectivo colectivoMaxGanancia = new Colectivo();
        decimal recaudacionTotal = 0;
        int auxMinViajesPasajero = 999999;
        int auxMaxViajesPasajero = 0;
        int auxViajes = 0;
        Pasajero pasajeroMinViajes = new Pasajero();
        Pasajero pasajeroMaxViajes = new Pasajero();
        int cantParaGrilla=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarViaje_Click(object sender, EventArgs e)
        {
            if (rbtViaje.Checked == false && rbtSaldo.Checked == false)
            {
                MessageBox.Show("Seleccione la operación a realizar.");
            }
            else
            {
                if (rbtViaje.Checked)
                {
                    if (txtNombre.Text.Trim() == "")
                    {
                        error += "Ingrese su nombre.\n";
                    }

                    if (txtApellido.Text.Trim() == "")
                    {
                        error += "Ingrese su apellido.\n";
                    }

                    if (nudColectivo.Value <= 0 || nudColectivo.Value > 999)
                    {
                        error += "Línea de colectivo inválida.\n";
                    }

                    if (nudMontoAbonado.Value < 3 || nudMontoAbonado.Value > 5)
                    {
                        error += "Monto a abonar incorrecto.\n";
                    }


                    if (error == "")
                    {
                        pasajeroEncontrado = false;

                        oViaje = new Viaje();
                        oViaje.lineaDeColectivo = Convert.ToInt32(nudColectivo.Value);
                        oViaje.montoAbonado = nudMontoAbonado.Value;

                        foreach (Pasajero pasajero in ListaPasajeros)
                        {
                            if (oPasajero.nombre == txtNombre.Text.Trim() && oPasajero.apellido == txtApellido.Text.Trim())
                            {
                                pasajeroEncontrado = true;
                                if (pasajero.saldo - nudMontoAbonado.Value >= -10)
                                {
                                    pasajero.saldo -= nudMontoAbonado.Value;
                                    pasajero.Viajes.Add(oViaje);
                                }
                                else
                                {
                                    error += "Saldo insuficiente.\n";
                                }
                            }
                        }

                        if (pasajeroEncontrado == false)
                        {
                            error += "Pasajero no encontrado. Si desea ingresar un pasajero nuevo, primero cárguele un saldo.\n";
                        }

                        colectivoEncontrado = false;
                        foreach (Colectivo oColectivo in listaColectivos)
                        {
                            if (oColectivo.lineaDeColectivo == Convert.ToInt32(nudColectivo.Value))
                            {
                                colectivoEncontrado = true;
                                oColectivo.cantPasajeros++;
                                oColectivo.recaudacion += nudMontoAbonado.Value;
                            }
                        }
                        if (colectivoEncontrado == false)
                        {
                            oColectivo = new Colectivo();
                            oColectivo.lineaDeColectivo = Convert.ToInt32(nudColectivo.Value);
                            oColectivo.cantPasajeros = 1;
                            oColectivo.recaudacion = nudMontoAbonado.Value;
                            listaColectivos.Add(oColectivo);
                        }

                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        nudSaldo.Text = "0,00";
                        nudColectivo.Text = "0";
                        nudMontoAbonado.Text = "0,00";

                        if (error == "")
                        {
                            MessageBox.Show("Viaje cargado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show(error,"Operación a realizar: CARGAR VIAJE");
                            error = "";
                        }
                        rbtViaje.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show(error, "Operación a realizar: CARGAR VIAJE");
                        error = "";
                    }
                }

                if (rbtSaldo.Checked)
                {
                    if (txtNombreSaldo.Text == "")
                    {
                        error += "Ingrese su nombre.\n";
                    }
                    if (txtApellidoSaldo.Text == "")
                    {
                        error += "Ingrese su apellido.\n";
                    }
                    if (nudSaldo.Value <= 0)
                    {
                        error += "Ingrese saldo válido.\n";
                    }

                    if (error == "")
                    {
                        pasajeroEncontrado = false;

                        foreach (Pasajero pasajero in ListaPasajeros)
                        {
                            if (oPasajero.nombre == txtNombreSaldo.Text.Trim() && oPasajero.apellido == txtApellidoSaldo.Text.Trim())
                            {
                                pasajeroEncontrado = true;
                                pasajero.saldo += nudSaldo.Value;
                            }
                        }

                        if (pasajeroEncontrado == false)
                        {
                            oPasajero = new Pasajero();
                            oPasajero.nombre = txtNombreSaldo.Text.Trim();
                            oPasajero.apellido = txtApellidoSaldo.Text.Trim();
                            oPasajero.saldo = nudSaldo.Value;
                            oPasajero.Viajes = new List<Viaje>();
                            ListaPasajeros.Add(oPasajero);
                        }

                        dgvGrilla.Rows.Add();
                        dgvGrilla[0, cantParaGrilla].Value = txtNombreSaldo.Text.Trim();
                        dgvGrilla[1, cantParaGrilla].Value = txtApellidoSaldo.Text.Trim();
                        dgvGrilla[2, cantParaGrilla].Value = nudSaldo.Value;
                        cantParaGrilla++;


                        txtNombreSaldo.Text = "";
                        txtApellidoSaldo.Text = "";
                        nudSaldo.Text = "0,00";
                        MessageBox.Show("Carga realizada correctamente.");
                        rbtSaldo.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show(error, "Operación a realizar: CARGAR SALDO");
                        error = "";
                    }

                }

            }
        }
                
        private void btnVerInformacion_Click(object sender, EventArgs e)
        {
            foreach (Colectivo auxColectivo in listaColectivos)
            {
                recaudacionTotal += auxColectivo.recaudacion;

                if (auxColectivo.cantPasajeros < auxMinPasajeros)
                {
                    colectivoMinPasajeros = auxColectivo;
                    auxMinPasajeros = auxColectivo.cantPasajeros;
                }
                
                if (auxColectivo.cantPasajeros > auxMaxPasajeros)
                {
                    colectivoMaxPasajeros = auxColectivo;
                    auxMaxPasajeros = auxColectivo.cantPasajeros;
                }

                if (auxColectivo.recaudacion < auxMinGananciaColectivo)
                {
                    colectivoMinGanancia = auxColectivo;
                    auxMinGananciaColectivo = auxColectivo.recaudacion;
                }
                
                if (auxColectivo.recaudacion > auxMaxGananciaColectivo)
                {
                    colectivoMaxGanancia = auxColectivo;
                    auxMaxGananciaColectivo = auxColectivo.recaudacion;
                }
                MessageBox.Show("La recaudación total de la línea de colectivo " + auxColectivo.lineaDeColectivo + " es $" + auxColectivo.recaudacion + ".");
            }

            foreach (Pasajero auxPasajero in ListaPasajeros)
            {
                auxViajes = 0;
                auxViajes = oPasajero.Viajes.Count;
                if (auxViajes < auxMinViajesPasajero)
                {
                    pasajeroMinViajes = oPasajero;
                    auxMinViajesPasajero = auxViajes;
                }
                
                if (auxViajes > auxMaxViajesPasajero)
                {
                    pasajeroMaxViajes = oPasajero;
                    auxMaxViajesPasajero = auxViajes;
                }
            }

            MessageBox.Show("Colectivo con más pasajeros: " + colectivoMaxPasajeros.lineaDeColectivo + ".\nCantidad de pasajeros: " + colectivoMaxPasajeros.cantPasajeros + ".");
            MessageBox.Show("Colectivo con menos pasajeros: " + colectivoMinPasajeros.lineaDeColectivo + ".\nCantidad de pasajeros: " + colectivoMinPasajeros.cantPasajeros + ".");
            MessageBox.Show("Colectivo con más ganancia: " + colectivoMaxGanancia.lineaDeColectivo + ".\nRecaudación: $" + colectivoMaxGanancia.recaudacion + ".");
            MessageBox.Show("Colectivo con menos ganancia: " + colectivoMinGanancia.lineaDeColectivo + ".\nRecaudación: $" + colectivoMinGanancia.recaudacion + ".");
            MessageBox.Show("Recaudación total de la SUBE: $" + recaudacionTotal + ".");
        }

    }
}