﻿namespace CSS_database_connection_tries
{
    partial class addingDatasToCount
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
            this.zalogujSięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outcommeHealthLabel = new System.Windows.Forms.Label();
            this.outcommeHealthUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.incommeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeSocialUpDown)).BeginInit();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeHealthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // incommeLabel
            // 
            this.incommeLabel.AutoSize = true;
            this.incommeLabel.Location = new System.Drawing.Point(142, 24);
            this.incommeLabel.Name = "incommeLabel";
            this.incommeLabel.Size = new System.Drawing.Size(105, 13);
            this.incommeLabel.TabIndex = 0;
            this.incommeLabel.Text = "PODAJ PRZYCHÓD";
            // 
            // openChecking
            // 
            this.openChecking.Location = new System.Drawing.Point(145, 270);
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
            this.incommeUpDown.Location = new System.Drawing.Point(145, 62);
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
            this.outcommeSocialUpDown.Location = new System.Drawing.Point(145, 147);
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
            this.outcommeSocialLabel.Location = new System.Drawing.Point(71, 109);
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
            this.menuMain.Size = new System.Drawing.Size(426, 24);
            this.menuMain.TabIndex = 5;
            this.menuMain.Text = "Główne Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zalogujSięToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // zalogujSięToolStripMenuItem
            // 
            this.zalogujSięToolStripMenuItem.Name = "zalogujSięToolStripMenuItem";
            this.zalogujSięToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.zalogujSięToolStripMenuItem.Text = "Zaloguj się";
            this.zalogujSięToolStripMenuItem.Click += new System.EventHandler(this.zalogujSięToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // outcommeHealthLabel
            // 
            this.outcommeHealthLabel.AutoSize = true;
            this.outcommeHealthLabel.Location = new System.Drawing.Point(71, 196);
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
            this.outcommeHealthUpDown.Location = new System.Drawing.Point(145, 224);
            this.outcommeHealthUpDown.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.outcommeHealthUpDown.Name = "outcommeHealthUpDown";
            this.outcommeHealthUpDown.Size = new System.Drawing.Size(120, 20);
            this.outcommeHealthUpDown.TabIndex = 7;
            // 
            // addingDatasToCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 345);
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
            this.MaximumSize = new System.Drawing.Size(442, 383);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(442, 383);
            this.Name = "addingDatasToCount";
            this.Text = "Sprawdź swoje podatki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addingDatasToCount_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.incommeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeSocialUpDown)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outcommeHealthUpDown)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem zalogujSięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Label outcommeHealthLabel;
        private System.Windows.Forms.NumericUpDown outcommeHealthUpDown;
    }
}