using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satranc_oyunu
{
    internal class Piyon : Chesspiece,IChesspiece
    {

      
        public Piyon(int PosX,int PosY, int Score, string type)
        {
            
            this.Score=Score;
            this.PosX = PosX;
            this.PosY= PosY;
            this.type = type;
        }

        //public int[] tehdit_et()
        //{
        //    //if (this.type == "sp")
        //    //{
        //    //    return new 
        //    //}

        //    //return [this.PosX - 1, this.PosY + 1];
        //}
    }
}
