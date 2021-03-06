﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BTDToolbox
{
    public class Browser : ThemedForm
    {
        public Browser(string url)
        {
            InitializeComponent();
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                ConsoleHandler.append("Attempted to open the url |  " + url + "  | this is a bad url");
                this.Close();
                return;
            }

            try { webBrowser1.Url = new Uri(url); }
            catch { System.Diagnostics.Process.Start(url); }

            this.TitleLabel.Text = "Browser";
        }
        public Browser(Main MdiParent, string url):this(url)
        {
            if (this.IsDisposed)
                return;

            this.MdiParent = Main.getInstance();
            this.Show();
        }

        private System.Windows.Forms.WebBrowser webBrowser1;

        private new void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.titleSeperator)).BeginInit();
            this.titleSeperator.Panel1.SuspendLayout();
            this.titleSeperator.Panel2.SuspendLayout();
            this.titleSeperator.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar_RightCorner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar_LeftCorner)).BeginInit();
            this.SuspendLayout();
            // 
            // titleSeperator
            // 
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.webBrowser1);
            // 
            // close_button
            // 
            this.close_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.close_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            // 
            // TitleBar_RightCorner
            // 
            this.TitleBar_RightCorner.Location = new System.Drawing.Point(755, 0);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 406);
            this.webBrowser1.TabIndex = 0;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Browser";
            this.titleSeperator.Panel1.ResumeLayout(false);
            this.titleSeperator.Panel1.PerformLayout();
            this.titleSeperator.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleSeperator)).EndInit();
            this.titleSeperator.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar_RightCorner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBar_LeftCorner)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
