using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorVeiculos.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pamela.tgpaz\source\repos\gerenciadorVeiculos\gerenciadorVeiculos\Model\gerenciarVeiculosbd.mdf;Integrated Security=True";
        }
    }
}
