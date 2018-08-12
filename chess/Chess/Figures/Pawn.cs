﻿using System;
using System.Collections.Generic;
using System.Text;
using Common;
using Figures.Contracts;

namespace Figures
{
    public class Pawn : BaseFigure, IFigure
    {
        public Pawn(ChessColor color)
            : base(color)
        {
        }
    }
}
