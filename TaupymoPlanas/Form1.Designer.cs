namespace TaupymoPlanas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RevenueTextBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PensionFundTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RecommendedPension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Įveskite savo amžių";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeTextBox.Location = new System.Drawing.Point(54, 87);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(165, 31);
            this.AgeTextBox.TabIndex = 1;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(54, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Įveskite savo mėnesinį darbo užmokestį atskaičiavus mokesčius";
            // 
            // RevenueTextBox
            // 
            this.RevenueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RevenueTextBox.Location = new System.Drawing.Point(54, 192);
            this.RevenueTextBox.Name = "RevenueTextBox";
            this.RevenueTextBox.Size = new System.Drawing.Size(150, 31);
            this.RevenueTextBox.TabIndex = 2;
            this.RevenueTextBox.TextChanged += new System.EventHandler(this.RevenueTextBox_TextChanged);
            // 
            // GenderBox
            // 
            this.GenderBox.AllowDrop = true;
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Vyras",
            "Moteris"});
            this.GenderBox.Location = new System.Drawing.Point(61, 300);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(182, 33);
            this.GenderBox.TabIndex = 5;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(59, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jūsų lytis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(59, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Įveskite prognozuojama senatvės pensija";
            // 
            // PensionFundTextbox
            // 
            this.PensionFundTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PensionFundTextbox.Location = new System.Drawing.Point(61, 406);
            this.PensionFundTextbox.Name = "PensionFundTextbox";
            this.PensionFundTextbox.Size = new System.Drawing.Size(150, 31);
            this.PensionFundTextbox.TabIndex = 8;
            this.PensionFundTextbox.TextChanged += new System.EventHandler(this.PensionFundTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(972, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Per mėnesį Jums reiktų taupyti";
            // 
            // ResultBox
            // 
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Enabled = false;
            this.ResultBox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultBox.Location = new System.Drawing.Point(972, 372);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(294, 40);
            this.ResultBox.TabIndex = 10;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(647, 293);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(177, 101);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Skaičiuoti";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 12;
            // 
            // RecommendedPension
            // 
            this.RecommendedPension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecommendedPension.Enabled = false;
            this.RecommendedPension.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RecommendedPension.Location = new System.Drawing.Point(972, 251);
            this.RecommendedPension.MaxLength = 4;
            this.RecommendedPension.Name = "RecommendedPension";
            this.RecommendedPension.Size = new System.Drawing.Size(294, 40);
            this.RecommendedPension.TabIndex = 14;
            this.RecommendedPension.TextChanged += new System.EventHandler(this.RecommendedPension_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(972, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rekomenduojama sutaupyti suma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 839);
            this.Controls.Add(this.RecommendedPension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PensionFundTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.RevenueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Taupymo planavimo programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox AgeTextBox;
        private Label label2;
        private TextBox RevenueTextBox;
        private ComboBox GenderBox;
        private Label label4;
        private Label label5;
        private TextBox PensionFundTextbox;
        private Label label6;
        private TextBox ResultBox;
        private Button CalculateButton;
        private Label label7;
        private TextBox RecommendedPension;
        private Label label3;
    }
}