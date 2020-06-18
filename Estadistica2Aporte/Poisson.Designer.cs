namespace Estadistica2Aporte
{
    partial class Poisson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poisson));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnMayorIgual = new System.Windows.Forms.RadioButton();
            this.rBtnMenorIgual = new System.Windows.Forms.RadioButton();
            this.rBtnMayor = new System.Windows.Forms.RadioButton();
            this.rBtnMenor = new System.Windows.Forms.RadioButton();
            this.rBtnEntre = new System.Windows.Forms.RadioButton();
            this.rBtnIgual = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtProbabilidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.txtOcurrencia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInterInicial = new System.Windows.Forms.TextBox();
            this.txtInterFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVEsperado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesvEstandar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribución de Poisson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "λ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "x:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rBtnMayorIgual);
            this.groupBox1.Controls.Add(this.rBtnMenorIgual);
            this.groupBox1.Controls.Add(this.rBtnMayor);
            this.groupBox1.Controls.Add(this.rBtnMenor);
            this.groupBox1.Controls.Add(this.rBtnEntre);
            this.groupBox1.Controls.Add(this.rBtnIgual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 101);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // rBtnMayorIgual
            // 
            this.rBtnMayorIgual.AutoSize = true;
            this.rBtnMayorIgual.Location = new System.Drawing.Point(464, 60);
            this.rBtnMayorIgual.Name = "rBtnMayorIgual";
            this.rBtnMayorIgual.Size = new System.Drawing.Size(127, 21);
            this.rBtnMayorIgual.TabIndex = 10;
            this.rBtnMayorIgual.TabStop = true;
            this.rBtnMayorIgual.Text = "Mayor o igual";
            this.rBtnMayorIgual.UseVisualStyleBackColor = true;
            this.rBtnMayorIgual.CheckedChanged += new System.EventHandler(this.rBtnMayorIgual_CheckedChanged);
            // 
            // rBtnMenorIgual
            // 
            this.rBtnMenorIgual.AutoSize = true;
            this.rBtnMenorIgual.Location = new System.Drawing.Point(249, 60);
            this.rBtnMenorIgual.Name = "rBtnMenorIgual";
            this.rBtnMenorIgual.Size = new System.Drawing.Size(128, 21);
            this.rBtnMenorIgual.TabIndex = 9;
            this.rBtnMenorIgual.TabStop = true;
            this.rBtnMenorIgual.Text = "Menor o igual";
            this.rBtnMenorIgual.UseVisualStyleBackColor = true;
            this.rBtnMenorIgual.CheckedChanged += new System.EventHandler(this.rBtnMenorIgual_CheckedChanged);
            // 
            // rBtnMayor
            // 
            this.rBtnMayor.AutoSize = true;
            this.rBtnMayor.Location = new System.Drawing.Point(464, 33);
            this.rBtnMayor.Name = "rBtnMayor";
            this.rBtnMayor.Size = new System.Drawing.Size(73, 21);
            this.rBtnMayor.TabIndex = 7;
            this.rBtnMayor.TabStop = true;
            this.rBtnMayor.Text = "Mayor";
            this.rBtnMayor.UseVisualStyleBackColor = true;
            this.rBtnMayor.CheckedChanged += new System.EventHandler(this.rBtnMayor_CheckedChanged);
            // 
            // rBtnMenor
            // 
            this.rBtnMenor.AutoSize = true;
            this.rBtnMenor.Location = new System.Drawing.Point(249, 33);
            this.rBtnMenor.Name = "rBtnMenor";
            this.rBtnMenor.Size = new System.Drawing.Size(74, 21);
            this.rBtnMenor.TabIndex = 6;
            this.rBtnMenor.TabStop = true;
            this.rBtnMenor.Text = "Menor";
            this.rBtnMenor.UseVisualStyleBackColor = true;
            this.rBtnMenor.CheckedChanged += new System.EventHandler(this.rBtnMenor_CheckedChanged);
            // 
            // rBtnEntre
            // 
            this.rBtnEntre.AutoSize = true;
            this.rBtnEntre.Location = new System.Drawing.Point(29, 60);
            this.rBtnEntre.Name = "rBtnEntre";
            this.rBtnEntre.Size = new System.Drawing.Size(68, 21);
            this.rBtnEntre.TabIndex = 8;
            this.rBtnEntre.TabStop = true;
            this.rBtnEntre.Text = "Entre";
            this.rBtnEntre.UseVisualStyleBackColor = true;
            this.rBtnEntre.CheckedChanged += new System.EventHandler(this.rBtnEntre_CheckedChanged);
            // 
            // rBtnIgual
            // 
            this.rBtnIgual.AutoSize = true;
            this.rBtnIgual.Checked = true;
            this.rBtnIgual.Location = new System.Drawing.Point(29, 33);
            this.rBtnIgual.Name = "rBtnIgual";
            this.rBtnIgual.Size = new System.Drawing.Size(64, 21);
            this.rBtnIgual.TabIndex = 5;
            this.rBtnIgual.TabStop = true;
            this.rBtnIgual.Text = "Igual";
            this.rBtnIgual.UseVisualStyleBackColor = true;
            this.rBtnIgual.CheckedChanged += new System.EventHandler(this.rBtnIgual_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(393, 444);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 42);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(102, 444);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(144, 42);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Enabled = false;
            this.txtProbabilidad.Location = new System.Drawing.Point(290, 401);
            this.txtProbabilidad.Name = "txtProbabilidad";
            this.txtProbabilidad.Size = new System.Drawing.Size(201, 22);
            this.txtProbabilidad.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Probabilidad:";
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(219, 122);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(201, 22);
            this.txtLambda.TabIndex = 1;
            // 
            // txtOcurrencia
            // 
            this.txtOcurrencia.Location = new System.Drawing.Point(220, 150);
            this.txtOcurrencia.Name = "txtOcurrencia";
            this.txtOcurrencia.Size = new System.Drawing.Size(201, 22);
            this.txtOcurrencia.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Intervalo Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Intervalo Final:";
            // 
            // txtInterInicial
            // 
            this.txtInterInicial.Location = new System.Drawing.Point(197, 179);
            this.txtInterInicial.Name = "txtInterInicial";
            this.txtInterInicial.Size = new System.Drawing.Size(100, 22);
            this.txtInterInicial.TabIndex = 3;
            // 
            // txtInterFinal
            // 
            this.txtInterFinal.Location = new System.Drawing.Point(435, 179);
            this.txtInterFinal.Name = "txtInterFinal";
            this.txtInterFinal.Size = new System.Drawing.Size(100, 22);
            this.txtInterFinal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "E(x) = V(x) :";
            // 
            // txtVEsperado
            // 
            this.txtVEsperado.Enabled = false;
            this.txtVEsperado.Location = new System.Drawing.Point(220, 213);
            this.txtVEsperado.Name = "txtVEsperado";
            this.txtVEsperado.Size = new System.Drawing.Size(201, 22);
            this.txtVEsperado.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "σ(x):";
            // 
            // txtDesvEstandar
            // 
            this.txtDesvEstandar.Enabled = false;
            this.txtDesvEstandar.Location = new System.Drawing.Point(220, 241);
            this.txtDesvEstandar.Name = "txtDesvEstandar";
            this.txtDesvEstandar.Size = new System.Drawing.Size(201, 22);
            this.txtDesvEstandar.TabIndex = 30;
            // 
            // Poisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 512);
            this.Controls.Add(this.txtDesvEstandar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVEsperado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInterFinal);
            this.Controls.Add(this.txtInterInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOcurrencia);
            this.Controls.Add(this.txtLambda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtProbabilidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Poisson";
            this.Text = "Poisson";
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnMayorIgual;
        private System.Windows.Forms.RadioButton rBtnMenorIgual;
        private System.Windows.Forms.RadioButton rBtnMayor;
        private System.Windows.Forms.RadioButton rBtnMenor;
        private System.Windows.Forms.RadioButton rBtnEntre;
        private System.Windows.Forms.RadioButton rBtnIgual;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtProbabilidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.TextBox txtOcurrencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInterInicial;
        private System.Windows.Forms.TextBox txtInterFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVEsperado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesvEstandar;
    }
}