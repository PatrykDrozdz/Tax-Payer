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
            this.contentsText = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.maxPayment = new System.Windows.Forms.Label();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.insertToDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // valueUpDown
            // 
            this.valueUpDown.DecimalPlaces = 3;
            this.valueUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.valueUpDown.Location = new System.Drawing.Point(30, 46);
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
            this.maxPaymentUpDown.Location = new System.Drawing.Point(30, 113);
            this.maxPaymentUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxPaymentUpDown.Name = "maxPaymentUpDown";
            this.maxPaymentUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxPaymentUpDown.TabIndex = 3;
            // 
            // contentsText
            // 
            this.contentsText.Location = new System.Drawing.Point(30, 167);
            this.contentsText.Multiline = true;
            this.contentsText.Name = "contentsText";
            this.contentsText.Size = new System.Drawing.Size(251, 96);
            this.contentsText.TabIndex = 4;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(27, 15);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(99, 13);
            this.valueLabel.TabIndex = 5;
            this.valueLabel.Text = "Stawka podatkowa";
            // 
            // maxPayment
            // 
            this.maxPayment.AutoSize = true;
            this.maxPayment.Location = new System.Drawing.Point(27, 79);
            this.maxPayment.Name = "maxPayment";
            this.maxPayment.Size = new System.Drawing.Size(208, 13);
            this.maxPayment.TabIndex = 6;
            this.maxPayment.Text = "Maksymalna pensja dla stawki podatkowej";
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Location = new System.Drawing.Point(27, 151);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(70, 13);
            this.contentsLabel.TabIndex = 7;
            this.contentsLabel.Text = "Treść ustawy";
            // 
            // insertToDB
            // 
            this.insertToDB.Location = new System.Drawing.Point(27, 281);
            this.insertToDB.Name = "insertToDB";
            this.insertToDB.Size = new System.Drawing.Size(254, 44);
            this.insertToDB.TabIndex = 8;
            this.insertToDB.Text = "Dodaj";
            this.insertToDB.UseVisualStyleBackColor = true;
            this.insertToDB.Click += new System.EventHandler(this.insertToDB_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 337);
            this.Controls.Add(this.insertToDB);
            this.Controls.Add(this.contentsLabel);
            this.Controls.Add(this.maxPayment);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.contentsText);
            this.Controls.Add(this.maxPaymentUpDown);
            this.Controls.Add(this.valueUpDown);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 375);
            this.Name = "Add";
            this.Text = "Dodaj stawkę podatkową";
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown valueUpDown;
        private System.Windows.Forms.NumericUpDown maxPaymentUpDown;
        private System.Windows.Forms.TextBox contentsText;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label maxPayment;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.Button insertToDB;
    }
}