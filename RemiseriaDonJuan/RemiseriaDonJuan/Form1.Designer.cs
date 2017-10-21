namespace RemiseriaDonJuan
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
            this.lblElijaChofer = new System.Windows.Forms.Label();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblNombreRemiseria = new System.Windows.Forms.Label();
            this.lblChoferes = new System.Windows.Forms.Label();
            this.btnCargarViaje = new System.Windows.Forms.Button();
            this.btnFinDelDia = new System.Windows.Forms.Button();
            this.nudKilometros = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElijaChofer
            // 
            this.lblElijaChofer.AutoSize = true;
            this.lblElijaChofer.Location = new System.Drawing.Point(20, 79);
            this.lblElijaChofer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElijaChofer.Name = "lblElijaChofer";
            this.lblElijaChofer.Size = new System.Drawing.Size(347, 18);
            this.lblElijaChofer.TabIndex = 0;
            this.lblElijaChofer.Text = "Elija el número de chofer que desea que lo traslade:";
            // 
            // cmbChoferes
            // 
            this.cmbChoferes.FormattingEnabled = true;
            this.cmbChoferes.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbChoferes.Location = new System.Drawing.Point(395, 79);
            this.cmbChoferes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoferes.Name = "cmbChoferes";
            this.cmbChoferes.Size = new System.Drawing.Size(56, 26);
            this.cmbChoferes.TabIndex = 1;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(20, 129);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(392, 18);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Ingrese destino ( \"C\" si va a capital / \"P\" si va a provincia ) :";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(420, 129);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(148, 24);
            this.txtDestino.TabIndex = 3;
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(20, 180);
            this.lblKilometros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(329, 18);
            this.lblKilometros.TabIndex = 4;
            this.lblKilometros.Text = "Ingrese cantidad de kilómetros que va a recorrer:";
            // 
            // lblNombreRemiseria
            // 
            this.lblNombreRemiseria.AutoSize = true;
            this.lblNombreRemiseria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRemiseria.Location = new System.Drawing.Point(13, 19);
            this.lblNombreRemiseria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreRemiseria.Name = "lblNombreRemiseria";
            this.lblNombreRemiseria.Size = new System.Drawing.Size(122, 29);
            this.lblNombreRemiseria.TabIndex = 6;
            this.lblNombreRemiseria.Text = "Don Juan";
            // 
            // lblChoferes
            // 
            this.lblChoferes.AutoSize = true;
            this.lblChoferes.Location = new System.Drawing.Point(654, 30);
            this.lblChoferes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoferes.Name = "lblChoferes";
            this.lblChoferes.Size = new System.Drawing.Size(73, 18);
            this.lblChoferes.TabIndex = 7;
            this.lblChoferes.Text = "Choferes:";
            // 
            // btnCargarViaje
            // 
            this.btnCargarViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarViaje.Location = new System.Drawing.Point(573, 278);
            this.btnCargarViaje.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarViaje.Name = "btnCargarViaje";
            this.btnCargarViaje.Size = new System.Drawing.Size(154, 51);
            this.btnCargarViaje.TabIndex = 8;
            this.btnCargarViaje.Text = "Cargar viaje";
            this.btnCargarViaje.UseVisualStyleBackColor = true;
            this.btnCargarViaje.Click += new System.EventHandler(this.btnCargarViaje_Click);
            // 
            // btnFinDelDia
            // 
            this.btnFinDelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinDelDia.Location = new System.Drawing.Point(751, 278);
            this.btnFinDelDia.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinDelDia.Name = "btnFinDelDia";
            this.btnFinDelDia.Size = new System.Drawing.Size(144, 53);
            this.btnFinDelDia.TabIndex = 9;
            this.btnFinDelDia.Text = "Fin del día";
            this.btnFinDelDia.UseVisualStyleBackColor = true;
            this.btnFinDelDia.Click += new System.EventHandler(this.btnFinDelDia_Click);
            // 
            // nudKilometros
            // 
            this.nudKilometros.DecimalPlaces = 1;
            this.nudKilometros.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudKilometros.Location = new System.Drawing.Point(357, 177);
            this.nudKilometros.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudKilometros.Name = "nudKilometros";
            this.nudKilometros.Size = new System.Drawing.Size(55, 24);
            this.nudKilometros.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(908, 344);
            this.Controls.Add(this.nudKilometros);
            this.Controls.Add(this.btnFinDelDia);
            this.Controls.Add(this.btnCargarViaje);
            this.Controls.Add(this.lblChoferes);
            this.Controls.Add(this.lblNombreRemiseria);
            this.Controls.Add(this.lblKilometros);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cmbChoferes);
            this.Controls.Add(this.lblElijaChofer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Remisería Don Juan";
            ((System.ComponentModel.ISupportInitialize)(this.nudKilometros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElijaChofer;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblNombreRemiseria;
        private System.Windows.Forms.Label lblChoferes;
        private System.Windows.Forms.Button btnCargarViaje;
        private System.Windows.Forms.Button btnFinDelDia;
        private System.Windows.Forms.NumericUpDown nudKilometros;
    }
}

