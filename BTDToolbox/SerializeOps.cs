﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static BTDToolbox.ProjectConfig;
using static BTDToolbox.TD_Toolbox_Window;
using static BTDToolbox.JetForm;
//using static BTDToolbox.ExtractingJet_Window;
namespace BTDToolbox
{
    public class Serializer
    {
        public static void SaveConfig(Form frm, string formName, ConfigFile serialize_config)
        {
            var cfg = Serializer.Deserialize_Config();

            if (formName == "game")
            {
                cfg.CurrentGame = gameName;
            }
            if (formName == "directories")
            {
                if (BTD5_Dir == null)
                    cfg.BTD5_Directory = cfg.BTD5_Directory;
                else
                    cfg.BTD5_Directory = BTD5_Dir;

                if (BTDB_Dir == null)
                    cfg.BTDB_Directory = cfg.BTDB_Directory;
                else
                    cfg.BTDB_Directory = BTDB_Dir;
            }

            if (formName == "main")
            {
                // serialize_config.Main_Fullscreen = WindowState == FormWindowState.Maximized;
                cfg.Main_SizeX = frm.Size.Width;
                cfg.Main_SizeY = frm.Size.Height;
                cfg.Main_PosX = frm.Location.X;
                cfg.Main_PosY = frm.Location.Y;
                cfg.Main_FontSize = frm.Font.Size;
                cfg.EnableConsole = enableConsole;
                cfg.ExistingUser = true;
            }

            if (formName == "console")
            {
                cfg.Console_SizeX = frm.Size.Width;
                cfg.Console_SizeY = frm.Size.Height;
                cfg.Console_PosX = frm.Location.X;
                cfg.Console_PosY = frm.Location.Y;
                cfg.Console_FontSize = frm.Font.Size;
            }

            if (formName == "jet explorer")
            {
                cfg.JetExplorer_SizeX = frm.Size.Width;
                cfg.JetExplorer_SizeY = frm.Size.Height;
                cfg.JetExplorer_PosX = frm.Location.X;
                cfg.JetExplorer_PosY = frm.Location.Y;                
                cfg.JetExplorer_FontSize = frm.Font.Size;
                cfg.JetExplorer_SplitterWidth = jetExplorer_SplitterWidth;
                cfg.JetExplorer_FolderView_FontSize = jetExplorer_FontSize;

                if (projName == null)
                    cfg.LastProject = cfg.LastProject;
                else
                    cfg.LastProject = projName;
            }

            if (formName == "json editor")
            {
                cfg.JSON_Editor_SizeX = frm.Size.Width;
                cfg.JSON_Editor_SizeY = frm.Size.Height;
                cfg.JSON_Editor_PosX = frm.Location.X;
                cfg.JSON_Editor_PosY = frm.Location.Y;
                cfg.JSON_Editor_FontSize = JsonEditor.jsonEditorFont;//frm.Font.Size;
            }

            string output_Cfg = JsonConvert.SerializeObject(cfg, Formatting.Indented);

            StreamWriter serialize = new StreamWriter(Environment.CurrentDirectory + "\\settings.json", false);
            serialize.Write(output_Cfg);
            serialize.Close();
        }

        public static ConfigFile Deserialize_Config()
        {
            ConfigFile programData = new ConfigFile();
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\settings.json"))
                {
                    string json = File.ReadAllText(Environment.CurrentDirectory + "\\settings.json");
                    programData = JsonConvert.DeserializeObject<ConfigFile>(json);
                }
                else
                {
                    //create config

                    programData.BTD5_Directory = "";
                    programData.BTDB_Directory = "";
                    programData.LastProject = null;
                    programData.CurrentGame = null;
                    programData.ExistingUser = false;

                    programData.Main_SizeX = 1280;
                    programData.Main_SizeY = 720;
                    programData.Main_PosX = 0;
                    programData.Main_PosX = 0;
                    programData.Main_FontSize = 10;

                    programData.Console_SizeX = 796;
                    programData.Console_SizeY = 197;
                    programData.Console_PosX = 454;
                    programData.Console_PosY = 448;
                    programData.Console_FontSize = 12;
                    programData.EnableConsole = true;

                    programData.JetExplorer_SplitterWidth = 240;
                    programData.JetExplorer_SizeX = 460;
                    programData.JetExplorer_SizeY = 605;
                    programData.JetExplorer_PosX = 0;
                    programData.JetExplorer_PosY = 0;
                    programData.JetExplorer_FontSize = 10;

                    programData.JSON_Editor_SizeX = 796;
                    programData.JSON_Editor_SizeY = 450;
                    programData.JSON_Editor_PosX = 462;
                    programData.JSON_Editor_PosY = 0;
                    programData.JSON_Editor_FontSize = 13;

                    string output_Cfg = JsonConvert.SerializeObject(programData, Formatting.Indented);

                    StreamWriter serialize = new StreamWriter(Environment.CurrentDirectory + "\\settings.json", false);
                    serialize.Write(output_Cfg);
                    serialize.Close();
                }
            }
            catch (JsonReaderException)
            {
                File.Delete(Environment.CurrentDirectory + "\\settings.json");
            }

            return programData;
        }

    }
}
