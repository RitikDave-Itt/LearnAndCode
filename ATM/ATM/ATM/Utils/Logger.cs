using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Utils
{
    public static class Logger
    {
        public static void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] " + message);
            Console.ResetColor();
        }

        public static void LogSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[SUCCESS] " + message);
            Console.ResetColor();
        }

        public static void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[INFO] " + message);
            Console.ResetColor();
        }
    }

}
