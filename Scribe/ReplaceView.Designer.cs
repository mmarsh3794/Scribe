namespace Scribe
{
    partial class ReplaceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceView));
            this.m_findLbl = new System.Windows.Forms.Label();
            this.m_replaceLbl = new System.Windows.Forms.Label();
            this.m_replaceTxtBox = new System.Windows.Forms.TextBox();
            this.m_findTxtBox = new System.Windows.Forms.TextBox();
            this.m_findBtn = new System.Windows.Forms.Button();
            this.m_replaceBtn = new System.Windows.Forms.Button();
            this.m_replaceAllBtn = new System.Windows.Forms.Button();
            this.m_cancelBtn = new System.Windows.Forms.Button();
            this.m_matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // m_findLbl
            // 
            this.m_findLbl.AutoSize = true;
            this.m_findLbl.Location = new System.Drawing.Point(13, 13);
            this.m_findLbl.Name = "m_findLbl";
            this.m_findLbl.Size = new System.Drawing.Size(59, 13);
            this.m_findLbl.TabIndex = 0;
            this.m_findLbl.Text = "Find What:";
            // 
            // m_replaceLbl
            // 
            this.m_replaceLbl.AutoSize = true;
            this.m_replaceLbl.Location = new System.Drawing.Point(13, 41);
            this.m_replaceLbl.Name = "m_replaceLbl";
            this.m_replaceLbl.Size = new System.Drawing.Size(78, 13);
            this.m_replaceLbl.TabIndex = 1;
            this.m_replaceLbl.Text = "Replace With: ";
            // 
            // m_findTxtBox
            // 
            this.m_findTxtBox.Location = new System.Drawing.Point(97, 10);
            this.m_findTxtBox.Name = "m_findTxtBox";
            this.m_findTxtBox.Size = new System.Drawing.Size(231, 20);
            this.m_findTxtBox.TabIndex = 2;
            this.m_findTxtBox.TextChanged += new System.EventHandler(this.FindTxtBox_TextChanged);
            // 
            // m_replaceTxtBox
            // 
            this.m_replaceTxtBox.Location = new System.Drawing.Point(97, 38);
            this.m_replaceTxtBox.Name = "m_replaceTxtBox";
            this.m_replaceTxtBox.Size = new System.Drawing.Size(231, 20);
            this.m_replaceTxtBox.TabIndex = 3;
            this.m_replaceTxtBox.TextChanged += new System.EventHandler(this.ReplaceTxtBox_TextChanged);
            // 
            // m_findBtn
            // 
            this.m_findBtn.Enabled = false;
            this.m_findBtn.Location = new System.Drawing.Point(349, 7);
            this.m_findBtn.Name = "m_findBtn";
            this.m_findBtn.Size = new System.Drawing.Size(93, 23);
            this.m_findBtn.TabIndex = 4;
            this.m_findBtn.Text = "Find Next";
            this.m_findBtn.UseVisualStyleBackColor = true;
            this.m_findBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // m_replaceBtn
            // 
            this.m_replaceBtn.Enabled = false;
            this.m_replaceBtn.Location = new System.Drawing.Point(349, 36);
            this.m_replaceBtn.Name = "m_replaceBtn";
            this.m_replaceBtn.Size = new System.Drawing.Size(93, 23);
            this.m_replaceBtn.TabIndex = 5;
            this.m_replaceBtn.Text = "Replace";
            this.m_replaceBtn.UseVisualStyleBackColor = true;
            this.m_replaceBtn.Click += new System.EventHandler(this.ReplaceBtn_Click);
            // 
            // m_replaceAllBtn
            // 
            this.m_replaceAllBtn.Enabled = false;
            this.m_replaceAllBtn.Location = new System.Drawing.Point(349, 65);
            this.m_replaceAllBtn.Name = "m_replaceAllBtn";
            this.m_replaceAllBtn.Size = new System.Drawing.Size(93, 23);
            this.m_replaceAllBtn.TabIndex = 6;
            this.m_replaceAllBtn.Text = "Repalce All";
            this.m_replaceAllBtn.UseVisualStyleBackColor = true;
            this.m_replaceAllBtn.Click += new System.EventHandler(this.ReplaceAllBtn_Click);
            // 
            // m_cancelBtn
            // 
            this.m_cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cancelBtn.Location = new System.Drawing.Point(349, 94);
            this.m_cancelBtn.Name = "m_cancelBtn";
            this.m_cancelBtn.Size = new System.Drawing.Size(93, 23);
            this.m_cancelBtn.TabIndex = 7;
            this.m_cancelBtn.Text = "Cancel";
            this.m_cancelBtn.UseVisualStyleBackColor = true;
            this.m_cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // m_matchCaseCheckBox
            // 
            this.m_matchCaseCheckBox.AutoSize = true;
            this.m_matchCaseCheckBox.Location = new System.Drawing.Point(16, 98);
            this.m_matchCaseCheckBox.Name = "m_matchCaseCheckBox";
            this.m_matchCaseCheckBox.Size = new System.Drawing.Size(83, 17);
            this.m_matchCaseCheckBox.TabIndex = 8;
            this.m_matchCaseCheckBox.Text = "Match Case";
            this.m_matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReplaceView
            // 
            this.AcceptButton = this.m_findBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_cancelBtn;
            this.ClientSize = new System.Drawing.Size(454, 146);
            this.Controls.Add(this.m_matchCaseCheckBox);
            this.Controls.Add(this.m_cancelBtn);
            this.Controls.Add(this.m_replaceAllBtn);
            this.Controls.Add(this.m_replaceBtn);
            this.Controls.Add(this.m_findBtn);
            this.Controls.Add(this.m_findTxtBox);
            this.Controls.Add(this.m_replaceTxtBox);
            this.Controls.Add(this.m_replaceLbl);
            this.Controls.Add(this.m_findLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceView";
            this.ShowIcon = false;
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_findLbl;
        private System.Windows.Forms.Label m_replaceLbl;
        private System.Windows.Forms.TextBox m_replaceTxtBox;
        private System.Windows.Forms.TextBox m_findTxtBox;
        private System.Windows.Forms.Button m_findBtn;
        private System.Windows.Forms.Button m_replaceBtn;
        private System.Windows.Forms.Button m_replaceAllBtn;
        private System.Windows.Forms.Button m_cancelBtn;
        private System.Windows.Forms.CheckBox m_matchCaseCheckBox;
    }
}