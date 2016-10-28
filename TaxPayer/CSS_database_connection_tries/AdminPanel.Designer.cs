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
            this.logOut = new System.Windows.Forms.Button();
            this.addOpen = new System.Windows.Forms.Button();
            this.addDeleteOpen = new System.Windows.Forms.Button();
            this.taxFreeOpen = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujSięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajStawkęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stawkęPodatkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kwoteWolnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odświeżToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akktywójPrógToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllDatas = new System.Windows.Forms.DataGridView();
            this.freePayLabel = new System.Windows.Forms.Label();
            this.freePayShow = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.Reactive = new System.Windows.Forms.Button();
            this.addAdmin_button = new System.Windows.Forms.Button();
            this.administratcjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajAdministratoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllDatas)).BeginInit();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(868, 52);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(99, 44);
            this.logOut.TabIndex = 10;
            this.logOut.Text = "Wyloguj się";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // addOpen
            // 
            this.addOpen.Location = new System.Drawing.Point(868, 102);
            this.addOpen.Name = "addOpen";
            this.addOpen.Size = new System.Drawing.Size(99, 44);
            this.addOpen.TabIndex = 13;
            this.addOpen.Text = "Dodaj stawkę";
            this.addOpen.UseVisualStyleBackColor = true;
            this.addOpen.Click += new System.EventHandler(this.addOpen_Click);
            // 
            // addDeleteOpen
            // 
            this.addDeleteOpen.Location = new System.Drawing.Point(868, 152);
            this.addDeleteOpen.Name = "addDeleteOpen";
            this.addDeleteOpen.Size = new System.Drawing.Size(99, 55);
            this.addDeleteOpen.TabIndex = 14;
            this.addDeleteOpen.Text = "edytuj/usuń stawkę podatkową";
            this.addDeleteOpen.UseVisualStyleBackColor = true;
            this.addDeleteOpen.Click += new System.EventHandler(this.addDeleteOpen_Click);
            // 
            // taxFreeOpen
            // 
            this.taxFreeOpen.Location = new System.Drawing.Point(868, 213);
            this.taxFreeOpen.Name = "taxFreeOpen";
            this.taxFreeOpen.Size = new System.Drawing.Size(99, 60);
            this.taxFreeOpen.TabIndex = 15;
            this.taxFreeOpen.Text = "Edytuj kwotę wolną od podatku";
            this.taxFreeOpen.UseVisualStyleBackColor = true;
            this.taxFreeOpen.Click += new System.EventHandler(this.taxFreeOpen_Click);
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
            this.mainMenu.Size = new System.Drawing.Size(979, 24);
            this.mainMenu.TabIndex = 16;
            this.mainMenu.Text = "Główne menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujSięToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // wylogujSięToolStripMenuItem
            // 
            this.wylogujSięToolStripMenuItem.Name = "wylogujSięToolStripMenuItem";
            this.wylogujSięToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.wylogujSięToolStripMenuItem.Text = "Wyloguj się";
            this.wylogujSięToolStripMenuItem.Click += new System.EventHandler(this.wylogujSięToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
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
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajStawkęToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.odświeżToolStripMenuItem,
            this.akktywójPrógToolStripMenuItem});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjeToolStripMenuItem.Text = "Operacje";
            // 
            // dodajStawkęToolStripMenuItem
            // 
            this.dodajStawkęToolStripMenuItem.Name = "dodajStawkęToolStripMenuItem";
            this.dodajStawkęToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dodajStawkęToolStripMenuItem.Text = "Dodaj stawkę";
            this.dodajStawkęToolStripMenuItem.Click += new System.EventHandler(this.dodajStawkęToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stawkęPodatkuToolStripMenuItem,
            this.kwoteWolnaToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // stawkęPodatkuToolStripMenuItem
            // 
            this.stawkęPodatkuToolStripMenuItem.Name = "stawkęPodatkuToolStripMenuItem";
            this.stawkęPodatkuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.stawkęPodatkuToolStripMenuItem.Text = "Stawkę podatku";
            this.stawkęPodatkuToolStripMenuItem.Click += new System.EventHandler(this.stawkęPodatkuToolStripMenuItem_Click);
            // 
            // kwoteWolnaToolStripMenuItem
            // 
            this.kwoteWolnaToolStripMenuItem.Name = "kwoteWolnaToolStripMenuItem";
            this.kwoteWolnaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kwoteWolnaToolStripMenuItem.Text = "Kwote wolna";
            this.kwoteWolnaToolStripMenuItem.Click += new System.EventHandler(this.kwoteWolnaToolStripMenuItem_Click);
            // 
            // odświeżToolStripMenuItem
            // 
            this.odświeżToolStripMenuItem.Name = "odświeżToolStripMenuItem";
            this.odświeżToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.odświeżToolStripMenuItem.Text = "Odśwież";
            this.odświeżToolStripMenuItem.Click += new System.EventHandler(this.odświeżToolStripMenuItem_Click);
            // 
            // akktywójPrógToolStripMenuItem
            // 
            this.akktywójPrógToolStripMenuItem.Name = "akktywójPrógToolStripMenuItem";
            this.akktywójPrógToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.akktywójPrógToolStripMenuItem.Text = "Akktywuj próg";
            this.akktywójPrógToolStripMenuItem.Click += new System.EventHandler(this.akktywujPrógToolStripMenuItem_Click);
            // 
            // showAllDatas
            // 
            this.showAllDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showAllDatas.Location = new System.Drawing.Point(12, 52);
            this.showAllDatas.Name = "showAllDatas";
            this.showAllDatas.Size = new System.Drawing.Size(822, 358);
            this.showAllDatas.TabIndex = 17;
            // 
            // freePayLabel
            // 
            this.freePayLabel.AutoSize = true;
            this.freePayLabel.Location = new System.Drawing.Point(12, 445);
            this.freePayLabel.Name = "freePayLabel";
            this.freePayLabel.Size = new System.Drawing.Size(128, 13);
            this.freePayLabel.TabIndex = 18;
            this.freePayLabel.Text = "Kwota wolna od podatku:";
            // 
            // freePayShow
            // 
            this.freePayShow.AutoSize = true;
            this.freePayShow.Location = new System.Drawing.Point(146, 445);
            this.freePayShow.Name = "freePayShow";
            this.freePayShow.Size = new System.Drawing.Size(10, 13);
            this.freePayShow.TabIndex = 19;
            this.freePayShow.Text = "-";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(868, 279);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(99, 33);
            this.refreshButton.TabIndex = 20;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(12, 33);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(162, 13);
            this.info_label.TabIndex = 21;
            this.info_label.Text = "Flagi: 0 - nieaktywne, 1 -aktywne";
            // 
            // Reactive
            // 
            this.Reactive.Location = new System.Drawing.Point(868, 318);
            this.Reactive.Name = "Reactive";
            this.Reactive.Size = new System.Drawing.Size(99, 44);
            this.Reactive.TabIndex = 22;
            this.Reactive.Text = "Aktywuj próg ponownie";
            this.Reactive.UseVisualStyleBackColor = true;
            this.Reactive.Click += new System.EventHandler(this.Reactive_Click);
            // 
            // addAdmin_button
            // 
            this.addAdmin_button.Location = new System.Drawing.Point(868, 368);
            this.addAdmin_button.Name = "addAdmin_button";
            this.addAdmin_button.Size = new System.Drawing.Size(99, 42);
            this.addAdmin_button.TabIndex = 23;
            this.addAdmin_button.Text = "Dodaj administratora";
            this.addAdmin_button.UseVisualStyleBackColor = true;
            this.addAdmin_button.Click += new System.EventHandler(this.addAdmin_button_Click);
            // 
            // administratcjaToolStripMenuItem
            // 
            this.administratcjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajAdministratoraToolStripMenuItem});
            this.administratcjaToolStripMenuItem.Name = "administratcjaToolStripMenuItem";
            this.administratcjaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.administratcjaToolStripMenuItem.Text = "Administratcja";
            // 
            // dodajAdministratoraToolStripMenuItem
            // 
            this.dodajAdministratoraToolStripMenuItem.Name = "dodajAdministratoraToolStripMenuItem";
            this.dodajAdministratoraToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dodajAdministratoraToolStripMenuItem.Text = "Dodaj administratora";
            this.dodajAdministratoraToolStripMenuItem.Click += new System.EventHandler(this.dodajAdministratoraToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 502);
            this.Controls.Add(this.addAdmin_button);
            this.Controls.Add(this.Reactive);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.freePayShow);
            this.Controls.Add(this.freePayLabel);
            this.Controls.Add(this.showAllDatas);
            this.Controls.Add(this.taxFreeOpen);
            this.Controls.Add(this.addDeleteOpen);
            this.Controls.Add(this.addOpen);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(995, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(995, 540);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showAllDatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button addOpen;
        private System.Windows.Forms.Button addDeleteOpen;
        private System.Windows.Forms.Button taxFreeOpen;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujSięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajStawkęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stawkęPodatkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kwoteWolnaToolStripMenuItem;
        private System.Windows.Forms.DataGridView showAllDatas;
        private System.Windows.Forms.Label freePayLabel;
        private System.Windows.Forms.Label freePayShow;
        private System.Windows.Forms.ToolStripMenuItem odświeżToolStripMenuItem;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button Reactive;
        private System.Windows.Forms.ToolStripMenuItem akktywójPrógToolStripMenuItem;
        private System.Windows.Forms.Button addAdmin_button;
        private System.Windows.Forms.ToolStripMenuItem administratcjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajAdministratoraToolStripMenuItem;
    }
}