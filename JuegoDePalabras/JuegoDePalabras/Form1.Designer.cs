namespace JuegoDePalabras
{
    partial class frmJuegoDePalabras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblfrase = new System.Windows.Forms.Label();
            this.txtfrase = new System.Windows.Forms.TextBox();
            this.mnsInformacion = new System.Windows.Forms.MenuStrip();
            this.cantidadVocales = new System.Windows.Forms.ToolStripMenuItem();
            this.vocalMasUsada = new System.Windows.Forms.ToolStripMenuItem();
            this.cantConsonantes = new System.Windows.Forms.ToolStripMenuItem();
            this.cantPalabras = new System.Windows.Forms.ToolStripMenuItem();
            this.frasesCapicua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mnsInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfrase
            // 
            this.lblfrase.AutoSize = true;
            this.lblfrase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrase.Location = new System.Drawing.Point(13, 183);
            this.lblfrase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfrase.Name = "lblfrase";
            this.lblfrase.Size = new System.Drawing.Size(181, 19);
            this.lblfrase.TabIndex = 0;
            this.lblfrase.Text = "Ingrese una palabra/frase:";
            // 
            // txtfrase
            // 
            this.txtfrase.Location = new System.Drawing.Point(236, 180);
            this.txtfrase.Margin = new System.Windows.Forms.Padding(4);
            this.txtfrase.Name = "txtfrase";
            this.txtfrase.Size = new System.Drawing.Size(654, 26);
            this.txtfrase.TabIndex = 1;
            // 
            // mnsInformacion
            // 
            this.mnsInformacion.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadVocales,
            this.vocalMasUsada,
            this.cantConsonantes,
            this.cantPalabras,
            this.frasesCapicua});
            this.mnsInformacion.Location = new System.Drawing.Point(0, 0);
            this.mnsInformacion.Name = "mnsInformacion";
            this.mnsInformacion.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnsInformacion.Size = new System.Drawing.Size(914, 31);
            this.mnsInformacion.TabIndex = 2;
            this.mnsInformacion.Text = "menuStrip1";
            // 
            // cantidadVocales
            // 
            this.cantidadVocales.Name = "cantidadVocales";
            this.cantidadVocales.Size = new System.Drawing.Size(159, 25);
            this.cantidadVocales.Text = "Cantidad de vocales";
            this.cantidadVocales.Click += new System.EventHandler(this.cantidadVocales_Click);
            // 
            // vocalMasUsada
            // 
            this.vocalMasUsada.Name = "vocalMasUsada";
            this.vocalMasUsada.Size = new System.Drawing.Size(137, 25);
            this.vocalMasUsada.Text = "Vocal más usada";
            this.vocalMasUsada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vocalMasUsada.Click += new System.EventHandler(this.vocalMasUsada_Click);
            // 
            // cantConsonantes
            // 
            this.cantConsonantes.Name = "cantConsonantes";
            this.cantConsonantes.Size = new System.Drawing.Size(196, 25);
            this.cantConsonantes.Text = "Cantidad de consonantes";
            this.cantConsonantes.Click += new System.EventHandler(this.cantConsonantes_Click);
            // 
            // cantPalabras
            // 
            this.cantPalabras.Name = "cantPalabras";
            this.cantPalabras.Size = new System.Drawing.Size(167, 25);
            this.cantPalabras.Text = "Cantidad de palabras";
            this.cantPalabras.Click += new System.EventHandler(this.cantPalabras_Click);
            // 
            // frasesCapicua
            // 
            this.frasesCapicua.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frasesCapicua.Name = "frasesCapicua";
            this.frasesCapicua.Size = new System.Drawing.Size(185, 25);
            this.frasesCapicua.Text = "Palabras/frases capicúa";
            this.frasesCapicua.Click += new System.EventHandler(this.frasesCapicua_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(793, 230);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 36);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmJuegoDePalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 278);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtfrase);
            this.Controls.Add(this.lblfrase);
            this.Controls.Add(this.mnsInformacion);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmJuegoDePalabras";
            this.ShowIcon = false;
            this.Text = "Juego de palabras";
            this.mnsInformacion.ResumeLayout(false);
            this.mnsInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrase;
        private System.Windows.Forms.TextBox txtfrase;
        private System.Windows.Forms.MenuStrip mnsInformacion;
        private System.Windows.Forms.ToolStripMenuItem cantidadVocales;
        private System.Windows.Forms.ToolStripMenuItem vocalMasUsada;
        private System.Windows.Forms.ToolStripMenuItem cantConsonantes;
        private System.Windows.Forms.ToolStripMenuItem cantPalabras;
        private System.Windows.Forms.ToolStripMenuItem frasesCapicua;
        private System.Windows.Forms.Button btnAceptar;
    }
}

