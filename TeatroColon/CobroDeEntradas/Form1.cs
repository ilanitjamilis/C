using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CobroDeEntradas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotalCompra_Click(object sender, EventArgs e)
        {
            if(nudEdad.Value<15)
            {
                MessageBox.Show("Su entrada es libre y gratuita.");
            }
            else
            {
                if(nudEdad.Value>=15&&nudEdad.Value<60&&rbtFemenino.Checked)
                {
                    MessageBox.Show("El valor de su entrada es $100.");
                }
                else{
                    if(nudEdad.Value>=60&&rbtFemenino.Checked)
                    {
                        MessageBox.Show("El valor de su entrada es $40.");
                    }
                    else {
                        if(nudEdad.Value>=15&&nudEdad.Value<65&&rbtMasculino.Checked)
                        {
                            MessageBox.Show("El valor de su entrada es $100.");
                        }
                        else
                        {
                            if(nudEdad.Value>=65&&rbtMasculino.Checked);
                            {
                                MessageBox.Show("El valor de su entrada es $40.");
                            }
                        }
                    }
                }
            }
        }
    }
}
  