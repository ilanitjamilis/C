namespace TiendaDeCafe
{
    partial class frmTiendaDeCafe
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
            this.lblBebida = new System.Windows.Forms.Label();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.cmbComida = new System.Windows.Forms.ComboBox();
            this.nudBebida = new System.Windows.Forms.NumericUpDown();
            this.nudComida = new System.Windows.Forms.NumericUpDown();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnIngresosDia = new System.Windows.Forms.Button();
            this.btnGananciasDia = new System.Windows.Forms.Button();
            this.btnGananciasMes = new System.Windows.Forms.Button();
            this.lblMetodoDePago = new System.Windows.Forms.Label();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjetaDebito = new System.Windows.Forms.RadioButton();
            this.rbtTarjetaCredito = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComida)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Location = new System.Drawing.Point(35, 45);
            this.lblBebida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(275, 18);
            this.lblBebida.TabIndex = 0;
            this.lblBebida.Text = "Elija su bebida y la cantidad de la misma:";
            // 
            // cmbBebida
            // 
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Items.AddRange(new object[] {
            "Gaseosa $20",
            "Cafe $15",
            "Te $10"});
            this.cmbBebida.Location = new System.Drawing.Point(330, 45);
            this.cmbBebida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(180, 26);
            this.cmbBebida.TabIndex = 1;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(35, 114);
            this.lblComida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(281, 18);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "Elija su comida y la cantidad de la misma:";
            // 
            // cmbComida
            // 
            this.cmbComida.FormattingEnabled = true;
            this.cmbComida.Items.AddRange(new object[] {
            "Sandwich $40",
            "Tortas $30",
            "Medialunas $8"});
            this.cmbComida.Location = new System.Drawing.Point(330, 114);
            this.cmbComida.Margin = new System.Windows.Forms.Padding(4);
            this.cmbComida.Name = "cmbComida";
            this.cmbComida.Size = new System.Drawing.Size(180, 26);
            this.cmbComida.TabIndex = 3;
            // 
            // nudBebida
            // 
            this.nudBebida.Location = new System.Drawing.Point(533, 47);
            this.nudBebida.Margin = new System.Windows.Forms.Padding(4);
            this.nudBebida.Name = "nudBebida";
            this.nudBebida.Size = new System.Drawing.Size(48, 24);
            this.nudBebida.TabIndex = 4;
            // 
            // nudComida
            // 
            this.nudComida.Location = new System.Drawing.Point(533, 116);
            this.nudComida.Margin = new System.Windows.Forms.Padding(4);
            this.nudComida.Name = "nudComida";
            this.nudComida.Size = new System.Drawing.Size(48, 24);
            this.nudComida.TabIndex = 5;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(814, 237);
            this.btnFinalizarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(174, 47);
            this.btnFinalizarCompra.TabIndex = 6;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnIngresosDia
            // 
            this.btnIngresosDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresosDia.Location = new System.Drawing.Point(13, 311);
            this.btnIngresosDia.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresosDia.Name = "btnIngresosDia";
            this.btnIngresosDia.Size = new System.Drawing.Size(200, 48);
            this.btnIngresosDia.TabIndex = 7;
            this.btnIngresosDia.Text = "Ver ingresos del día";
            this.btnIngresosDia.UseVisualStyleBackColor = true;
            this.btnIngresosDia.Click += new System.EventHandler(this.btnIngresosDia_Click);
            // 
            // btnGananciasDia
            // 
            this.btnGananciasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGananciasDia.Location = new System.Drawing.Point(241, 311);
            this.btnGananciasDia.Margin = new System.Windows.Forms.Padding(4);
            this.btnGananciasDia.Name = "btnGananciasDia";
            this.btnGananciasDia.Size = new System.Drawing.Size(201, 48);
            this.btnGananciasDia.TabIndex = 8;
            this.btnGananciasDia.Text = "Ver ganancias del día";
            this.btnGananciasDia.UseVisualStyleBackColor = true;
            this.btnGananciasDia.Click += new System.EventHandler(this.btnGananciasDia_Click);
            // 
            // btnGananciasMes
            // 
            this.btnGananciasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGananciasMes.Location = new System.Drawing.Point(469, 311);
            this.btnGananciasMes.Margin = new System.Windows.Forms.Padding(4);
            this.btnGananciasMes.Name = "btnGananciasMes";
            this.btnGananciasMes.Size = new System.Drawing.Size(220, 48);
            this.btnGananciasMes.TabIndex = 9;
            this.btnGananciasMes.Text = "Ver ganancias del mes";
            this.btnGananciasMes.UseVisualStyleBackColor = true;
            this.btnGananciasMes.Click += new System.EventHandler(this.btnGananciasMes_Click);
            // 
            // lblMetodoDePago
            // 
            this.lblMetodoDePago.AutoSize = true;
            this.lblMetodoDePago.Location = new System.Drawing.Point(35, 183);
            this.lblMetodoDePago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetodoDePago.Name = "lblMetodoDePago";
            this.lblMetodoDePago.Size = new System.Drawing.Size(359, 18);
            this.lblMetodoDePago.TabIndex = 10;
            this.lblMetodoDePago.Text = "Seleccione el medio por el cual va a pagar la compra:";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Location = new System.Drawing.Point(419, 183);
            this.rbtEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(79, 22);
            this.rbtEfectivo.TabIndex = 11;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjetaDebito
            // 
            this.rbtTarjetaDebito.AutoSize = true;
            this.rbtTarjetaDebito.Location = new System.Drawing.Point(522, 183);
            this.rbtTarjetaDebito.Margin = new System.Windows.Forms.Padding(4);
            this.rbtTarjetaDebito.Name = "rbtTarjetaDebito";
            this.rbtTarjetaDebito.Size = new System.Drawing.Size(135, 22);
            this.rbtTarjetaDebito.TabIndex = 12;
            this.rbtTarjetaDebito.TabStop = true;
            this.rbtTarjetaDebito.Text = "Tarjeta de débito";
            this.rbtTarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // rbtTarjetaCredito
            // 
            this.rbtTarjetaCredito.AutoSize = true;
            this.rbtTarjetaCredito.Location = new System.Drawing.Point(691, 183);
            this.rbtTarjetaCredito.Margin = new System.Windows.Forms.Padding(4);
            this.rbtTarjetaCredito.Name = "rbtTarjetaCredito";
            this.rbtTarjetaCredito.Size = new System.Drawing.Size(140, 22);
            this.rbtTarjetaCredito.TabIndex = 13;
            this.rbtTarjetaCredito.TabStop = true;
            this.rbtTarjetaCredito.Text = "Tarjeta de crédito";
            this.rbtTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // frmTiendaDeCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1001, 387);
            this.Controls.Add(this.rbtTarjetaCredito);
            this.Controls.Add(this.rbtTarjetaDebito);
            this.Controls.Add(this.rbtEfectivo);
            this.Controls.Add(this.lblMetodoDePago);
            this.Controls.Add(this.btnGananciasMes);
            this.Controls.Add(this.btnGananciasDia);
            this.Controls.Add(this.btnIngresosDia);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.nudComida);
            this.Controls.Add(this.nudBebida);
            this.Controls.Add(this.cmbComida);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.cmbBebida);
            this.Controls.Add(this.lblBebida);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTiendaDeCafe";
            this.ShowIcon = false;
            this.Text = "Tienda de café";
            ((System.ComponentModel.ISupportInitialize)(this.nudBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.ComboBox cmbComida;
        private System.Windows.Forms.NumericUpDown nudBebida;
        private System.Windows.Forms.NumericUpDown nudComida;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnIngresosDia;
        private System.Windows.Forms.Button btnGananciasDia;
        private System.Windows.Forms.Button btnGananciasMes;
        private System.Windows.Forms.Label lblMetodoDePago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjetaDebito;
        private System.Windows.Forms.RadioButton rbtTarjetaCredito;
    }
}

