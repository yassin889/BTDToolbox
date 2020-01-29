﻿using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static BTDToolbox.ProjectConfig;

namespace BTDToolbox
{
    public partial class TD_Toolbox_Window : Form
    {
        //Form variables
        string livePath = Environment.CurrentDirectory;
        public string projectDirPath;
        private static TD_Toolbox_Window toolbox;

        string version = "Alpha 0.0.1";

        //Project Variables
        public DirectoryInfo dirInfo = new DirectoryInfo(Environment.CurrentDirectory);

        //Config variables
        ConfigFile programData;
        bool firstUse = true;
        public bool loadLastProject;
        public static string file;
        public int mainFormFontSize;
        public static bool enableConsole;
        public static string projName;
        private Bitmap bgImg;
        public string lastProject;
        float fontSize;

        //Scroll bar variables
        private const int SB_BOTH = 3;
        private const int WM_NCCALCSIZE = 0x83;
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

        //
        //Initialize window
        //
        public TD_Toolbox_Window()
        {
            InitializeComponent();
            toolbox = this;
            Startup();

            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(15, 15, 15);
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Resize += mainResize;
            this.KeyPreview = true;

            this.versionTag.BackColor = Color.FromArgb(15, 15, 15);
            this.versionTag.Text = version;

            Random rand = new Random();
            switch (rand.Next(0, 2))
            {
                case 0:
                    bgImg = Properties.Resources.Logo1;
                    break;
                case 1:
                    bgImg = Properties.Resources.Logo2;
                    break;
            }

            this.BackgroundImage = bgImg;
            this.FormClosed += ExitHandling;
        }
        private void Startup()
        {
            try
            {
                Deserialize_Config();

                bool existingUser = programData.ExistingUser;
                if (existingUser == false)
                    firstUse = true;
                else
                    firstUse = false;

                this.Size = new Size(programData.Main_SizeX, programData.Main_SizeY);
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(programData.Main_PosX, programData.Main_PosY);
                this.Font = new Font("Microsoft Sans Serif", programData.Main_FontSize);
                if (programData.Main_Fullscreen)
                    this.WindowState = FormWindowState.Maximized;

                enableConsole = programData.EnableConsole;
                projectDirPath = programData.LastProject_Path;
                lastProject = programData.LastProject;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
                //  SerializeConfig();
            }
            catch (System.NullReferenceException ex) 
            {
                throw ex;
                //  SerializeConfig();
                ;
            }
            catch (ArgumentException)
            {
                fontSize = 10;
                programData.Console_FontSize = fontSize;
                // SerializeConfig();
            }
        }
        private void TD_Toolbox_Window_Load(object sender, EventArgs e)
        {

            ConsoleHandler.console = new NewConsole();
            ConsoleHandler.console.MdiParent = this;

            if (enableConsole == true)
                ConsoleHandler.console.Show();
            else
                ConsoleHandler.console.Hide();
            
            ConsoleHandler.appendLog("Program loaded!");
            ConsoleHandler.appendLog("Searching for existing projects...");

            OpenJetForm();

            foreach (Control con in Controls)
                if (con is MdiClient)
                    mdiClient = con as MdiClient;
        }

        public static TD_Toolbox_Window getInstance()
        {
            return toolbox;
        }
        public void OpenJetForm()
        {
            if (lastProject != "" && lastProject != null)
            {
                //DirectoryInfo dinfo = new DirectoryInfo(livePath + "\\" + lastProject);
                DirectoryInfo dinfo = new DirectoryInfo(lastProject);
                if(dinfo.Exists)
                {
                    foreach (JetForm o in JetProps.get())
                    {
                        if (o.projName == projName)
                        {
                            MessageBox.Show("The project is already opened..");
                            return;
                        }
                    }
                    JetForm jf = new JetForm(dinfo, this, projName);
                    jf.MdiParent = this;
                    jf.Show();
                }
            }
        }
        private void TD_Toolbox_Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                compileJet("launch");
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                AddNewJet();
            }
        }
        private void mainResize(object sender, EventArgs e)
        {
            this.BackgroundImage = bgImg;
            this.BackgroundImageLayout = ImageLayout.Center;
        }
        private void Debug_ThemedForm_Click(object sender, EventArgs e)
        {
            ThemedForm tft = new ThemedForm();
            tft.MdiParent = this;
            tft.Show();
        }
        //
        //Open or Create Projects
        //
        public void ImportNewJet_Click(object sender, EventArgs e)
        {
            AddNewJet();
        }
        public static void AddNewJet()
        {
            OpenFileDialog fileDiag = new OpenFileDialog();

            fileDiag.Title = "Open .jet";
            fileDiag.DefaultExt = "jet";
            fileDiag.Filter = "Jet files (*.jet)|*.jet|All files (*.*)|*.*";
            fileDiag.Multiselect = false;
            if (fileDiag.ShowDialog() == DialogResult.OK)
            {
                file = fileDiag.FileName;
                byte[] jetBytes = File.ReadAllBytes(file).Take(2).ToArray();
                string bytes = "" + (char)jetBytes[0] + (char)jetBytes[1];

                if (bytes == "PK")
                {
                    var setProjectName = new SetProjectName();
                    //ExtractingJet_Window.file = file;     //come back to this. Otherwise it will open twice
                    setProjectName.Show();
                }
                else
                {
                    MessageBox.Show("Error!! Not a valid .Jet File. Please try again...");
                }
            }
        }
        private void OpenExistingProject_Click(object sender, EventArgs e)
        {
            BrowseForExistingProjects();
        }
        private void BrowseForExistingProjects()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select project folder";
            fbd.ShowNewFolderButton = false;
            fbd.SelectedPath = projectDirPath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string selected = fbd.SelectedPath;
                DirectoryInfo dirInfo = new DirectoryInfo(selected);
                string[] split = fbd.SelectedPath.Split('\\');
                string name = split[split.Length - 1];
                if (!name.StartsWith("proj_"))
                {
                    MessageBox.Show("Error!! Not a valid project file. Please try again...");
                }
                else
                {
                    JetForm jf = new JetForm(dirInfo, this, name);
                    jf.MdiParent = this;
                    jf.Show();
                }
            }
        }
        //
        //UI Buttons
        //
        private void compileJet(string switchCase)
        {
            if (switchCase == "launch")
            {
                if (JetProps.get().Count == 1)
                {
                    ExtractingJet_Window.switchCase = switchCase;
                    var compile = new ExtractingJet_Window();
                }
                else
                {
                    if (JetProps.get().Count < 1)
                    {
                        MessageBox.Show("You have no .jets or projects open, you need one to launch.");
                    }
                    else
                    {
                        MessageBox.Show("You have multiple .jets or projects open, only one can be launched.");
                    }
                }
            }
            else
            {
                ExtractingJet_Window.switchCase = switchCase;
                var compile = new ExtractingJet_Window();
            }
            
        }
        private void LaunchProgram_Click(object sender, EventArgs e)
        {
            compileJet("launch");
        }
        private void RestoreBackup_Click(object sender, EventArgs e)
        {
            ExtractingJet_Window.switchCase = "backup";
            var compile = new ExtractingJet_Window();
        }
        private void ToggleConsole_Click(object sender, EventArgs e)
        {
            if (ConsoleHandler.console.Visible)
            {
                ConsoleHandler.console.Hide();
                enableConsole = false;
            }
            else
            {
                enableConsole = true;
                ConsoleHandler.console.Show();
            }
        }
        private void Find_Button_Click(object sender, EventArgs e)
        {
            FindWindow findForm = new FindWindow();
            findForm.Show();
            findForm.Text = "Find";
            findForm.replace = false;
            findForm.find = true;
        }
        private void Replace_Button_Click(object sender, EventArgs e)
        {
            FindWindow findForm = new FindWindow();
            findForm.Show();
            findForm.Text = "Replace";
            findForm.replace = true;
            findForm.find = false;
        }
        private void OpenCredits_Click(object sender, EventArgs e)
        {
            CreditViewer cv = new CreditViewer();
            cv.MdiParent = this;
            cv.Show();
        }
        //
        //Config stuff
        //
        private void Deserialize_Config()
        {
            programData = Serializer.Deserialize_Config();
        }
        private void ExitHandling(object sender, EventArgs e)
        {
            if (ConsoleHandler.console.Visible)
            {
                enableConsole = true;
            }
            else
            {
                enableConsole = false;
            }
            Serializer.SaveConfig(this, "main", programData);
        }
        //
        //Mdi Stuff
        //
        protected override void WndProc(ref Message m)
        {
            if (mdiClient != null)
            {
                try
                {
                    ShowScrollBar(mdiClient.Handle, SB_BOTH, 0 /*Hide the ScrollBars*/);
                }
                catch (Exception)
                {
                }
            }
            base.WndProc(ref m);
        }
        MdiClient mdiClient = null;

        private void OpenJetExplorer_Click(object sender, EventArgs e)
        {
            try
            {
                OpenJetForm();
            } catch (Exception ex)
            {
                ConsoleHandler.appendLog(ex.StackTrace);
            }
        }

        private void TD_Toolbox_Window_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compileJet("output");
        }

        private void NewProject_From_Backup_Click(object sender, EventArgs e)
        {
            compileJet("decompile backup");
        }

        private void RemakeBackupjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compileJet("clean backup");
        }
    }
}