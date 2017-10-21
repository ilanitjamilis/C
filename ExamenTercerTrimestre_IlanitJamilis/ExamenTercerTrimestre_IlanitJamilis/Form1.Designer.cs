namespace ExamenTercerTrimestre_IlanitJamilis
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVerInformacion = new System.Windows.Forms.Button();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.nudCantCanciones = new System.Windows.Forms.NumericUpDown();
            this.nudCantReproducciones = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantReproducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artista: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spotify";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de reproducciones: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de canciones: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Album: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(191, 170);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 38);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVerInformacion
            // 
            this.btnVerInformacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInformacion.Location = new System.Drawing.Point(166, 215);
            this.btnVerInformacion.Name = "btnVerInformacion";
            this.btnVerInformacion.Size = new System.Drawing.Size(146, 38);
            this.btnVerInformacion.TabIndex = 6;
            this.btnVerInformacion.Text = "Ver información";
            this.btnVerInformacion.UseVisualStyleBackColor = true;
            this.btnVerInformacion.Click += new System.EventHandler(this.btnVerInformacion_Click);
            // 
            // txtArtista
            // 
            this.txtArtista.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtista.Location = new System.Drawing.Point(66, 37);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(154, 25);
            this.txtArtista.TabIndex = 8;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbum.Location = new System.Drawing.Point(65, 67);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(205, 25);
            this.txtAlbum.TabIndex = 9;
            // 
            // nudCantCanciones
            // 
            this.nudCantCanciones.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantCanciones.Location = new System.Drawing.Point(181, 97);
            this.nudCantCanciones.Name = "nudCantCanciones";
            this.nudCantCanciones.Size = new System.Drawing.Size(51, 25);
            this.nudCantCanciones.TabIndex = 10;
            // 
            // nudCantReproducciones
            // 
            this.nudCantReproducciones.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantReproducciones.Location = new System.Drawing.Point(216, 125);
            this.nudCantReproducciones.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCantReproducciones.Name = "nudCantReproducciones";
            this.nudCantReproducciones.Size = new System.Drawing.Size(76, 25);
            this.nudCantReproducciones.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(321, 262);
            this.Controls.Add(this.nudCantReproducciones);
            this.Controls.Add(this.nudCantCanciones);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.btnVerInformacion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Spotify";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantReproducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVerInformacion;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.NumericUpDown nudCantCanciones;
        private System.Windows.Forms.NumericUpDown nudCantReproducciones;
    }
}

