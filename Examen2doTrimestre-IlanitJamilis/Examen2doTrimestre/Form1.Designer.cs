namespace Examen2doTrimestre
{
    partial class Examen2doTrimestre
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnCantPalabras = new System.Windows.Forms.Button();
            this.btnCantPalabrasImpares = new System.Windows.Forms.Button();
            this.btnCantNumeros = new System.Windows.Forms.Button();
            this.btnNumerosPrimos = new System.Windows.Forms.Button();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(16, 24);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(135, 23);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Ingrese una frase:";
            // 
            // txtFrase
            // 
            this.txtFrase.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrase.Location = new System.Drawing.Point(157, 24);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(654, 29);
            this.txtFrase.TabIndex = 1;
            // 
            // btnCantPalabras
            // 
            this.btnCantPalabras.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantPalabras.Location = new System.Drawing.Point(12, 152);
            this.btnCantPalabras.Name = "btnCantPalabras";
            this.btnCantPalabras.Size = new System.Drawing.Size(191, 87);
            this.btnCantPalabras.TabIndex = 2;
            this.btnCantPalabras.Text = "Ver cantidad de palabras";
            this.btnCantPalabras.UseVisualStyleBackColor = true;
            this.btnCantPalabras.Click += new System.EventHandler(this.btnCantPalabras_Click);
            // 
            // btnCantPalabrasImpares
            // 
            this.btnCantPalabrasImpares.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantPalabrasImpares.Location = new System.Drawing.Point(215, 152);
            this.btnCantPalabrasImpares.Name = "btnCantPalabrasImpares";
            this.btnCantPalabrasImpares.Size = new System.Drawing.Size(191, 87);
            this.btnCantPalabrasImpares.TabIndex = 3;
            this.btnCantPalabrasImpares.Text = "Ver cantidad de palabras impares";
            this.btnCantPalabrasImpares.UseVisualStyleBackColor = true;
            this.btnCantPalabrasImpares.Click += new System.EventHandler(this.btnCantPalabrasImpares_Click);
            // 
            // btnCantNumeros
            // 
            this.btnCantNumeros.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantNumeros.Location = new System.Drawing.Point(420, 153);
            this.btnCantNumeros.Name = "btnCantNumeros";
            this.btnCantNumeros.Size = new System.Drawing.Size(191, 86);
            this.btnCantNumeros.TabIndex = 4;
            this.btnCantNumeros.Text = "Ver cantidad de números ingresados en el textBox";
            this.btnCantNumeros.UseVisualStyleBackColor = true;
            this.btnCantNumeros.Click += new System.EventHandler(this.btnCantNumeros_Click);
            // 
            // btnNumerosPrimos
            // 
            this.btnNumerosPrimos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumerosPrimos.Location = new System.Drawing.Point(620, 151);
            this.btnNumerosPrimos.Name = "btnNumerosPrimos";
            this.btnNumerosPrimos.Size = new System.Drawing.Size(191, 88);
            this.btnNumerosPrimos.TabIndex = 5;
            this.btnNumerosPrimos.Text = "Ver números primos entre los dos ingresados";
            this.btnNumerosPrimos.UseVisualStyleBackColor = true;
            this.btnNumerosPrimos.Click += new System.EventHandler(this.btnNumerosPrimos_Click);
            // 
            // nud2
            // 
            this.nud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud2.Location = new System.Drawing.Point(439, 86);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 31);
            this.nud2.TabIndex = 6;
            // 
            // nud1
            // 
            this.nud1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud1.Location = new System.Drawing.Point(302, 86);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 31);
            this.nud1.TabIndex = 7;
            // 
            // Examen2doTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 251);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.btnNumerosPrimos);
            this.Controls.Add(this.btnCantNumeros);
            this.Controls.Add(this.btnCantPalabrasImpares);
            this.Controls.Add(this.btnCantPalabras);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblFrase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Examen2doTrimestre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen 2do Trimestre - Ilanit Jamilis 4ºIB 2015";
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnCantPalabras;
        private System.Windows.Forms.Button btnCantPalabrasImpares;
        private System.Windows.Forms.Button btnCantNumeros;
        private System.Windows.Forms.Button btnNumerosPrimos;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud1;
    }
}

