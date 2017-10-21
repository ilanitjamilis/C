namespace Examen2doTrimestreVectores_IlanitJamilis
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
            this.lblAmazonas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudPuntos = new System.Windows.Forms.NumericUpDown();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnCargarJugador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmazonas
            // 
            this.lblAmazonas.AutoSize = true;
            this.lblAmazonas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmazonas.Location = new System.Drawing.Point(382, 9);
            this.lblAmazonas.Name = "lblAmazonas";
            this.lblAmazonas.Size = new System.Drawing.Size(224, 22);
            this.lblAmazonas.TabIndex = 0;
            this.lblAmazonas.Text = "Amazonas Basket Club";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(10, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(164, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ingrese nombre del jugador:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(12, 55);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(220, 20);
            this.lblPuntos.TabIndex = 2;
            this.lblPuntos.Text = "Ingrese cantidad de puntos marcados:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(180, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 25);
            this.txtNombre.TabIndex = 3;
            // 
            // nudPuntos
            // 
            this.nudPuntos.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPuntos.Location = new System.Drawing.Point(238, 52);
            this.nudPuntos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPuntos.Name = "nudPuntos";
            this.nudPuntos.Size = new System.Drawing.Size(120, 25);
            this.nudPuntos.TabIndex = 4;
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInfo.Location = new System.Drawing.Point(432, 136);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(174, 42);
            this.btnVerInfo.TabIndex = 5;
            this.btnVerInfo.Text = "Ver informacion";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // btnCargarJugador
            // 
            this.btnCargarJugador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarJugador.Location = new System.Drawing.Point(363, 81);
            this.btnCargarJugador.Name = "btnCargarJugador";
            this.btnCargarJugador.Size = new System.Drawing.Size(139, 39);
            this.btnCargarJugador.TabIndex = 6;
            this.btnCargarJugador.Text = "Cargar jugador";
            this.btnCargarJugador.UseVisualStyleBackColor = true;
            this.btnCargarJugador.Click += new System.EventHandler(this.btnCargarJugador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(612, 183);
            this.Controls.Add(this.btnCargarJugador);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.nudPuntos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAmazonas);
            this.Name = "Form1";
            this.Text = "Examen 2do Trimestre Vectores";
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmazonas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudPuntos;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnCargarJugador;
    }
}

