using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RENAPER
{
    public partial class Renaper : Form
    {
        public Renaper()
        {
            InitializeComponent();
            lblInformacion.Text = "Datos que usted debe ingresar:\nPrimer Nombre\nSegundo nombre\nApellido\nSegundo apellido\nFecha de nacimiento\nCódigo postal\nDirección\n\nSi la persona no tiene segundo nombre o segundo apellido,ingrese un guíón.\nLos datos van separados por comas.\n\nEjemplo: Ariel,Gustavo,Lipschutz,-,07/08/1988,C1414AOB,Vera 147";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string datos = txtDatos.Text;
            datos = datos.Trim();
            int posicionComa = datos.IndexOf(",");

            if (datos.IndexOf(",") > 0)
            {
                string primerNombre = datos.Substring(0, posicionComa);
                lblPrimerNombre.Text = "Primer nombre: " + primerNombre;
            }

            string datos1 = datos.Substring(posicionComa + 1);
            datos1 = datos1.Trim();
            int posicionComa1 = datos1.IndexOf(",");

            if (datos1.IndexOf(",") > 0)
            {
                string segundoNombre = datos1.Substring(0, posicionComa1);
                if (segundoNombre != "-")
                {
                    lblSegundoNombre.Text = "Segundo nombre: " + segundoNombre;
                }
                else
                {
                    lblSegundoNombre.Text = "Segundo nombre: NO TIENE";
                }
            }

            string datos2 = datos1.Substring(posicionComa1 + 1);
            datos2 = datos2.Trim();
            int posicionComa2 = datos2.IndexOf(",");

            if (datos2.IndexOf(",") > 0)
            {
                string primerApellido = datos2.Substring(0, posicionComa2);
                lblPrimerApellido.Text = "Primer apellido: " + primerApellido;
            }

            string datos3 = datos2.Substring(posicionComa2 + 1);
            datos3 = datos3.Trim();
            int posicionComa3 = datos3.IndexOf(",");

            if (datos3.IndexOf(",") > 0)
            {
                string segundoApellido = datos3.Substring(0, posicionComa3);
                if (segundoApellido != "-")
                {
                    lblSegundoApellido.Text = "Segundo apellido: " + segundoApellido;
                }
                else
                {
                    lblSegundoApellido.Text = "Segundo apellido: NO TIENE";
                }
            }

            string datos4 = datos3.Substring(posicionComa3 + 1);
            datos4 = datos4.Trim();
            int posicionComa4 = datos4.IndexOf(",");
            string nacimiento = datos4.Substring(0, posicionComa4);
            string dia = nacimiento.Substring(0, 2);
            string mes = nacimiento.Substring(3, 2);
            string año = nacimiento.Substring(6,4);
            if (Convert.ToInt32(dia) > 0 && Convert.ToInt32(dia) < 32 && Convert.ToInt32(mes) > 0 && Convert.ToInt32(mes) < 13)
            {
                if (Convert.ToDateTime(nacimiento) < DateTime.Now && Convert.ToInt32(año)>1900)
                {
                    lblFecha.Text = "Fecha de nacimiento: " + nacimiento;
                }
                else
                {
                    lblFecha.Text = "Fecha de nacimiento: INCORRECTA";
                }
            }

            else
            {
                lblFecha.Text = "Fecha de nacimiento: INCORRECTA";
            }

            string datos5 = datos4.Substring(posicionComa4 + 1);
            datos5 = datos5.Trim();
            int posicionComa5 = datos5.IndexOf(",");

            if (datos5.IndexOf(",") > 0)
            {
                string codigo = datos5.Substring(0, posicionComa5);
                codigo = codigo.Trim();
                codigo = codigo.Substring(1,4);
                lblCodigo.Text = "Código postal: " + codigo;
            }

            string datos6 = datos5.Substring(posicionComa5 + 1);
            datos6 = datos6.Trim();

            string direccion = datos6;
            lblDireccion.Text = "Dirección: " + direccion;
        }
    }
}
