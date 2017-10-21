namespace Muebleria
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblCantSillas = new System.Windows.Forms.Label();
            this.lblTamano = new System.Windows.Forms.Label();
            this.txtNumJuego = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.cmbTamano = new System.Windows.Forms.ComboBox();
            this.nudCodJuego = new System.Windows.Forms.NumericUpDown();
            this.nudCantSillas = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantSillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(827, 269);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 53);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInfo.Location = new System.Drawing.Point(12, 278);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(290, 44);
            this.btnVerInfo.TabIndex = 1;
            this.btnVerInfo.Text = "Ver informacion de la semana";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(7, 24);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(316, 25);
            this.lblIngresar.TabIndex = 2;
            this.lblIngresar.Text = "Por favor ingrese los siguientes datos:";
            // 
            // lblCantSillas
            // 
            this.lblCantSillas.AutoSize = true;
            this.lblCantSillas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantSillas.Location = new System.Drawing.Point(341, 230);
            this.lblCantSillas.Name = "lblCantSillas";
            this.lblCantSillas.Size = new System.Drawing.Size(158, 25);
            this.lblCantSillas.TabIndex = 3;
            this.lblCantSillas.Text = "Cantidad de sillas:";
            // 
            // lblTamano
            // 
            this.lblTamano.AutoSize = true;
            this.lblTamano.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamano.Location = new System.Drawing.Point(341, 174);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(82, 25);
            this.lblTamano.TabIndex = 4;
            this.lblTamano.Text = "Tamaño:";
            // 
            // txtNumJuego
            // 
            this.txtNumJuego.AutoSize = true;
            this.txtNumJuego.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumJuego.Location = new System.Drawing.Point(341, 115);
            this.txtNumJuego.Name = "txtNumJuego";
            this.txtNumJuego.Size = new System.Drawing.Size(122, 25);
            this.txtNumJuego.TabIndex = 5;
            this.txtNumJuego.Text = "Código juego:";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.Location = new System.Drawing.Point(341, 60);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(164, 25);
            this.lblNumFactura.TabIndex = 6;
            this.lblNumFactura.Text = "Número de factura:";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.txtNumFactura.Location = new System.Drawing.Point(547, 57);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(142, 32);
            this.txtNumFactura.TabIndex = 7;
            // 
            // cmbTamano
            // 
            this.cmbTamano.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.Items.AddRange(new object[] {
            "GRANDE",
            "MEDIANO",
            "CHICO"});
            this.cmbTamano.Location = new System.Drawing.Point(547, 171);
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.Size = new System.Drawing.Size(142, 33);
            this.cmbTamano.TabIndex = 8;
            // 
            // nudCodJuego
            // 
            this.nudCodJuego.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.nudCodJuego.Location = new System.Drawing.Point(547, 113);
            this.nudCodJuego.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCodJuego.Name = "nudCodJuego";
            this.nudCodJuego.Size = new System.Drawing.Size(120, 32);
            this.nudCodJuego.TabIndex = 9;
            // 
            // nudCantSillas
            // 
            this.nudCantSillas.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.nudCantSillas.Location = new System.Drawing.Point(547, 228);
            this.nudCantSillas.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCantSillas.Name = "nudCantSillas";
            this.nudCantSillas.Size = new System.Drawing.Size(120, 32);
            this.nudCantSillas.TabIndex = 11;
            this.nudCantSillas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Muebleria.Properties.Resources.muebleria_jimenez;
            this.pictureBox1.Location = new System.Drawing.Point(720, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(983, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudCantSillas);
            this.Controls.Add(this.nudCodJuego);
            this.Controls.Add(this.cmbTamano);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblNumFactura);
            this.Controls.Add(this.txtNumJuego);
            this.Controls.Add(this.lblTamano);
            this.Controls.Add(this.lblCantSillas);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnAceptar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Muebleria Jimenez";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCodJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantSillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblCantSillas;
        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.Label txtNumJuego;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.ComboBox cmbTamano;
        private System.Windows.Forms.NumericUpDown nudCodJuego;
        private System.Windows.Forms.NumericUpDown nudCantSillas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

