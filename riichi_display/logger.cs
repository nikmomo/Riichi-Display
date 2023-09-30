using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riichi_display
{
    public enum ActionType
    {
        NONE,
        RESET,
        DRAW,
        TSUMO,
        RON
    }

    public enum EditType
    {
        TEAM,
        NAME,
        POINT,
        KYUTAKU,
        COMBO,
        DEALER,
        ROUND
    }

    public class Logger
    {
        private string logFile; // Log file path
        public ActionType Action { set; get; } // Setting the action such that the program can react based on different actions
        private string han = ""; // Han and fu record
        private string fu = "";
        private string point = ""; // use for manual input

        public Logger(string logFile)
        {
            this.logFile = logFile;
        }
        
        public void LogStatus(string round, int kyutaku, int combo)
        {
            string logMsg = "[" + round + "]" + "[场供: " + kyutaku + "]" + "[本场: " + combo + "]";
            WriteLog(FormatMessage(logMsg));
        }

        public void LogRiichi(Player player)
        {
            string riichiStatus = player.Riichi ? "RIICHI" : "RIICHI CANCELLED";
            string logMsg = "[Action:" + riichiStatus + "]";
            logMsg += "[" + player.Name + ":" + player.Point + "]";
            WriteLog(FormatMessage(logMsg));
        }

        public void LogHanFu(string hanValue, string fuValue)
        {
            han = hanValue;
            fu = fuValue;
        }
        private void ClearHanFu() { han = ""; fu = ""; }

        public void LogPoint(string pointValue) 
        { 
            point = pointValue;
            ClearHanFu();
        }

        public void LogSubmission(Player[] players)
        {
            string actionValue = Action.ToString();
            string logMsg = "[Action:" + actionValue + "]";
            if (han != "" || fu != "")
            {
                logMsg += "[" + han + "翻" + fu + "符]";
                ClearHanFu();
            }
            else if (point != "")
            {
                logMsg += "[" + point + "points]";
                point = "";
            }

            foreach (Player player in players)
            {
                string addupSymbol = player.Addup > 0 ? "+" : "";
                logMsg += "[" + player.Name + ":" + player.Point + ":" + addupSymbol + player.Addup + "]";
            }
            WriteLog(FormatMessage(logMsg));
        }

        public void LogReset()
        {
            WriteLog(FormatMessage("[Game Reset / New Game]"));
        }

        public void LogEditValue(EditType edit, int index, string value)
        {
            string editValue = edit.ToString();
            string logMsg = "[Action:" + editValue + "]" + "[Player Index" + index + ": " + value + "]";
            WriteLog(FormatMessage(logMsg));
        }


        private string FormatMessage(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{timestamp}-{message}";
        }

        private void WriteLog(string message)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/RiichiLogs";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (StreamWriter writer = File.AppendText(logFile))
            {
                writer.WriteLine(message);
            }
            //Action = ActionType.NONE;
        }
    }
}
