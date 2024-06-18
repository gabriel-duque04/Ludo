using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    internal class Jogador
    {
        public string cor;
        public int id;
        public string nome;
        public Peao[] peoes;
    
        public Jogador(string cor, int id,string nome)
        {
            this.cor = cor;
            this.id = id;
            this.nome = nome;
            this.peoes = new Peao[4];
        }
        public int lancaDado()
        {
            Random r = new Random();
            return (r.Next(1,7));
        }
        public void moverPeao(int id)
        {
            posicao += (lancaDado());
        }
    }
}
