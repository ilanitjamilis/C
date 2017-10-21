namespace Peaje
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
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Camioneta",
            "Camión"});
            this.cmbVehiculos.Location = new System.Drawing.Point(442, 104);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(121, 21);
            this.cmbVehiculos.TabIndex = 0;
            this.cmbVehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Miramonte", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(31, 84);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(363, 43);
            this.lblVehiculo.TabIndex = 1;
            this.lblVehiculo.Text = "Seleccione su vehiculo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Miramonte", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(613, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(176, 62);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Miramonte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(519, 339);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(443, 47);
            this.btnInformacion.TabIndex = 3;
            this.btnInformacion.Text = "Mostrar informacion del dia";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1004, 409);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.cmbVehiculos);
            this.ForeColor = System.Drawing.Color.Ivory;
            this.Name = "Form1";
            this.Text = "Peaje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnInformacion;
    }
}

