namespace Consultorio
{
    partial class gpbZona
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
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.rbtCapital = new System.Windows.Forms.RadioButton();
            this.rbtGBA = new System.Windows.Forms.RadioButton();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbPago = new System.Windows.Forms.GroupBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbPago.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEstudio
            // 
            this.cmbEstudio.FormattingEnabled = true;
            this.cmbEstudio.Items.AddRange(new object[] {
            "Radiografía",
            "Implante",
            "Ecografía",
            "Análisis de orina"});
            this.cmbEstudio.Location = new System.Drawing.Point(507, 27);
            this.cmbEstudio.Name = "cmbEstudio";
            this.cmbEstudio.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudio.TabIndex = 0;
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudio.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblEstudio.Location = new System.Drawing.Point(26, 19);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(454, 27);
            this.lblEstudio.TabIndex = 1;
            this.lblEstudio.Text = "Seleccione el estudio que desea hacerse:";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.Location = new System.Drawing.Point(458, 19);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(139, 31);
            this.rbtMasculino.TabIndex = 2;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemenino.Location = new System.Drawing.Point(270, 19);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(136, 31);
            this.rbtFemenino.TabIndex = 3;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(244, 149);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 20);
            this.nudEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(26, 142);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(191, 27);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Ingrese su edad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(748, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 57);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnDia
            // 
            this.btnDia.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDia.Location = new System.Drawing.Point(12, 363);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(180, 44);
            this.btnDia.TabIndex = 8;
            this.btnDia.Text = "Finalizar día";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnMes
            // 
            this.btnMes.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.Location = new System.Drawing.Point(215, 363);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(184, 44);
            this.btnMes.TabIndex = 9;
            this.btnMes.Text = "Finalizar mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // rbtCapital
            // 
            this.rbtCapital.AutoSize = true;
            this.rbtCapital.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCapital.Location = new System.Drawing.Point(279, 21);
            this.rbtCapital.Name = "rbtCapital";
            this.rbtCapital.Size = new System.Drawing.Size(199, 31);
            this.rbtCapital.TabIndex = 11;
            this.rbtCapital.TabStop = true;
            this.rbtCapital.Text = "Capital Federal";
            this.rbtCapital.UseVisualStyleBackColor = true;
            // 
            // rbtGBA
            // 
            this.rbtGBA.AutoSize = true;
            this.rbtGBA.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGBA.Location = new System.Drawing.Point(485, 21);
            this.rbtGBA.Name = "rbtGBA";
            this.rbtGBA.Size = new System.Drawing.Size(79, 31);
            this.rbtGBA.TabIndex = 12;
            this.rbtGBA.TabStop = true;
            this.rbtGBA.Text = "GBA";
            this.rbtGBA.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEfectivo.Location = new System.Drawing.Point(379, 22);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(116, 31);
            this.rbtEfectivo.TabIndex = 14;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTarjeta.Location = new System.Drawing.Point(526, 22);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(107, 31);
            this.rbtTarjeta.TabIndex = 15;
            this.rbtTarjeta.TabStop = true;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtGBA);
            this.groupBox1.Controls.Add(this.rbtCapital);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 58);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione su zona: ";
            // 
            // gpbPago
            // 
            this.gpbPago.Controls.Add(this.rbtEfectivo);
            this.gpbPago.Controls.Add(this.rbtTarjeta);
            this.gpbPago.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPago.Location = new System.Drawing.Point(22, 264);
            this.gpbPago.Name = "gpbPago";
            this.gpbPago.Size = new System.Drawing.Size(684, 59);
            this.gpbPago.TabIndex = 17;
            this.gpbPago.TabStop = false;
            this.gpbPago.Text = "Seleccione su método de pago:";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Controls.Add(this.rbtFemenino);
            this.gpbSexo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSexo.Location = new System.Drawing.Point(31, 63);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(653, 56);
            this.gpbSexo.TabIndex = 18;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Seleccione su sexo:";
            // 
            // gpbZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(957, 411);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.gpbPago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.cmbEstudio);
            this.Name = "gpbZona";
            this.Text = "Consultorio";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbPago.ResumeLayout(false);
            this.gpbPago.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudio;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.RadioButton rbtCapital;
        private System.Windows.Forms.RadioButton rbtGBA;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbPago;
        private System.Windows.Forms.GroupBox gpbSexo;
    }
}

