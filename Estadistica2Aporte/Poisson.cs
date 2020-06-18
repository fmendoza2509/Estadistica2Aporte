using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica2Aporte
{
    public partial class Poisson : Form
    {
        public Poisson(){
            InitializeComponent();
            DescativarTextBox();
        }
        //Método para desactivar componentes cuando no este activo el radiobutton entre
        private void DescativarTextBox(){
            txtInterInicial.Enabled = false;
            txtInterFinal.Enabled = false;
        }
        //Método para activar componentes cuando no este activo el radiobutton entre
        private void ActivarTextBox()
        {
            txtInterInicial.Enabled = true;
            txtInterFinal.Enabled = true;
        }
        //Método para calcular el factorial
        private double Factorial(double f){
            double fact = 1;
            if ((f == 0) || (f == 1)){
                fact = 1;
            }else if (f > 1){
                for (int i = 2; i <= f; i++){
                    fact *= i;
                }
            }
            return fact;
        }
        //Método para calcular la distribucion de poisson
        private double DistPoisson(double l, double x) {
            return (((Math.Pow(Math.E,-l))*(Math.Pow(l,x)))/(Factorial(x)));
        }
        //Método para calcular la desviacion estandar
        private double DesvEstandar(double l) {
            return (Math.Sqrt(l));
        }
        //Método para borrar los texbox
        private void Borrar() {
            txtLambda.Text = "";
            txtOcurrencia.Text = "";
            txtInterInicial.Text = "";
            txtInterFinal.Text = "";
            txtProbabilidad.Text = "";
            txtVEsperado.Text = "";
            txtDesvEstandar.Text = "";
        }
        //Método para validad el promedio de ocurrencia
        private bool ValLambda() {
            if (Convert.ToDouble(txtLambda.Text) > 0)
            {
                return true;
            }else {
                return false;
            }
        }
        //Método para validar la ocurrencia esperada
        private bool ValOcurrencia() {
            if (Convert.ToDouble(txtOcurrencia.Text) >= 0){
                return true;
            }else {
                return false;
            }
        }
        //Método para validar el intervalo inicial
        private bool ValIntInicial() {
            if (Convert.ToDouble(txtInterInicial.Text)>=0) {
                return true;
            }else {
                return false;
            }
        }
        //Método para validar el intervalo final
        private bool ValIntFinal() {
            if (Convert.ToDouble(txtInterFinal.Text)>Convert.ToDouble(txtInterInicial.Text)) {
                return true;
            }else {
                return false;
            }
        }
        private void CalculosBasicos() {
            txtVEsperado.Text = txtLambda.Text;
            txtDesvEstandar.Text = DesvEstandar(Convert.ToDouble(txtLambda.Text)).ToString();
        }
        private void btnCalcular_Click(object sender, EventArgs e){
            double r = 0;
            try{
                if (ValLambda() == true){//Aqui compruebo si lambda tiene un valor
                    if (ValOcurrencia()==true) {
                        if (rBtnIgual.Checked) {
                            CalculosBasicos();
                            txtProbabilidad.Text = DistPoisson(Convert.ToDouble(txtLambda.Text),
                                Convert.ToDouble(txtOcurrencia.Text)).ToString();
                        } else if (rBtnEntre.Checked) {
                            if (ValIntInicial() == true){
                                if (ValIntFinal() == true) {
                                    for (int i = Convert.ToInt32(txtInterInicial.Text); i <= Convert.ToInt32(txtInterFinal.Text); i++)
                                    {
                                        r += DistPoisson(Convert.ToDouble(txtLambda.Text),i);
                                    }
                                    CalculosBasicos();
                                    txtProbabilidad.Text = r.ToString();
                                }
                                else {
                                    MessageBox.Show("Ingrese el favol final"
                                        +"\nEl valor final no puede ser menor al inicial");
                                    txtInterFinal.Text = "";
                                    txtInterFinal.Focus();
                                }
                            }else {
                                MessageBox.Show("Ingrese el valor inicial"
                                    +"\nEl valor inicial no puede ser negativo");
                                txtInterInicial.Text = "";
                                txtInterInicial.Focus();
                            }
                        } else if (rBtnMenor.Checked) {
                            for (int i = 0; i < Convert.ToInt32(txtOcurrencia.Text); i++) {
                                r += DistPoisson(Convert.ToDouble(txtLambda.Text),i);
                            }
                            CalculosBasicos();
                            txtProbabilidad.Text = r.ToString();
                        } else if (rBtnMayor.Checked) {
                            for (int i = 0; i <= Convert.ToInt32(txtOcurrencia.Text); i++) {
                                r += DistPoisson(Convert.ToDouble(txtLambda.Text),i);
                            }
                            r = 1 - r;
                            CalculosBasicos();
                            txtProbabilidad.Text = r.ToString();
                        } else if (rBtnMenorIgual.Checked) {
                            for (int i = 0; i <= Convert.ToInt32(txtOcurrencia.Text); i++) {
                                r += DistPoisson(Convert.ToDouble(txtLambda.Text),i);
                            }
                            CalculosBasicos();
                            txtProbabilidad.Text = r.ToString();
                        } else if (rBtnMayorIgual.Checked) {
                            for (int i = 0;i<Convert.ToInt32(txtOcurrencia.Text);i++) {
                                r += DistPoisson(Convert.ToDouble(txtLambda.Text),i);
                            }
                            r = 1 - r;
                            CalculosBasicos();
                            txtProbabilidad.Text = r.ToString();
                        }
                    }else {
                        MessageBox.Show("Ingrese el número de ocurrencia esperado x"
                        + "\nNo puede ser un número negativo!!!");
                        txtOcurrencia.Text = "";
                        txtOcurrencia.Focus();
                    }
                }else {
                    MessageBox.Show("Ingrese el número de ocurrencia"
                        +"\nEl numero de ocurrencia no puede ser negativo");
                    txtLambda.Text = "";
                    txtLambda.Focus();
                }
            }catch (Exception){
                if (txtLambda.Text == string.Empty) {
                    MessageBox.Show("Ingrese el promedio de ocurrencia Lambda"
                        + "\nNo puede ser un número negativo!!!");
                    txtLambda.Text = "";
                    txtLambda.Focus();
                } else if (txtOcurrencia.Text == string.Empty) {
                    MessageBox.Show("Ingrese el número de ocurrencia esperado x"
                        + "\nNo puede ser un número negativo!!!");
                    txtOcurrencia.Text = "";
                    txtOcurrencia.Focus();
                } else if (txtInterInicial.Text == string.Empty) {
                    MessageBox.Show("Ingrese el valor del intervalo inicial"
                        + "\nNo puede se un número negativo!!!!");
                    txtInterInicial.Text = "";
                    txtInterInicial.Focus();
                } else if (txtInterFinal.Text == string.Empty) {
                    MessageBox.Show("Ingrese el valor del intervalo final"
                        +"\nNo puede ser un número negativo!!!");
                    txtInterFinal.Text = "";
                    txtInterFinal.Focus();
                }
            }
        }
        private void rBtnMenor_CheckedChanged(object sender, EventArgs e){
            DescativarTextBox();
            txtOcurrencia.Enabled = true;
        }
        private void rBtnIgual_CheckedChanged(object sender, EventArgs e){
            DescativarTextBox();
            txtOcurrencia.Enabled = true;
        }

        private void rBtnMayor_CheckedChanged(object sender, EventArgs e){
            DescativarTextBox();
            txtOcurrencia.Enabled = true;
        }

        private void rBtnEntre_CheckedChanged(object sender, EventArgs e){
            ActivarTextBox();
            txtOcurrencia.Enabled = false;
        }

        private void rBtnMenorIgual_CheckedChanged(object sender, EventArgs e){
            DescativarTextBox();
            txtOcurrencia.Enabled = true;
        }

        private void rBtnMayorIgual_CheckedChanged(object sender, EventArgs e){
            DescativarTextBox();
            txtOcurrencia.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e){
            Borrar();
        }
    }
}
