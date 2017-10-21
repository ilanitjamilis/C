namespace PracticaPruebaTercerTrimestre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblHabitantes = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.nudHabitantes = new System.Windows.Forms.NumericUpDown();
            this.nudMetros = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(21, 77);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(95, 25);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetros.Location = new System.Drawing.Point(23, 227);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(166, 25);
            this.lblMetros.TabIndex = 1;
            this.lblMetros.Text = "Metros cuadrados: ";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(12, 20);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(210, 23);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.Text = "Ingrese los siguientes datos: ";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(21, 127);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(73, 25);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblHabitantes
            // 
            this.lblHabitantes.AutoSize = true;
            this.lblHabitantes.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitantes.Location = new System.Drawing.Point(22, 177);
            this.lblHabitantes.Name = "lblHabitantes";
            this.lblHabitantes.Size = new System.Drawing.Size(206, 25);
            this.lblHabitantes.TabIndex = 4;
            this.lblHabitantes.Text = "Cantidad de habitantes: ";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(122, 77);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(134, 32);
            this.txtProvincia.TabIndex = 5;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(109, 124);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(134, 32);
            this.txtCiudad.TabIndex = 6;
            // 
            // nudHabitantes
            // 
            this.nudHabitantes.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHabitantes.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHabitantes.Location = new System.Drawing.Point(234, 177);
            this.nudHabitantes.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudHabitantes.Name = "nudHabitantes";
            this.nudHabitantes.Size = new System.Drawing.Size(120, 32);
            this.nudHabitantes.TabIndex = 7;
            // 
            // nudMetros
            // 
            this.nudMetros.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMetros.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMetros.Location = new System.Drawing.Point(195, 227);
            this.nudMetros.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMetros.Name = "nudMetros";
            this.nudMetros.Size = new System.Drawing.Size(120, 32);
            this.nudMetros.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(375, 261);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(120, 48);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInfo.Location = new System.Drawing.Point(352, 20);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(150, 35);
            this.btnVerInfo.TabIndex = 10;
            this.btnVerInfo.Text = "Ver informacion";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 325);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.nudMetros);
            this.Controls.Add(this.nudHabitantes);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblHabitantes);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblProvincia);
            this.Name = "Form1";
            this.Text = "Estado nacional - Provincias y ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.nudHabitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMetros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblHabitantes;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.NumericUpDown nudHabitantes;
        private System.Windows.Forms.NumericUpDown nudMetros;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVerInfo;
    }
}

