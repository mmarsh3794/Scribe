namespace Scribe
{
    partial class GoToForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToForm));
            this.m_lineNumLbl = new System.Windows.Forms.Label();
            this.m_lineNumTxtBox = new System.Windows.Forms.TextBox();
            this.m_goToBtn = new System.Windows.Forms.Button();
            this.m_cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_lineNumLbl
            // 
            this.m_lineNumLbl.AutoSize = true;
            this.m_lineNumLbl.Location = new System.Drawing.Point(13, 13);
            this.m_lineNumLbl.Name = "m_lineNumLbl";
            this.m_lineNumLbl.Size = new System.Drawing.Size(70, 13);
            this.m_lineNumLbl.TabIndex = 0;
            this.m_lineNumLbl.Text = "Line Number:";
            // 
            // m_lineNumTxtBox
            // 
            this.m_lineNumTxtBox.Location = new System.Drawing.Point(16, 30);
            this.m_lineNumTxtBox.Name = "m_lineNumTxtBox";
            this.m_lineNumTxtBox.Size = new System.Drawing.Size(232, 20);
            this.m_lineNumTxtBox.TabIndex = 1;
            // 
            // m_goToBtn
            // 
            this.m_goToBtn.Location = new System.Drawing.Point(101, 56);
            this.m_goToBtn.Name = "m_goToBtn";
            this.m_goToBtn.Size = new System.Drawing.Size(75, 23);
            this.m_goToBtn.TabIndex = 2;
            this.m_goToBtn.Text = "Go To";
            this.m_goToBtn.UseVisualStyleBackColor = true;
            this.m_goToBtn.Click += new System.EventHandler(this.GoToBtn_Click);
            // 
            // m_cancelBtn
            // 
            this.m_cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cancelBtn.Location = new System.Drawing.Point(182, 56);
            this.m_cancelBtn.Name = "m_cancelBtn";
            this.m_cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.m_cancelBtn.TabIndex = 3;
            this.m_cancelBtn.Text = "Cancel";
            this.m_cancelBtn.UseVisualStyleBackColor = true;
            this.m_cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // GoToForm
            // 
            this.AcceptButton = this.m_goToBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_cancelBtn;
            this.ClientSize = new System.Drawing.Size(269, 94);
            this.Controls.Add(this.m_cancelBtn);
            this.Controls.Add(this.m_goToBtn);
            this.Controls.Add(this.m_lineNumTxtBox);
            this.Controls.Add(this.m_lineNumLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToForm";
            this.ShowIcon = false;
            this.Text = "Go To";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lineNumLbl;
        private System.Windows.Forms.TextBox m_lineNumTxtBox;
        private System.Windows.Forms.Button m_goToBtn;
        private System.Windows.Forms.Button m_cancelBtn;
    }
}