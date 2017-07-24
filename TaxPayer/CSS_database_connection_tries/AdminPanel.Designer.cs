namespace CSS_database_connection_tries
{
    partial class AdminPanel
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutSięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stawkęPodatkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwotęWolnaOdPodatkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratcjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajAdministratoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujSwojeKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllDatas = new System.Windows.Forms.DataGridView();
            this.info_label = new System.Windows.Forms.Label();
            this.taxelLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllDatas)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.operacjeToolStripMenuItem,
            this.administratcjaToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 16;
            this.mainMenu.Text = "Główne menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutSięToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logOutSięToolStripMenuItem
            // 
            this.logOutSięToolStripMenuItem.Name = "logOutSięToolStripMenuItem";
            this.logOutSięToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.logOutSięToolStripMenuItem.Text = "Wyloguj się";
            this.logOutSięToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
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
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addValueToolStripMenuItem,
            this.editToolStripMenuItem,
            this.reactiveToolStripMenuItem,
            this.refreashToolStripMenuItem});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "Operacje";
            // 
            // addValueToolStripMenuItem
            // 
            this.addValueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stawkęPodatkuToolStripMenuItem,
            this.kwotęWolnaOdPodatkuToolStripMenuItem});
            this.addValueToolStripMenuItem.Name = "addValueToolStripMenuItem";
            this.addValueToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addValueToolStripMenuItem.Text = "Dodaj";
            // 
            // stawkęPodatkuToolStripMenuItem
            // 
            this.stawkęPodatkuToolStripMenuItem.Name = "stawkęPodatkuToolStripMenuItem";
            this.stawkęPodatkuToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.stawkęPodatkuToolStripMenuItem.Text = "Stawkę podatku";
            this.stawkęPodatkuToolStripMenuItem.Click += new System.EventHandler(this.addTaxValueToolStripMenuItem_Click);
            // 
            // kwotęWolnaOdPodatkuToolStripMenuItem
            // 
            this.kwotęWolnaOdPodatkuToolStripMenuItem.Name = "kwotęWolnaOdPodatkuToolStripMenuItem";
            this.kwotęWolnaOdPodatkuToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.kwotęWolnaOdPodatkuToolStripMenuItem.Text = "Kwotę wolna od podatku";
            this.kwotęWolnaOdPodatkuToolStripMenuItem.Click += new System.EventHandler(this.freePatValueAddToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taxValueToolStripMenuItem,
            this.freeValueToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.editToolStripMenuItem.Text = "Edytuj";
            // 
            // taxValueToolStripMenuItem
            // 
            this.taxValueToolStripMenuItem.Name = "taxValueToolStripMenuItem";
            this.taxValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.taxValueToolStripMenuItem.Text = "Stawkę podatku";
            this.taxValueToolStripMenuItem.Click += new System.EventHandler(this.taxValueToolStripMenuItem_Click);
            // 
            // freeValueToolStripMenuItem
            // 
            this.freeValueToolStripMenuItem.Name = "freeValueToolStripMenuItem";
            this.freeValueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.freeValueToolStripMenuItem.Text = "Kwote wolna";
            this.freeValueToolStripMenuItem.Click += new System.EventHandler(this.freeValueToolStripMenuItem_Click);
            // 
            // reactiveToolStripMenuItem
            // 
            this.reactiveToolStripMenuItem.Name = "reactiveToolStripMenuItem";
            this.reactiveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.reactiveToolStripMenuItem.Text = "Akktywuj próg";
            this.reactiveToolStripMenuItem.Click += new System.EventHandler(this.reactiveToolStripMenuItem_Click);
            // 
            // refreashToolStripMenuItem
            // 
            this.refreashToolStripMenuItem.Name = "refreashToolStripMenuItem";
            this.refreashToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.refreashToolStripMenuItem.Text = "Odśwież";
            this.refreashToolStripMenuItem.Click += new System.EventHandler(this.refreashToolStripMenuItem_Click);
            // 
            // administratcjaToolStripMenuItem
            // 
            this.administratcjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajAdministratoraToolStripMenuItem,
            this.edytujSwojeKontoToolStripMenuItem});
            this.administratcjaToolStripMenuItem.Name = "administratcjaToolStripMenuItem";
            this.administratcjaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administratcjaToolStripMenuItem.Text = "Administratcja";
            // 
            // dodajAdministratoraToolStripMenuItem
            // 
            this.dodajAdministratoraToolStripMenuItem.Name = "dodajAdministratoraToolStripMenuItem";
            this.dodajAdministratoraToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dodajAdministratoraToolStripMenuItem.Text = "Dodaj administratora";
            this.dodajAdministratoraToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // edytujSwojeKontoToolStripMenuItem
            // 
            this.edytujSwojeKontoToolStripMenuItem.Name = "edytujSwojeKontoToolStripMenuItem";
            this.edytujSwojeKontoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.edytujSwojeKontoToolStripMenuItem.Text = "Edytuj swoje konto";
            this.edytujSwojeKontoToolStripMenuItem.Click += new System.EventHandler(this.editAdminAccountToolStripMenuItem_Click);
            // 
            // showAllDatas
            // 
            this.showAllDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showAllDatas.Location = new System.Drawing.Point(17, 84);
            this.showAllDatas.Name = "showAllDatas";
            this.showAllDatas.Size = new System.Drawing.Size(743, 358);
            this.showAllDatas.TabIndex = 17;
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_label.Location = new System.Drawing.Point(14, 68);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(194, 13);
            this.info_label.TabIndex = 21;
            this.info_label.Text = "Flagi(FlagT): 0 - nieaktywne, 1 - aktywne";
            // 
            // taxelLabel
            // 
            this.taxelLabel.AutoSize = true;
            this.taxelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxelLabel.Location = new System.Drawing.Point(12, 34);
            this.taxelLabel.Name = "taxelLabel";
            this.taxelLabel.Size = new System.Drawing.Size(191, 25);
            this.taxelLabel.TabIndex = 24;
            this.taxelLabel.Text = "Stawki podatkowe:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.taxelLabel);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.showAllDatas);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 540);
            this.Name = "AdminPanel";
            this.Text = "Panel administracyjny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllDatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutSięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeValueToolStripMenuItem;
        private System.Windows.Forms.DataGridView showAllDatas;
        private System.Windows.Forms.ToolStripMenuItem refreashToolStripMenuItem;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.ToolStripMenuItem reactiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratcjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajAdministratoraToolStripMenuItem;
        private System.Windows.Forms.Label taxelLabel;
        private System.Windows.Forms.ToolStripMenuItem stawkęPodatkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kwotęWolnaOdPodatkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujSwojeKontoToolStripMenuItem;
    }
}