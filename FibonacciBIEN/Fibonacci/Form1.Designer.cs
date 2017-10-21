namespace Fibonacci
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.btnHastaNumero = new System.Windows.Forms.Button();
            this.btnSiEsta = new System.Windows.Forms.Button();
            this.btnVeces = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(13, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(114, 18);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Elija un número:";
            // 
            // nudNumero
            // 
            this.nudNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero.Location = new System.Drawing.Point(133, 11);
            this.nudNumero.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(61, 24);
            this.nudNumero.TabIndex = 1;
            // 
            // btnHastaNumero
            // 
            this.btnHastaNumero.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnHastaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaNumero.Location = new System.Drawing.Point(178, 77);
            this.btnHastaNumero.Name = "btnHastaNumero";
            this.btnHastaNumero.Size = new System.Drawing.Size(118, 109);
            this.btnHastaNumero.TabIndex = 2;
            this.btnHastaNumero.Text = "Mostrar Fibonacci hasta número elegido";
            this.btnHastaNumero.UseVisualStyleBackColor = false;
            this.btnHastaNumero.Click += new System.EventHandler(this.btnHastaNumero_Click);
            // 
            // btnSiEsta
            // 
            this.btnSiEsta.BackColor = System.Drawing.Color.Khaki;
            this.btnSiEsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiEsta.Location = new System.Drawing.Point(331, 77);
            this.btnSiEsta.Name = "btnSiEsta";
            this.btnSiEsta.Size = new System.Drawing.Size(126, 109);
            this.btnSiEsta.TabIndex = 3;
            this.btnSiEsta.Text = "Mostrar si el número elegido está en Fibonacci";
            this.btnSiEsta.UseVisualStyleBackColor = false;
            this.btnSiEsta.Click += new System.EventHandler(this.btnSiEsta_Click);
            // 
            // btnVeces
            // 
            this.btnVeces.BackColor = System.Drawing.Color.Tomato;
            this.btnVeces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeces.ForeColor = System.Drawing.Color.Black;
            this.btnVeces.Location = new System.Drawing.Point(16, 77);
            this.btnVeces.Name = "btnVeces";
            this.btnVeces.Size = new System.Drawing.Size(122, 109);
            this.btnVeces.TabIndex = 4;
            this.btnVeces.Text = "Mostrar Fibonacci veces número elegido";
            this.btnVeces.UseVisualStyleBackColor = false;
            this.btnVeces.Click += new System.EventHandler(this.btnVeces_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(469, 198);
            this.Controls.Add(this.btnVeces);
            this.Controls.Add(this.btnSiEsta);
            this.Controls.Add(this.btnHastaNumero);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.lblNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.Button btnHastaNumero;
        private System.Windows.Forms.Button btnSiEsta;
        private System.Windows.Forms.Button btnVeces;
    }
}

