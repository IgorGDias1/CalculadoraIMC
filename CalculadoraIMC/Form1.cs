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
            double peso, alt, imc;
            peso = double.Parse(txbPeso.Text);
            alt = double.Parse(txbAltura.Text);
            alt = Math.Pow(alt, 2);
            imc = peso / alt;

            txbResultado.Text = imc.ToString();

            if(imc < 18.5)
            {
                lblResultado.Text = "abaixo do peso";
            }
            else if(imc > 18.6 && imc < 24.9)
            {
                lblResultado.Text = "Peso ideal(Parabéns!)";
            }
            else if(imc > 25.0 && imc < 29.9)
            {
                lblResultado.Text = "Levemente acima do peso";
            }
            else if(imc > 30.0 && imc < 34.9)
            {
                lblResultado.Text = "Obesidade grau 1";
            }
            else if (imc > 35.0 && imc < 39.9)
            {
                lblResultado.Text = "Obesidade grau 2";
            }
            else if (imc > 40)
            {
                lblResultado.Text = "Obesidade grau 3";
            }
            else
            {
                lblResultado.Text = "Classificação não encontrada";
            }
        }
    }
}
