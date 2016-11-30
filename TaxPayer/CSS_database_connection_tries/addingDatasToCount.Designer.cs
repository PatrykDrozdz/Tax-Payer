namespace CSS_database_connection_tries
{
    partial class AddingDatasToCount
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
            this.incommeLabel = new System.Windows.Forms.Label();
            this.openChecking = new System.Windows.Forms.Button();
            this.incommeUpDown = new System.Windows.Forms.NumericUpDown();
            this.outcommeSocialUpDown = new System.Windows.Forms.NumericUpDown();
            this.outcommeSocialLabel = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.outcommeHealthLabel = new System.Windows.Forms.Label();
            this.outcommeHealthUpDown = new System.Windows.Forms.NumericUpDown();
            this.IncommeCostsLabel = new System.Windows.Forms.Label();
            this.IncommeCostsUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.incommeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeSocialUpDown)).BeginInit();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeHealthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncommeCostsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // incommeLabel
            // 
            this.incommeLabel.AutoSize = true;
            this.incommeLabel.Location = new System.Drawing.Point(95, 46);
            this.incommeLabel.Name = "incommeLabel";
            this.incommeLabel.Size = new System.Drawing.Size(105, 13);
            this.incommeLabel.TabIndex = 0;
            this.incommeLabel.Text = "PODAJ PRZYCHÓD";
            // 
            // openChecking
            // 
            this.openChecking.Location = new System.Drawing.Point(98, 399);
            this.openChecking.Name = "openChecking";
            this.openChecking.Size = new System.Drawing.Size(120, 46);
            this.openChecking.TabIndex = 1;
            this.openChecking.Text = "Oblicz";
            this.openChecking.UseVisualStyleBackColor = true;
            this.openChecking.Click += new System.EventHandler(this.openChecking_Click);
            // 
            // incommeUpDown
            // 
            this.incommeUpDown.DecimalPlaces = 2;
            this.incommeUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.incommeUpDown.Location = new System.Drawing.Point(98, 84);
            this.incommeUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.incommeUpDown.Name = "incommeUpDown";
            this.incommeUpDown.Size = new System.Drawing.Size(120, 20);
            this.incommeUpDown.TabIndex = 2;
            // 
            // outcommeSocialUpDown
            // 
            this.outcommeSocialUpDown.DecimalPlaces = 2;
            this.outcommeSocialUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.outcommeSocialUpDown.Location = new System.Drawing.Point(98, 274);
            this.outcommeSocialUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.outcommeSocialUpDown.Name = "outcommeSocialUpDown";
            this.outcommeSocialUpDown.Size = new System.Drawing.Size(120, 20);
            this.outcommeSocialUpDown.TabIndex = 3;
            // 
            // outcommeSocialLabel
            // 
            this.outcommeSocialLabel.AutoSize = true;
            this.outcommeSocialLabel.Location = new System.Drawing.Point(24, 236);
            this.outcommeSocialLabel.Name = "outcommeSocialLabel";
            this.outcommeSocialLabel.Size = new System.Drawing.Size(269, 13);
            this.outcommeSocialLabel.TabIndex = 4;
            this.outcommeSocialLabel.Text = "PODAJ WYDATKI NA UBEZPIECZENIE SPOŁECZNE";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(323, 24);
            this.menuMain.TabIndex = 5;
            this.menuMain.Text = "Główne Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.logInToolStripMenuItem.Text = "Zaloguj się";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.LogInToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.closeToolStripMenuItem.Text = "Zamknij";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.helpToolStripMenuItem2.Text = "Pomoc";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // outcommeHealthLabel
            // 
            this.outcommeHealthLabel.AutoSize = true;
            this.outcommeHealthLabel.Location = new System.Drawing.Point(24, 323);
            this.outcommeHealthLabel.Name = "outcommeHealthLabel";
            this.outcommeHealthLabel.Size = new System.Drawing.Size(276, 13);
            this.outcommeHealthLabel.TabIndex = 6;
            this.outcommeHealthLabel.Text = "PODAJ WYDATKI NA UBEZPIECZENIE ZDROWOTNE";
            // 
            // outcommeHealthUpDown
            // 
            this.outcommeHealthUpDown.DecimalPlaces = 2;
            this.outcommeHealthUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.outcommeHealthUpDown.Location = new System.Drawing.Point(98, 351);
            this.outcommeHealthUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.outcommeHealthUpDown.Name = "outcommeHealthUpDown";
            this.outcommeHealthUpDown.Size = new System.Drawing.Size(120, 20);
            this.outcommeHealthUpDown.TabIndex = 7;
            // 
            // IncommeCostsLabel
            // 
            this.IncommeCostsLabel.AutoSize = true;
            this.IncommeCostsLabel.Location = new System.Drawing.Point(68, 136);
            this.IncommeCostsLabel.Name = "IncommeCostsLabel";
            this.IncommeCostsLabel.Size = new System.Drawing.Size(172, 13);
            this.IncommeCostsLabel.TabIndex = 9;
            this.IncommeCostsLabel.Text = "KOSZTY UZYSKANIA DOCHODU";
            // 
            // IncommeCostsUpDown
            // 
            this.IncommeCostsUpDown.DecimalPlaces = 2;
            this.IncommeCostsUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IncommeCostsUpDown.Location = new System.Drawing.Point(98, 174);
            this.IncommeCostsUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.IncommeCostsUpDown.Name = "IncommeCostsUpDown";
            this.IncommeCostsUpDown.Size = new System.Drawing.Size(120, 20);
            this.IncommeCostsUpDown.TabIndex = 8;
            // 
            // AddingDatasToCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 466);
            this.Controls.Add(this.IncommeCostsLabel);
            this.Controls.Add(this.IncommeCostsUpDown);
            this.Controls.Add(this.outcommeHealthUpDown);
            this.Controls.Add(this.outcommeHealthLabel);
            this.Controls.Add(this.outcommeSocialLabel);
            this.Controls.Add(this.outcommeSocialUpDown);
            this.Controls.Add(this.incommeUpDown);
            this.Controls.Add(this.openChecking);
            this.Controls.Add(this.incommeLabel);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(339, 504);
            this.Name = "AddingDatasToCount";
            this.Text = "Sprawdź swoje podatki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addingDatasToCount_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.incommeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeSocialUpDown)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeHealthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncommeCostsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incommeLabel;
        private System.Windows.Forms.Button openChecking;
        private System.Windows.Forms.NumericUpDown incommeUpDown;
        private System.Windows.Forms.NumericUpDown outcommeSocialUpDown;
        private System.Windows.Forms.Label outcommeSocialLabel;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.Label outcommeHealthLabel;
        private System.Windows.Forms.NumericUpDown outcommeHealthUpDown;
        private System.Windows.Forms.Label IncommeCostsLabel;
        private System.Windows.Forms.NumericUpDown IncommeCostsUpDown;
    }
}