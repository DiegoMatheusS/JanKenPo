using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonKenPo.Model
{
    public class Jogador
    {
        public Jogador(string nome, string escolha, int pontuacao)
        {
            Nome = nome;
            Escolha = escolha;
            Pontuacao = pontuacao;
        }

        public string Nome { get; set; }

        public string Escolha{ get; set; }

        public int Pontuacao { get; set; }
    }



  
}
