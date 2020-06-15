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
        private void btnCalcular_Click(object sender, EventArgs e){
            txtError.Text = Q(Convert.ToDouble(txtAcierto.Text)).ToString();
            txtMedia.Text = Ex(Convert.ToDouble(txtEnsayos.Text),Convert.ToDouble(txtAcierto.Text)).ToString();
            txtVx.Text = Vx(Convert.ToDouble(txtEnsayos.Text),Convert.ToDouble(txtAcierto.Text)).ToString();
            txtDex.Text = Dex(Convert.ToDouble(txtEnsayos.Text),Convert.ToDouble(txtAcierto.Text)).ToString();
            txtPrbabilidad.Text = DistribucionBinomial(Convert.ToDouble(txtEnsayos.Text),Convert.ToDouble(txtAcierto.Text),Convert.ToDouble(txtIntentos.Text)).ToString();
        }
    }
}
