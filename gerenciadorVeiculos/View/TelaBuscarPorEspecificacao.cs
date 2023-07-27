﻿using gerenciadorVeiculos.Controller;
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
    public partial class TelaBuscarPorEspecificacao : Form
    {
        public TelaBuscarPorEspecificacao()
        {
            InitializeComponent();
        }

        private void btnBuscarEspec_Click(object sender, EventArgs e)
        {
            Veiculos.NomeVeic = textBoxEspecificacao.Text;
            dataGridView1.DataSource = GerenciarVeiculos.BuscaVeiculoEspecificacao();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderCell.Value = "Código";
            dataGridView1.Columns[8].HeaderCell.Value = "Nome";
            dataGridView1.Columns[9].HeaderCell.Value = "Modelo";
            dataGridView1.Columns[10].HeaderCell.Value = "Ano";
            dataGridView1.Columns[11].HeaderCell.Value = "Placa";
            dataGridView1.Columns[12].HeaderCell.Value = "Cor";
            dataGridView1.Columns[13].HeaderCell.Value = "Marca";
        }
    }
}
