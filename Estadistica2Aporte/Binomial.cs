using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica2Aporte
{
    public partial class Binomial : Form
    {
        private double n, p, k;
        public Binomial()
        {
            InitializeComponent();
        }
        //Métodos Setters
        public void setN(double n)
        {
            this.n = n;
        }
        public void setP(double p)
        {
            this.p = p;
        }
        public void setK(double k)
        {
            this.k = k;
        }
        //Métodos Getters
        public double getN()
        {
            return n;
        }
        public double getP()
        {
            return p;
        }
        public double getK()
        {
            return k;
        }
        //Metodo para borrar los texboxs
        private void Borrar() {
            txtAcierto.Text = "";
            txtEnsayos.Text = "";
            txtError.Text = "";
            txtIntentos.Text = "";
            txtMedia.Text = "";
            txtVx.Text = "";
            txtDex.Text = "";
        }
        //Método para calcular el factorial
        private double Factorial(double f){
            double fact = 1;
            if((f==0) || (f == 1)) {
                fact=1;
            }else if (f > 1) { 
                for(int i = 2; i <= f; i++) {
                    fact *= i;
                }
            }
            return fact;
        }
        //Método para calcular q
        private double Q(double p) {
            return 1 - p;
        }
        //Método para calcular la distribución binomial
        private double DistribucionBinomial(double n, double p, double k) {
            return ((Factorial(n)) / ((Factorial(k)) * (Factorial(n - k))))*Math.Pow(p,k)*Math.Pow(Q(Convert.ToDouble(txtAcierto.Text)),(n-k));
        }
        //Método para calcular miu
        private double Ex(double n, double p) {
            return (n * p);
        }
        //Método para calcular la varianza
        private double Vx(double n, double p) {
            return (n*p*Q(Convert.ToDouble(txtAcierto.Text)));
        }
        //Método para calcular la desviacion estandar
        private double Dex(double n, double p) {
            return Math.Sqrt(Vx(Convert.ToDouble(txtEnsayos.Text),Convert.ToDouble(txtAcierto.Text)));
        }
        //Método para validar el campo de ensayos
        private bool ValEnsayo() {
            if (Convert.ToDouble(txtEnsayos.Text)<=1){
                return false;
            }else {
                return true;
            }
        }
        //Método para validar el campo acierto
        private bool ValAcierto() {
            if ((Convert.ToDouble(txtAcierto.Text) >= 0) && (Convert.ToDouble(txtAcierto.Text) <= 1)) {
                return true;
            }else {
                return false;
            }
        }
        //Método para validar el numero de intentos
        private bool ValIntentos() {
            if (Convert.ToDouble(txtIntentos.Text) < 0)
            {
                return false;
            }else {
                return true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e){
            Borrar();
            txtEnsayos.Focus();
        }

        //Metodo para llamar las cosas basicas de calculo
        private void CalculosBasicos() {
            txtError.Text = Q(Convert.ToDouble(txtAcierto.Text))
                                            .ToString();
            txtMedia.Text = Ex(Convert.ToDouble(txtEnsayos.Text),
                Convert.ToDouble(txtAcierto.Text)).ToString();
            txtVx.Text = Vx(Convert.ToDouble(txtEnsayos.Text),
                Convert.ToDouble(txtAcierto.Text)).ToString();
            txtDex.Text = Dex(Convert.ToDouble(txtEnsayos.Text),
                Convert.ToDouble(txtAcierto.Text)).ToString();
        }
        private void btnCalcular_Click(object sender, EventArgs e){
            double r = 0;
            try{
                
                if (ValEnsayo()==true) {
                    if (ValAcierto() == true){
                        if (ValIntentos()==true) {
                            if (rBtnIgual.Checked == true) {
                                CalculosBasicos();
                                txtPrbabilidad.Text = DistribucionBinomial(Convert.ToDouble(txtEnsayos.Text),
                                    Convert.ToDouble(txtAcierto.Text), Convert.ToDouble(txtIntentos.Text)).ToString();
                            } else if (rBtnMenor.Checked == true) {
                                CalculosBasicos();
                                for (int i = 0; i < Convert.ToInt32(txtIntentos.Text); i++) {
                                    r += DistribucionBinomial(Convert.ToDouble(txtEnsayos.Text), Convert.ToDouble(txtAcierto.Text), i);
                                }
                                txtPrbabilidad.Text = r.ToString();
                            } else if (rBtnMayor.Checked == true) {
                                CalculosBasicos();
                                for (int i = Convert.ToInt32(txtIntentos.Text) + 1; i <= Convert.ToInt32(txtEnsayos.Text); i++) {
                                    r += DistribucionBinomial(Convert.ToDouble(txtEnsayos.Text), Convert.ToDouble(txtAcierto.Text), i);
                                }
                                txtPrbabilidad.Text = r.ToString();
                            } else if (rBtnMenorIgual.Checked == true) {
                                CalculosBasicos();
                                for (int i = 0; i <= Convert.ToInt32(txtIntentos.Text); i++) {
                                    r += DistribucionBinomial(Convert.ToDouble(txtEnsayos.Text), Convert.ToDouble(txtAcierto.Text), i);
                                }
                                txtPrbabilidad.Text = r.ToString();
                            } else if (rBtnMayorIgual.Checked==true) {
                                CalculosBasicos();
                                for (int i = Convert.ToInt32(txtIntentos.Text);i<=Convert.ToInt32(txtEnsayos.Text);i++) {
                                    r += DistribucionBinomial(Convert.ToDouble(txtEnsayos.Text), Convert.ToDouble(txtAcierto.Text), i);
                                }
                                txtPrbabilidad.Text = r.ToString();
                            }
                        }else {
                            MessageBox.Show("Ingrese un número de intentos"
                                +"\nEl número de ensayo no puede ser negativo");
                            txtIntentos.Text = "";
                            txtIntentos.Focus();
                        }
                    }else {
                        MessageBox.Show("Ingrese la probabilidad de acierto corrctamente"
                            +"\nEsta debe estar comprendida entre 0 y 1");
                        txtAcierto.Text = "";
                        txtAcierto.Focus();
                    }
                }else {
                    MessageBox.Show("Ingrese un número de ensayos repetidos válidos"
                        +"\nEl número de ensayos tiene que ser mayor que 1");
                    txtEnsayos.Text = "";
                    txtEnsayos.Focus();
                }
            }
            catch (Exception){
                if(txtEnsayos.Text == string.Empty) {
                    MessageBox.Show("Ingrese el numero de ensayos");
                    txtEnsayos.Text = "";
                    txtEnsayos.Focus();
                }else if (txtAcierto.Text == string.Empty) {
                    MessageBox.Show("Ingrese la probabilidad de acierto entre 0 y 1");
                    txtAcierto.Text = "";
                    txtAcierto.Focus();
                }else if (txtIntentos.Text == string.Empty) {
                    MessageBox.Show("Ingrese el numero de intentos");
                    txtIntentos.Text = "";
                    txtIntentos.Focus();
                }
            }
        }
    }
}
