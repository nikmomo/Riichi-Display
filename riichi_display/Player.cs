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
    // The Player class represents a single player in the game.
    // It includes properties for storing the player's information and game status.
    public class Player
    {
        // Player's name
        public string Name { get; set; } = "NoName";

        // Player's team
        public string Team { get; set; } = "N/A";

        // Player's current point total
        public int Point { get; set; } = 25000;

        // Accumulated points from multiple rounds
        public int Addup { get; set; } = 0;

        // Indicates if the player has declared Riichi
        public bool Riichi { get; set; } = false;

        // Indicates if the player is in Tenpai (one away from winning)
        public bool Tenpai { get; set; } = false;

        // Index of the player in a list of players
        public int Index { get; set; } = 0;

        // Indicates if the player is the dealer (Oya)
        public bool Oya { get; set; } = false;

        // Indicates if the player is the winner of the round
        public bool Winner { get; set; } = false;

        // Overrides the ToString() method to display the player's information in a readable format
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

        // Clears the 'Addup' and 'Winner' properties of the player
        public void ClearAddupWinner()
        {
            Addup = 0;
            Winner = false;
        }

        // Clears the game status properties of the player
        public void Clear()
        {
            ClearAddupWinner();
            Riichi = false;
            Tenpai = false;
            Winner = false;
        }

        // Resets all game status properties and the player's points to their initial values
        public void Reset()
        {
            Clear();
            Point = 25000;
            Oya = false;
        }
    }
}
