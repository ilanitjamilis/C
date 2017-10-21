/*
    El estado nacional requiere realizar un sistema que permita conocer los datos de las provincias y las ciudades de nuestro pais. 

    Para eso te convoca para que desarolles un sistema que debe contener dos clases. 

    Provincias: 
    1) Con un nombre. 
    2) Lista de ciudades. 

    Ciudades: 
    1) Nombre. 
    2) Cantidad de habitantes. 
    3) Metros cuadrados. 

    Lo que el estado necesita saber es: 
    1) Poblacion total del pais. 
    2) Ciudad con mas habitantes. 
    3) Provincia con mas habitantes. 
    4) Provincia con menos metros cuadrados. 
    5) Provincia con mas habitantes por metro cuadrado. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaPruebaTercerTrimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Provincia oProvincia = new Provincia();
        Ciudad oCiudad = new Ciudad();
        string error = "";
        List<Provincia> listaProvincias = new List<Provincia>();
        bool provinciaEncontrada = false;
        long poblacionTotal = 0;
        Ciudad ciudadConMasHabitantes = new Ciudad();
        long cantHabitantesCiudadMas = 0;
        Provincia provinciaConMasHabitantes = new Provincia();
        long cantHabitantesProvinciaMas = 0;
        long auxCantHabitantesProvincia = 0;
        Provincia provinciaMenosMetros = new Provincia();
        decimal metrosProvinciaMenosMetros = 999999999;
        decimal auxProvinciaMetros = 0;
        Provincia provinciaMasHabitantesPorMetroCuadrado = new Provincia();
        decimal habitantesPorMetroCuadradoProvinciaMas = 0;
        decimal auxHabitantesPorMetroCuadradoProvincia = 0;

        private void btnCargar_Click(object sender, EventArgs e)
        {
            error = "";
            if(txtProvincia.Text=="")
            {
                error += "Ingrese el nombre de la provincia.\n";
            }
            if(txtCiudad.Text=="")
            {
                error += "Ingrese el nombre de la ciudad.\n";
            }
            if(nudHabitantes.Value<1)
            {
                error += "Ingrese cantidad de habitantes válida.\n";
            }
            if(nudMetros.Value<1)
            {
                error += "Ingrese cantidad de metros cuadrados válida.\n";
            }

            if(error=="")
            {
                provinciaEncontrada = false;

                oCiudad = new Ciudad();
                oCiudad.nombre = txtCiudad.Text.Trim();
                oCiudad.cantHabitantes = Convert.ToInt32(nudHabitantes.Value);
                oCiudad.metrosCuadrados = Convert.ToInt32(nudMetros.Value);

                foreach(Provincia provincia in listaProvincias)
                {
                    if(provincia.nombre==txtProvincia.Text.Trim())
                    {
                        provinciaEncontrada = true;
                        oProvincia.listaCiudades.Add(oCiudad);
                    }
                }
                if (provinciaEncontrada == false)
                {
                    oProvincia = new Provincia();
                    oProvincia.nombre = txtProvincia.Text.Trim();
                    oProvincia.listaCiudades = new List<Ciudad>();
                    oProvincia.listaCiudades.Add(oCiudad);
                    listaProvincias.Add(oProvincia);
                }

                MessageBox.Show("Datos cargados correctamente.");
                txtProvincia.Text = "";
                txtCiudad.Text = "";
                nudHabitantes.Text = "0";
                nudMetros.Text = "0";
            }
            else
            {
                MessageBox.Show(error,"ERROR");
            }
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            foreach(Provincia oProvincia in listaProvincias)
            {
                auxCantHabitantesProvincia = 0;
                auxProvinciaMetros = 0;
                auxHabitantesPorMetroCuadradoProvincia = 0;
                foreach(Ciudad oCiudad in oProvincia.listaCiudades)
                {
                    poblacionTotal += oCiudad.cantHabitantes;
                    if(oCiudad.cantHabitantes>cantHabitantesCiudadMas)
                    {
                        ciudadConMasHabitantes = oCiudad;
                        cantHabitantesCiudadMas = oCiudad.cantHabitantes;
                    }
                    auxCantHabitantesProvincia += oCiudad.cantHabitantes;
                    auxProvinciaMetros += oCiudad.metrosCuadrados;
                    auxHabitantesPorMetroCuadradoProvincia += (oCiudad.cantHabitantes/oCiudad.metrosCuadrados);
                }
                if(auxCantHabitantesProvincia>cantHabitantesProvinciaMas)
                {
                    provinciaConMasHabitantes = oProvincia;
                    cantHabitantesProvinciaMas = auxCantHabitantesProvincia;
                }
                if(auxProvinciaMetros<metrosProvinciaMenosMetros)
                {
                    provinciaMenosMetros = oProvincia;
                    metrosProvinciaMenosMetros = auxProvinciaMetros;
                }
                if(auxHabitantesPorMetroCuadradoProvincia>habitantesPorMetroCuadradoProvinciaMas)
                {
                    provinciaMasHabitantesPorMetroCuadrado = oProvincia;
                    habitantesPorMetroCuadradoProvinciaMas = auxHabitantesPorMetroCuadradoProvincia;
                }
            }
            MessageBox.Show("Cantidad total de habitantes en el país: " + poblacionTotal + ".\nCiudad con mas habitantes: "
            +ciudadConMasHabitantes.nombre+"; Cantidad de habitantes: "+ciudadConMasHabitantes.cantHabitantes+".\nProvincia "+
            "con mas habitantes: "+provinciaConMasHabitantes.nombre+"; Cantidad de habitantes: "+auxCantHabitantesProvincia+ ".\n"+
            "Provincia con menos metros cuadrados: "+provinciaMenosMetros.nombre+"; Cantidad de metros cuadrados: "+
            metrosProvinciaMenosMetros+".\nProvincia con mas habitantes por metro cuadrado: "+
            provinciaMasHabitantesPorMetroCuadrado.nombre+"; Cantidad de habitantes por metro cuadrado: "+
            Math.Round(habitantesPorMetroCuadradoProvinciaMas,2)+".","INFORMACION GENERAL");
        }
    }
}