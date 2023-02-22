using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satranc_oyunu
{
    internal class Player
    {
        //Her bir oyuncu için name,score ve kalan taşlar bilgisi tutulur ve bu taşların konum bilgileri hesaplanır.
        public string Name { get; set; }

        public int Score { get; set; }
        public List<Chesspiece> kalan_taslar;
        
        public Player(int score, List<Chesspiece> kalan_taslar)
        {
            this.Score = score;
            this.kalan_taslar = kalan_taslar;
        }   

        public List<int[]> Positions()
           
        {
            //Oyuncunun sahip olduğu tüm taşların konumlarını x ve y olarak döndüren fonksiyon.
            List<int[]> arrayList = new List<int[]>();
            this.kalan_taslar.ForEach(delegate (Chesspiece tas)
            {
            arrayList.Add(new int[] { tas.PosX, tas.PosY });
            });

          

            return arrayList;
        }
    }
}
