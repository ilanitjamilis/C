namespace Notas
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
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNota
            // 
            this.nudNota.BackColor = System.Drawing.Color.RoyalBlue;
            this.nudNota.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNota.ForeColor = System.Drawing.SystemColors.Window;
            this.nudNota.Location = new System.Drawing.Point(232, 53);
            this.nudNota.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(60, 38);
            this.nudNota.TabIndex = 0;
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInformacion.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInformacion.Location = new System.Drawing.Point(232, 250);
            this.btnInformacion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(644, 59);
            this.btnInformacion.TabIndex = 1;
            this.btnInformacion.Text = "Ver información sobre alumnos aprobados";
            this.btnInformacion.UseVisualStyleBackColor = false;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardarNota.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNota.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardarNota.Location = new System.Drawing.Point(434, 167);
            this.btnGuardarNota.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(442, 59);
            this.btnGuardarNota.TabIndex = 2;
            this.btnGuardarNota.Text = "Guardar nota / ver promedio";
            this.btnGuardarNota.UseVisualStyleBackColor = false;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese nota:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(888, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.nudNota);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escuela Técnica Ort";
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNota;
    }
}

