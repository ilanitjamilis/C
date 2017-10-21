namespace NumerosRomanos
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
            this.lblNumeroDecimal = new System.Windows.Forms.Label();
            this.txtNumeroDecimal = new System.Windows.Forms.TextBox();
            this.lblNumeroR = new System.Windows.Forms.Label();
            this.lblNumeroRomano = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroDecimal
            // 
            this.lblNumeroDecimal.AutoSize = true;
            this.lblNumeroDecimal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDecimal.Location = new System.Drawing.Point(12, 19);
            this.lblNumeroDecimal.Name = "lblNumeroDecimal";
            this.lblNumeroDecimal.Size = new System.Drawing.Size(180, 16);
            this.lblNumeroDecimal.TabIndex = 0;
            this.lblNumeroDecimal.Text = "Ingrese un número en base decimal:";
            // 
            // txtNumeroDecimal
            // 
            this.txtNumeroDecimal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDecimal.Location = new System.Drawing.Point(211, 19);
            this.txtNumeroDecimal.Name = "txtNumeroDecimal";
            this.txtNumeroDecimal.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroDecimal.TabIndex = 1;
            // 
            // lblNumeroR
            // 
            this.lblNumeroR.AutoSize = true;
            this.lblNumeroR.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroR.Location = new System.Drawing.Point(12, 69);
            this.lblNumeroR.Name = "lblNumeroR";
            this.lblNumeroR.Size = new System.Drawing.Size(177, 16);
            this.lblNumeroR.TabIndex = 2;
            this.lblNumeroR.Text = "El número ingresado en romano es:";
            // 
            // lblNumeroRomano
            // 
            this.lblNumeroRomano.AutoSize = true;
            this.lblNumeroRomano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRomano.Location = new System.Drawing.Point(207, 69);
            this.lblNumeroRomano.Name = "lblNumeroRomano";
            this.lblNumeroRomano.Size = new System.Drawing.Size(0, 19);
            this.lblNumeroRomano.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(267, 112);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 157);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumeroRomano);
            this.Controls.Add(this.lblNumeroR);
            this.Controls.Add(this.txtNumeroDecimal);
            this.Controls.Add(this.lblNumeroDecimal);
            this.Name = "Form1";
            this.Text = "Conversion a numeros romanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroDecimal;
        private System.Windows.Forms.TextBox txtNumeroDecimal;
        private System.Windows.Forms.Label lblNumeroR;
        private System.Windows.Forms.Label lblNumeroRomano;
        private System.Windows.Forms.Button btnAceptar;
    }
}

