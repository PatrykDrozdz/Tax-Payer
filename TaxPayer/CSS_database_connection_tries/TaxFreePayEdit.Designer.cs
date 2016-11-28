namespace CSS_database_connection_tries
{
    partial class TaxFreePayEdit
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
            this.taxFreePaymentLabel = new System.Windows.Forms.Label();
            this.updateFreePaymentTax = new System.Windows.Forms.Button();
            this.taxFreePaymentToShow = new System.Windows.Forms.Label();
            this.taxFreePaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.taxFreePaymentLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taxFreePaymentUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // taxFreePaymentLabel
            // 
            this.taxFreePaymentLabel.AutoSize = true;
            this.taxFreePaymentLabel.Location = new System.Drawing.Point(42, 33);
            this.taxFreePaymentLabel.Name = "taxFreePaymentLabel";
            this.taxFreePaymentLabel.Size = new System.Drawing.Size(165, 13);
            this.taxFreePaymentLabel.TabIndex = 0;
            this.taxFreePaymentLabel.Text = "Obecna kwota wolna od podatku";
            // 
            // updateFreePaymentTax
            // 
            this.updateFreePaymentTax.Location = new System.Drawing.Point(45, 180);
            this.updateFreePaymentTax.Name = "updateFreePaymentTax";
            this.updateFreePaymentTax.Size = new System.Drawing.Size(152, 47);
            this.updateFreePaymentTax.TabIndex = 1;
            this.updateFreePaymentTax.Text = "Aktualizuj";
            this.updateFreePaymentTax.UseVisualStyleBackColor = true;
            this.updateFreePaymentTax.Click += new System.EventHandler(this.updateFreePaymentTax_Click);
            // 
            // taxFreePaymentToShow
            // 
            this.taxFreePaymentToShow.AutoSize = true;
            this.taxFreePaymentToShow.Location = new System.Drawing.Point(42, 60);
            this.taxFreePaymentToShow.Name = "taxFreePaymentToShow";
            this.taxFreePaymentToShow.Size = new System.Drawing.Size(10, 13);
            this.taxFreePaymentToShow.TabIndex = 2;
            this.taxFreePaymentToShow.Text = "-";
            // 
            // taxFreePaymentUpDown
            // 
            this.taxFreePaymentUpDown.DecimalPlaces = 2;
            this.taxFreePaymentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.taxFreePaymentUpDown.Location = new System.Drawing.Point(45, 133);
            this.taxFreePaymentUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.taxFreePaymentUpDown.Name = "taxFreePaymentUpDown";
            this.taxFreePaymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.taxFreePaymentUpDown.TabIndex = 4;
            // 
            // taxFreePaymentLabel2
            // 
            this.taxFreePaymentLabel2.AutoSize = true;
            this.taxFreePaymentLabel2.Location = new System.Drawing.Point(42, 103);
            this.taxFreePaymentLabel2.Name = "taxFreePaymentLabel2";
            this.taxFreePaymentLabel2.Size = new System.Drawing.Size(195, 13);
            this.taxFreePaymentLabel2.TabIndex = 5;
            this.taxFreePaymentLabel2.Text = "Kwota wolna od podatku do aktualizacji";
            // 
            // TaxFreePayEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 251);
            this.Controls.Add(this.taxFreePaymentLabel2);
            this.Controls.Add(this.taxFreePaymentUpDown);
            this.Controls.Add(this.taxFreePaymentToShow);
            this.Controls.Add(this.updateFreePaymentTax);
            this.Controls.Add(this.taxFreePaymentLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 290);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 290);
            this.Name = "TaxFreePayEdit";
            this.Text = "Edytuj kwotę wolną od podatku";
            ((System.ComponentModel.ISupportInitialize)(this.taxFreePaymentUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taxFreePaymentLabel;
        private System.Windows.Forms.Button updateFreePaymentTax;
        private System.Windows.Forms.Label taxFreePaymentToShow;
        private System.Windows.Forms.NumericUpDown taxFreePaymentUpDown;
        private System.Windows.Forms.Label taxFreePaymentLabel2;
    }
}