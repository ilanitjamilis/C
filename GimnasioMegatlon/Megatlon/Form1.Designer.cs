namespace Megatlon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblActividades = new System.Windows.Forms.Label();
            this.cmbActividades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNumerosActividades = new System.Windows.Forms.Label();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(215, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese su nombre y apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(246, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblActividades
            // 
            this.lblActividades.AutoSize = true;
            this.lblActividades.Location = new System.Drawing.Point(25, 102);
            this.lblActividades.Name = "lblActividades";
            this.lblActividades.Size = new System.Drawing.Size(297, 19);
            this.lblActividades.TabIndex = 2;
            this.lblActividades.Text = "Elija la actividad que usted desea realizar:";
            // 
            // cmbActividades
            // 
            this.cmbActividades.FormattingEnabled = true;
            this.cmbActividades.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbActividades.Location = new System.Drawing.Point(328, 102);
            this.cmbActividades.Name = "cmbActividades";
            this.cmbActividades.Size = new System.Drawing.Size(67, 27);
            this.cmbActividades.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija en que turno desea realizar la actividad (D=diurno/N=nocturno):";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "D",
            "N"});
            this.cmbTurno.Location = new System.Drawing.Point(525, 168);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(69, 27);
            this.cmbTurno.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(463, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 48);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNumerosActividades
            // 
            this.lblNumerosActividades.AutoSize = true;
            this.lblNumerosActividades.Location = new System.Drawing.Point(578, 9);
            this.lblNumerosActividades.Name = "lblNumerosActividades";
            this.lblNumerosActividades.Size = new System.Drawing.Size(92, 19);
            this.lblNumerosActividades.TabIndex = 7;
            this.lblNumerosActividades.Text = "Actividades:";
            this.lblNumerosActividades.Visible = false;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(609, 325);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(216, 48);
            this.btnInformacion.TabIndex = 8;
            this.btnInformacion.Text = "Ver información";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActividades.Location = new System.Drawing.Point(692, 241);
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.Size = new System.Drawing.Size(133, 57);
            this.btnActividades.TabIndex = 9;
            this.btnActividades.Text = "Ver / ocultar actividades";
            this.btnActividades.UseVisualStyleBackColor = true;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(837, 385);
            this.Controls.Add(this.btnActividades);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.lblNumerosActividades);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbActividades);
            this.Controls.Add(this.lblActividades);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Megatlon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblActividades;
        private System.Windows.Forms.ComboBox cmbActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNumerosActividades;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnActividades;
    }
}

