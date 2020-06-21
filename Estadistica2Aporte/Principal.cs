using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//Para mover la ventana

namespace Estadistica2Aporte
{
    public partial class Estadística : Form
    {
        public Estadística()
        {
            InitializeComponent();
        }

        private void Estadística_Load(object sender, EventArgs e)
        {

        }

        private void iBtnCerrar_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void iBtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Método para abrir form dentro de un panel
        private void AbrirForm(object f)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = f as Form;
            fh.TopLevel = false;//con esto le decimos que es un formulario de nivel inferior
            fh.Dock = DockStyle.Fill;//con esto hacemos que se acople a nuestro contenedor
            this.PanelContenedor.Controls.Add(fh);//Lo agregamos al panel
            //Establecemos la instancia como contenedor de datos de nuestro panel
            this.PanelContenedor.Tag = fh;
            //Mostramos en formulario
            fh.Show();
        }

        private void btnBinomial_Click(object sender, EventArgs e)
        {
            /*******************************************************************
             * Llamamos a nuestra funcion Abrir form y le pasamos el parametro *
             * que será del tipo del formulario que vamos a mostrar            *
             *******************************************************************/
            AbrirForm(new Binomial());
        }

        private void btExponencial_Click(object sender, EventArgs e)
        {
            AbrirForm(new Exponencial());
        }

        private void btnPoisson_Click(object sender, EventArgs e)
        {
            AbrirForm(new Poisson());
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            AbrirForm(new Normal());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Facultad de Informática y Electrónica"
                +"\nEscuela de Ingeniería de Sistemas"
                +"\nCarrera:"
                +"\n\tIngeniería de Software"
                +"\nIntegrantes:"
                +"\n\tJoao Barrionuevo"
                +"\n\tWellington Cabezas"
                +"\n\tFranklin Mendoza");
        }
    }
}
