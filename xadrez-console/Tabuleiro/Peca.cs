using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; set; }
        public _tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, _tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;            
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
