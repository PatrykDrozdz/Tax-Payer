namespace CSS_database_connection_tries
{
    partial class UpdateDelete
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
            this.idCombo = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.labelForMaxPayment = new System.Windows.Forms.Label();
            this.labelForValue = new System.Windows.Forms.Label();
            this.maxPayment2 = new System.Windows.Forms.Label();
            this.valueLabel2 = new System.Windows.Forms.Label();
            this.maxPayment = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.maxPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueUpDown = new System.Windows.Forms.NumericUpDown();
            this.downPaymentLabel = new System.Windows.Forms.Label();
            this.guaranteedAmountLabel = new System.Windows.Forms.Label();
            this.downPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.guaranteedAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.downPaymentLabel2 = new System.Windows.Forms.Label();
            this.labelForDownPayment = new System.Windows.Forms.Label();
            this.guaranteedAmountLabel2 = new System.Windows.Forms.Label();
            this.labelForGuaranteedAmount = new System.Windows.Forms.Label();
            this.taxFreePaymentLabel = new System.Windows.Forms.Label();
            this.labelForTaxFreePayment = new System.Windows.Forms.Label();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.editGroup = new System.Windows.Forms.GroupBox();
            this.freePayLabel = new System.Windows.Forms.Label();
            this.taxFreeValue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPaymentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteedAmountUpDown)).BeginInit();
            this.infoGroup.SuspendLayout();
            this.editGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCombo
            // 
            this.idCombo.FormattingEnabled = true;
            this.idCombo.Location = new System.Drawing.Point(181, 17);
            this.idCombo.Name = "idCombo";
            this.idCombo.Size = new System.Drawing.Size(66, 21);
            this.idCombo.TabIndex = 0;
            this.idCombo.SelectedIndexChanged += new System.EventHandler(this.idCombo_SelectedIndexChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(32, 17);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(116, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "Id Progu Podatkowego";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(19, 362);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 42);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(42, 357);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(148, 42);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "edytuj";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // labelForMaxPayment
            // 
            this.labelForMaxPayment.AutoSize = true;
            this.labelForMaxPayment.Location = new System.Drawing.Point(21, 188);
            this.labelForMaxPayment.Name = "labelForMaxPayment";
            this.labelForMaxPayment.Size = new System.Drawing.Size(10, 13);
            this.labelForMaxPayment.TabIndex = 7;
            this.labelForMaxPayment.Text = "-";
            // 
            // labelForValue
            // 
            this.labelForValue.AutoSize = true;
            this.labelForValue.Location = new System.Drawing.Point(21, 61);
            this.labelForValue.Name = "labelForValue";
            this.labelForValue.Size = new System.Drawing.Size(10, 13);
            this.labelForValue.TabIndex = 6;
            this.labelForValue.Text = "-";
            // 
            // maxPayment2
            // 
            this.maxPayment2.AutoSize = true;
            this.maxPayment2.Location = new System.Drawing.Point(16, 158);
            this.maxPayment2.Name = "maxPayment2";
            this.maxPayment2.Size = new System.Drawing.Size(208, 13);
            this.maxPayment2.TabIndex = 9;
            this.maxPayment2.Text = "Maksymalna pensja dla stawki podatkowej";
            // 
            // valueLabel2
            // 
            this.valueLabel2.AutoSize = true;
            this.valueLabel2.Location = new System.Drawing.Point(16, 34);
            this.valueLabel2.Name = "valueLabel2";
            this.valueLabel2.Size = new System.Drawing.Size(99, 13);
            this.valueLabel2.TabIndex = 8;
            this.valueLabel2.Text = "Stawka podatkowa";
            // 
            // maxPayment
            // 
            this.maxPayment.AutoSize = true;
            this.maxPayment.Location = new System.Drawing.Point(258, 43);
            this.maxPayment.Name = "maxPayment";
            this.maxPayment.Size = new System.Drawing.Size(208, 13);
            this.maxPayment.TabIndex = 14;
            this.maxPayment.Text = "Maksymalna pensja dla stawki podatkowej";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(39, 43);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(99, 13);
            this.valueLabel.TabIndex = 13;
            this.valueLabel.Text = "Stawka podatkowa";
            // 
            // maxPaymentUpDown
            // 
            this.maxPaymentUpDown.DecimalPlaces = 2;
            this.maxPaymentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxPaymentUpDown.Location = new System.Drawing.Point(261, 72);
            this.maxPaymentUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxPaymentUpDown.Name = "maxPaymentUpDown";
            this.maxPaymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxPaymentUpDown.TabIndex = 11;
            // 
            // valueUpDown
            // 
            this.valueUpDown.DecimalPlaces = 3;
            this.valueUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.valueUpDown.Location = new System.Drawing.Point(42, 72);
            this.valueUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueUpDown.Name = "valueUpDown";
            this.valueUpDown.Size = new System.Drawing.Size(120, 20);
            this.valueUpDown.TabIndex = 10;
            // 
            // downPaymentLabel
            // 
            this.downPaymentLabel.AutoSize = true;
            this.downPaymentLabel.Location = new System.Drawing.Point(258, 168);
            this.downPaymentLabel.Name = "downPaymentLabel";
            this.downPaymentLabel.Size = new System.Drawing.Size(196, 13);
            this.downPaymentLabel.TabIndex = 21;
            this.downPaymentLabel.Text = "Minimalna pensja dla stawki podatkowej";
            // 
            // guaranteedAmountLabel
            // 
            this.guaranteedAmountLabel.AutoSize = true;
            this.guaranteedAmountLabel.Location = new System.Drawing.Point(39, 168);
            this.guaranteedAmountLabel.Name = "guaranteedAmountLabel";
            this.guaranteedAmountLabel.Size = new System.Drawing.Size(116, 13);
            this.guaranteedAmountLabel.TabIndex = 20;
            this.guaranteedAmountLabel.Text = "Stawka gwarantowana";
            // 
            // downPaymentUpDown
            // 
            this.downPaymentUpDown.DecimalPlaces = 2;
            this.downPaymentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.downPaymentUpDown.Location = new System.Drawing.Point(261, 191);
            this.downPaymentUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.downPaymentUpDown.Name = "downPaymentUpDown";
            this.downPaymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.downPaymentUpDown.TabIndex = 19;
            // 
            // guaranteedAmountUpDown
            // 
            this.guaranteedAmountUpDown.DecimalPlaces = 3;
            this.guaranteedAmountUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.guaranteedAmountUpDown.Location = new System.Drawing.Point(42, 191);
            this.guaranteedAmountUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guaranteedAmountUpDown.Name = "guaranteedAmountUpDown";
            this.guaranteedAmountUpDown.Size = new System.Drawing.Size(120, 20);
            this.guaranteedAmountUpDown.TabIndex = 18;
            // 
            // downPaymentLabel2
            // 
            this.downPaymentLabel2.AutoSize = true;
            this.downPaymentLabel2.Location = new System.Drawing.Point(16, 96);
            this.downPaymentLabel2.Name = "downPaymentLabel2";
            this.downPaymentLabel2.Size = new System.Drawing.Size(196, 13);
            this.downPaymentLabel2.TabIndex = 23;
            this.downPaymentLabel2.Text = "Minimalna pensja dla stawki podatkowej";
            // 
            // labelForDownPayment
            // 
            this.labelForDownPayment.AutoSize = true;
            this.labelForDownPayment.Location = new System.Drawing.Point(21, 124);
            this.labelForDownPayment.Name = "labelForDownPayment";
            this.labelForDownPayment.Size = new System.Drawing.Size(10, 13);
            this.labelForDownPayment.TabIndex = 22;
            this.labelForDownPayment.Text = "-";
            // 
            // guaranteedAmountLabel2
            // 
            this.guaranteedAmountLabel2.AutoSize = true;
            this.guaranteedAmountLabel2.Location = new System.Drawing.Point(16, 223);
            this.guaranteedAmountLabel2.Name = "guaranteedAmountLabel2";
            this.guaranteedAmountLabel2.Size = new System.Drawing.Size(110, 13);
            this.guaranteedAmountLabel2.TabIndex = 25;
            this.guaranteedAmountLabel2.Text = "Kwota gwarantowana";
            // 
            // labelForGuaranteedAmount
            // 
            this.labelForGuaranteedAmount.AutoSize = true;
            this.labelForGuaranteedAmount.Location = new System.Drawing.Point(21, 256);
            this.labelForGuaranteedAmount.Name = "labelForGuaranteedAmount";
            this.labelForGuaranteedAmount.Size = new System.Drawing.Size(10, 13);
            this.labelForGuaranteedAmount.TabIndex = 24;
            this.labelForGuaranteedAmount.Text = "-";
            // 
            // taxFreePaymentLabel
            // 
            this.taxFreePaymentLabel.AutoSize = true;
            this.taxFreePaymentLabel.Location = new System.Drawing.Point(16, 286);
            this.taxFreePaymentLabel.Name = "taxFreePaymentLabel";
            this.taxFreePaymentLabel.Size = new System.Drawing.Size(131, 13);
            this.taxFreePaymentLabel.TabIndex = 27;
            this.taxFreePaymentLabel.Text = "Kwota wolna od podatku: ";
            // 
            // labelForTaxFreePayment
            // 
            this.labelForTaxFreePayment.AutoSize = true;
            this.labelForTaxFreePayment.Location = new System.Drawing.Point(21, 314);
            this.labelForTaxFreePayment.Name = "labelForTaxFreePayment";
            this.labelForTaxFreePayment.Size = new System.Drawing.Size(10, 13);
            this.labelForTaxFreePayment.TabIndex = 28;
            this.labelForTaxFreePayment.Text = "-";
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.valueLabel2);
            this.infoGroup.Controls.Add(this.labelForValue);
            this.infoGroup.Controls.Add(this.labelForTaxFreePayment);
            this.infoGroup.Controls.Add(this.labelForMaxPayment);
            this.infoGroup.Controls.Add(this.taxFreePaymentLabel);
            this.infoGroup.Controls.Add(this.maxPayment2);
            this.infoGroup.Controls.Add(this.labelForDownPayment);
            this.infoGroup.Controls.Add(this.guaranteedAmountLabel2);
            this.infoGroup.Controls.Add(this.downPaymentLabel2);
            this.infoGroup.Controls.Add(this.labelForGuaranteedAmount);
            this.infoGroup.Controls.Add(this.deleteButton);
            this.infoGroup.Location = new System.Drawing.Point(35, 51);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(254, 423);
            this.infoGroup.TabIndex = 29;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Detale ustawy";
            // 
            // editGroup
            // 
            this.editGroup.Controls.Add(this.freePayLabel);
            this.editGroup.Controls.Add(this.taxFreeValue);
            this.editGroup.Controls.Add(this.valueUpDown);
            this.editGroup.Controls.Add(this.maxPaymentUpDown);
            this.editGroup.Controls.Add(this.editButton);
            this.editGroup.Controls.Add(this.valueLabel);
            this.editGroup.Controls.Add(this.downPaymentLabel);
            this.editGroup.Controls.Add(this.maxPayment);
            this.editGroup.Controls.Add(this.guaranteedAmountLabel);
            this.editGroup.Controls.Add(this.guaranteedAmountUpDown);
            this.editGroup.Controls.Add(this.downPaymentUpDown);
            this.editGroup.Location = new System.Drawing.Point(310, 56);
            this.editGroup.Name = "editGroup";
            this.editGroup.Size = new System.Drawing.Size(515, 418);
            this.editGroup.TabIndex = 30;
            this.editGroup.TabStop = false;
            this.editGroup.Text = "Pole edycji kwoty podatku";
            // 
            // freePayLabel
            // 
            this.freePayLabel.AutoSize = true;
            this.freePayLabel.Location = new System.Drawing.Point(39, 251);
            this.freePayLabel.Name = "freePayLabel";
            this.freePayLabel.Size = new System.Drawing.Size(125, 13);
            this.freePayLabel.TabIndex = 28;
            this.freePayLabel.Text = "Kwota wolna od podatku";
            // 
            // taxFreeValue
            // 
            this.taxFreeValue.FormattingEnabled = true;
            this.taxFreeValue.Location = new System.Drawing.Point(42, 290);
            this.taxFreeValue.Name = "taxFreeValue";
            this.taxFreeValue.Size = new System.Drawing.Size(120, 21);
            this.taxFreeValue.TabIndex = 27;
            this.taxFreeValue.SelectedIndexChanged += new System.EventHandler(this.taxFreeValue_SelectedIndexChanged);
            // 
            // UpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 486);
            this.Controls.Add(this.editGroup);
            this.Controls.Add(this.infoGroup);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idCombo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(868, 524);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(868, 524);
            this.Name = "UpdateDelete";
            this.Text = "Usuń lub edytuj stawkę podatkową ";
            this.Load += new System.EventHandler(this.UpdateDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPaymentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteedAmountUpDown)).EndInit();
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.editGroup.ResumeLayout(false);
            this.editGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idCombo;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label labelForMaxPayment;
        private System.Windows.Forms.Label labelForValue;
        private System.Windows.Forms.Label maxPayment2;
        private System.Windows.Forms.Label valueLabel2;
        private System.Windows.Forms.Label maxPayment;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.NumericUpDown maxPaymentUpDown;
        private System.Windows.Forms.NumericUpDown valueUpDown;
        private System.Windows.Forms.Label downPaymentLabel;
        private System.Windows.Forms.Label guaranteedAmountLabel;
        private System.Windows.Forms.NumericUpDown downPaymentUpDown;
        private System.Windows.Forms.NumericUpDown guaranteedAmountUpDown;
        private System.Windows.Forms.Label downPaymentLabel2;
        private System.Windows.Forms.Label labelForDownPayment;
        private System.Windows.Forms.Label guaranteedAmountLabel2;
        private System.Windows.Forms.Label labelForGuaranteedAmount;
        private System.Windows.Forms.Label taxFreePaymentLabel;
        private System.Windows.Forms.Label labelForTaxFreePayment;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.GroupBox editGroup;
        private System.Windows.Forms.Label freePayLabel;
        private System.Windows.Forms.ComboBox taxFreeValue;
    }
}