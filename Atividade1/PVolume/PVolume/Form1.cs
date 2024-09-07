using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        double raio, altura, resultado;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_Validated(object Cancelsender, EventArgs e)
        {
            if (!Double.TryParse(lblAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
                e.Cancel = true;
            }
            else if (altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior que zero");
                e.Cancel = true;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtRaio.Text, out raio) ||
                !Double.TryParse(TxtAltura.Text, out altura) ||
                raio <= 0 || altura <= 0)
            resultado = Math.PI * Math.Pow(raio, 2) * altura;
            txtResultado.Text = resultado.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            TxtAltura.Text = "";
            txtresultado.Clear();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(!Double.TryParse(lblRaio.Text, out raio))
            {
                MessageBox.Show("Raio inválido!");
                lblRaio.Focus();
            }
            else if (raio<= 0)
            {
                MessageBox.Show("Raio deve ser maior que zero!");
                lblRaio.Focus();
            }
        }
        private void txtRaio_Validated(object sender, EventArgs e)
        { 
            if (!Double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Raio invalido!");
                txtRaio.Focus();
            }
            else if (raio<= 0)
            {
                MessageBox.Show("Raio deve ser maior que zero");
                txtRaio.Focus();
            }
                
        }
    }
}
