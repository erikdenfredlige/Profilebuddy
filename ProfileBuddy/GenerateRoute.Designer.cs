namespace ProfileBuddy
{
    partial class GenerateRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateRoute));
            this.nameLabel = new System.Windows.Forms.Label();
            this.minimumLevelLabel = new System.Windows.Forms.Label();
            this.maximumLevelLabel = new System.Windows.Forms.Label();
            this.mailListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sellListBox = new System.Windows.Forms.CheckedListBox();
            this.nameOfRouteTB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(-1, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name of route:";
            // 
            // minimumLevelLabel
            // 
            this.minimumLevelLabel.AutoSize = true;
            this.minimumLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumLevelLabel.Location = new System.Drawing.Point(0, 38);
            this.minimumLevelLabel.Name = "minimumLevelLabel";
            this.minimumLevelLabel.Size = new System.Drawing.Size(90, 13);
            this.minimumLevelLabel.TabIndex = 1;
            this.minimumLevelLabel.Text = "Minimum level:";
            // 
            // maximumLevelLabel
            // 
            this.maximumLevelLabel.AutoSize = true;
            this.maximumLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumLevelLabel.Location = new System.Drawing.Point(-3, 64);
            this.maximumLevelLabel.Name = "maximumLevelLabel";
            this.maximumLevelLabel.Size = new System.Drawing.Size(93, 13);
            this.maximumLevelLabel.TabIndex = 2;
            this.maximumLevelLabel.Text = "Maximum level:";
            // 
            // mailListBox
            // 
            this.mailListBox.FormattingEnabled = true;
            this.mailListBox.Items.AddRange(new object[] {
            "White items",
            "Green items",
            "Blue items",
            "Purple items"});
            this.mailListBox.Location = new System.Drawing.Point(230, 249);
            this.mailListBox.Name = "mailListBox";
            this.mailListBox.Size = new System.Drawing.Size(120, 94);
            this.mailListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail which items?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sell which items?";
            // 
            // sellListBox
            // 
            this.sellListBox.FormattingEnabled = true;
            this.sellListBox.Items.AddRange(new object[] {
            "White items",
            "Green items",
            "Blue items",
            "Purple items"});
            this.sellListBox.Location = new System.Drawing.Point(12, 249);
            this.sellListBox.Name = "sellListBox";
            this.sellListBox.Size = new System.Drawing.Size(120, 94);
            this.sellListBox.TabIndex = 7;
            // 
            // nameOfRouteTB
            // 
            this.nameOfRouteTB.Location = new System.Drawing.Point(92, 9);
            this.nameOfRouteTB.Name = "nameOfRouteTB";
            this.nameOfRouteTB.Size = new System.Drawing.Size(255, 20);
            this.nameOfRouteTB.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 20);
            this.textBox3.TabIndex = 10;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.generateButton.ForeColor = System.Drawing.Color.Green;
            this.generateButton.Location = new System.Drawing.Point(205, 349);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(142, 51);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Generate!";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.Maroon;
            this.backButton.Location = new System.Drawing.Point(12, 350);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(142, 51);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GenerateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(359, 412);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nameOfRouteTB);
            this.Controls.Add(this.sellListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailListBox);
            this.Controls.Add(this.maximumLevelLabel);
            this.Controls.Add(this.minimumLevelLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenerateRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label minimumLevelLabel;
        private System.Windows.Forms.Label maximumLevelLabel;
        private System.Windows.Forms.CheckedListBox mailListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox sellListBox;
        private System.Windows.Forms.TextBox nameOfRouteTB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button backButton;
    }
}