namespace CSS_database_connection_tries
{
    partial class AddFreeTaxValue
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
            this.taxFreePaymentLabel2 = new System.Windows.Forms.Label();
            this.taxFreePaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.addFreePaymentTax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taxFreePaymentUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // taxFreePaymentLabel2
            // 
            this.taxFreePaymentLabel2.AutoSize = true;
            this.taxFreePaymentLabel2.Location = new System.Drawing.Point(26, 38);
            this.taxFreePaymentLabel2.Name = "taxFreePaymentLabel2";
            this.taxFreePaymentLabel2.Size = new System.Drawing.Size(181, 13);
            this.taxFreePaymentLabel2.TabIndex = 8;
            this.taxFreePaymentLabel2.Text = "Kwota wolna od podatku do dodania";
            // 
            // taxFreePaymentUpDown
            // 
            this.taxFreePaymentUpDown.DecimalPlaces = 2;
            this.taxFreePaymentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.taxFreePaymentUpDown.Location = new System.Drawing.Point(29, 85);
            this.taxFreePaymentUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.taxFreePaymentUpDown.Name = "taxFreePaymentUpDown";
            this.taxFreePaymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.taxFreePaymentUpDown.TabIndex = 7;
            // 
            // addFreePaymentTax
            // 
            this.addFreePaymentTax.Location = new System.Drawing.Point(29, 142);
            this.addFreePaymentTax.Name = "addFreePaymentTax";
            this.addFreePaymentTax.Size = new System.Drawing.Size(152, 47);
            this.addFreePaymentTax.TabIndex = 6;
            this.addFreePaymentTax.Text = "Dodaj";
            this.addFreePaymentTax.UseVisualStyleBackColor = true;
            this.addFreePaymentTax.Click += new System.EventHandler(this.addFreePaymentTax_Click);
            // 
            // AddFreeTaxValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 224);
            this.Controls.Add(this.taxFreePaymentLabel2);
            this.Controls.Add(this.taxFreePaymentUpDown);
            this.Controls.Add(this.addFreePaymentTax);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(244, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(244, 262);
            this.Name = "AddFreeTaxValue";
            this.Text = "Dodaj kwotę wolną od podatku";
            ((System.ComponentModel.ISupportInitialize)(this.taxFreePaymentUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taxFreePaymentLabel2;
        private System.Windows.Forms.NumericUpDown taxFreePaymentUpDown;
        private System.Windows.Forms.Button addFreePaymentTax;
    }
}