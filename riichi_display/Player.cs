/*
This file is part of Riichi Mahjong Livestreaming Display System.

Riichi Mahjong Livestreaming Display System is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Riichi Mahjong Livestreaming Display System is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Riichi Mahjong Livestreaming Display System.  If not, see <https://www.gnu.org/licenses/>.
*/

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
