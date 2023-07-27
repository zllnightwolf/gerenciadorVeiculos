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
    public partial class TelaAlterarVeiculo : Form
    {
        public TelaAlterarVeiculo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Veiculos.Codigo = Convert.ToInt32(textBoxCodigo.Text);

            GerenciarVeiculos gerenciarVeiculos = new GerenciarVeiculos();
            gerenciarVeiculos.BuscaVeiculoCod();

            textBoxCodigoVer.Text = Veiculos.Codigo.ToString();
            textBoxNome.Text = Veiculos.NomeVeic;
            textBoxMarca.Text = Veiculos.MarcaVeic;
            textBoxModelo.Text = Veiculos.ModeloVeic;
            textBoxAno.Text = Veiculos.AnoVeic;
            textBoxPlaca.Text = Veiculos.PlacaVeic;
            textBoxCor.Text = Veiculos.CorVeic;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Veiculos.Codigo = Convert.ToInt32(textBoxCodigoVer.Text);
            Veiculos.NomeVeic = textBoxNome.Text;
            Veiculos.ModeloVeic = textBoxModelo.Text;
            Veiculos.AnoVeic = textBoxAno.Text;
            Veiculos.PlacaVeic = textBoxPlaca.Text;
            Veiculos.CorVeic = textBoxCor.Text;
            Veiculos.MarcaVeic = textBoxMarca.Text;

            GerenciarVeiculos gerenciarVeiculos = new GerenciarVeiculos();
            gerenciarVeiculos.AlterarVeic();
        }
    }
}
