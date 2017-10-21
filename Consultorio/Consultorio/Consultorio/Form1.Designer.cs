namespace Consultorio
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
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstudio
            // 
            this.cmbEstudio.FormattingEnabled = true;
            this.cmbEstudio.Items.AddRange(new object[] {
            "Radiografía",
            "Implante",
            "Ecografía",
            "Análisis de orina"});
            this.cmbEstudio.Location = new System.Drawing.Point(507, 43);
            this.cmbEstudio.Name = "cmbEstudio";
            this.cmbEstudio.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudio.TabIndex = 0;
            this.cmbEstudio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudio.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblEstudio.Location = new System.Drawing.Point(25, 37);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(454, 27);
            this.lblEstudio.TabIndex = 1;
            this.lblEstudio.Text = "Seleccione el estudio que desea hacerse:";
            this.lblEstudio.Click += new System.EventHandler(this.lblEstudio_Click);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMasculino.Location = new System.Drawing.Point(452, 102);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(139, 31);
            this.rbtMasculino.TabIndex = 2;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemenino.Location = new System.Drawing.Point(279, 102);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(136, 31);
            this.rbtFemenino.TabIndex = 3;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(25, 102);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(220, 27);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Seleccione su sexo:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(246, 177);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 20);
            this.nudEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(25, 168);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(191, 27);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Ingrese su edad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(400, 219);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 57);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnDia
            // 
            this.btnDia.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDia.Location = new System.Drawing.Point(547, 321);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(180, 44);
            this.btnDia.TabIndex = 8;
            this.btnDia.Text = "Finalizar día";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnMes
            // 
            this.btnMes.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMes.Location = new System.Drawing.Point(733, 321);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(184, 44);
            this.btnMes.TabIndex = 9;
            this.btnMes.Text = "Finalizar mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(929, 377);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnDia);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.lblEstudio);
            this.Controls.Add(this.cmbEstudio);
            this.Name = "Form1";
            this.Text = "Consultorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstudio;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnMes;
    }
}

