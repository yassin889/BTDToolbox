﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDToolbox
{
    class ProjectConfigs
    {
        public class Window
        {
            public string WindowName { get; set; }
            public int SizeX = 0;
            public int SizeY = 0;
            public int PosX { get; set; }
            public int PosY { get; set; }
            public float FontSize { get; set; }
            public Window(string windowName, int sizeX, int sizeY, int posX, int posY, float fontSize)
            {
                WindowName = windowName;
                SizeX = sizeX;
                SizeY = sizeY;
                PosX = posX;
                PosY = posY;
                FontSize = fontSize;
            }

        }
        public class MainForm_Config : Window
        {
            public bool EnableConsole { get; set; }
            public bool Fullscreen { get; set; }
            public string DirPath { get; set; }
            public MainForm_Config(string windowName, int sizeX, int sizeY, int posX, int posY, float fontSize, bool enableConsole, string dirPath, bool fullscreen) : base(windowName, sizeX, sizeY, posX, posY, fontSize)
            {
                WindowName = windowName;
                SizeX = sizeX;
                SizeY = sizeY;
                PosX = posX;
                PosY = posY;
                FontSize = fontSize;
                DirPath = dirPath;
                EnableConsole = enableConsole;
                Fullscreen = fullscreen;
            }
        }
        public class JetExplorer_Config : Window
        {
            public int SplitterDistance { get; set; }
            public float TreeViewFontSize { get; set; }
            public string LastProject { get; set; }
            public JetExplorer_Config(string windowName, string lastProject, int sizeX, int sizeY, int posX, int posY, float fontSize, int splitterDistance, float treeViewFontSize) : base(windowName, sizeX, sizeY, posX, posY, fontSize)
            {
                WindowName = windowName;
                LastProject = lastProject;
                SizeX = sizeX;
                SizeY = sizeY;
                PosX = posX;
                PosY = posY;
                FontSize = fontSize;
                SplitterDistance = splitterDistance;
                TreeViewFontSize = treeViewFontSize;
            }
        }
        public class JsonEditor_Config : Window
        {
            public JsonEditor_Config(string windowName, int sizeX, int sizeY, int posX, int posY, float fontSize) : base(windowName, sizeX, sizeY, posX, posY, fontSize)
            {
                WindowName = windowName;
                SizeX = sizeX;
                SizeY = sizeY;
                PosX = posX;
                PosY = posY;
                FontSize = fontSize;
            }
        }
        public class LaunchSettings_Config
        {
            public string GameDir { get; set; }

            public LaunchSettings_Config(string gameDir)
            {
                GameDir = gameDir;
            }
        }
    }
}
