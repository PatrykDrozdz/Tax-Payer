namespace CSS_database_connection_tries
{
    partial class addAdmin
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
            this.logLabel = new System.Windows.Forms.Label();
            this.addAdministrator = new System.Windows.Forms.Button();
            this.logTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(22, 41);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(36, 13);
            this.logLabel.TabIndex = 0;
            this.logLabel.Text = "Login:";
            // 
            // addAdministrator
            // 
            this.addAdministrator.Location = new System.Drawing.Point(25, 190);
            this.addAdministrator.Name = "addAdministrator";
            this.addAdministrator.Size = new System.Drawing.Size(100, 44);
            this.addAdministrator.TabIndex = 1;
            this.addAdministrator.Text = "Dodaj administratora";
            this.addAdministrator.UseVisualStyleBackColor = true;
            this.addAdministrator.Click += new System.EventHandler(this.addAdministrator_Click);
            // 
            // logTxt
            // 
            this.logTxt.Location = new System.Drawing.Point(25, 70);
            this.logTxt.Name = "logTxt";
            this.logTxt.Size = new System.Drawing.Size(164, 20);
            this.logTxt.TabIndex = 2;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(25, 141);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(164, 20);
            this.passTxt.TabIndex = 4;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(22, 113);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(39, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Hasło:";
            // 
            // addAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 262);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.logTxt);
            this.Controls.Add(this.addAdministrator);
            this.Controls.Add(this.logLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(240, 300);
            this.Name = "addAdmin";
            this.Text = "Dodaj administratora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button addAdministrator;
        private System.Windows.Forms.TextBox logTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label passLabel;
    }
}