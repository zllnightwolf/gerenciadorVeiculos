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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void porCódigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaBuscarPorEspecificacao telaBuscar = new TelaBuscarPorEspecificacao();
            telaBuscar.Show();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarVeiculo telaCadastrar = new TelaCadastrarVeiculo();
            telaCadastrar.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarVeiculo telaBuscar = new TelaBuscarVeiculo();
            telaBuscar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarVeiculo telaAlterarVeiculo = new TelaAlterarVeiculo();
            telaAlterarVeiculo.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletarVeiculo telaDeletarVeiculo = new TelaDeletarVeiculo();
            telaDeletarVeiculo.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
