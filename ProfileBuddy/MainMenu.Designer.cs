namespace ProfileBuddy
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.generateRouteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMainMenu.Size = new System.Drawing.Size(359, 412);
            this.labelMainMenu.TabIndex = 0;
            this.labelMainMenu.Text = "Profilebuddy.\nA route-generator for\nHonorbuddy.";
            this.labelMainMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMainMenu.UseMnemonic = false;
            // 
            // generateRouteButton
            // 
            this.generateRouteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.generateRouteButton.AutoSize = true;
            this.generateRouteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateRouteButton.ForeColor = System.Drawing.Color.Green;
            this.generateRouteButton.Location = new System.Drawing.Point(12, 95);
            this.generateRouteButton.Name = "generateRouteButton";
            this.generateRouteButton.Size = new System.Drawing.Size(335, 104);
            this.generateRouteButton.TabIndex = 1;
            this.generateRouteButton.Text = "Generate Route";
            this.generateRouteButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Maroon;
            this.exitButton.Location = new System.Drawing.Point(12, 296);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(335, 104);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(359, 412);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateRouteButton);
            this.Controls.Add(this.labelMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Profilebuddy";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Button generateRouteButton;
        private System.Windows.Forms.Button exitButton;
    }
}

