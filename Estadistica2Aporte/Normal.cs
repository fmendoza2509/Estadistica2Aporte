using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meta.Numerics.Statistics.Distributions;

namespace Estadistica2Aporte{
    public partial class Normal : Form{
        private NormalDistribution d = new NormalDistribution();
        public Normal(){
            InitializeComponent();
            InhabilitarNormal();
            InhabilitarZ();
        }
        //Método para inhabilitar desde el inicio
        private void InhabilitarNormal() {
            txtMedia.Enabled = false;
            txtDesvEstandar.Enabled = false;
            txtX.Enabled = false;
            txtProbabilidad.Enabled = false;
            txtPorcentaje.Enabled = false;
        }
        //Método para inhabilitar las cajas de texto de resultado
        private void InhabilitarZ() {
            txtZ.Enabled = false;
            txtInterInicial.Enabled = true;
            txtInterFinal.Enabled = true;
        }
        //Método para habilitar las cajas de texto con la distribucion normal
        private void HabilitarNormal() {
            txtMedia.Enabled = true;
            txtDesvEstandar.Enabled = true;
            txtX.Enabled = true;
        }
        //Método para habilitar las cajas de texto con la distribucion normal estandar z
        private void HabilitarZ() {
            txtZ.Enabled = true;
            txtInterInicial.Enabled = false;
            txtInterFinal.Enabled = false;
        }
        //Método para calcular z cuando se seleccione la opcion de la distribucion normal
        private double CalcularZ(double mu, double sigma, double x) {
            return ((x - mu)/(sigma));
        }
        //Método para borrar las cajas de texto
        private void Borrar() {
            txtMedia.Text = "";
            txtDesvEstandar.Text = "";
            txtX.Text = "";
            txtZ.Text = "";
            txtInterInicial.Text = "";
            txtInterFinal.Text = "";
            txtProbabilidad.Text = "";
            txtPorcentaje.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e){
            Borrar();
        }

        private void btnCalcular_Click(object sender, EventArgs e){
            double a, b, r,aux;
            a = b = r = aux = 0;
            try{
                if (rBtnEstandar.Checked) {
                    if (rBtnEntre.Checked) {
                        if (Convert.ToDouble(txtInterInicial.Text) < 0){
                            if (Convert.ToDouble(txtInterFinal.Text) > Convert.ToDouble(txtInterInicial.Text)){
                                aux = Convert.ToDouble(txtInterInicial.Text) * -1;
                                a = d.LeftProbability(aux) - d.LeftProbability(0);
                                b = d.LeftProbability(Convert.ToDouble(txtInterFinal.Text)) - d.LeftProbability(0);
                                r = a + b;
                                txtProbabilidad.Text = r.ToString();
                                txtPorcentaje.Text = (r * 100).ToString() + "%";
                            }else {
                                MessageBox.Show("El valor del intervalo final debe ser mayor"
                                    +"\nal intervalo inicial");
                                txtInterFinal.Text = "";
                                txtInterFinal.Focus();
                            }
                        }else if(Convert.ToDouble(txtInterInicial.Text)>=0){
                            if (Convert.ToDouble(txtInterFinal.Text) > Convert.ToDouble(txtInterInicial.Text)){
                                r = d.LeftProbability(Convert.ToDouble(txtInterFinal.Text)) - d.LeftProbability(Convert.ToDouble(txtInterInicial.Text));
                                txtProbabilidad.Text = r.ToString();
                                txtPorcentaje.Text = (r * 100).ToString() + "%";
                            }else {
                                MessageBox.Show("El valor del intervalo final debe ser mayor"
                                    + "\nal intervalo inicial");
                                txtInterFinal.Text = "";
                                txtInterFinal.Focus();
                            }
                        }
                    } else if (rBtnMenorIgual.Checked) {
                        r = d.LeftProbability(Convert.ToDouble(txtZ.Text));
                        txtProbabilidad.Text = r.ToString();
                        txtPorcentaje.Text = (r * 100).ToString() + "%";
                    } else if (radioButton1.Checked) {
                        r = d.RightProbability(Convert.ToDouble(txtZ.Text));
                        txtProbabilidad.Text = r.ToString();
                        txtPorcentaje.Text = (r * 100).ToString() + "%";
                    }
                } else if (rBtnNormal.Checked) {
                    if (Convert.ToDouble(txtMedia.Text) > 0){
                        if (Convert.ToDouble(txtDesvEstandar.Text) > 0){
                            if (Convert.ToDouble(txtX.Text)>0) {                                
                                if (rBtnMenorIgual.Checked) {
                                    r = d.LeftProbability(
                                        CalcularZ(Convert.ToDouble(txtMedia.Text),
                                        Convert.ToDouble(txtDesvEstandar.Text), Convert.ToDouble(txtX.Text)));
                                    txtProbabilidad.Text = r.ToString();
                                    txtPorcentaje.Text = (r * 100).ToString() + "%";
                                } else if (radioButton1.Checked) {
                                    r = d.RightProbability(
                                        CalcularZ(Convert.ToDouble(txtMedia.Text),
                                        Convert.ToDouble(txtDesvEstandar.Text), Convert.ToDouble(txtX.Text)));
                                    txtProbabilidad.Text = r.ToString();
                                    txtPorcentaje.Text = (r * 100).ToString() + "%";
                                }
                            }
                            else {
                                MessageBox.Show("Ingrese el valor esperado"
                                    +"\nEste valor no puede ser negativo");
                                txtX.Text = "";
                                txtX.Focus();
                            }
                        }else {
                            MessageBox.Show("Ingrese el valor de la desviación estandar"
                                +"\nEste valor no puede ser negativo");
                            txtDesvEstandar.Text = "";
                            txtDesvEstandar.Focus();
                        }
                    }else {
                        MessageBox.Show("Ingrese el valor de la media"
                            +"\nEste valor es mayor que 0");
                        txtMedia.Text = "";
                        txtMedia.Focus();
                    }
                }
            }catch (Exception){
                if (txtInterInicial.Text == string.Empty){
                    MessageBox.Show("Ingrese el valor del intervalo inicial en Z");
                    txtInterInicial.Text = "";
                    txtInterInicial.Focus();
                }else if (txtInterFinal.Text == string.Empty){
                    MessageBox.Show("Ingrese el valor del intervalo final en Z");
                    txtInterFinal.Text = "";
                    txtInterFinal.Focus();
                }else {
                    MessageBox.Show("Verifique los datos por favor");
                }
            }
        }

        private void rBtnEstandar_CheckedChanged(object sender, EventArgs e){
            InhabilitarNormal();
        }

        private void rBtnEntre_CheckedChanged(object sender, EventArgs e){
            
            if (rBtnNormal.Checked) {
                txtInterInicial.Enabled = false;
                txtInterFinal.Enabled = false;
            } else if (rBtnEstandar.Checked) {
                InhabilitarZ();
            }
        }

        private void rBtnNormal_CheckedChanged(object sender, EventArgs e){
            HabilitarNormal();
            txtInterInicial.Enabled = false;
            txtInterFinal.Enabled = false;
        }

        private void rBtnMenorIgual_CheckedChanged(object sender, EventArgs e){
            if (rBtnEstandar.Checked) {
                HabilitarZ();
            } else if (rBtnNormal.Checked) {
                HabilitarNormal();
                InhabilitarZ();
                txtInterInicial.Enabled = false;
                txtInterFinal.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e){
            if (rBtnEstandar.Checked){
                HabilitarZ();
            }else if (rBtnNormal.Checked){
                HabilitarNormal();
                InhabilitarZ();
                txtInterInicial.Enabled = false;
                txtInterFinal.Enabled = false;
            }
        }
    }
}
