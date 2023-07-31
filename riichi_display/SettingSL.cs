using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace riichi_display
{
    public class SettingSL
    {
        const int playerCount = 4;
        private ApplicationState appState;
        private class ApplicationState
        {
            public Player[] Players { get; set; }
            public PointHandler Handler { get; set; }
            public setting set { get; set; }

            public int RoundIndex { get; set; }

            public ApplicationState()
            {
                RoundIndex = 0;
                Handler = new PointHandler();
            }
        }

        string fileName = "setting.json";

        public SettingSL()
        {
            LoadJSON();
        }
        private void LoadJSON()
        {
            Player[] players = new Player[playerCount];

            if (!File.Exists(fileName)) // If the file isn't exist, then make new states
            {
                for (int i = 0; i < playerCount; i++)
                {
                    players[i] = new Player { Index = i, Name = "PLAYER" + (i + 1).ToString() };
                    if (i == 0)
                        players[i].Oya = true; // Assign dealer status to first player
                }
                appState = new ApplicationState();
                appState.Players = players;
                return;
            }

            // Read the file
            string json = File.ReadAllText(fileName);

            // Deserialize the JSON into a Player array
            appState = JsonConvert.DeserializeObject<ApplicationState>(json);

            if (appState == null)
            {
                appState = new ApplicationState();
                appState.Players = players;
            }
        }

        public Player[] LoadPlayer()
        {
            return appState.Players;
        }

        public PointHandler LoadHandler()
        {
            return appState.Handler;
        }

        public int LoadRoundIndex()
        {
            return appState.RoundIndex;
        }

        public void SaveState(Player[] players, PointHandler handler, int roundIndex)
        {
            appState.Players = players;
            appState.Handler = handler;
            appState.RoundIndex = roundIndex;

            // Serialize the players array to JSON
            string json = JsonConvert.SerializeObject(appState);

            // Write the JSON to the file
            File.WriteAllText(fileName, json);

        }
    }
}
