using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorVeiculos.Model
{
    internal class Veiculos
    {
        private static int codigo;
        private static string nomeVeic;
        private static string modeloVeic;
        private static string anoVeic;
        private static string placaVeic;
        private static string corVeic;
        private static string marcaVeic;
        private static string retornoVeic;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string NomeVeic { get => nomeVeic; set => nomeVeic = value; }
        public static string ModeloVeic { get => modeloVeic; set => modeloVeic = value; }
        public static string AnoVeic { get => anoVeic; set => anoVeic = value; }
        public static string PlacaVeic { get => placaVeic; set => placaVeic = value; }
        public static string CorVeic { get => corVeic; set => corVeic = value; }
        public static string MarcaVeic { get => marcaVeic; set => marcaVeic = value; }
        public static string RetornoVeic { get => retornoVeic; set => retornoVeic = value; }
    }
}
