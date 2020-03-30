﻿using BTDToolbox.Classes;
using BTDToolbox.Extra_Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTDToolbox.ProjectConfig;

namespace BTDToolbox
{
    public partial class New_JsonEditor : ThemedForm
    {
        public static int JsonEditor_Width = 0;
        public static int JsonEditor_Height = 0;
        public static string selectedPath = "";
        public static bool isJsonError = false;
        public JsonEditor_Instance[] userControls;
        public TabPage[] tabPages;
        public string[] tabFilePaths;

        ConfigFile programData;
        public New_JsonEditor()
        {
            InitializeComponent();
            this.MdiParent = Main.getInstance();
            this.Font = new Font("Consolas", 11);
            JsonEditor_Width = tabControl1.Width;
            JsonEditor_Height = tabControl1.Height;

            programData = Serializer.Deserialize_Config();
            this.Size = new Size(programData.JSON_Editor_SizeX, programData.JSON_Editor_SizeY);
            this.Location = new Point(programData.JSON_Editor_PosX, programData.JSON_Editor_PosY);
        }


        //
        //Open stuff
        //
        public void NewTab(string path)
        {
            if (path != "" && path != null)
            {
                //handle user control stuff
                Array.Resize(ref userControls, userControls.Length + 1);
                userControls[userControls.Length - 1] = new JsonEditor_Instance();

                //handle tab pages
                Array.Resize(ref tabPages, tabPages.Length + 1);
                tabPages[tabPages.Length - 1] = new TabPage();

                //handle file path array
                Array.Resize(ref tabFilePaths, tabFilePaths.Length + 1);
                tabFilePaths[tabFilePaths.Length - 1] = path;

                //create the tab and do required processing

                string[] split = path.Split('\\');
                string filename = split[split.Length - 1];
                if (path.Contains("BackupProject"))
                {
                    filename = filename + "_original";
                    userControls[userControls.Length - 1].Editor_TextBox.ReadOnly = true;
                }

                tabPages[tabPages.Length - 1].Text = filename;
                tabPages[tabPages.Length - 1].Controls.Add(userControls[userControls.Length - 1]);
                userControls[userControls.Length - 1].path = path;
                userControls[userControls.Length - 1].filename = filename;

                AddText(path);

                this.tabControl1.TabPages.Add(tabPages[tabPages.Length - 1]);

                OpenTab(path);
                ConsoleHandler.appendLog_CanRepeat("Opened " + filename);
                userControls[userControls.Length - 1].FinishedLoading();

            }
            else
            {
                ConsoleHandler.appendLog_CanRepeat("Something went wrong when trying to read the files path...");
            }
        }
        private void AddText(string path)
        {
            string unformattedText = File.ReadAllText(path);
            try
            {
                JToken jt = JToken.Parse(unformattedText);
                string formattedText = jt.ToString(Formatting.Indented);
                userControls[userControls.Length - 1].Editor_TextBox.Text = formattedText;
            }
            catch (Exception)
            {
                userControls[userControls.Length - 1].Editor_TextBox.Text = unformattedText;
            }
        }
        public void OpenTab(string path)
        {
            int i = 0;
            foreach (string t in tabFilePaths)
            {
                if (t == path)
                {
                    tabControl1.SelectedTab = tabPages[i];
                    userControls[i].Size = new Size(tabControl1.SelectedTab.Width, tabControl1.SelectedTab.Height);
                }
                i++;
            }
        }

        //
        //Methods
        //
        private string GetTabFilePath()
        {
            int i = 0;
            foreach (TabPage x in tabPages)
            {
                if (x.Text == tabControl1.SelectedTab.Text)
                {
                    selectedPath = tabFilePaths[i];
                }
                i++;
            }
            return selectedPath;
        }

        //
        //Closing stuff
        //
        public void CloseTab(string path)
        {
            int i = tabControl1.SelectedIndex;

            //Remove the closed filepath
            int j = 0;
            string[] tempFilePaths = new string[tabFilePaths.Length - 1];
            foreach (string tf in tabFilePaths)
            {
                if (j != i)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            tempFilePaths[j] = tf;
                        }
                        else
                        {
                            tempFilePaths[j - 1] = tf;
                        }
                    }
                    else if (j + 1 <= tempFilePaths.Length)
                    {
                        tempFilePaths[j] = tf;
                    }
                    else if (j + 1 == tempFilePaths.Length + 1)
                        tempFilePaths[j - 1] = tf;
                }
                j++;
            }
            Array.Resize(ref tabFilePaths, tabFilePaths.Length - 1);
            Array.Copy(tempFilePaths, 0, tabFilePaths, 0, tempFilePaths.Length);


            //Remove the closed usercontrol
            j = 0;
            JsonEditor_Instance[] tempUserControl = new JsonEditor_Instance[userControls.Length - 1];
            foreach (JsonEditor_Instance tf in userControls)
            {
                if (j != i)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            tempUserControl[j] = tf;
                        }
                        else
                        {
                            tempUserControl[j - 1] = tf;
                        }
                    }
                    else if (j + 1 <= tempUserControl.Length)
                    {
                        tempUserControl[j] = tf;
                    }
                    else if (j + 1 == tempUserControl.Length + 1)
                        tempUserControl[j - 1] = tf;
                    /*else
                        tempUserControl[j] = tf;*/
                }
                j++;
            }
            Array.Resize(ref userControls, userControls.Length - 1);
            Array.Copy(tempUserControl, 0, userControls, 0, tempUserControl.Length);


            //Remove the closed tab page
            j = 0;
            TabPage[] tempTabPages = new TabPage[tabPages.Length - 1];
            foreach (TabPage tf in tabPages)
            {
                if (j != i)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            tempTabPages[j] = tf;
                        }
                        else
                        {
                            tempTabPages[j - 1] = tf;
                        }
                    }
                    else if (j + 1 <= tempTabPages.Length)
                    {
                        tempTabPages[j] = tf;
                    }
                    else if (j + 1 == tempTabPages.Length + 1)
                        tempTabPages[j - 1] = tf;
                    //else
                    //tempTabPages[j] = tf;
                }
                j++;
            }
            Array.Resize(ref tabPages, tabPages.Length - 1);
            Array.Copy(tempTabPages, 0, tabPages, 0, tempTabPages.Length);

            if (tabControl1.TabPages.Count - 1 <= 0)
                this.Close();

            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            
            if (i + 1 <= tabControl1.TabPages.Count)
                tabControl1.SelectedIndex = i;
            else
                tabControl1.SelectedIndex = i - 1;
        }
        private void New_JsonEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer.SaveConfig(this, "json editor", programData);
            Serializer.SaveJSONEditor_Tabs(programData);
            if(userControls.Length >0)
                Serializer.SaveJSONEditor_Instance(userControls[tabControl1.SelectedIndex], programData);
            JsonEditorHandler.jeditor = null;
        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            Serializer.SaveConfig(this, "json editor", programData);
            Serializer.SaveJSONEditor_Tabs(programData);
            if (JsonEditorHandler.AreJsonErrors())
            {
                //tabControl1.SelectedIndex = i;
                DialogResult diag = MessageBox.Show(tabControl1.SelectedTab.Text + " has a Json Error! Your mod will break if you don't fix it.\nClose anyways?", "WARNING!!", MessageBoxButtons.YesNo);
                if (diag == DialogResult.Yes)
                    this.Close();
                
            }
        }

        //
        //Other stuff
        //
        private void New_JsonEditor_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.Control && e.KeyCode == Keys.F)
            {
                FindReplace_Panel.Visible = !FindReplace_Panel.Visible;
                FindReplace_Panel.BringToFront();
            }*/
        }
        private void TabControl1_SizeChanged(object sender, EventArgs e)
        {
            if (userControls != null)
            {
                foreach (var x in userControls)
                {
                    x.Size = new Size(tabControl1.SelectedTab.Width, tabControl1.SelectedTab.Height);
                }
            }
        }
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            //e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            //TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);
            TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, Color.White);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ConsoleHandler.appendLog_CanRepeat("Tab Pages: " + tabPages.Length.ToString());
            ConsoleHandler.appendLog_CanRepeat("User Controls: " + userControls.Length.ToString());
            ConsoleHandler.appendLog_CanRepeat("File paths: " + tabFilePaths.Length.ToString());
        }
    }
}
