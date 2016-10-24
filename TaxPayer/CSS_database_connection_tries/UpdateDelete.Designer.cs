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
            this.contentsLabel = new System.Windows.Forms.Label();
            this.maxPayment = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.contentsText = new System.Windows.Forms.TextBox();
            this.maxPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueUpDown = new System.Windows.Forms.NumericUpDown();
            this.contentsLabel2 = new System.Windows.Forms.Label();
            this.contentsTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // idCombo
            // 
            this.idCombo.FormattingEnabled = true;
            this.idCombo.Location = new System.Drawing.Point(236, 12);
            this.idCombo.Name = "idCombo";
            this.idCombo.Size = new System.Drawing.Size(66, 21);
            this.idCombo.TabIndex = 0;
            this.idCombo.SelectedIndexChanged += new System.EventHandler(this.idCombo_SelectedIndexChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(178, 12);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(15, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "id";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(44, 315);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 42);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(322, 315);
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
            this.labelForMaxPayment.Location = new System.Drawing.Point(46, 143);
            this.labelForMaxPayment.Name = "labelForMaxPayment";
            this.labelForMaxPayment.Size = new System.Drawing.Size(10, 13);
            this.labelForMaxPayment.TabIndex = 7;
            this.labelForMaxPayment.Text = "-";
            // 
            // labelForValue
            // 
            this.labelForValue.AutoSize = true;
            this.labelForValue.Location = new System.Drawing.Point(46, 76);
            this.labelForValue.Name = "labelForValue";
            this.labelForValue.Size = new System.Drawing.Size(10, 13);
            this.labelForValue.TabIndex = 6;
            this.labelForValue.Text = "-";
            // 
            // maxPayment2
            // 
            this.maxPayment2.AutoSize = true;
            this.maxPayment2.Location = new System.Drawing.Point(41, 107);
            this.maxPayment2.Name = "maxPayment2";
            this.maxPayment2.Size = new System.Drawing.Size(208, 13);
            this.maxPayment2.TabIndex = 9;
            this.maxPayment2.Text = "Maksymalna pensja dla stawki podatkowej";
            // 
            // valueLabel2
            // 
            this.valueLabel2.AutoSize = true;
            this.valueLabel2.Location = new System.Drawing.Point(41, 43);
            this.valueLabel2.Name = "valueLabel2";
            this.valueLabel2.Size = new System.Drawing.Size(99, 13);
            this.valueLabel2.TabIndex = 8;
            this.valueLabel2.Text = "Stawka podatkowa";
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Location = new System.Drawing.Point(319, 179);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(70, 13);
            this.contentsLabel.TabIndex = 15;
            this.contentsLabel.Text = "Treść ustawy";
            // 
            // maxPayment
            // 
            this.maxPayment.AutoSize = true;
            this.maxPayment.Location = new System.Drawing.Point(319, 107);
            this.maxPayment.Name = "maxPayment";
            this.maxPayment.Size = new System.Drawing.Size(208, 13);
            this.maxPayment.TabIndex = 14;
            this.maxPayment.Text = "Maksymalna pensja dla stawki podatkowej";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(319, 43);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(99, 13);
            this.valueLabel.TabIndex = 13;
            this.valueLabel.Text = "Stawka podatkowa";
            // 
            // contentsText
            // 
            this.contentsText.Location = new System.Drawing.Point(322, 198);
            this.contentsText.Multiline = true;
            this.contentsText.Name = "contentsText";
            this.contentsText.Size = new System.Drawing.Size(251, 96);
            this.contentsText.TabIndex = 12;
            // 
            // maxPaymentUpDown
            // 
            this.maxPaymentUpDown.DecimalPlaces = 2;
            this.maxPaymentUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxPaymentUpDown.Location = new System.Drawing.Point(322, 141);
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
            this.valueUpDown.Location = new System.Drawing.Point(322, 74);
            this.valueUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueUpDown.Name = "valueUpDown";
            this.valueUpDown.Size = new System.Drawing.Size(120, 20);
            this.valueUpDown.TabIndex = 10;
            // 
            // contentsLabel2
            // 
            this.contentsLabel2.AutoSize = true;
            this.contentsLabel2.Location = new System.Drawing.Point(41, 179);
            this.contentsLabel2.Name = "contentsLabel2";
            this.contentsLabel2.Size = new System.Drawing.Size(70, 13);
            this.contentsLabel2.TabIndex = 16;
            this.contentsLabel2.Text = "Treść ustawy";
            // 
            // contentsTextLabel
            // 
            this.contentsTextLabel.AutoSize = true;
            this.contentsTextLabel.Location = new System.Drawing.Point(46, 201);
            this.contentsTextLabel.Name = "contentsTextLabel";
            this.contentsTextLabel.Size = new System.Drawing.Size(10, 13);
            this.contentsTextLabel.TabIndex = 17;
            this.contentsTextLabel.Text = "-";
            // 
            // UpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 369);
            this.Controls.Add(this.contentsTextLabel);
            this.Controls.Add(this.contentsLabel2);
            this.Controls.Add(this.contentsLabel);
            this.Controls.Add(this.maxPayment);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.contentsText);
            this.Controls.Add(this.maxPaymentUpDown);
            this.Controls.Add(this.valueUpDown);
            this.Controls.Add(this.maxPayment2);
            this.Controls.Add(this.valueLabel2);
            this.Controls.Add(this.labelForMaxPayment);
            this.Controls.Add(this.labelForValue);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idCombo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(614, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(614, 407);
            this.Name = "UpdateDelete";
            this.Text = "Usuń lub edytuj stawkę podatkową ";
            ((System.ComponentModel.ISupportInitialize)(this.maxPaymentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
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
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.Label maxPayment;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox contentsText;
        private System.Windows.Forms.NumericUpDown maxPaymentUpDown;
        private System.Windows.Forms.NumericUpDown valueUpDown;
        private System.Windows.Forms.Label contentsLabel2;
        private System.Windows.Forms.Label contentsTextLabel;
    }
}