using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace riichi_display
{
    public enum ActionType
    {
        NONE,
        EDIT,
        RESET,
        RIICHI,
        DRAW,
        TSUMO,
        RON
    }

    public enum EditType
    {
        TEAM,
        NAME,
        POINT
    }

    public class Logger
    {
        private string logFile; // Log file path
        private ActionType Action { set; get; } // Setting the action such that the program can react based on different actions

        public Logger(string logFile)
        {
            this.logFile = logFile;
        }
        
        public void LogRiichi(Player player)
        {
            string actionValue = Action.ToString();
            string logMsg = "[Action:" + actionValue + "]";
            logMsg += "[" + player.Name + ":" + player.Point + "]";
        }

        public void LogSubmission(Player[] players)
        {
            string actionValue = Action.ToString();
            string logMsg = "[Action:" + actionValue + "]";

            foreach (Player player in players)
            {
                logMsg += "[" + player.Name + ":" + player.Point + ":" + player.Addup + "]";
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
            string logMsg = "[Index: " + index + "]" + "[" + editValue + "]" + value;
            WriteLog(FormatMessage(logMsg));
        }


        private string FormatMessage(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return $"{timestamp} - {message}";
        }

        private void WriteLog(string message)
        {
            // This is just an example. Writing directly to a file like this can be slow
            // if you're logging a lot of messages. You might want to consider using a
            // buffer and/or a separate thread for writing the log entries to disk.
            using (StreamWriter writer = File.AppendText(logFile))
            {
                writer.WriteLine(message);
            }
            Action = ActionType.NONE;
        }
    }
}
