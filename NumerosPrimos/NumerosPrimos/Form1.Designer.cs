namespace NumerosPrimos
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
            this.lblNum = new System.Windows.Forms.Label();
            this.nudNum = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(12, 24);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(154, 24);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Ingresar número:";
            // 
            // nudNum
            // 
            this.nudNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNum.Location = new System.Drawing.Point(172, 22);
            this.nudNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNum.Name = "nudNum";
            this.nudNum.Size = new System.Drawing.Size(56, 29);
            this.nudNum.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(245, 81);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 40);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 150);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nudNum);
            this.Controls.Add(this.lblNum);
            this.Name = "Form1";
            this.Text = "Numeros Primos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.NumericUpDown nudNum;
        private System.Windows.Forms.Button btnAceptar;
    }
}

