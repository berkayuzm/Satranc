using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satranc_oyunu
{
    internal class Sah:Chesspiece,IChesspiece
    {
        public Sah(int PosX, int PosY, int Score, string type)
        {

            this.Score = Score;
            this.PosX = PosX;
            this.PosY = PosY;
            this.type = type;
        }
    }
}
