namespace Garbarino
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblMetodoDePago = new System.Windows.Forms.Label();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjetaSantander = new System.Windows.Forms.RadioButton();
            this.rbtTarjetaGarbarino = new System.Windows.Forms.RadioButton();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.nudCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnInformacionGarbarino = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblGarbarino = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCarrito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProducto.Location = new System.Drawing.Point(28, 102);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(184, 18);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Elija producto a comprar:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProductos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductos.ForeColor = System.Drawing.Color.Crimson;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Items.AddRange(new object[] {
            "Notebook Toshiba",
            "Telefono Samsung S3 Mini",
            "Microondas Dream",
            "Televisor Samsung LED 32´"});
            this.cmbProductos.Location = new System.Drawing.Point(229, 99);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(222, 26);
            this.cmbProductos.TabIndex = 1;
            // 
            // lblMetodoDePago
            // 
            this.lblMetodoDePago.AutoSize = true;
            this.lblMetodoDePago.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoDePago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMetodoDePago.Location = new System.Drawing.Point(28, 229);
            this.lblMetodoDePago.Name = "lblMetodoDePago";
            this.lblMetodoDePago.Size = new System.Drawing.Size(230, 18);
            this.lblMetodoDePago.TabIndex = 2;
            this.lblMetodoDePago.Text = "Seleccione su método de pago:";
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEfectivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtEfectivo.Location = new System.Drawing.Point(275, 229);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(85, 22);
            this.rbtEfectivo.TabIndex = 3;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTarjetaSantander
            // 
            this.rbtTarjetaSantander.AutoSize = true;
            this.rbtTarjetaSantander.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTarjetaSantander.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtTarjetaSantander.Location = new System.Drawing.Point(375, 229);
            this.rbtTarjetaSantander.Name = "rbtTarjetaSantander";
            this.rbtTarjetaSantander.Size = new System.Drawing.Size(180, 22);
            this.rbtTarjetaSantander.TabIndex = 4;
            this.rbtTarjetaSantander.TabStop = true;
            this.rbtTarjetaSantander.Text = "Tarjeta Santander Rio";
            this.rbtTarjetaSantander.UseVisualStyleBackColor = true;
            // 
            // rbtTarjetaGarbarino
            // 
            this.rbtTarjetaGarbarino.AutoSize = true;
            this.rbtTarjetaGarbarino.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTarjetaGarbarino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtTarjetaGarbarino.Location = new System.Drawing.Point(570, 229);
            this.rbtTarjetaGarbarino.Name = "rbtTarjetaGarbarino";
            this.rbtTarjetaGarbarino.Size = new System.Drawing.Size(217, 22);
            this.rbtTarjetaGarbarino.TabIndex = 5;
            this.rbtTarjetaGarbarino.TabStop = true;
            this.rbtTarjetaGarbarino.Text = "Tarjeta Garbarino Discount";
            this.rbtTarjetaGarbarino.UseVisualStyleBackColor = true;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidadProducto.Location = new System.Drawing.Point(28, 164);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(408, 18);
            this.lblCantidadProducto.TabIndex = 6;
            this.lblCantidadProducto.Text = "Elija la cantidad del producto elejido que desea comprar:";
            // 
            // nudCantidadProducto
            // 
            this.nudCantidadProducto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadProducto.ForeColor = System.Drawing.Color.Crimson;
            this.nudCantidadProducto.Location = new System.Drawing.Point(453, 162);
            this.nudCantidadProducto.Name = "nudCantidadProducto";
            this.nudCantidadProducto.Size = new System.Drawing.Size(44, 25);
            this.nudCantidadProducto.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Crimson;
            this.btnGuardar.Location = new System.Drawing.Point(117, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(364, 33);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Agregar al carrito y continuar con la compra";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.Crimson;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(519, 295);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(160, 32);
            this.btnFinalizarCompra.TabIndex = 9;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnInformacionGarbarino
            // 
            this.btnInformacionGarbarino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacionGarbarino.ForeColor = System.Drawing.Color.Crimson;
            this.btnInformacionGarbarino.Location = new System.Drawing.Point(715, 295);
            this.btnInformacionGarbarino.Name = "btnInformacionGarbarino";
            this.btnInformacionGarbarino.Size = new System.Drawing.Size(154, 32);
            this.btnInformacionGarbarino.TabIndex = 10;
            this.btnInformacionGarbarino.Text = "Ver información";
            this.btnInformacionGarbarino.UseVisualStyleBackColor = true;
            this.btnInformacionGarbarino.Click += new System.EventHandler(this.btnInformacionGarbarino_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCarrito.Location = new System.Drawing.Point(464, 9);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(140, 15);
            this.lblCarrito.TabIndex = 11;
            this.lblCarrito.Text = "Productos en el carrito:";
            this.lblCarrito.Visible = false;
            // 
            // lblGarbarino
            // 
            this.lblGarbarino.AutoSize = true;
            this.lblGarbarino.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarbarino.Location = new System.Drawing.Point(12, 358);
            this.lblGarbarino.Name = "lblGarbarino";
            this.lblGarbarino.Size = new System.Drawing.Size(543, 15);
            this.lblGarbarino.TabIndex = 12;
            this.lblGarbarino.Text = "El uso de esta aplicación implica la aceptación de los Términos y Condiciones y d" +
    "e las Políticas de Privacidad de Garbarino S.A.";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(24, 23);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(196, 42);
            this.lblLogo.TabIndex = 14;
            this.lblLogo.Text = "Garbarino";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(728, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Visible = false;
            // 
            // btnCarrito
            // 
            this.btnCarrito.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.ForeColor = System.Drawing.Color.Crimson;
            this.btnCarrito.Location = new System.Drawing.Point(760, 140);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(120, 67);
            this.btnCarrito.TabIndex = 16;
            this.btnCarrito.Text = "Ver / ocultar carrito de compras";
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(892, 380);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblGarbarino);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnInformacionGarbarino);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudCantidadProducto);
            this.Controls.Add(this.lblCantidadProducto);
            this.Controls.Add(this.rbtTarjetaGarbarino);
            this.Controls.Add(this.rbtTarjetaSantander);
            this.Controls.Add(this.rbtEfectivo);
            this.Controls.Add(this.lblMetodoDePago);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.lblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Garbarino. Garantía de confianza.";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblMetodoDePago;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjetaSantander;
        private System.Windows.Forms.RadioButton rbtTarjetaGarbarino;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.NumericUpDown nudCantidadProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnInformacionGarbarino;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblGarbarino;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCarrito;
    }
}

