using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using IWshRuntimeLibrary;

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

            if (!System.IO.File.Exists(fileName)) // If the file isn't exist, then make new states
            {
                CreateShortCut(this, new EventArgs()); // Creating a new shortcut for the first launching

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
            string json = System.IO.File.ReadAllText(fileName);

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
            System.IO.File.WriteAllText(fileName, json);

        }

        /** 
         * Use for creating a shortcut on desktop at the first time starting the program
         * That's why I leave this function here, I know it's weird but I really can't
         * figure out a good place to put this function. You know, if I leave it in main,
         * then settingSL will have hard time using it, and I also want to add a option in
         * setting so that people can manually create a shortcut if they play dumb and delete it
         * So if I leave this function in setting, then still, the same issue. But it does 
         * weird cuz a setting memory class shouldn't have a irrelevant function in it.
         * A function that creating shortcut? what's the relation with memorizing the setting
         * I mean, bruh, Idk man. I really don't want to make this function globally cuz that
         * is really stupid. Well, screw it I'll leave it here.
        **/
        public void CreateShortCut(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutLocation = Path.Combine(desktopPath, "Riichi Display.lnk");
            string targetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Riichi Livestream Display System.exe"); // Change to your application path

            WshShell wsh = new WshShell();
            IWshShortcut shortcut = wsh.CreateShortcut(shortcutLocation) as IWshShortcut;
            shortcut.TargetPath = targetPath;
            shortcut.Description = "意易失，吾亦逝　－－田烁豪耳　1919年8月10日";
            shortcut.IconLocation = targetPath; // Can set to your app icon path
            shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);
            shortcut.Save();
        }
    }
}
