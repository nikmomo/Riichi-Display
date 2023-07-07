using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riichi_display
{
    internal class Player
    {
        public string Name { get; set; } = "NoName";
        public string Team { get; set; } = "N/A";
        public int Point { get; set; } = 25000;
        public int Addup { get; set; } = 0;
        public bool Riichi { get; set; } = false;
        public bool Tenpai { get; set; } = false;
        public int Index { get; set; } = 0;
        public bool Oya { get; set; } = false;
        public bool Winner { get; set; } = false;

        public override string ToString()
        {
            return $"Player Info: \n" +
                   $"Name: {Name}\n" +
                   $"Team: {Team}\n" +
                   $"Point: {Point}\n" +
                   $"Addup: {Addup}\n" +
                   $"Riichi: {Riichi}\n" +
                   $"Tenpai: {Tenpai}\n" +
                   $"Seat: {Index}\n" +
                   $"Oya: {Oya}\n" +
                   $"Winner: {Winner}\n";
        }
        public void ClearAddupWinner()
        {
            Addup = 0;
            Winner = false;
        }
        public void Clear()
        {
            ClearAddupWinner();
            Riichi = false;
            Tenpai = false;
            Winner = false;
        }

        public void Reset()
        {
            Clear();
            Point = 25000;
            Oya = false;
        }
    }
}
