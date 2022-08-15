﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro._Tabuleiro tab) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
