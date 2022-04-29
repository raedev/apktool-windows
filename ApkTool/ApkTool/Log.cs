using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkTool
{
    public delegate void LogEventHandler(string message);

    internal class Log
    {
        public static event LogEventHandler OnLogEvent;

        public static void D(string message)
        {
            var line = $"[{DateTime.Now:HH:mm:ss}] {message}\r\n";
            if (OnLogEvent != null)
            {
                OnLogEvent(line);
            }
        }

        public static void E(string message)
        {
            var line = $"[{DateTime.Now:HH:mm:ss}] [E] {message}\r\n";
            if (OnLogEvent != null)
            {
                OnLogEvent(line);
            }
        }
    }
}
