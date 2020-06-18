namespace Estadistica2Aporte
{
    partial class Exponencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exponencial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLambdaN = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtProbabilidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnMayorIgual = new System.Windows.Forms.RadioButton();
            this.rBtnMenorIgual = new System.Windows.Forms.RadioButton();
            this.rBtnEntre = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInterInicial = new System.Windows.Forms.TextBox();
            this.txtInterFinal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribución Exponencial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prom. Ocurrencia (λ):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº de Ocurrencia (x):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Probabilidad:";
            // 
            // txtLambdaN
            // 
            this.txtLambdaN.Location = new System.Drawing.Point(276, 167);
            this.txtLambdaN.Name = "txtLambdaN";
            this.txtLambdaN.Size = new System.Drawing.Size(201, 22);
            this.txtLambdaN.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(276, 204);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(201, 22);
            this.txtX.TabIndex = 3;
            // 
            // txtProbabilidad
            // 
            this.txtProbabilidad.Location = new System.Drawing.Point(276, 413);
            this.txtProbabilidad.Name = "txtProbabilidad";
            this.txtProbabilidad.Size = new System.Drawing.Size(201, 22);
            this.txtProbabilidad.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rBtnMayorIgual);
            this.groupBox1.Controls.Add(this.rBtnMenorIgual);
            this.groupBox1.Controls.Add(this.rBtnEntre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 101);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // rBtnMayorIgual
            // 
            this.rBtnMayorIgual.AutoSize = true;
            this.rBtnMayorIgual.Location = new System.Drawing.Point(459, 43);
            this.rBtnMayorIgual.Name = "rBtnMayorIgual";
            this.rBtnMayorIgual.Size = new System.Drawing.Size(127, 21);
            this.rBtnMayorIgual.TabIndex = 5;
            this.rBtnMayorIgual.Text = "Mayor o igual";
            this.rBtnMayorIgual.UseVisualStyleBackColor = true;
            this.rBtnMayorIgual.CheckedChanged += new System.EventHandler(this.rBtnMayorIgual_CheckedChanged);
            // 
            // rBtnMenorIgual
            // 
            this.rBtnMenorIgual.AutoSize = true;
            this.rBtnMenorIgual.Location = new System.Drawing.Point(217, 43);
            this.rBtnMenorIgual.Name = "rBtnMenorIgual";
            this.rBtnMenorIgual.Size = new System.Drawing.Size(128, 21);
            this.rBtnMenorIgual.TabIndex = 4;
            this.rBtnMenorIgual.Text = "Menor o igual";
            this.rBtnMenorIgual.UseVisualStyleBackColor = true;
            this.rBtnMenorIgual.CheckedChanged += new System.EventHandler(this.rBtnMenorIgual_CheckedChanged);
            // 
            // rBtnEntre
            // 
            this.rBtnEntre.AutoSize = true;
            this.rBtnEntre.Location = new System.Drawing.Point(17, 43);
            this.rBtnEntre.Name = "rBtnEntre";
            this.rBtnEntre.Size = new System.Drawing.Size(68, 21);
            this.rBtnEntre.TabIndex = 1;
            this.rBtnEntre.Text = "Entre";
            this.rBtnEntre.UseVisualStyleBackColor = true;
            this.rBtnEntre.CheckedChanged += new System.EventHandler(this.rBtnEntre_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(97, 458);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(144, 42);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(388, 458);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 42);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Inter. Inicial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Inter. Final:";
            // 
            // txtInterInicial
            // 
            this.txtInterInicial.Location = new System.Drawing.Point(241, 232);
            this.txtInterInicial.Name = "txtInterInicial";
            this.txtInterInicial.Size = new System.Drawing.Size(59, 22);
            this.txtInterInicial.TabIndex = 6;
            // 
            // txtInterFinal
            // 
            this.txtInterFinal.Location = new System.Drawing.Point(418, 232);
            this.txtInterFinal.Name = "txtInterFinal";
            this.txtInterFinal.Size = new System.Drawing.Size(59, 22);
            this.txtInterFinal.TabIndex = 19;
            // 
            // Exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 512);
            this.Controls.Add(this.txtInterFinal);
            this.Controls.Add(this.txtInterInicial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProbabilidad);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtLambdaN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exponencial";
            this.Text = "Exponencial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLambdaN;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtProbabilidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnMayorIgual;
        private System.Windows.Forms.RadioButton rBtnMenorIgual;
        private System.Windows.Forms.RadioButton rBtnEntre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInterInicial;
        private System.Windows.Forms.TextBox txtInterFinal;
    }
}