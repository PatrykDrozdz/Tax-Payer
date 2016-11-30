namespace CSS_database_connection_tries
{
    partial class Add
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
            this.valueUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueLabel = new System.Windows.Forms.Label();
            this.maxPaymentLabel = new System.Windows.Forms.Label();
            this.insertToDB = new System.Windows.Forms.Button();
            this.downPaymentLabel = new System.Windows.Forms.Label();
            this.downPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.guaranteedAmountLabel = new System.Windows.Forms.Label();
            this.guaranteedAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.taxFreeValue = new System.Windows.Forms.ComboBox();
            this.freeTaxValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPaymentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteedAmountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // valueUpDown
            // 
            this.valueUpDown.DecimalPlaces = 2;
            this.valueUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.valueUpDown.Location = new System.Drawing.Point(28, 60);
            this.valueUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueUpDown.Name = "valueUpDown";
            this.valueUpDown.Size = new System.Drawing.Size(120, 20);
            this.valueUpDown.TabIndex = 2;
            // 
            // maxPaymentUpDown
            // 
            this.maxPaymentUpDown.DecimalPlaces = 2;
            this.maxPaymentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxPaymentUpDown.Location = new System.Drawing.Point(28, 361);
            this.maxPaymentUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxPaymentUpDown.Name = "maxPaymentUpDown";
            this.maxPaymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxPaymentUpDown.TabIndex = 3;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(25, 29);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(99, 13);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.Text = "Stawka podatkowa";
            // 
            // maxPaymentLabel
            // 
            this.maxPaymentLabel.AutoSize = true;
            this.maxPaymentLabel.Location = new System.Drawing.Point(25, 327);
            this.maxPaymentLabel.Name = "maxPaymentLabel";
            this.maxPaymentLabel.Size = new System.Drawing.Size(208, 13);
            this.maxPaymentLabel.TabIndex = 6;
            this.maxPaymentLabel.Text = "Maksymalna pensja dla stawki podatkowej";
            // 
            // insertToDB
            // 
            this.insertToDB.Location = new System.Drawing.Point(18, 519);
            this.insertToDB.MaximumSize = new System.Drawing.Size(215, 44);
            this.insertToDB.MinimumSize = new System.Drawing.Size(215, 44);
            this.insertToDB.Name = "insertToDB";
            this.insertToDB.Size = new System.Drawing.Size(215, 44);
            this.insertToDB.TabIndex = 8;
            this.insertToDB.Text = "Dodaj";
            this.insertToDB.UseVisualStyleBackColor = true;
            this.insertToDB.Click += new System.EventHandler(this.insertToDB_Click);
            // 
            // downPaymentLabel
            // 
            this.downPaymentLabel.AutoSize = true;
            this.downPaymentLabel.Location = new System.Drawing.Point(25, 229);
            this.downPaymentLabel.Name = "downPaymentLabel";
            this.downPaymentLabel.Size = new System.Drawing.Size(196, 13);
            this.downPaymentLabel.TabIndex = 10;
            this.downPaymentLabel.Text = "Minimalna pensja dla stawki podatkowej";
            // 
            // downPaymentUpDown
            // 
            this.downPaymentUpDown.DecimalPlaces = 2;
            this.downPaymentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.downPaymentUpDown.Location = new System.Drawing.Point(28, 260);
            this.downPaymentUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.downPaymentUpDown.Name = "downPaymentUpDown";
            this.downPaymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.downPaymentUpDown.TabIndex = 9;
            // 
            // guaranteedAmountLabel
            // 
            this.guaranteedAmountLabel.AutoSize = true;
            this.guaranteedAmountLabel.Location = new System.Drawing.Point(25, 127);
            this.guaranteedAmountLabel.Name = "guaranteedAmountLabel";
            this.guaranteedAmountLabel.Size = new System.Drawing.Size(152, 13);
            this.guaranteedAmountLabel.TabIndex = 12;
            this.guaranteedAmountLabel.Text = "Kwota gwarantowana podatku";
            // 
            // guaranteedAmountUpDown
            // 
            this.guaranteedAmountUpDown.DecimalPlaces = 2;
            this.guaranteedAmountUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.guaranteedAmountUpDown.Location = new System.Drawing.Point(28, 161);
            this.guaranteedAmountUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.guaranteedAmountUpDown.Name = "guaranteedAmountUpDown";
            this.guaranteedAmountUpDown.Size = new System.Drawing.Size(120, 20);
            this.guaranteedAmountUpDown.TabIndex = 11;
            // 
            // taxFreeValue
            // 
            this.taxFreeValue.FormattingEnabled = true;
            this.taxFreeValue.Location = new System.Drawing.Point(28, 469);
            this.taxFreeValue.Name = "taxFreeValue";
            this.taxFreeValue.Size = new System.Drawing.Size(120, 21);
            this.taxFreeValue.TabIndex = 13;
            this.taxFreeValue.SelectedIndexChanged += new System.EventHandler(this.taxFreeValue_SelectedIndexChanged);
            // 
            // freeTaxValueLabel
            // 
            this.freeTaxValueLabel.AutoSize = true;
            this.freeTaxValueLabel.Location = new System.Drawing.Point(25, 428);
            this.freeTaxValueLabel.Name = "freeTaxValueLabel";
            this.freeTaxValueLabel.Size = new System.Drawing.Size(125, 13);
            this.freeTaxValueLabel.TabIndex = 14;
            this.freeTaxValueLabel.Text = "Kwota wolna od podatku";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 575);
            this.Controls.Add(this.freeTaxValueLabel);
            this.Controls.Add(this.taxFreeValue);
            this.Controls.Add(this.guaranteedAmountLabel);
            this.Controls.Add(this.guaranteedAmountUpDown);
            this.Controls.Add(this.downPaymentLabel);
            this.Controls.Add(this.downPaymentUpDown);
            this.Controls.Add(this.insertToDB);
            this.Controls.Add(this.maxPaymentLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.maxPaymentUpDown);
            this.Controls.Add(this.valueUpDown);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add";
            this.Text = "Dodaj stawkę podatkową";
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPaymentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guaranteedAmountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown valueUpDown;
        private System.Windows.Forms.NumericUpDown maxPaymentUpDown;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label maxPaymentLabel;
        private System.Windows.Forms.Button insertToDB;
        private System.Windows.Forms.Label downPaymentLabel;
        private System.Windows.Forms.NumericUpDown downPaymentUpDown;
        private System.Windows.Forms.Label guaranteedAmountLabel;
        private System.Windows.Forms.NumericUpDown guaranteedAmountUpDown;
        private System.Windows.Forms.ComboBox taxFreeValue;
        private System.Windows.Forms.Label freeTaxValueLabel;
    }
}