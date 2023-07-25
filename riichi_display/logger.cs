using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riichi_display
{
    public class Logger
    {
        private string logFile; // Log file path

        public Logger(string logFile)
        {
            this.logFile = logFile;
        }

        public void Log(string message)
        {
            string logMessage = FormatMessage(message);
            WriteLog(logMessage);
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
        }
    }
}
