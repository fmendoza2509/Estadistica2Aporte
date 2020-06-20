namespace Estadistica2Aporte
{
    partial class Normal
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnNormal = new System.Windows.Forms.RadioButton();
            this.rBtnEstandar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rBtnMenorIgual = new System.Windows.Forms.RadioButton();
            this.rBtnEntre = new System.Windows.Forms.RadioButton();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtDesvEstandar = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtInterInicial = new System.Windows.Forms.TextBox();
            this.txtInterFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProbabilidad = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribución Normal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnNormal);
            this.groupBox1.Controls.Add(this.rBtnEstandar);
            this.groupBox1.Location = new System.Drawing.Point(132, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Distribución";
            // 
            // rBtnNormal
            // 
            this.rBtnNormal.AutoSize = true;
            this.rBtnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnNormal.Location = new System.Drawing.Point(218, 26);
            this.rBtnNormal.Name = "rBtnNormal";
            this.rBtnNormal.Size = new System.Drawing.Size(80, 21);
            this.rBtnNormal.TabIndex = 1;
            this.rBtnNormal.Text = "Normal";
            this.rBtnNormal.UseVisualStyleBackColor = true;
            this.rBtnNormal.CheckedChanged += new System.EventHandler(this.rBtnNormal_CheckedChanged);
            // 
            // rBtnEstandar
            // 
            this.rBtnEstandar.AutoSize = true;
            this.rBtnEstandar.Checked = true;
            this.rBtnEstandar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnEstandar.Location = new System.Drawing.Point(6, 26);
            this.rBtnEstandar.Name = "rBtnEstandar";
            this.rBtnEstandar.Size = new System.Drawing.Size(121, 21);
            this.rBtnEstandar.TabIndex = 0;
            this.rBtnEstandar.TabStop = true;
            this.rBtnEstandar.Text = "Estandar (Z)";
            this.rBtnEstandar.UseVisualStyleBackColor = true;
            this.rBtnEstandar.CheckedChanged += new System.EventHandler(this.rBtnEstandar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Media (µ):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desv. Típica (σ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Z:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Inter. Inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Inter. Final:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rBtnMenorIgual);
            this.groupBox2.Controls.Add(this.rBtnEntre);
            this.groupBox2.Location = new System.Drawing.Point(49, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 61);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(380, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Mayor o Igual";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rBtnMenorIgual
            // 
            this.rBtnMenorIgual.AutoSize = true;
            this.rBtnMenorIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMenorIgual.Location = new System.Drawing.Point(170, 34);
            this.rBtnMenorIgual.Name = "rBtnMenorIgual";
            this.rBtnMenorIgual.Size = new System.Drawing.Size(128, 21);
            this.rBtnMenorIgual.TabIndex = 1;
            this.rBtnMenorIgual.Text = "Menor o Igual";
            this.rBtnMenorIgual.UseVisualStyleBackColor = true;
            this.rBtnMenorIgual.CheckedChanged += new System.EventHandler(this.rBtnMenorIgual_CheckedChanged);
            // 
            // rBtnEntre
            // 
            this.rBtnEntre.AutoSize = true;
            this.rBtnEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnEntre.Location = new System.Drawing.Point(7, 34);
            this.rBtnEntre.Name = "rBtnEntre";
            this.rBtnEntre.Size = new System.Drawing.Size(68, 21);
            this.rBtnEntre.TabIndex = 0;
            this.rBtnEntre.Text = "Entre";
            this.rBtnEntre.UseVisualStyleBackColor = true;
            this.rBtnEntre.CheckedChanged += new System.EventHandler(this.rBtnEntre_CheckedChanged);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(293, 103);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(137, 22);
            this.txtMedia.TabIndex = 9;
            // 
            // txtDesvEstandar
            // 
            this.txtDesvEstandar.Location = new System.Drawing.Point(293, 137);
            this.txtDesvEstandar.Name = "txtDesvEstandar";
            this.txtDesvEstandar.Size = new System.Drawing.Size(137, 22);
            this.txtDesvEstandar.TabIndex = 10;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(293, 168);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(137, 22);
            this.txtX.TabIndex = 11;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(293, 197);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(137, 22);
            this.txtZ.TabIndex = 12;
            // 
            // txtInterInicial
            // 
            this.txtInterInicial.Location = new System.Drawing.Point(210, 227);
            this.txtInterInicial.Name = "txtInterInicial";
            this.txtInterInicial.Size = new System.Drawing.Size(70, 22);
            this.txtInterInicial.TabIndex = 13;
            // 
            // txtInterFinal
            // 
            this.txtInterFinal.Location = new System.Drawing.Point(399, 227);
            this.txtInterFinal.Name = "txtInterFinal";
            this.txtInterFinal.Size = new System.Drawing.Size(70, 22);
            this.txtInterFinal.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Probabilidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Porcentaje:";
            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Location = new System.Drawing.Point(293, 336);
            this.txtProbabilidad.Name = "txtProbabilidad";
            this.txtProbabilidad.Size = new System.Drawing.Size(137, 22);
            this.txtProbabilidad.TabIndex = 17;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(293, 364);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(137, 22);
            this.txtPorcentaje.TabIndex = 18;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(106, 447);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(144, 42);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(399, 447);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 42);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 512);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtProbabilidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInterFinal);
            this.Controls.Add(this.txtInterInicial);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtDesvEstandar);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Normal";
            this.Text = "Normal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnNormal;
        private System.Windows.Forms.RadioButton rBtnEstandar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rBtnMenorIgual;
        private System.Windows.Forms.RadioButton rBtnEntre;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtDesvEstandar;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtInterInicial;
        private System.Windows.Forms.TextBox txtInterFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProbabilidad;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
    }
}