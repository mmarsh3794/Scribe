namespace Scribe
{
    partial class FindView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindView));
            this.m_findLabel = new System.Windows.Forms.Label();
            this.m_findTxtBox = new System.Windows.Forms.TextBox();
            this.m_fndNxtBtn = new System.Windows.Forms.Button();
            this.m_cancelBtn = new System.Windows.Forms.Button();
            this.m_dirGroupBox = new System.Windows.Forms.GroupBox();
            this.m_downRadioBtn = new System.Windows.Forms.RadioButton();
            this.m_upRadioBtn = new System.Windows.Forms.RadioButton();
            this.m_matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.m_dirGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_findLabel
            // 
            this.m_findLabel.AutoSize = true;
            this.m_findLabel.Location = new System.Drawing.Point(13, 13);
            this.m_findLabel.Name = "m_findLabel";
            this.m_findLabel.Size = new System.Drawing.Size(56, 13);
            this.m_findLabel.TabIndex = 0;
            this.m_findLabel.Text = "Find what:";
            // 
            // m_findTxtBox
            // 
            this.m_findTxtBox.Location = new System.Drawing.Point(76, 13);
            this.m_findTxtBox.Name = "m_findTxtBox";
            this.m_findTxtBox.Size = new System.Drawing.Size(210, 20);
            this.m_findTxtBox.TabIndex = 1;
            this.m_findTxtBox.TextChanged += new System.EventHandler(this.FindTxtBox_TextChanged);
            // 
            // m_fndNxtBtn
            // 
            this.m_fndNxtBtn.Enabled = false;
            this.m_fndNxtBtn.Location = new System.Drawing.Point(301, 12);
            this.m_fndNxtBtn.Name = "m_fndNxtBtn";
            this.m_fndNxtBtn.Size = new System.Drawing.Size(75, 23);
            this.m_fndNxtBtn.TabIndex = 2;
            this.m_fndNxtBtn.Text = "Find Next";
            this.m_fndNxtBtn.UseVisualStyleBackColor = true;
            this.m_fndNxtBtn.Click += new System.EventHandler(this.FndNxtBtn_Click);
            // 
            // m_cancelBtn
            // 
            this.m_cancelBtn.Location = new System.Drawing.Point(301, 42);
            this.m_cancelBtn.Name = "m_cancelBtn";
            this.m_cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.m_cancelBtn.TabIndex = 3;
            this.m_cancelBtn.Text = "Cancel";
            this.m_cancelBtn.UseVisualStyleBackColor = true;
            this.m_cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // m_dirGroupBox
            // 
            this.m_dirGroupBox.Controls.Add(this.m_downRadioBtn);
            this.m_dirGroupBox.Controls.Add(this.m_upRadioBtn);
            this.m_dirGroupBox.Location = new System.Drawing.Point(173, 53);
            this.m_dirGroupBox.Name = "m_dirGroupBox";
            this.m_dirGroupBox.Size = new System.Drawing.Size(113, 47);
            this.m_dirGroupBox.TabIndex = 4;
            this.m_dirGroupBox.TabStop = false;
            this.m_dirGroupBox.Text = "Direction";
            // 
            // m_downRadioBtn
            // 
            this.m_downRadioBtn.AutoSize = true;
            this.m_downRadioBtn.Checked = true;
            this.m_downRadioBtn.Location = new System.Drawing.Point(52, 20);
            this.m_downRadioBtn.Name = "m_downRadioBtn";
            this.m_downRadioBtn.Size = new System.Drawing.Size(53, 17);
            this.m_downRadioBtn.TabIndex = 1;
            this.m_downRadioBtn.TabStop = true;
            this.m_downRadioBtn.Text = "Down";
            this.m_downRadioBtn.UseVisualStyleBackColor = true;
            // 
            // m_upRadioBtn
            // 
            this.m_upRadioBtn.AutoSize = true;
            this.m_upRadioBtn.Location = new System.Drawing.Point(7, 20);
            this.m_upRadioBtn.Name = "m_upRadioBtn";
            this.m_upRadioBtn.Size = new System.Drawing.Size(39, 17);
            this.m_upRadioBtn.TabIndex = 0;
            this.m_upRadioBtn.Text = "Up";
            this.m_upRadioBtn.UseVisualStyleBackColor = true;
            // 
            // m_matchCaseCheckBox
            // 
            this.m_matchCaseCheckBox.AutoSize = true;
            this.m_matchCaseCheckBox.Location = new System.Drawing.Point(16, 83);
            this.m_matchCaseCheckBox.Name = "m_matchCaseCheckBox";
            this.m_matchCaseCheckBox.Size = new System.Drawing.Size(83, 17);
            this.m_matchCaseCheckBox.TabIndex = 5;
            this.m_matchCaseCheckBox.Text = "Match Case";
            this.m_matchCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 110);
            this.Controls.Add(this.m_matchCaseCheckBox);
            this.Controls.Add(this.m_dirGroupBox);
            this.Controls.Add(this.m_cancelBtn);
            this.Controls.Add(this.m_fndNxtBtn);
            this.Controls.Add(this.m_findTxtBox);
            this.Controls.Add(this.m_findLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.m_dirGroupBox.ResumeLayout(false);
            this.m_dirGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_findLabel;
        private System.Windows.Forms.TextBox m_findTxtBox;
        private System.Windows.Forms.Button m_fndNxtBtn;
        private System.Windows.Forms.Button m_cancelBtn;
        private System.Windows.Forms.GroupBox m_dirGroupBox;
        private System.Windows.Forms.RadioButton m_downRadioBtn;
        private System.Windows.Forms.RadioButton m_upRadioBtn;
        private System.Windows.Forms.CheckBox m_matchCaseCheckBox;
    }
}