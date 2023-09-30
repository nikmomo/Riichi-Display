using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using IWshRuntimeLibrary;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace riichi_display
{
    public class displayStatus
    {
        public bool windIndicatorVisual { get; set; }
        public bool teamVisual { get; set; }
        public Font fontName { get; set; }
        public Font fontTeam { get; set; }
        public Font fontPoint { get; set; }
        public Font fontAddup { get; set; }
        //public bool RiichiPostion { get; set; }
    }
    public class SettingSL
    {
        const int playerCount = 4;
        private ApplicationState appState;
        private class ApplicationState
        {
            public Player[] Players { get; set; }
            public PointHandler Handler { get; set; }
            public setting set { get; set; }

            public displayStatus disStatus { get; set; }

            public int RoundIndex { get; set; }

            public ApplicationState()
            {
                RoundIndex = 0;
                Handler = new PointHandler();
                disStatus = new displayStatus();
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

                appState.disStatus.fontName = new Font("Microsoft YaHei UI", 28, FontStyle.Bold | FontStyle.Italic);
                appState.disStatus.fontPoint = new Font("Microsoft YaHei UI", 42, FontStyle.Bold | FontStyle.Italic);
                appState.disStatus.fontAddup = new Font("Microsoft YaHei UI", 26, FontStyle.Bold);
                appState.disStatus.fontTeam = new Font("Microsoft YaHei UI", 22);
                appState.disStatus.windIndicatorVisual = false;
                appState.disStatus.teamVisual = false;
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

        public displayStatus LoadDisplay()
        {
            return appState.disStatus;
        }

        public int LoadRoundIndex()
        {
            return appState.RoundIndex;
        }

        public void SaveState(Player[] players, PointHandler handler, int roundIndex, displayStatus displayStatus)
        {
            appState.Players = players;
            appState.Handler = handler;
            appState.RoundIndex = roundIndex;
            appState.disStatus = displayStatus;

            // Serialize the players array to JSON
            string json = JsonConvert.SerializeObject(appState);

            // Write the JSON to the file
            System.IO.File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName), json);

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
            //string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //string shortcutLocation = Path.Combine(desktopPath, "Riichi Display.lnk");
            string targetPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Riichi Livestream Display System.exe"); // Change to your application path

            //WshShell wsh = new WshShell();
            //IWshShortcut shortcut = wsh.CreateShortcut(shortcutLocation) as IWshShortcut;
            //shortcut.TargetPath = targetPath;
            //shortcut.Description = "意易失，吾亦逝　－－田烁豪耳　1919年8月10日";
            //shortcut.IconLocation = targetPath; // Can set to your app icon path
            //shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);
            //shortcut.Save();

            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription("意易失，吾亦逝　－－田烁豪耳　1919年8月10日");
            link.SetPath(@targetPath);

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            file.Save(Path.Combine(desktopPath, "立直直播.lnk"), false);
        }
    }
}

[ComImport]
[Guid("00021401-0000-0000-C000-000000000046")]
internal class ShellLink
{
}

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("000214F9-0000-0000-C000-000000000046")]
internal interface IShellLink
{
    void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
    void GetIDList(out IntPtr ppidl);
    void SetIDList(IntPtr pidl);
    void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
    void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
    void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
    void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
    void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
    void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
    void GetHotkey(out short pwHotkey);
    void SetHotkey(short wHotkey);
    void GetShowCmd(out int piShowCmd);
    void SetShowCmd(int iShowCmd);
    void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
    void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
    void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
    void Resolve(IntPtr hwnd, int fFlags);
    void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
}
