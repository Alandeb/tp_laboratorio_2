using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace Calculadora_tp
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private static double Operar(string numero1 , string numero2 , string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.ResetText();
            lblResultado.ResetText();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = Convert.ToString(resultado);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            
            if(lblResultado.Text == "" )
            {
                double numD;
                double.TryParse(txtNumero1.Text, out numD);
                Numero num1 = new Numero(txtNumero1.Text);
                lblResultado.Text = num1.DecimalBinario(numD);
            }
            else
            {
                Numero num1 = new Numero(lblResultado.Text);
                lblResultado.Text = num1.DecimalBinario(lblResultado.Text);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "")
            {
                
                Numero num1 = new Numero(txtNumero1.Text);
                lblResultado.Text = num1.BinarioDecimal(txtNumero1.Text);
            }
            else
            {
                Numero num1 = new Numero(lblResultado.Text);
                lblResultado.Text = num1.BinarioDecimal(lblResultado.Text);
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
