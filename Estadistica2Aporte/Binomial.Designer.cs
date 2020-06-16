namespace Estadistica2Aporte
{
    partial class Binomial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Binomial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnsayos = new System.Windows.Forms.TextBox();
            this.txtAcierto = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtVx = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.txtPrbabilidad = new System.Windows.Forms.TextBox();
            this.rBtnIgual = new System.Windows.Forms.RadioButton();
            this.rBtnMenor = new System.Windows.Forms.RadioButton();
            this.rBtnMayor = new System.Windows.Forms.RadioButton();
            this.rBtnMenorIgual = new System.Windows.Forms.RadioButton();
            this.rBtnMayorIgual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ensayos y Distribución Binomial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº de Ensayos (n):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob. de Acierto (p):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prob. de Error (q):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nº de Intentos (k):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "E(x) µ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "V(x):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "DE(x) σ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Probabilidad:";
            // 
            // txtEnsayos
            // 
            this.txtEnsayos.Location = new System.Drawing.Point(285, 141);
            this.txtEnsayos.Name = "txtEnsayos";
            this.txtEnsayos.Size = new System.Drawing.Size(213, 22);
            this.txtEnsayos.TabIndex = 1;
            this.txtEnsayos.Tag = "";
            // 
            // txtAcierto
            // 
            this.txtAcierto.Location = new System.Drawing.Point(285, 169);
            this.txtAcierto.Name = "txtAcierto";
            this.txtAcierto.Size = new System.Drawing.Size(213, 22);
            this.txtAcierto.TabIndex = 2;
            this.txtAcierto.Tag = "2";
            // 
            // txtError
            // 
            this.txtError.Enabled = false;
            this.txtError.Location = new System.Drawing.Point(285, 197);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(213, 22);
            this.txtError.TabIndex = 3;
            this.txtError.Tag = "3";
            // 
            // txtIntentos
            // 
            this.txtIntentos.Location = new System.Drawing.Point(285, 225);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(213, 22);
            this.txtIntentos.TabIndex = 4;
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(285, 253);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(213, 22);
            this.txtMedia.TabIndex = 5;
            // 
            // txtVx
            // 
            this.txtVx.Enabled = false;
            this.txtVx.Location = new System.Drawing.Point(285, 281);
            this.txtVx.Name = "txtVx";
            this.txtVx.Size = new System.Drawing.Size(213, 22);
            this.txtVx.TabIndex = 6;
            // 
            // txtDex
            // 
            this.txtDex.Enabled = false;
            this.txtDex.Location = new System.Drawing.Point(285, 309);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(213, 22);
            this.txtDex.TabIndex = 7;
            // 
            // txtPrbabilidad
            // 
            this.txtPrbabilidad.Enabled = false;
            this.txtPrbabilidad.Location = new System.Drawing.Point(285, 425);
            this.txtPrbabilidad.Name = "txtPrbabilidad";
            this.txtPrbabilidad.Size = new System.Drawing.Size(213, 22);
            this.txtPrbabilidad.TabIndex = 14;
            // 
            // rBtnIgual
            // 
            this.rBtnIgual.AutoSize = true;
            this.rBtnIgual.BackColor = System.Drawing.Color.Transparent;
            this.rBtnIgual.Checked = true;
            this.rBtnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnIgual.Location = new System.Drawing.Point(29, 31);
            this.rBtnIgual.Name = "rBtnIgual";
            this.rBtnIgual.Size = new System.Drawing.Size(64, 21);
            this.rBtnIgual.TabIndex = 9;
            this.rBtnIgual.TabStop = true;
            this.rBtnIgual.Text = "Igual";
            this.rBtnIgual.UseVisualStyleBackColor = false;
            // 
            // rBtnMenor
            // 
            this.rBtnMenor.AutoSize = true;
            this.rBtnMenor.BackColor = System.Drawing.Color.Transparent;
            this.rBtnMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMenor.Location = new System.Drawing.Point(124, 31);
            this.rBtnMenor.Name = "rBtnMenor";
            this.rBtnMenor.Size = new System.Drawing.Size(74, 21);
            this.rBtnMenor.TabIndex = 10;
            this.rBtnMenor.Text = "Menor";
            this.rBtnMenor.UseVisualStyleBackColor = false;
            // 
            // rBtnMayor
            // 
            this.rBtnMayor.AutoSize = true;
            this.rBtnMayor.BackColor = System.Drawing.Color.Transparent;
            this.rBtnMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMayor.Location = new System.Drawing.Point(227, 31);
            this.rBtnMayor.Name = "rBtnMayor";
            this.rBtnMayor.Size = new System.Drawing.Size(73, 21);
            this.rBtnMayor.TabIndex = 11;
            this.rBtnMayor.Text = "Mayor";
            this.rBtnMayor.UseVisualStyleBackColor = false;
            // 
            // rBtnMenorIgual
            // 
            this.rBtnMenorIgual.AutoSize = true;
            this.rBtnMenorIgual.BackColor = System.Drawing.Color.Transparent;
            this.rBtnMenorIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMenorIgual.Location = new System.Drawing.Point(316, 31);
            this.rBtnMenorIgual.Name = "rBtnMenorIgual";
            this.rBtnMenorIgual.Size = new System.Drawing.Size(128, 21);
            this.rBtnMenorIgual.TabIndex = 12;
            this.rBtnMenorIgual.Text = "Menor o igual";
            this.rBtnMenorIgual.UseVisualStyleBackColor = false;
            // 
            // rBtnMayorIgual
            // 
            this.rBtnMayorIgual.AutoSize = true;
            this.rBtnMayorIgual.BackColor = System.Drawing.Color.Transparent;
            this.rBtnMayorIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMayorIgual.Location = new System.Drawing.Point(459, 31);
            this.rBtnMayorIgual.Name = "rBtnMayorIgual";
            this.rBtnMayorIgual.Size = new System.Drawing.Size(127, 21);
            this.rBtnMayorIgual.TabIndex = 13;
            this.rBtnMayorIgual.Text = "Mayor o igual";
            this.rBtnMayorIgual.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rBtnIgual);
            this.groupBox1.Controls.Add(this.rBtnMayorIgual);
            this.groupBox1.Controls.Add(this.rBtnMenor);
            this.groupBox1.Controls.Add(this.rBtnMenorIgual);
            this.groupBox1.Controls.Add(this.rBtnMayor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(97, 458);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(144, 42);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(398, 458);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 42);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Binomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrbabilidad);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.txtVx);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtIntentos);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txtAcierto);
            this.Controls.Add(this.txtEnsayos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Binomial";
            this.Text = "Binomial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnsayos;
        private System.Windows.Forms.TextBox txtAcierto;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtVx;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.TextBox txtPrbabilidad;
        private System.Windows.Forms.RadioButton rBtnIgual;
        private System.Windows.Forms.RadioButton rBtnMenor;
        private System.Windows.Forms.RadioButton rBtnMayor;
        private System.Windows.Forms.RadioButton rBtnMenorIgual;
        private System.Windows.Forms.RadioButton rBtnMayorIgual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}