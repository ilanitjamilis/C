using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Form1 : Form
    {
            int radiografia = 0;
            int implante = 0;
            int ecografia = 0;
            int orina = 0;
            int femeninoRadiografia = 0;
            int masculinoRadiografia = 0;
            int femeninoImplante= 0;
            int masculinoImplante= 0;
            int femeninoEcografia= 0;
            int masculinoEcografia= 0;
            int femeninoOrina= 0;
            int masculinoOrina= 0;
            int recaudacion = 0;
            int radiografiaIngresos = 0;
            int implanteIngresos = 0;
            int ecografiaIngresos = 0;
            int orinaIngresos = 0;
            int estudiosEmpleado = 0;
            int empleados = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEstudio_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmbEstudio.Text=="Radiografía"){
                if (rbtFemenino.Checked)
                {
                    if (nudEdad.Value < 60)
                    {
                        MessageBox.Show("Usted debe abonar $90.");
                        radiografia = radiografia + 90;
                        radiografiaIngresos = radiografiaIngresos + (90 - 20);
                        recaudacion = recaudacion + 90;
                        femeninoRadiografia = femeninoRadiografia + 1;
                        estudiosEmpleado = estudiosEmpleado + 1;
                        if (estudiosEmpleado == 8)
                        {
                            empleados = empleados + 1;
                            estudiosEmpleado = 0;
                        }
                    }
                    if (nudEdad.Value >= 60)
                    {
                        MessageBox.Show("Usted debe abonar $45.");
                        radiografia = radiografia + 45;
                        radiografiaIngresos = radiografiaIngresos + (45 - 20);
                        recaudacion = recaudacion + 45;
                        femeninoRadiografia = femeninoRadiografia + 1;
                        estudiosEmpleado = estudiosEmpleado + 1;
                        if (estudiosEmpleado == 8)
                        {
                            empleados = empleados + 1;
                            estudiosEmpleado = 0;
                        }
                    }
                }
                if (rbtMasculino.Checked)
                {
                    if (nudEdad.Value < 65)
                    {
                        MessageBox.Show("Usted debe abonar $90.");
                        radiografia = radiografia + 90;
                        radiografiaIngresos = radiografiaIngresos + (90 - 20);
                        recaudacion = recaudacion + 90;
                        masculinoRadiografia = masculinoRadiografia + 1;
                        estudiosEmpleado = estudiosEmpleado + 1;
                        if (estudiosEmpleado == 8)
                        {
                            empleados = empleados + 1;
                            estudiosEmpleado = 0;
                        }
                    }
                    if (nudEdad.Value >= 65)
                    {
                        MessageBox.Show("Usted debe abonar $45.");
                        radiografia = radiografia + 45;
                        radiografiaIngresos = radiografiaIngresos + (45 - 20);
                        recaudacion = recaudacion + 45;
                        masculinoRadiografia = masculinoRadiografia + 1;
                        estudiosEmpleado = estudiosEmpleado + 1;
                        if (estudiosEmpleado == 8)
                        {
                            empleados = empleados + 1;
                            estudiosEmpleado = 0;
                        }
                    }
                }
            }

            if(cmbEstudio.Text=="Implante"){
                if(rbtFemenino.Checked){
                    if(nudEdad.Value<60){
                    MessageBox.Show("Usted debe abonar $300.");
                    implante = implante + 300;
                    implanteIngresos = implanteIngresos + (300 - 60);
                    recaudacion = recaudacion + 300;
                    femeninoImplante = femeninoImplante + 1;
                    estudiosEmpleado = estudiosEmpleado + 1;
                    if (estudiosEmpleado == 8)
                        {
                            empleados = empleados + 1;
                            estudiosEmpleado = 0;
                        }
                    }
                    if(nudEdad.Value>=60){
                        MessageBox.Show("Usted debe abonar $150.");
                        implante = implante + 150;
                        implanteIngresos = implanteIngresos + (150 - 60);
                        recaudacion = recaudacion + 150;
                        femeninoImplante = femeninoImplante + 1;
                        estudiosEmpleado = estudiosEmpleado + 1;
                        if (estudiosEmpleado == 8)
                        {
                            empleados = empleados + 1;
                            estudiosEmpleado = 0;
                        }
                    }
                    if(rbtMasculino.Checked){
                        if(nudEdad.Value<65){
                           MessageBox.Show("Usted debe abonar $300.");
                           implante = implante + 300;
                           implanteIngresos = implanteIngresos + (300 - 60);
                           recaudacion = recaudacion + 300;
                           masculinoImplante = masculinoImplante + 1;
                           estudiosEmpleado = estudiosEmpleado + 1;
                           if (estudiosEmpleado == 8)
                           {
                               empleados = empleados + 1;
                               estudiosEmpleado = 0;
                           }
                           if(nudEdad.Value>=65){
                              MessageBox.Show("Usted debe abonar $150.");
                              implante = implante + 150;
                              implanteIngresos = implanteIngresos + (150 - 60);
                              recaudacion = recaudacion + 150;
                              masculinoImplante = masculinoImplante + 1;
                              estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                 {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                 }
                            }
                        }
                    }

                    if(cmbEstudio.Text=="Ecografía"){
                        if(rbtFemenino.Checked){
                            if(nudEdad.Value<60){
                                MessageBox.Show("Usted debe abonar $150.");
                                ecografia = ecografia + 150;
                                ecografiaIngresos = ecografiaIngresos + (150 - 40);
                                recaudacion = recaudacion + 150;
                                femeninoEcografia = femeninoEcografia + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }
                            }
                            if(nudEdad.Value>=60){
                                MessageBox.Show("Usted debe abonar $75.");
                                ecografia = ecografia + 75;
                                ecografiaIngresos = ecografiaIngresos + (75 - 40);
                                recaudacion = recaudacion + 75;
                                femeninoEcografia = femeninoEcografia + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }

                            }
                        }
                        if(rbtMasculino.Checked){
                            if(nudEdad.Value<65){
                                MessageBox.Show("Usted debe abonar $150.");
                                ecografia = ecografia + 150;
                                ecografiaIngresos = ecografiaIngresos + (150 - 40);
                                recaudacion = recaudacion + 150;
                                masculinoEcografia = masculinoEcografia + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }
                            }
                            if(nudEdad.Value>=65){
                                MessageBox.Show("Usted debe abonar $75.");
                                ecografia = ecografia + 75;
                                ecografiaIngresos = ecografiaIngresos + (75 - 40);
                                recaudacion = recaudacion + 75;
                                masculinoEcografia = masculinoEcografia + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }

                            }
                        }
                    }

                    if(cmbEstudio.Text=="Análisis de orina"){
                        if(rbtFemenino.Checked){
                            if(nudEdad.Value<60){
                                MessageBox.Show("Usted debe abonar $60.");
                                orina = orina + 60;
                                orinaIngresos = orinaIngresos + (60 - 15);
                                recaudacion = recaudacion + 60;
                                femeninoOrina = femeninoOrina + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }
                            }
                            if(nudEdad.Value>=60){
                                MessageBox.Show("Usted debe abonar $30.");
                                orina = orina + 30;
                                orinaIngresos = orinaIngresos + (30 - 15);
                                recaudacion = recaudacion + 30;
                                femeninoOrina = femeninoOrina + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }
                            }
                        }
                        if(rbtMasculino.Checked)
                        {
                            if(nudEdad.Value<65){
                                MessageBox.Show("Usted debe abonar $60.");
                                orina = orina + 60;
                                orinaIngresos = orinaIngresos + (60 - 15);
                                recaudacion = recaudacion + 60;
                                masculinoOrina = masculinoOrina + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }
                            }
                            if(nudEdad.Value>=65)
                            {
                                MessageBox.Show("Usted debe abonar $30.");
                                orina = orina + 30;
                                orinaIngresos = orinaIngresos + (30 - 15);
                                recaudacion = recaudacion + 30;
                                masculinoOrina = masculinoOrina + 1;
                                estudiosEmpleado = estudiosEmpleado + 1;
                                if (estudiosEmpleado == 8)
                                {
                                    empleados = empleados + 1;
                                    estudiosEmpleado = 0;
                                }
                            }
                        }
                    }

                }





        private void btnDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoy " +femeninoRadiografia+ " mujeres y "+masculinoRadiografia+" hombres se hicieron radiografías.");
            MessageBox.Show("Hoy "+femeninoImplante+" mujeres y "+masculinoImplante+" hombres se hicieron implantes.");
            MessageBox.Show("Hoy "+femeninoEcografia+" mujeres y "+masculinoEcografia+" hombres se hicieron ecografías.");
            MessageBox.Show("Hoy "+femeninoOrina+" mujeres y "+masculinoOrina+" hombres se hicieron análisis de orina.");
            MessageBox.Show("Hoy se recaudó $" + radiografia + " de las radiografías, $"+implante+" de los implantes, $"+ecografia+" de las ecografías y $"+orina+" de los análisis de orina.");
            MessageBox.Show("La recaudación total del día de hoy fue $" + recaudacion+".");
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los ingresos totales de este mes fueron $"+(radiografiaIngresos+implanteIngresos+ecografiaIngresos+orinaIngresos-empleados*200)+".");

        }


    }
}

