using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        // TODO: 同时handle所有的logging 还是很难的一件事情，需要好好想想在设置完action之后，怎么去log based on different action
        public Logger(string logFile)
        {
            this.logFile = logFile;
        }

        public void LogEditValue(EditType edit, int index, string value)
        {
            string editValue = edit.ToString();
            string logMsg = "[ Player Index: " + index + " ]" + "[" + editValue + "]" + value;
            WriteLog(FormatMessage(logMsg));
            Action = ActionType.NONE;
        }
        //public void Log(string message)
        //{
        //    string logMessage = FormatMessage(message);
        //    WriteLog(logMessage);
        //}

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
        }
    }
}
