namespace TransporteUrbano
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblMontoAbonado = new System.Windows.Forms.Label();
            this.lblLineaDeColectivo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudSaldo = new System.Windows.Forms.NumericUpDown();
            this.nudMontoAbonado = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVerInformacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudColectivo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtApellidoSaldo = new System.Windows.Forms.TextBox();
            this.txtNombreSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtSaldo = new System.Windows.Forms.RadioButton();
            this.rbtViaje = new System.Windows.Forms.RadioButton();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldoCargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoAbonado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColectivo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(6, 86);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(49, 17);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(5, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblMontoAbonado
            // 
            this.lblMontoAbonado.AutoSize = true;
            this.lblMontoAbonado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonado.Location = new System.Drawing.Point(6, 137);
            this.lblMontoAbonado.Name = "lblMontoAbonado";
            this.lblMontoAbonado.Size = new System.Drawing.Size(116, 17);
            this.lblMontoAbonado.TabIndex = 3;
            this.lblMontoAbonado.Text = "Monto a abonar: ";
            // 
            // lblLineaDeColectivo
            // 
            this.lblLineaDeColectivo.AutoSize = true;
            this.lblLineaDeColectivo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineaDeColectivo.Location = new System.Drawing.Point(6, 100);
            this.lblLineaDeColectivo.Name = "lblLineaDeColectivo";
            this.lblLineaDeColectivo.Size = new System.Drawing.Size(132, 17);
            this.lblLineaDeColectivo.TabIndex = 4;
            this.lblLineaDeColectivo.Text = "Línea de colectivo: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(77, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 25);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(75, 63);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 25);
            this.txtApellido.TabIndex = 7;
            // 
            // nudSaldo
            // 
            this.nudSaldo.DecimalPlaces = 2;
            this.nudSaldo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSaldo.Location = new System.Drawing.Point(79, 84);
            this.nudSaldo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSaldo.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudSaldo.Name = "nudSaldo";
            this.nudSaldo.Size = new System.Drawing.Size(72, 25);
            this.nudSaldo.TabIndex = 8;
            // 
            // nudMontoAbonado
            // 
            this.nudMontoAbonado.DecimalPlaces = 2;
            this.nudMontoAbonado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMontoAbonado.Location = new System.Drawing.Point(140, 137);
            this.nudMontoAbonado.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMontoAbonado.Name = "nudMontoAbonado";
            this.nudMontoAbonado.Size = new System.Drawing.Size(56, 25);
            this.nudMontoAbonado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "$";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(1157, 201);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(114, 36);
            this.btnCargar.TabIndex = 17;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargarViaje_Click);
            // 
            // btnVerInformacion
            // 
            this.btnVerInformacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInformacion.Location = new System.Drawing.Point(1139, 245);
            this.btnVerInformacion.Name = "btnVerInformacion";
            this.btnVerInformacion.Size = new System.Drawing.Size(132, 33);
            this.btnVerInformacion.TabIndex = 18;
            this.btnVerInformacion.Text = "Ver información";
            this.btnVerInformacion.UseVisualStyleBackColor = true;
            this.btnVerInformacion.Click += new System.EventHandler(this.btnVerInformacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransporteUrbano.Properties.Resources.logoSube;
            this.pictureBox1.Location = new System.Drawing.Point(1068, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 131);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // nudColectivo
            // 
            this.nudColectivo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudColectivo.Location = new System.Drawing.Point(143, 100);
            this.nudColectivo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudColectivo.Name = "nudColectivo";
            this.nudColectivo.Size = new System.Drawing.Size(56, 25);
            this.nudColectivo.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLineaDeColectivo);
            this.groupBox1.Controls.Add(this.nudColectivo);
            this.groupBox1.Controls.Add(this.lblMontoAbonado);
            this.groupBox1.Controls.Add(this.nudMontoAbonado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 170);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para cargar un viaje ingrese los siguientes datos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtApellidoSaldo);
            this.groupBox2.Controls.Add(this.nudSaldo);
            this.groupBox2.Controls.Add(this.txtNombreSaldo);
            this.groupBox2.Controls.Add(this.lblSaldo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(351, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 131);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para cargar saldo ingrese los siguientes datos:";
            // 
            // txtApellidoSaldo
            // 
            this.txtApellidoSaldo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoSaldo.Location = new System.Drawing.Point(77, 52);
            this.txtApellidoSaldo.Name = "txtApellidoSaldo";
            this.txtApellidoSaldo.Size = new System.Drawing.Size(165, 25);
            this.txtApellidoSaldo.TabIndex = 28;
            // 
            // txtNombreSaldo
            // 
            this.txtNombreSaldo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSaldo.Location = new System.Drawing.Point(79, 21);
            this.txtNombreSaldo.Name = "txtNombreSaldo";
            this.txtNombreSaldo.Size = new System.Drawing.Size(119, 25);
            this.txtNombreSaldo.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nombre: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtSaldo);
            this.groupBox3.Controls.Add(this.rbtViaje);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 79);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elija la operación que va a realizar:";
            // 
            // rbtSaldo
            // 
            this.rbtSaldo.AutoSize = true;
            this.rbtSaldo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSaldo.Location = new System.Drawing.Point(363, 33);
            this.rbtSaldo.Name = "rbtSaldo";
            this.rbtSaldo.Size = new System.Drawing.Size(157, 28);
            this.rbtSaldo.TabIndex = 1;
            this.rbtSaldo.TabStop = true;
            this.rbtSaldo.Text = "Cargar saldo";
            this.rbtSaldo.UseVisualStyleBackColor = true;
            // 
            // rbtViaje
            // 
            this.rbtViaje.AutoSize = true;
            this.rbtViaje.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtViaje.Location = new System.Drawing.Point(179, 33);
            this.rbtViaje.Name = "rbtViaje";
            this.rbtViaje.Size = new System.Drawing.Size(149, 28);
            this.rbtViaje.TabIndex = 0;
            this.rbtViaje.TabStop = true;
            this.rbtViaje.Text = "Cargar viaje";
            this.rbtViaje.UseVisualStyleBackColor = true;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.colApellido,
            this.ColSaldoCargado});
            this.dgvGrilla.Location = new System.Drawing.Point(685, 29);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(344, 195);
            this.dgvGrilla.TabIndex = 29;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // ColSaldoCargado
            // 
            this.ColSaldoCargado.HeaderText = "Saldo Cargado";
            this.ColSaldoCargado.Name = "ColSaldoCargado";
            this.ColSaldoCargado.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 293);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerInformacion);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Transporte Urbano";
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoAbonado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColectivo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblMontoAbonado;
        private System.Windows.Forms.Label lblLineaDeColectivo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudSaldo;
        private System.Windows.Forms.NumericUpDown nudMontoAbonado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVerInformacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudColectivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtApellidoSaldo;
        private System.Windows.Forms.TextBox txtNombreSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtSaldo;
        private System.Windows.Forms.RadioButton rbtViaje;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldoCargado;
    }
}

