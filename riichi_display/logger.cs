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

        public Logger(string logFile)
        {
            this.logFile = logFile;
        }
        
        public void LogStatus(string round, int kyutaku, int combo)
        {
            string logMsg = "[" + round + "]" + "[Kyutaku: " + kyutaku + "]" + "[Combo: " + combo + "]";
            using (StreamWriter writer = File.AppendText(logFile))
            {
                writer.WriteLine(logMsg);
            }
        }

        public void LogRiichi(Player player)
        {
            string riichiStatus = player.Riichi ? "RIICHI" : "RIICHI CANCELLED";
            string logMsg = "[Action:" + riichiStatus + "]";
            logMsg += "[" + player.Name + ":" + player.Point + "]";
            WriteLog(FormatMessage(logMsg));
        }

        public void LogSubmission(Player[] players)
        {
            string actionValue = Action.ToString();
            string logMsg = "[Action:" + actionValue + "]";

            foreach (Player player in players)
            {
                string addupSymbol = player.Addup > 0 ? "+" : "";
                logMsg += "[" + player.Name + ":" + player.Point + ":" + addupSymbol + player.Addup + "]";
            }
            WriteLog(FormatMessage(logMsg));
        }

        public void LogReset()
        {
            WriteLog("[Game Reset / New Game]");
        }

        public void LogEditValue(EditType edit, int index, string value)
        {
            string editValue = edit.ToString();
            string logMsg = "[Action:" + editValue + "]" + "[Player Index: " + index + ": " + value + "]";
            WriteLog(FormatMessage(logMsg));
        }


        private string FormatMessage(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            return $"{timestamp}-{message}";
        }

        private void WriteLog(string message)
        {
            using (StreamWriter writer = File.AppendText(logFile))
            {
                writer.WriteLine(message);
            }
            Action = ActionType.NONE;
        }
    }
}
