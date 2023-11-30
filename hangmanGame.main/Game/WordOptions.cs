using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangmanGame.main.Game
{
    internal class WordOptions
    {
        public static Dictionary<string, string> Dict()
        {
            return new Dictionary<string, string> {
            {"GIRASSOL", "Natureza"},
            {"FLORESTA", "Natureza"},
            {"ALEGRIA", "Sentimento"},
            {"FELICIDADE", "Sentimento"},
            {"TRISTEZA", "Sentimento"},
            {"RAIVA", "Sentimento"},
            {"LIVRO", "Material Escolar"},
            {"MOCHILA", "Material Escolar"},
            {"CADERNO", "Material Escolar"},
            {"COMPUTADOR", "Material Escolar"},
            {"CARRO", "Veículo"},
            {"MOTO", "Veículo"},
            {"BICICLETA", "Veículo"},
            {"CACHORRO", "Animal de Estimação"},
            {"GATO", "Animal de Estimação"},
            {"HAMSTER", "Animal de Estimação"},
            {"FUTEBOL", "Esportes"},
            {"HANDEBOL", "Esportes"},
            {"BASQUETE", "Esportes"}
            };
        }
    }
}
