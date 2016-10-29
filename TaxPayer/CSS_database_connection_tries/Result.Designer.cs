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
            this.labelForShowingContent = new System.Windows.Forms.Label();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.taxValueCount = new System.Windows.Forms.Label();
            this.taxValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(48, 28);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(121, 13);
            this.taxLabel.TabIndex = 0;
            this.taxLabel.Text = "Podatek do zapłacenia:";
            // 
            // taxValueLabel
            // 
            this.taxValueLabel.AutoSize = true;
            this.taxValueLabel.Location = new System.Drawing.Point(48, 92);
            this.taxValueLabel.Name = "taxValueLabel";
            this.taxValueLabel.Size = new System.Drawing.Size(95, 13);
            this.taxValueLabel.TabIndex = 1;
            this.taxValueLabel.Text = "Wartość podatku: ";
            // 
            // labelForShowingContent
            // 
            this.labelForShowingContent.AutoSize = true;
            this.labelForShowingContent.Location = new System.Drawing.Point(48, 184);
            this.labelForShowingContent.Name = "labelForShowingContent";
            this.labelForShowingContent.Size = new System.Drawing.Size(10, 13);
            this.labelForShowingContent.TabIndex = 3;
            this.labelForShowingContent.Text = "-";
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Location = new System.Drawing.Point(48, 150);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(70, 13);
            this.contentsLabel.TabIndex = 2;
            this.contentsLabel.Text = "Treść ustawy";
            // 
            // taxValueCount
            // 
            this.taxValueCount.AutoSize = true;
            this.taxValueCount.Location = new System.Drawing.Point(48, 58);
            this.taxValueCount.Name = "taxValueCount";
            this.taxValueCount.Size = new System.Drawing.Size(10, 13);
            this.taxValueCount.TabIndex = 4;
            this.taxValueCount.Text = "-";
            // 
            // taxValue
            // 
            this.taxValue.AutoSize = true;
            this.taxValue.Location = new System.Drawing.Point(48, 118);
            this.taxValue.Name = "taxValue";
            this.taxValue.Size = new System.Drawing.Size(10, 13);
            this.taxValue.TabIndex = 5;
            this.taxValue.Text = "-";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 301);
            this.Controls.Add(this.taxValue);
            this.Controls.Add(this.taxValueCount);
            this.Controls.Add(this.labelForShowingContent);
            this.Controls.Add(this.contentsLabel);
            this.Controls.Add(this.taxValueLabel);
            this.Controls.Add(this.taxLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 339);
            this.Name = "Result";
            this.Text = "Wynik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxValueLabel;
        private System.Windows.Forms.Label labelForShowingContent;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.Label taxValueCount;
        private System.Windows.Forms.Label taxValue;
    }
}