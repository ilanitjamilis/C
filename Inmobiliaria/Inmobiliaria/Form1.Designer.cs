namespace Inmobiliaria
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
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblAmbientes = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.cmbAmbientes = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 26);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(232, 24);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección de la propiedad:";
            // 
            // lblAmbientes
            // 
            this.lblAmbientes.AutoSize = true;
            this.lblAmbientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmbientes.Location = new System.Drawing.Point(11, 76);
            this.lblAmbientes.Name = "lblAmbientes";
            this.lblAmbientes.Size = new System.Drawing.Size(345, 24);
            this.lblAmbientes.TabIndex = 1;
            this.lblAmbientes.Text = "Cantidad de ambientes de la propiedad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(13, 119);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(206, 24);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio de la propiedad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(268, 163);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(189, 40);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Procesar datos";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(250, 26);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(169, 29);
            this.txtDireccion.TabIndex = 4;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrecio.Location = new System.Drawing.Point(225, 117);
            this.nudPrecio.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(131, 29);
            this.nudPrecio.TabIndex = 5;
            this.nudPrecio.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // cmbAmbientes
            // 
            this.cmbAmbientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAmbientes.FormattingEnabled = true;
            this.cmbAmbientes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbAmbientes.Location = new System.Drawing.Point(362, 73);
            this.cmbAmbientes.Name = "cmbAmbientes";
            this.cmbAmbientes.Size = new System.Drawing.Size(48, 32);
            this.cmbAmbientes.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inmobiliaria.Properties.Resources.cadena_inmobiliaria;
            this.pictureBox1.Location = new System.Drawing.Point(468, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 206);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(12, 188);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(170, 35);
            this.btnInformacion.TabIndex = 8;
            this.btnInformacion.Text = "Ver información";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(411, 221);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(314, 12);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "IMPORTANTE: VALOR DE LA PROPIEDAD ENTRE $500000 Y $2000000.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 235);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbAmbientes);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAmbientes);
            this.Controls.Add(this.lblDireccion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADENA INMOBILIARIA";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblAmbientes;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.ComboBox cmbAmbientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Label lblInfo;
    }
}

