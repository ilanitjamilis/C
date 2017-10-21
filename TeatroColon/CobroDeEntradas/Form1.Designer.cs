namespace CobroDeEntradas
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
            this.lblIngreseEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.btnTotalCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngreseEdad
            // 
            this.lblIngreseEdad.AutoSize = true;
            this.lblIngreseEdad.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseEdad.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblIngreseEdad.Location = new System.Drawing.Point(51, 112);
            this.lblIngreseEdad.Name = "lblIngreseEdad";
            this.lblIngreseEdad.Size = new System.Drawing.Size(232, 43);
            this.lblIngreseEdad.TabIndex = 5;
            this.lblIngreseEdad.Text = "Ingrese su edad:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSexo.Location = new System.Drawing.Point(42, 273);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(264, 43);
            this.lblSexo.TabIndex = 7;
            this.lblSexo.Text = "Seleccione su sexo:";
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemenino.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbtFemenino.Location = new System.Drawing.Point(304, 276);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(139, 40);
            this.rbtFemenino.TabIndex = 8;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rbtMasculino.Location = new System.Drawing.Point(463, 276);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(148, 40);
            this.rbtMasculino.TabIndex = 9;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(335, 131);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(160, 20);
            this.nudEdad.TabIndex = 10;
            // 
            // btnTotalCompra
            // 
            this.btnTotalCompra.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnTotalCompra.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalCompra.ForeColor = System.Drawing.Color.Maroon;
            this.btnTotalCompra.Location = new System.Drawing.Point(519, 383);
            this.btnTotalCompra.Name = "btnTotalCompra";
            this.btnTotalCompra.Size = new System.Drawing.Size(461, 81);
            this.btnTotalCompra.TabIndex = 11;
            this.btnTotalCompra.Text = "Mostrar el valor de tu entrada";
            this.btnTotalCompra.UseVisualStyleBackColor = false;
            this.btnTotalCompra.Click += new System.EventHandler(this.btnTotalCompra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1010, 511);
            this.Controls.Add(this.btnTotalCompra);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblIngreseEdad);
            this.Name = "Form1";
            this.Text = "Compra de entradas para el Teatro Colon";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Button btnTotalCompra;

    }
}

