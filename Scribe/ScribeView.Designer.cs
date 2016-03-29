namespace Scribe
{
    partial class ScribeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScribeView));
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
            this.m_mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditGoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuEditSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuEditTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.m_rtbDoc = new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();
            this.m_mnuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_mnuBar
            // 
            this.m_mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuFile,
            this.m_mnuEdit});
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
            this.m_mnuFileSave.Click += new System.EventHandler(this.MnuFileSave_Click);
            // 
            // m_mnuFileSaveAs
            // 
            this.m_mnuFileSaveAs.Name = "m_mnuFileSaveAs";
            this.m_mnuFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFileSaveAs.Text = "Save As";
            this.m_mnuFileSaveAs.Click += new System.EventHandler(this.MnuFileSaveAs_Click);
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
            this.m_mnuFilePageSetup.Click += new System.EventHandler(this.MnuFilePageSetup_Click);
            // 
            // m_mnuFilePrintPreview
            // 
            this.m_mnuFilePrintPreview.Name = "m_mnuFilePrintPreview";
            this.m_mnuFilePrintPreview.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFilePrintPreview.Text = "Print Preview";
            this.m_mnuFilePrintPreview.Click += new System.EventHandler(this.MnuFilePrintPreview_Click);
            // 
            // m_mnuFilePrint
            // 
            this.m_mnuFilePrint.Name = "m_mnuFilePrint";
            this.m_mnuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.m_mnuFilePrint.Size = new System.Drawing.Size(146, 22);
            this.m_mnuFilePrint.Text = "Print";
            this.m_mnuFilePrint.Click += new System.EventHandler(this.MnuFilePrint_Click);
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
            this.m_mnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // m_mnuEdit
            // 
            this.m_mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuEditSelectAll,
            this.m_mnuEditSep1,
            this.m_mnuEditUndo,
            this.m_mnuEditRedo,
            this.m_mnuEditSep2,
            this.m_mnuEditCut,
            this.m_mnuEditCopy,
            this.m_mnuEditPaste,
            this.m_mnuEditDelete,
            this.m_mnuEditSep3,
            this.m_mnuEditFind,
            this.m_mnuEditFindNext,
            this.m_mnuEditReplace,
            this.m_mnuEditGoTo,
            this.m_mnuEditSep4,
            this.m_mnuEditTimeDate});
            this.m_mnuEdit.Name = "m_mnuEdit";
            this.m_mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.m_mnuEdit.Text = "Edit";
            // 
            // m_mnuEditSelectAll
            // 
            this.m_mnuEditSelectAll.Name = "m_mnuEditSelectAll";
            this.m_mnuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.m_mnuEditSelectAll.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditSelectAll.Text = "Select All";
            this.m_mnuEditSelectAll.Click += new System.EventHandler(this.MnuEditSelectAll_Click);
            // 
            // m_mnuEditSep1
            // 
            this.m_mnuEditSep1.Name = "m_mnuEditSep1";
            this.m_mnuEditSep1.Size = new System.Drawing.Size(161, 6);
            // 
            // m_mnuEditUndo
            // 
            this.m_mnuEditUndo.Enabled = false;
            this.m_mnuEditUndo.Name = "m_mnuEditUndo";
            this.m_mnuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.m_mnuEditUndo.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditUndo.Text = "Undo";
            this.m_mnuEditUndo.Click += new System.EventHandler(this.MnuEditUndo_Click);
            // 
            // m_mnuEditRedo
            // 
            this.m_mnuEditRedo.Enabled = false;
            this.m_mnuEditRedo.Name = "m_mnuEditRedo";
            this.m_mnuEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.m_mnuEditRedo.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditRedo.Text = "Redo";
            this.m_mnuEditRedo.Click += new System.EventHandler(this.MnuEditRedo_Click);
            // 
            // m_mnuEditSep2
            // 
            this.m_mnuEditSep2.Name = "m_mnuEditSep2";
            this.m_mnuEditSep2.Size = new System.Drawing.Size(161, 6);
            // 
            // m_mnuEditCut
            // 
            this.m_mnuEditCut.Enabled = false;
            this.m_mnuEditCut.Name = "m_mnuEditCut";
            this.m_mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.m_mnuEditCut.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditCut.Text = "Cut";
            this.m_mnuEditCut.Click += new System.EventHandler(this.MnuEditCut_Click);
            // 
            // m_mnuEditCopy
            // 
            this.m_mnuEditCopy.Enabled = false;
            this.m_mnuEditCopy.Name = "m_mnuEditCopy";
            this.m_mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.m_mnuEditCopy.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditCopy.Text = "Copy";
            this.m_mnuEditCopy.Click += new System.EventHandler(this.MnuEditCopy_Click);
            // 
            // m_mnuEditPaste
            // 
            this.m_mnuEditPaste.Name = "m_mnuEditPaste";
            this.m_mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.m_mnuEditPaste.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditPaste.Text = "Paste";
            this.m_mnuEditPaste.Click += new System.EventHandler(this.MnuEditPaste_Click);
            // 
            // m_mnuEditDelete
            // 
            this.m_mnuEditDelete.Enabled = false;
            this.m_mnuEditDelete.Name = "m_mnuEditDelete";
            this.m_mnuEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.m_mnuEditDelete.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditDelete.Text = "Delete";
            this.m_mnuEditDelete.Click += new System.EventHandler(this.MnuEditDelete_Click);
            // 
            // m_mnuEditSep3
            // 
            this.m_mnuEditSep3.Name = "m_mnuEditSep3";
            this.m_mnuEditSep3.Size = new System.Drawing.Size(161, 6);
            // 
            // m_mnuEditFind
            // 
            this.m_mnuEditFind.Enabled = false;
            this.m_mnuEditFind.Name = "m_mnuEditFind";
            this.m_mnuEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.m_mnuEditFind.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditFind.Text = "Find";
            this.m_mnuEditFind.Click += new System.EventHandler(this.MnuEditFind_Click);
            // 
            // m_mnuEditFindNext
            // 
            this.m_mnuEditFindNext.Enabled = false;
            this.m_mnuEditFindNext.Name = "m_mnuEditFindNext";
            this.m_mnuEditFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.m_mnuEditFindNext.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditFindNext.Text = "Find Next";
            this.m_mnuEditFindNext.Click += new System.EventHandler(this.MnuEditFindNext_Click);
            // 
            // m_mnuEditReplace
            // 
            this.m_mnuEditReplace.Name = "m_mnuEditReplace";
            this.m_mnuEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.m_mnuEditReplace.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditReplace.Text = "Replace";
            // 
            // m_mnuEditGoTo
            // 
            this.m_mnuEditGoTo.Name = "m_mnuEditGoTo";
            this.m_mnuEditGoTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.m_mnuEditGoTo.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditGoTo.Text = "Go To";
            // 
            // m_mnuEditSep4
            // 
            this.m_mnuEditSep4.Name = "m_mnuEditSep4";
            this.m_mnuEditSep4.Size = new System.Drawing.Size(161, 6);
            // 
            // m_mnuEditTimeDate
            // 
            this.m_mnuEditTimeDate.Name = "m_mnuEditTimeDate";
            this.m_mnuEditTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.m_mnuEditTimeDate.Size = new System.Drawing.Size(164, 22);
            this.m_mnuEditTimeDate.Text = "Time/Date";
            this.m_mnuEditTimeDate.Click += new System.EventHandler(this.MnuEditTimeDate_Click);
            // 
            // m_rtbDoc
            // 
            m_rtbDoc.AcceptsTab = true;
            m_rtbDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            m_rtbDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            m_rtbDoc.HideSelection = false;
            m_rtbDoc.Location = new System.Drawing.Point(0, 24);
            m_rtbDoc.Name = "m_rtbDoc";
            m_rtbDoc.Size = new System.Drawing.Size(547, 315);
            m_rtbDoc.TabIndex = 2;
            m_rtbDoc.Text = "";
            m_rtbDoc.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RtbDoc_LinkClicked);
            m_rtbDoc.SelectionChanged += new System.EventHandler(this.RtbDoc_SelectionChanged);
            m_rtbDoc.TextChanged += new System.EventHandler(this.RtbDoc_TextChanged);
            // 
            // ScribeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(547, 339);
            this.Controls.Add(m_rtbDoc);
            this.Controls.Add(this.m_mnuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_mnuBar;
            this.Name = "ScribeView";
            this.Text = "Untitled - Scribe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScribeView_FormClosing);
            this.m_mnuBar.ResumeLayout(false);
            this.m_mnuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBoxPrintCtrl.RichTextBoxPrintCtrl m_rtbDoc;
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
        private System.Windows.Forms.ToolStripMenuItem m_mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditSelectAll;
        private System.Windows.Forms.ToolStripSeparator m_mnuEditSep1;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditRedo;
        private System.Windows.Forms.ToolStripSeparator m_mnuEditSep2;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditDelete;
        private System.Windows.Forms.ToolStripSeparator m_mnuEditSep3;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditFind;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditFindNext;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditReplace;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditGoTo;
        private System.Windows.Forms.ToolStripSeparator m_mnuEditSep4;
        private System.Windows.Forms.ToolStripMenuItem m_mnuEditTimeDate;





    }
}

