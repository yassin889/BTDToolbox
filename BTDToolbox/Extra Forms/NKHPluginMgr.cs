﻿using BTDToolbox.Classes;
using BTDToolbox.Classes.NewProjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ListBox = System.Windows.Forms.ListBox;

namespace BTDToolbox.Extra_Forms
{
    public partial class NKHPluginMgr : ThemedForm
    {
        #region Constructors
        string nkhDir = "";
        public NKHPluginMgr()
        {
            InitializeComponent();

            if (CurrentProjectVariables.GameName != "BTD5")
                this.Close();
            if (!NKHook.DoesNkhExist())
            {
                ConsoleHandler.force_appendNotice("You need to have NKHook downloaded to use this feature.");
                MessageBox.Show("You need to have NKHook downloaded to use this feature.");
                NKHook_Message msg = new NKHook_Message();
                msg.Show();
                this.Close();
            }
            if(IsDisposed)
                return;


            this.Show();
            this.MdiParent = Main.getInstance();

            FileInfo nkhEXE = new FileInfo(NKHook.nkhEXE);
            nkhDir = nkhEXE.FullName.Replace(nkhEXE.Name, "");
            
            PopulateUnloadedPlugings();
        }

        public NKHPluginMgr(string temp): this()
        {

        }
        #endregion
        
        private void PopulateUnloadedPlugings()
        {
            if (!Directory.Exists(nkhDir + "UnloadedPlugins"))
                return;

            var files = new DirectoryInfo(nkhDir + "UnloadedPlugins").GetFiles("*");
            if (files.Length <= 0)
                return;

            foreach(var file in files)
                UnloadedPlugin_LB.Items.Add(file.Name);
        }

        private void LoadPlugin_Button_Click(object sender, EventArgs e)
        {
            if(UnloadedPlugin_LB.SelectedItems.Count <= 0)
            {
                ConsoleHandler.force_appendLog("You need to select at least one plugin in the \"Unloaded Plugins\" section.");
                return;
            }

            MoveLBItem(UnloadedPlugin_LB, LoadedPlugin_LB);
        }

        private void UnloadPlugin_Button_Click(object sender, EventArgs e)
        {
            if (LoadedPlugin_LB.SelectedItems.Count <= 0)
            {
                ConsoleHandler.force_appendLog("You need to select at least one plugin in the \"Loaded Plugins\" section.");
                return;
            }
            MoveLBItem(LoadedPlugin_LB, UnloadedPlugin_LB);
        }
        private void MoveLBItem(ListBox source, ListBox dest)
        {
            FileInfo nkhEXE = new FileInfo(NKHook.nkhEXE);
            var files = source.SelectedItems;
            var unloadedLB = new List<string>();

            foreach (string item in source.Items) unloadedLB.Add(item);

            foreach (string file in files)
            {
                FileInfo f = new FileInfo(nkhEXE.FullName.Replace(nkhEXE.Name, "") + "UnloadedPlugins\\" + file);
                string sourcFile = nkhEXE.FullName.Replace(nkhEXE.Name, "") + "UnloadedPlugins\\" + f.Name;
                string destFile = nkhEXE.FullName.Replace(nkhEXE.Name, "") + "Plugins\\" + f.Name;

                CopyFile(sourcFile, destFile);
                File.Delete(sourcFile);

                dest.Items.Add(f.Name);
                unloadedLB.RemoveAt(source.SelectedIndex);
            }

            source.Items.Clear();
            foreach (var item in unloadedLB)
                source.Items.Add(item);
        }

        private void Done_Button_Click(object sender, EventArgs e)
        {

            this.Close();
            return;
        }

        private void BrowseForPlugin_Button_Click(object sender, EventArgs e)
        {
            FileInfo nkhEXE = new FileInfo(NKHook.nkhEXE);
            if (!Directory.Exists(nkhEXE.FullName.Replace(nkhEXE.Name, "") + "UnloadedPlugins\\"))
                Directory.CreateDirectory(nkhEXE.FullName.Replace(nkhEXE.Name, "") + "UnloadedPlugins\\");

            var files = GeneralMethods.BrowseForFiles("Browse for plugins", "dll", "Dll files (*.dll)|*.dll", Environment.CurrentDirectory);
            if (files.Count() <= 0)
                return;

            foreach(string file in files)
            {
                FileInfo f = new FileInfo(file);                
                CopyFile(f.FullName, nkhEXE.FullName.Replace(nkhEXE.Name,"") + "UnloadedPlugins\\" + f.Name);
                UnloadedPlugin_LB.Items.Add(f.Name);
            }
        }
        public string CopyFile(string source, string dest)
        {
            if (!File.Exists(source))
            {
                ConsoleHandler.force_appendLog("Unable to copy plugin. Source plugin does not exist");
                return "";
            }

            if (File.Exists(dest))
            {
                FileInfo f = new FileInfo(dest);
                string filename = f.Name;
                string fileExt = f.Extension;
                string destDir = dest.Replace(filename, "");

                int i = 1;
                while (File.Exists(dest))
                {
                    dest = destDir + filename.Replace(fileExt, "") + " - Copy " + i + fileExt;
                    i++;
                }
            }
            File.Copy(source, dest);
            return dest;

        }
    }
}
