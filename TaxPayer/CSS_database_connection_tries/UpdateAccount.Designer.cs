namespace CSS_database_connection_tries
{
    partial class UpdateAccount
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.changeLog = new System.Windows.Forms.Button();
            this.newLog = new System.Windows.Forms.TextBox();
            this.changeNameAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.changePassAcountgroupBox = new System.Windows.Forms.GroupBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.changePass = new System.Windows.Forms.Button();
            this.loginToShow = new System.Windows.Forms.Label();
            this.changeNameAccountGroupBox.SuspendLayout();
            this.changePassAcountgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(22, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(144, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Obecny login:";
            // 
            // changeLog
            // 
            this.changeLog.Location = new System.Drawing.Point(15, 116);
            this.changeLog.Name = "changeLog";
            this.changeLog.Size = new System.Drawing.Size(157, 46);
            this.changeLog.TabIndex = 1;
            this.changeLog.Text = "Zmień login";
            this.changeLog.UseVisualStyleBackColor = true;
            this.changeLog.Click += new System.EventHandler(this.changeLog_Click);
            // 
            // newLog
            // 
            this.newLog.Location = new System.Drawing.Point(15, 55);
            this.newLog.Name = "newLog";
            this.newLog.Size = new System.Drawing.Size(157, 20);
            this.newLog.TabIndex = 2;
            // 
            // changeNameAccountGroupBox
            // 
            this.changeNameAccountGroupBox.Controls.Add(this.newLog);
            this.changeNameAccountGroupBox.Controls.Add(this.changeLog);
            this.changeNameAccountGroupBox.Location = new System.Drawing.Point(12, 64);
            this.changeNameAccountGroupBox.Name = "changeNameAccountGroupBox";
            this.changeNameAccountGroupBox.Size = new System.Drawing.Size(200, 185);
            this.changeNameAccountGroupBox.TabIndex = 3;
            this.changeNameAccountGroupBox.TabStop = false;
            this.changeNameAccountGroupBox.Text = "Zmień login";
            // 
            // changePassAcountgroupBox
            // 
            this.changePassAcountgroupBox.Controls.Add(this.newPass);
            this.changePassAcountgroupBox.Controls.Add(this.changePass);
            this.changePassAcountgroupBox.Location = new System.Drawing.Point(258, 64);
            this.changePassAcountgroupBox.Name = "changePassAcountgroupBox";
            this.changePassAcountgroupBox.Size = new System.Drawing.Size(200, 185);
            this.changePassAcountgroupBox.TabIndex = 4;
            this.changePassAcountgroupBox.TabStop = false;
            this.changePassAcountgroupBox.Text = "Zmień hasło";
            // 
            // newPass
            // 
            this.newPass.Location = new System.Drawing.Point(15, 55);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(157, 20);
            this.newPass.TabIndex = 2;
            // 
            // changePass
            // 
            this.changePass.Location = new System.Drawing.Point(15, 116);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(157, 46);
            this.changePass.TabIndex = 1;
            this.changePass.Text = "Zmień hasło";
            this.changePass.UseVisualStyleBackColor = true;
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // loginToShow
            // 
            this.loginToShow.AutoSize = true;
            this.loginToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginToShow.Location = new System.Drawing.Point(172, 20);
            this.loginToShow.Name = "loginToShow";
            this.loginToShow.Size = new System.Drawing.Size(19, 25);
            this.loginToShow.TabIndex = 5;
            this.loginToShow.Text = "-";
            // 
            // UpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.loginToShow);
            this.Controls.Add(this.changePassAcountgroupBox);
            this.Controls.Add(this.changeNameAccountGroupBox);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 300);
            this.Name = "UpdateAccount";
            this.Text = "Ustawienia konta";
            this.changeNameAccountGroupBox.ResumeLayout(false);
            this.changeNameAccountGroupBox.PerformLayout();
            this.changePassAcountgroupBox.ResumeLayout(false);
            this.changePassAcountgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button changeLog;
        private System.Windows.Forms.TextBox newLog;
        private System.Windows.Forms.GroupBox changeNameAccountGroupBox;
        private System.Windows.Forms.GroupBox changePassAcountgroupBox;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Label loginToShow;
    }
}