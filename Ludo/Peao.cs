using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    internal class Peao
    {
        private string peao;
        private int id;
        private int posicao;

        public Peao(string peao, int id, int posicao)
        {
            this.peao = peao;
            this.id = id;
            this.posicao = posicao;
        }

        public void Mover(int casas)
        {
            posicao += casas;
        }
        public void retornarCasa() { 
            posicao = 0;
        }
    }
}
