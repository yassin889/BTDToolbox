﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDToolbox.Classes
{
    class NKHook
    {
        public static string nkhEXE = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NKHook5\\NKHook5-Injector.exe";
        public static bool DoesNkhExist()
        {
            if (File.Exists(nkhEXE))
            {
                return true;
            }
            return false;
        }

        public static void LaunchNKH()
        {
            if(!DoesNkhExist())
            {
                ConsoleHandler.appendLog("Unable to find NKHook5-Injector.exe. Failed to launch...");
                return;
            }
            ConsoleHandler.appendLog("Launching NKHook");
            Process.Start(nkhEXE);
        }

        public static void OpenNkhGithub()
        {
            ConsoleHandler.appendLog("Opening NKHook Github page...");
            Process.Start("https://github.com/DisabledMallis/NKHook5");
        }
    }
}
