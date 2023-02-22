using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Satranc_oyunu
{
    internal class GameManager
    {
      
        public void  ReadBoard(string filePath)
        {
            var rows = new string[]
            {
                "1","2","3","4","5","6","7","8"
            };
            var cols = new string[]
            {
                "a","b","c","d","e","f","g","h"
            };
            using (StreamReader sr = new StreamReader(filePath))
            {
                var str = sr.ReadToEnd();
                var boardrows = str.Split('\n');
                var keys = boardrows.Select((x, rowIndex) => x.Split(' ').Select((y, colIndex) => new
                {
                    key = y,
                    row = rows[rowIndex],
                    col = cols[colIndex]
                }).Where(k => k.key != "--")).SelectMany(b => b).ToList();

                foreach (var row in boardrows)
                {
                    Console.WriteLine(row);
                }
            }
          
        }
    }
}
