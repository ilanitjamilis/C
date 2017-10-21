namespace ClubAlmagro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.nudAntiguedad = new System.Windows.Forms.NumericUpDown();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.cmbDeportes = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAntiguedad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarFont = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(810, 43);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(170, 37);
            this.dtpNacimiento.TabIndex = 0;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(308, 49);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(442, 28);
            this.lblNacimiento.TabIndex = 1;
            this.lblNacimiento.Text = "Ingrese la fecha de nacimiento del socio:";
            // 
            // nudAntiguedad
            // 
            this.nudAntiguedad.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAntiguedad.Location = new System.Drawing.Point(829, 162);
            this.nudAntiguedad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAntiguedad.Name = "nudAntiguedad";
            this.nudAntiguedad.Size = new System.Drawing.Size(73, 37);
            this.nudAntiguedad.TabIndex = 2;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedad.Location = new System.Drawing.Point(308, 164);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(450, 28);
            this.lblAntiguedad.TabIndex = 3;
            this.lblAntiguedad.Text = "Ingrese antigüedad del mismo en el club:";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(308, 274);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(414, 28);
            this.lblDeporte.TabIndex = 4;
            this.lblDeporte.Text = "Seleccione el deporte que este realiza:";
            // 
            // cmbDeportes
            // 
            this.cmbDeportes.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeportes.FormattingEnabled = true;
            this.cmbDeportes.Items.AddRange(new object[] {
            "Backgammon",
            "Futbol",
            "Hockey",
            "Pelota-paleta",
            "Burako"});
            this.cmbDeportes.Location = new System.Drawing.Point(795, 271);
            this.cmbDeportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDeportes.Name = "cmbDeportes";
            this.cmbDeportes.Size = new System.Drawing.Size(185, 36);
            this.cmbDeportes.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(908, 391);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(208, 94);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1129, 500);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbDeportes);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.nudAntiguedad);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.dtpNacimiento);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Almagro";
            ((System.ComponentModel.ISupportInitialize)(this.nudAntiguedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.NumericUpDown nudAntiguedad;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.ComboBox cmbDeportes;
        private System.Windows.Forms.Button btnAceptar;
    }
}

