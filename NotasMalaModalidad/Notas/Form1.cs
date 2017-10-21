using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        decimal notaPrimerTrimestre = 0;
        decimal notaSegundoTrimestre = 0;
        decimal notaTercerTrimestre = 0;
        int contador = 0;
        decimal cantidadAlumnos = 0;
        decimal cantidadAlumnosA = 0;
        decimal porcentajeAlumnosA = 0;
        decimal porcentajeAlumnosAFinal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarNota_Click_1(object sender, EventArgs e)
        {
            if (nudNota.Value >= 1 && nudNota.Value <= 10)
            {
                if (contador == 3)
                {
                    contador = 0;
                }

                contador = contador + 1;

                if (contador == 1)
                {
                    notaPrimerTrimestre=nudNota.Value;
                }

                if (contador == 2)
                {
                    notaSegundoTrimestre=nudNota.Value;
                }

                if (contador == 3)
                {
                    notaTercerTrimestre=nudNota.Value;

                    cantidadAlumnos = cantidadAlumnos + 1;

                    decimal promedioParcial = 0;
                    decimal promedioFinal = 0;

                    promedioParcial = (notaPrimerTrimestre + notaSegundoTrimestre + notaTercerTrimestre);
                    promedioFinal = (promedioParcial / 3);

                    if (promedioFinal>=6 && notaTercerTrimestre>=6)
                    {
                        MessageBox.Show("Aprobaste la materia.");
                        cantidadAlumnosA = cantidadAlumnosA + 1;
                    }
                    else
                    {
                        MessageBox.Show("No aprobaste la materia.");    
                    }

                    MessageBox.Show("Tu promedio es " + promedioFinal + ".");
                }
            }
            else
            {
                MessageBox.Show("Error, por favor ingrese una nota válida.");
            }
            
        }
        
        private void btnInformacion_Click(object sender, EventArgs e)
        
        {
            porcentajeAlumnosA = (cantidadAlumnosA / cantidadAlumnos);
            porcentajeAlumnosAFinal=(porcentajeAlumnosA*100);
            MessageBox.Show("El porcentaje de los alumnos aprobados es " + porcentajeAlumnosAFinal + "%.");
            porcentajeAlumnosA = 0;
            porcentajeAlumnosAFinal = 0;
        }
    }
}
