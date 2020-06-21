namespace Estadistica2Aporte
{
    partial class Estadística
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadística));
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iBtnMinimizar = new System.Windows.Forms.PictureBox();
            this.iBtnCerrar = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.btExponencial = new System.Windows.Forms.Button();
            this.btnBinomial = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnCerrar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.iBtnMinimizar);
            this.Header.Controls.Add(this.iBtnCerrar);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(831, 38);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ESTADÍSTICA Y PROBABILIDAD";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // iBtnMinimizar
            // 
            this.iBtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iBtnMinimizar.Image")));
            this.iBtnMinimizar.Location = new System.Drawing.Point(758, 3);
            this.iBtnMinimizar.Name = "iBtnMinimizar";
            this.iBtnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.iBtnMinimizar.TabIndex = 2;
            this.iBtnMinimizar.TabStop = false;
            this.iBtnMinimizar.Click += new System.EventHandler(this.iBtnMinimizar_Click);
            // 
            // iBtnCerrar
            // 
            this.iBtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iBtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iBtnCerrar.Image")));
            this.iBtnCerrar.Location = new System.Drawing.Point(796, 3);
            this.iBtnCerrar.Name = "iBtnCerrar";
            this.iBtnCerrar.Size = new System.Drawing.Size(32, 32);
            this.iBtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iBtnCerrar.TabIndex = 1;
            this.iBtnCerrar.TabStop = false;
            this.iBtnCerrar.Click += new System.EventHandler(this.iBtnCerrar_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.PanelMenu.Controls.Add(this.panel4);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.btnNormal);
            this.PanelMenu.Controls.Add(this.btnPoisson);
            this.PanelMenu.Controls.Add(this.btExponencial);
            this.PanelMenu.Controls.Add(this.btnBinomial);
            this.PanelMenu.Controls.Add(this.pictureBox2);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 38);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 512);
            this.PanelMenu.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel4.Location = new System.Drawing.Point(0, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 38);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel3.Location = new System.Drawing.Point(0, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 38);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel2.Location = new System.Drawing.Point(0, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 38);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 38);
            this.panel1.TabIndex = 7;
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.Location = new System.Drawing.Point(18, 307);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(182, 38);
            this.btnNormal.TabIndex = 6;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnPoisson
            // 
            this.btnPoisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnPoisson.FlatAppearance.BorderSize = 0;
            this.btnPoisson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.btnPoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoisson.Location = new System.Drawing.Point(18, 263);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(182, 38);
            this.btnPoisson.TabIndex = 5;
            this.btnPoisson.Text = "Poisson";
            this.btnPoisson.UseVisualStyleBackColor = false;
            this.btnPoisson.Click += new System.EventHandler(this.btnPoisson_Click);
            // 
            // btExponencial
            // 
            this.btExponencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btExponencial.FlatAppearance.BorderSize = 0;
            this.btExponencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.btExponencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExponencial.Location = new System.Drawing.Point(18, 219);
            this.btExponencial.Name = "btExponencial";
            this.btExponencial.Size = new System.Drawing.Size(182, 38);
            this.btExponencial.TabIndex = 4;
            this.btExponencial.Text = "Exponencial";
            this.btExponencial.UseVisualStyleBackColor = false;
            this.btExponencial.Click += new System.EventHandler(this.btExponencial_Click);
            // 
            // btnBinomial
            // 
            this.btnBinomial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            this.btnBinomial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBinomial.FlatAppearance.BorderSize = 0;
            this.btnBinomial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(198)))), ((int)(((byte)(182)))));
            this.btnBinomial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBinomial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinomial.Location = new System.Drawing.Point(18, 175);
            this.btnBinomial.Name = "btnBinomial";
            this.btnBinomial.Size = new System.Drawing.Size(182, 38);
            this.btnBinomial.TabIndex = 3;
            this.btnBinomial.Text = "Binomial";
            this.btnBinomial.UseVisualStyleBackColor = false;
            this.btnBinomial.Click += new System.EventHandler(this.btnBinomial_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(130, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.PanelContenedor.Controls.Add(this.pictureBox3);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 38);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(631, 512);
            this.PanelContenedor.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(628, 509);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Estadística
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 550);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadística";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística";
            this.Load += new System.EventHandler(this.Estadística_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnCerrar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox iBtnCerrar;
        private System.Windows.Forms.PictureBox iBtnMinimizar;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Button btExponencial;
        private System.Windows.Forms.Button btnBinomial;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

