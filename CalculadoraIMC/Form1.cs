using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class FmIMC : Form
    {
        public FmIMC()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obter os números do form
            double peso, alt, imc;
            peso = double.Parse(txbPeso.Text);
            alt = double.Parse(txbAltura.Text);
            // Calcular o IMC
            alt = Math.Pow(alt, 2);
            imc = Math.Round(peso / alt);

            txbResultado.Text = imc.ToString();
            // Classificar com base no IMC 
            if(imc < 18.5)
            {
                lblClassificação.Text = "abaixo do peso";
                lblClassificação.ForeColor = Color.Yellow;
            }
            else if(imc > 18.6 && imc < 24.9)
            {
                lblClassificação.Text = "Peso ideal(Parabéns!)";
                lblClassificação.ForeColor = Color.Green;
            }
            else if(imc > 25.0 && imc < 29.9)
            {
                lblClassificação.Text = "Levemente acima do peso";
                lblClassificação.ForeColor = Color.Yellow;
            }
            else if(imc > 30.0 && imc < 34.9)
            {
                lblClassificação.Text = "Obesidade grau 1";
                lblClassificação.ForeColor = Color.Red;
            }
            else if (imc > 35.0 && imc < 39.9)
            {
                lblClassificação.Text = "Obesidade grau 2";
                lblClassificação.ForeColor = Color.Red;
            }
            else if (imc > 40)
            {
                lblClassificação.Text = "Obesidade grau 3";
                lblClassificação.ForeColor = Color.Red;
            }
            else
            {
                lblClassificação.Text = "Classificação não encontrada";
            }
        }

        private void FmIMC_Load(object sender, EventArgs e)
        {

        }
    }
}
