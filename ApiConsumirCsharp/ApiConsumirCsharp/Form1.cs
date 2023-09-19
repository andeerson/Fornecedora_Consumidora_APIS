using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiConsumirCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Veiculos.GetVeiculos();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var veiculo = new Veiculos();
            veiculo = veiculo.GetVeiculo(Convert.ToInt32(txtId.Text));

            txtId.Text = veiculo.Id.ToString();
            txtMarca.Text = veiculo.Marca;
            txtModelo.Text = veiculo.Modelo;
            txtAno.Text = veiculo.Ano.ToString();
            txtFabricação.Text = veiculo.Fabricacao.ToString();
            txtCor.Text = veiculo.Cor;
            txtAutomatico.Text = veiculo.Automatico.ToString();
            txtCombustivel.Text = veiculo.Combustivel.ToString();
            txtValor.Text = veiculo.Valor.ToString("N2");




        }
    }
}
