using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using JonKenPo.Model;
using System.Xml.Linq;

namespace JonKenPo.ViewModel
{
    public partial class JonKenPoViewModel : ObservableObject
    {
        public JonKenPoViewModel() {

            CreateJogadorCommand = new Command(Add);
        }


        [ObservableProperty]
        public string _nome;

        [ObservableProperty]
        public string _escolha;

        [ObservableProperty]
        public int _pontuacao;

        [ObservableProperty]
        public string _escolhapicker;



        private ObservableCollection<Jogador> _jogadores = new ObservableCollection<Jogador>();  //cria colecao de uma lista
        public ObservableCollection<Jogador> Jogador
        {
            get { return _jogadores; }
            set { _jogadores = value; }
        }

        public ICommand CreateJogadorCommand { get; } //pegar comando do botao

        public void Add()
        {
            
            Jogador jogador = new Jogador(Nome, Escolha, Pontuacao);
            _jogadores.Add(jogador);

            int maqueico = new Jogo(Escolha());
        }



    }
}
