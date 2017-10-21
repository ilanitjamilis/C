using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KioskoDeLaAbuela
{
    public partial class Form1 : Form
    {
        string error = "";
        decimal compra = 0;
        decimal plataCliente = 0;
        decimal vuelto = 0;
        decimal vB50 = 0;
        decimal vB20 = 0;
        decimal vB10 = 0;
        decimal vB5 = 0;
        decimal vB2 = 0;
        decimal vM1 = 0;
        decimal vM50c = 0;
        int caramelo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            compra = Convert.ToDecimal(txtCompra.Text);
            plataCliente = nud100.Value * 100 + nud50.Value * 50 + nud20.Value * 20 + nud10.Value * 10 + nud5.Value * 5 + nud2.Value * 2 + nud1.Value + nud50c.Value * 0.5M;

            if (nud100.Value < 0 || nud50.Value < 0 || nud20.Value < 0 || nud10.Value < 0 || nud5.Value < 0 || nud2.Value < 0 || nud1.Value < 0 || nud50c.Value < 0)
            {
                error = "ERROR";
            }
            else
            {
                if (nud100.Value == 0 && nud50.Value == 0 && nud20.Value == 0 && nud10.Value == 0 && nud5.Value == 0 && nud2.Value == 0 && nud1.Value == 0 && nud50c.Value == 0)
                {
                    error = "ERROR";
                }
                else
                {
                    if (compra <= 0)
                    {
                        error = "ERROR";
                    }
                    else
                    {
                        if (compra > plataCliente)
                        {
                            error = "ERROR";
                        }
                    }
                }
            }

            if (error == "")
            {
                error = "";
                vuelto = plataCliente - compra;

                if (vuelto == 0)
                {
                    lbl50.Text = "El cliente te pagó exacto, no le des vuelto!!";
                    lbl50.Show();
                }
                else
                {
                    lblVuelto.Show();

                    vB50 = Math.Truncate(vuelto / 50);
                    vuelto = vuelto % 50;
                    vB20 = Math.Truncate(vuelto / 20);
                    vuelto = vuelto % 20;
                    vB10 = Math.Truncate(vuelto / 10);
                    vuelto = vuelto % 10;
                    vB5 = Math.Truncate(vuelto / 5);
                    vuelto = vuelto % 5;
                    vB2 = Math.Truncate(vuelto / 2);
                    vuelto = vuelto % 2;
                    vM1 = Math.Truncate(vuelto / 1);
                    vuelto = vuelto % 1;
                    vM50c = Math.Truncate(vuelto / 0.5M);
                    vuelto = vuelto % 0.5M;
                    if (vuelto != 0)
                    {
                        caramelo = 1;
                    }

                    if (vB50 != 0)
                    {
                        pct50.Show();
                        lbl50.Text = Convert.ToString(vB50);
                        lbl50.Show();
                    }
                    if (vB20 != 0)
                    {
                        pct20.Show();
                        lbl20.Text = Convert.ToString(vB20);
                        lbl20.Show();
                    }
                    if (vB10 != 0)
                    {
                        pct10.Show();
                        lbl10.Text = Convert.ToString(vB10);
                        lbl10.Show();
                    }
                    if (vB5 != 0)
                    {
                        pct5.Show();
                        lbl5.Text = Convert.ToString(vB5);
                        lbl5.Show();
                    }
                    if (vB2 != 0)
                    {
                        pct2.Show();
                        lbl2.Text = Convert.ToString(vB2);
                        lbl2.Show();
                    }
                    if (vM1 != 0)
                    {
                        pct1.Show();
                        lbl1.Text = Convert.ToString(vM1);
                        lbl1.Show();
                    }
                    if (vM50c != 0)
                    {
                        pct50c.Show();
                        lbl50c.Text = Convert.ToString(vM50c);
                        lbl50c.Show();
                    }
                    if (caramelo != 0)
                    {
                        pctCaramelo.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show(error);
                error = "";
            }
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {

            plataCliente = 0;
            vuelto = 0;
            vB50 = 0;
            vB20 = 0;
            vB10 = 0;
            vB5 = 0;
            vB2 = 0;
            vM1 = 0;
            vM50c = 0;
            caramelo = 0;

            nud100.Value = 0;
            nud50.Value = 0;
            nud20.Value = 0;
            nud10.Value = 0;
            nud5.Value = 0;
            nud2.Value = 0;
            nud1.Value = 0;
            nud50c.Value = 0;

            lblVuelto.Hide();

            pct50.Hide();
            pct20.Hide();
            pct10.Hide();
            pct5.Hide();
            pct2.Hide();
            pct1.Hide();
            pct50c.Hide();
            pctCaramelo.Hide();

            lbl50.Hide();
            lbl20.Hide();
            lbl10.Hide();
            lbl5.Hide();
            lbl2.Hide();
            lbl1.Hide();
            lbl50c.Hide();

            txtCompra.Text = "";
        }
    }
}
