namespace Aeropuertos_Argentina_20._000
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
            this.lblNumVuelo = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblFechaDePartida = new System.Windows.Forms.Label();
            this.lblAerolinea = new System.Windows.Forms.Label();
            this.lblNumPuerta = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantPasajeros = new System.Windows.Forms.Label();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.txtNumVuelo = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.dtpPartida = new System.Windows.Forms.DateTimePicker();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.nudPuerta = new System.Windows.Forms.NumericUpDown();
            this.nudPasaje = new System.Windows.Forms.NumericUpDown();
            this.nudCantPasajeros = new System.Windows.Forms.NumericUpDown();
            this.btnCargarVuelo = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumVuelo
            // 
            this.lblNumVuelo.AutoSize = true;
            this.lblNumVuelo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVuelo.Location = new System.Drawing.Point(11, 37);
            this.lblNumVuelo.Name = "lblNumVuelo";
            this.lblNumVuelo.Size = new System.Drawing.Size(133, 23);
            this.lblNumVuelo.TabIndex = 1;
            this.lblNumVuelo.Text = "Número de vuelo:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(11, 76);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(61, 23);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(11, 109);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(66, 23);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino:";
            // 
            // lblFechaDePartida
            // 
            this.lblFechaDePartida.AutoSize = true;
            this.lblFechaDePartida.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDePartida.Location = new System.Drawing.Point(12, 149);
            this.lblFechaDePartida.Name = "lblFechaDePartida";
            this.lblFechaDePartida.Size = new System.Drawing.Size(132, 23);
            this.lblFechaDePartida.TabIndex = 4;
            this.lblFechaDePartida.Text = "Fecha de partida:";
            // 
            // lblAerolinea
            // 
            this.lblAerolinea.AutoSize = true;
            this.lblAerolinea.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAerolinea.Location = new System.Drawing.Point(12, 182);
            this.lblAerolinea.Name = "lblAerolinea";
            this.lblAerolinea.Size = new System.Drawing.Size(80, 23);
            this.lblAerolinea.TabIndex = 5;
            this.lblAerolinea.Text = "Aerolinea:";
            // 
            // lblNumPuerta
            // 
            this.lblNumPuerta.AutoSize = true;
            this.lblNumPuerta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPuerta.Location = new System.Drawing.Point(12, 217);
            this.lblNumPuerta.Name = "lblNumPuerta";
            this.lblNumPuerta.Size = new System.Drawing.Size(140, 23);
            this.lblNumPuerta.TabIndex = 6;
            this.lblNumPuerta.Text = "Número de puerta:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 255);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(136, 23);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio por pasaje:";
            // 
            // lblCantPasajeros
            // 
            this.lblCantPasajeros.AutoSize = true;
            this.lblCantPasajeros.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPasajeros.Location = new System.Drawing.Point(12, 294);
            this.lblCantPasajeros.Name = "lblCantPasajeros";
            this.lblCantPasajeros.Size = new System.Drawing.Size(171, 23);
            this.lblCantPasajeros.TabIndex = 8;
            this.lblCantPasajeros.Text = "Cantidad de pasajeros:";
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.Location = new System.Drawing.Point(3, 5);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(269, 20);
            this.lblIngrese.TabIndex = 9;
            this.lblIngrese.Text = "De cada vuelo ingrese los siguientes datos";
            // 
            // txtNumVuelo
            // 
            this.txtNumVuelo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumVuelo.Location = new System.Drawing.Point(151, 37);
            this.txtNumVuelo.Name = "txtNumVuelo";
            this.txtNumVuelo.Size = new System.Drawing.Size(100, 29);
            this.txtNumVuelo.TabIndex = 10;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(84, 73);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(236, 29);
            this.txtOrigen.TabIndex = 11;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(84, 109);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(236, 29);
            this.txtDestino.TabIndex = 12;
            // 
            // dtpPartida
            // 
            this.dtpPartida.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPartida.Location = new System.Drawing.Point(151, 146);
            this.dtpPartida.Name = "dtpPartida";
            this.dtpPartida.Size = new System.Drawing.Size(289, 29);
            this.dtpPartida.TabIndex = 13;
            this.dtpPartida.Value = new System.DateTime(2015, 8, 26, 0, 0, 0, 0);
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAerolinea.Location = new System.Drawing.Point(98, 179);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(167, 29);
            this.txtAerolinea.TabIndex = 14;
            // 
            // nudPuerta
            // 
            this.nudPuerta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPuerta.Location = new System.Drawing.Point(158, 217);
            this.nudPuerta.Name = "nudPuerta";
            this.nudPuerta.Size = new System.Drawing.Size(54, 29);
            this.nudPuerta.TabIndex = 15;
            // 
            // nudPasaje
            // 
            this.nudPasaje.DecimalPlaces = 2;
            this.nudPasaje.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPasaje.Location = new System.Drawing.Point(151, 255);
            this.nudPasaje.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudPasaje.Name = "nudPasaje";
            this.nudPasaje.Size = new System.Drawing.Size(132, 29);
            this.nudPasaje.TabIndex = 16;
            // 
            // nudCantPasajeros
            // 
            this.nudCantPasajeros.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantPasajeros.Location = new System.Drawing.Point(189, 292);
            this.nudCantPasajeros.Name = "nudCantPasajeros";
            this.nudCantPasajeros.Size = new System.Drawing.Size(76, 29);
            this.nudCantPasajeros.TabIndex = 17;
            // 
            // btnCargarVuelo
            // 
            this.btnCargarVuelo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVuelo.Location = new System.Drawing.Point(354, 234);
            this.btnCargarVuelo.Name = "btnCargarVuelo";
            this.btnCargarVuelo.Size = new System.Drawing.Size(153, 44);
            this.btnCargarVuelo.TabIndex = 18;
            this.btnCargarVuelo.Text = "Cargar vuelo";
            this.btnCargarVuelo.UseVisualStyleBackColor = true;
            this.btnCargarVuelo.Click += new System.EventHandler(this.btnCargarVuelo_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(316, 294);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(191, 38);
            this.btnInfo.TabIndex = 19;
            this.btnInfo.Text = "Ver informacion";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aeropuertos_Argentina_20._000.Properties.Resources._0010236437;
            this.pictureBox1.Location = new System.Drawing.Point(513, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCargarVuelo);
            this.Controls.Add(this.nudCantPasajeros);
            this.Controls.Add(this.nudPasaje);
            this.Controls.Add(this.nudPuerta);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.dtpPartida);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtNumVuelo);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.lblCantPasajeros);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNumPuerta);
            this.Controls.Add(this.lblAerolinea);
            this.Controls.Add(this.lblFechaDePartida);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblNumVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Aeropuertos Argentina 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPuerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumVuelo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblFechaDePartida;
        private System.Windows.Forms.Label lblAerolinea;
        private System.Windows.Forms.Label lblNumPuerta;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantPasajeros;
        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.TextBox txtNumVuelo;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.DateTimePicker dtpPartida;
        private System.Windows.Forms.TextBox txtAerolinea;
        private System.Windows.Forms.NumericUpDown nudPuerta;
        private System.Windows.Forms.NumericUpDown nudPasaje;
        private System.Windows.Forms.NumericUpDown nudCantPasajeros;
        private System.Windows.Forms.Button btnCargarVuelo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

