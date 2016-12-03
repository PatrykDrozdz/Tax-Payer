namespace CSS_database_connection_tries
{
    partial class Result
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
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxValueLabel = new System.Windows.Forms.Label();
            this.taxValueCount = new System.Windows.Forms.Label();
            this.taxValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxLabel.Location = new System.Drawing.Point(35, 26);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(237, 25);
            this.taxLabel.TabIndex = 0;
            this.taxLabel.Text = "Podatek do zapłacenia:";
            // 
            // taxValueLabel
            // 
            this.taxValueLabel.AutoSize = true;
            this.taxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxValueLabel.Location = new System.Drawing.Point(36, 147);
            this.taxValueLabel.Name = "taxValueLabel";
            this.taxValueLabel.Size = new System.Drawing.Size(193, 25);
            this.taxValueLabel.TabIndex = 1;
            this.taxValueLabel.Text = "Kwota podatkowa: ";
            // 
            // taxValueCount
            // 
            this.taxValueCount.AutoSize = true;
            this.taxValueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxValueCount.Location = new System.Drawing.Point(36, 67);
            this.taxValueCount.Name = "taxValueCount";
            this.taxValueCount.Size = new System.Drawing.Size(15, 20);
            this.taxValueCount.TabIndex = 4;
            this.taxValueCount.Text = "-";
            // 
            // taxValue
            // 
            this.taxValue.AutoSize = true;
            this.taxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taxValue.Location = new System.Drawing.Point(36, 188);
            this.taxValue.Name = "taxValue";
            this.taxValue.Size = new System.Drawing.Size(15, 20);
            this.taxValue.TabIndex = 5;
            this.taxValue.Text = "-";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 228);
            this.Controls.Add(this.taxValue);
            this.Controls.Add(this.taxValueCount);
            this.Controls.Add(this.taxValueLabel);
            this.Controls.Add(this.taxLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(302, 266);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(302, 266);
            this.Name = "Result";
            this.Text = "Wynik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxValueLabel;
        private System.Windows.Forms.Label taxValueCount;
        private System.Windows.Forms.Label taxValue;
    }
}