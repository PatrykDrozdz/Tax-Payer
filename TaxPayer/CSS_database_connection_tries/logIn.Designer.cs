namespace CSS_database_connection_tries
{
    partial class logIn
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
            this.connect_db = new System.Windows.Forms.Button();
            this.label_log = new System.Windows.Forms.Label();
            this.log_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect_db
            // 
            this.connect_db.Location = new System.Drawing.Point(70, 190);
            this.connect_db.Name = "connect_db";
            this.connect_db.Size = new System.Drawing.Size(167, 38);
            this.connect_db.TabIndex = 0;
            this.connect_db.Text = "zaloguj się";
            this.connect_db.UseVisualStyleBackColor = true;
            this.connect_db.Click += new System.EventHandler(this.connect_db_Click);
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(20, 73);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(29, 13);
            this.label_log.TabIndex = 1;
            this.label_log.Text = "login";
            // 
            // log_text
            // 
            this.log_text.Location = new System.Drawing.Point(70, 73);
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(173, 20);
            this.log_text.TabIndex = 2;
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(70, 118);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(173, 20);
            this.pass_text.TabIndex = 3;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(14, 118);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(34, 13);
            this.label_pass.TabIndex = 4;
            this.label_pass.Text = "hasło";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(288, 24);
            this.menuMain.TabIndex = 5;
            this.menuMain.Text = "Główne Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liczenieToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // liczenieToolStripMenuItem
            // 
            this.liczenieToolStripMenuItem.Name = "liczenieToolStripMenuItem";
            this.liczenieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.liczenieToolStripMenuItem.Text = "Liczenie";
            this.liczenieToolStripMenuItem.Click += new System.EventHandler(this.liczenieToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 301);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.log_text);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.connect_db);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(304, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(304, 339);
            this.Name = "logIn";
            this.Text = "Zaloguj się na serwer";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_db;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.TextBox log_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
    }
}

