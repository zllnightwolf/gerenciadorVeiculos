using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gerenciadorVeiculos.Model;

using gerenciadorVeiculos.View;
using Microsoft.Data.SqlClient;

namespace gerenciadorVeiculos.Controller
{
    internal class GerenciarVeiculos
    {
        public void CodVeic()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVeiculo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("nomeVeic", Veiculos.NomeVeic);
                cmd.Parameters.AddWithValue("modeloVeic", Veiculos.ModeloVeic);
                cmd.Parameters.AddWithValue("anoVeic", Veiculos.AnoVeic);
                cmd.Parameters.AddWithValue("placaVeic", Veiculos.PlacaVeic);
                cmd.Parameters.AddWithValue("corVeic", Veiculos.CorVeic);
                cmd.Parameters.AddWithValue("marcaVeic", Veiculos.MarcaVeic);

                SqlParameter nv = cmd.Parameters.Add("IdVeiculos", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Veículo Cadastrado com Sucesso, Deseja Cadastrar outro?",
                    "Novo Cadastro", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    //TelaCadastrarVeiculo telaCadastro = new TelaCadastrarVeiculo();
                    //telaCadastro.AbrirCadastro();

                    Veiculos.NomeVeic = string.Empty;
                    Veiculos.AnoVeic = string.Empty;
                    Veiculos.CorVeic = string.Empty;
                    Veiculos.ModeloVeic = string.Empty;
                    Veiculos.PlacaVeic = string.Empty;
                    Veiculos.MarcaVeic = string.Empty;
                }
                else
                {
                    Veiculos.RetornoVeic = "v";
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BuscaVeiculoCod()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscarVeiculoCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdVeiculos", Veiculos.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Veiculos.Codigo = Convert.ToInt32(registros["IdVeiculo"]);
                    Veiculos.NomeVeic = (string)registros["nomeVeic"];
                    Veiculos.ModeloVeic = (string)registros["modeloVeic"];
                    Veiculos.AnoVeic = (string)registros["anoVeic"];
                    Veiculos.PlacaVeic = (string)registros["placaVeic"];
                    Veiculos.CorVeic = (string)registros["corVeic"];
                    Veiculos.MarcaVeic = (string)registros["marcaVeic"];
                }
                else
                {
                    Veiculos.Codigo = 0;
                    Veiculos.NomeVeic = "";
                    Veiculos.ModeloVeic = "";
                    Veiculos.AnoVeic = "";
                    Veiculos.PlacaVeic = "";
                    Veiculos.CorVeic = "";
                    Veiculos.MarcaVeic = "";
                    MessageBox.Show("Veículo não encontrado", "Pesquisa Código");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarVeic()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarVeiculo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdVeiculos",Veiculos.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Veículo deletado com sucesso, Deseja Deletar outro",
                    "Deletar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarVeic()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarVeiculos", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@IdVeiculos", Veiculos.Codigo);
                cmd.Parameters.AddWithValue("@nomeVeic", Veiculos.NomeVeic);
                cmd.Parameters.AddWithValue("@modeloVeic", Veiculos.ModeloVeic);
                cmd.Parameters.AddWithValue("@anoVeic", Veiculos.AnoVeic);
                cmd.Parameters.AddWithValue("@placaVeic", Veiculos.PlacaVeic);
                cmd.Parameters.AddWithValue("@corVeic", Veiculos.CorVeic);
                cmd.Parameters.AddWithValue("@marcaVeic", Veiculos.MarcaVeic);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Veículo Alterado com sucesso");

                Veiculos.Codigo = 0;
                Veiculos.NomeVeic = "";
                Veiculos.ModeloVeic = "";
                Veiculos.AnoVeic = "";
                Veiculos.PlacaVeic = "";
                Veiculos.CorVeic = "";
                Veiculos.MarcaVeic = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static BindingSource BuscaVeiculoEspecificacao()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscarEspecificacao", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomeVeic", Veiculos.NomeVeic);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource dados = new BindingSource();
            dados.DataSource = dt;

            return dados;
        }

    }
}
