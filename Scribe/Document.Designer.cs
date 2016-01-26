﻿namespace Scribe
{
    partial class Document
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.m_rtbDoc = new System.Windows.Forms.RichTextBox();
            this.m_mnuBar = new System.Windows.Forms.MenuStrip();
            this.m_mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuFileSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_rtbDoc
            // 
            this.m_rtbDoc.AcceptsTab = true;
            this.m_rtbDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_rtbDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_rtbDoc.Location = new System.Drawing.Point(0, 24);
            this.m_rtbDoc.Name = "m_rtbDoc";
            this.m_rtbDoc.Size = new System.Drawing.Size(547, 315);
            this.m_rtbDoc.TabIndex = 0;
            this.m_rtbDoc.Text = "";
            // 
            // m_mnuBar
            // 
            this.m_mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuFile});
            this.m_mnuBar.Location = new System.Drawing.Point(0, 0);
            this.m_mnuBar.Name = "m_mnuBar";
            this.m_mnuBar.Size = new System.Drawing.Size(547, 24);
            this.m_mnuBar.TabIndex = 1;
            this.m_mnuBar.Text = "menu";
            // 
            // m_mnuFile
            // 
            this.m_mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuFileNew,
            this.m_mnuFileOpen,
            this.m_mnuFileSave,
            this.m_mnuFileSaveAs,
            this.m_mnuFileSep1,
            this.m_mnuFilePageSetup,
            this.m_mnuFilePrintPreview,
            this.m_mnuFilePrint,
            this.m_mnuFileSep2,
            this.m_mnuFileExit});
            this.m_mnuFile.Name = "m_mnuFile";
            this.m_mnuFile.Size = new System.Drawing.Size(37, 20);
            this.m_mnuFile.Text = "File";
            // 
            // m_mnuFileNew
            // 
            this.m_mnuFileNew.Name = "m_mnuFileNew";
            this.m_mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.m_mnuFileNew.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFileNew.Text = "New";
            this.m_mnuFileNew.Click += new System.EventHandler(this.MnuFileNew_Click);
            // 
            // m_mnuFileOpen
            // 
            this.m_mnuFileOpen.Name = "m_mnuFileOpen";
            this.m_mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.m_mnuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFileOpen.Text = "Open";
            this.m_mnuFileOpen.Click += new System.EventHandler(this.MnuFileOpen_Click);
            // 
            // m_mnuFileSave
            // 
            this.m_mnuFileSave.Name = "m_mnuFileSave";
            this.m_mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.m_mnuFileSave.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFileSave.Text = "Save";
            // 
            // m_mnuFileSaveAs
            // 
            this.m_mnuFileSaveAs.Name = "m_mnuFileSaveAs";
            this.m_mnuFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFileSaveAs.Text = "Save As";
            // 
            // m_mnuFileSep1
            // 
            this.m_mnuFileSep1.Name = "m_mnuFileSep1";
            this.m_mnuFileSep1.Size = new System.Drawing.Size(143, 6);
            // 
            // m_mnuFilePageSetup
            // 
            this.m_mnuFilePageSetup.Name = "m_mnuFilePageSetup";
            this.m_mnuFilePageSetup.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFilePageSetup.Text = "Page Setup";
            // 
            // m_mnuFilePrintPreview
            // 
            this.m_mnuFilePrintPreview.Name = "m_mnuFilePrintPreview";
            this.m_mnuFilePrintPreview.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFilePrintPreview.Text = "Print Preview";
            // 
            // m_mnuFilePrint
            // 
            this.m_mnuFilePrint.Name = "m_mnuFilePrint";
            this.m_mnuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.m_mnuFilePrint.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFilePrint.Text = "Print";
            // 
            // m_mnuFileSep2
            // 
            this.m_mnuFileSep2.Name = "m_mnuFileSep2";
            this.m_mnuFileSep2.Size = new System.Drawing.Size(143, 6);
            // 
            // m_mnuFileExit
            // 
            this.m_mnuFileExit.Name = "m_mnuFileExit";
            this.m_mnuFileExit.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFileExit.Text = "Exit";
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(547, 339);
            this.Controls.Add(this.m_rtbDoc);
            this.Controls.Add(this.m_mnuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_mnuBar;
            this.Name = "Document";
            this.Text = "Untitled - Scribe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.m_mnuBar.ResumeLayout(false);
            this.m_mnuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox m_rtbDoc;
        private System.Windows.Forms.MenuStrip m_mnuBar;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFile;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator m_mnuFileSep1;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFilePageSetup;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFilePrint;
        private System.Windows.Forms.ToolStripSeparator m_mnuFileSep2;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFilePrintPreview;





    }
}

