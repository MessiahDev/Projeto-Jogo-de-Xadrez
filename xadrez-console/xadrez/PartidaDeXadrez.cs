﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public _Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new _Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQteMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.ColocarPeca(new Rei(Cor.Branca, Tab), new PosicaoXadrez('d', 1).ToPosicao());

            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('d', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 7).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('e', 8).ToPosicao());
            Tab.ColocarPeca(new Rei(Cor.Preta, Tab), new PosicaoXadrez('d', 8).ToPosicao());
        }
    }
}