using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica2Aporte{
    public partial class Exponencial : Form{
        public Exponencial(){
            InitializeComponent();
            Desactivar();
        }
        //Método para borrar
        private void Borrar() {
            txtLambdaN.Text = "";
            txtX.Text = "";            
            txtInterInicial.Text = "";
            txtInterFinal.Text = "";
            txtProbabilidad.Text = "";
        }
        //Método para desactivar cajas de texto innecesarias
        private void Desactivar() {
            txtInterInicial.Enabled = false;
            txtInterFinal.Enabled = false;
            txtX.Enabled = true;
        }
        //Método para activar las cajas de texto
        private void Activar() {
            txtInterInicial.Enabled = true;
            txtInterFinal.Enabled = true;
            txtX.Enabled = false;
        }
        //Método para calcular la distribición exponencial
        private double DistExponencial(double l, double x) {
            return (1-Math.Pow(Math.E,(-1*(l*x))));
        }
        //Método para validar Lambda numerador
        private bool ValLambdaN() {
            if (Convert.ToDouble(txtLambdaN.Text) > 0){
                return true;
            }else {
                return false;
            }
        }
        //Método para validar x
        private bool ValOcurrencia() {
            if (Convert.ToDouble(txtX.Text) > 0){
                return true;
            }else {
                return false;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e){
            double r = 0;
            try{
                if (ValLambdaN() == true){
                    if (ValOcurrencia() == true) {
                        if (rBtnEntre.Checked){
                            r = DistExponencial(Convert.ToDouble(txtLambdaN.Text), Convert.ToDouble(txtInterFinal.Text))
                                - DistExponencial(Convert.ToDouble(txtLambdaN.Text), Convert.ToDouble(txtInterInicial.Text));
                            txtProbabilidad.Text = r.ToString();
                        }else if (rBtnMenorIgual.Checked) {
                            txtProbabilidad.Text = DistExponencial(Convert.ToDouble(txtLambdaN.Text),Convert.ToDouble(txtX.Text)).ToString();
                        }else if (rBtnMayorIgual.Checked) {
                            r = 1 - DistExponencial(Convert.ToDouble(txtLambdaN.Text),Convert.ToDouble(txtX.Text));
                            txtProbabilidad.Text = r.ToString();
                        }
                    }else {
                        txtProbabilidad.Text = "0";
                    }
                }else {
                    MessageBox.Show("Ingrese el promedio de ocurrencia Lambda"
                        +"\nEste valor tiene que ser mayor a 0");
                    txtLambdaN.Text = "";
                    txtLambdaN.Focus();
                }
            }catch (Exception){
                if (txtLambdaN.Text == string.Empty) {
                    MessageBox.Show("Ingrese el valor de Lambda"
                        + "\nEL valor de Lambda es mayor que 0");
                    txtLambdaN.Text = "";
                    txtLambdaN.Focus();
                } else if (txtX.Text == string.Empty) {
                    MessageBox.Show("Ingrese el valor de ocurrencia");
                    txtX.Text = "";
                    txtX.Focus();
                }
            }
        }

        private void rBtnEntre_CheckedChanged(object sender, EventArgs e){
            Activar();
        }
        
        private void rBtnMenorIgual_CheckedChanged(object sender, EventArgs e){
            Desactivar();
        }

        private void rBtnMayorIgual_CheckedChanged(object sender, EventArgs e){
            Desactivar();
        }

        private void btnBorrar_Click(object sender, EventArgs e){
            Borrar();
        }
    }
}
