using gerenciadorVeiculos.Controller;
using gerenciadorVeiculos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciadorVeiculos.View
{
    public partial class TelaCadastrarVeiculo : Form
    {
        public TelaCadastrarVeiculo()
        {
            InitializeComponent();
        }

        public void AbrirCadastro()
        {
            this.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Veiculos.NomeVeic = textBoxNome.Text;
            Veiculos.ModeloVeic = textBoxModelo.Text;
            Veiculos.PlacaVeic = textBoxPlaca.Text;
            Veiculos.CorVeic = textBoxCor.Text;
            Veiculos.AnoVeic = textBoxAno.Text;
            Veiculos.MarcaVeic = textBoxMarca.Text;

            GerenciarVeiculos gerenciarVeiculos = new GerenciarVeiculos();
            gerenciarVeiculos.CodVeic();

            textBoxNome.Text = Veiculos.NomeVeic;
            textBoxModelo.Text = Veiculos.ModeloVeic;
            textBoxPlaca.Text = Veiculos.PlacaVeic;
            textBoxCor.Text = Veiculos.CorVeic;
            textBoxAno.Text = Veiculos.AnoVeic;
            textBoxMarca.Text = Veiculos.MarcaVeic;

            if (Veiculos.RetornoVeic == "v")
            {
                this.Close();
            }

        }
    }
}
