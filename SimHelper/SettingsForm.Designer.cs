namespace SimHelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.setStartToDefaultButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sfxStartTestButton = new System.Windows.Forms.Button();
            this.sfxStartPathBrowseButton = new System.Windows.Forms.Button();
            this.sfxStartPathBox = new System.Windows.Forms.TextBox();
            this.setCompleteToDefaultButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sfxCompleteTestButton = new System.Windows.Forms.Button();
            this.sfxCompletePathBrowseButton = new System.Windows.Forms.Button();
            this.sfxCompletePathBox = new System.Windows.Forms.TextBox();
            this.MinimizeToTrayBox = new System.Windows.Forms.CheckBox();
            this.AlwaysShowTrayIconBox = new System.Windows.Forms.CheckBox();
            this.LaunchWithWindows = new System.Windows.Forms.CheckBox();
            this.LaunchMinimized = new System.Windows.Forms.CheckBox();
            this.StartOnLaunch = new System.Windows.Forms.CheckBox();
            this.DisableRunningWarningBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowErrorBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // setStartToDefaultButton
            // 
            this.setStartToDefaultButton.Location = new System.Drawing.Point(93, 51);
            this.setStartToDefaultButton.Name = "setStartToDefaultButton";
            this.setStartToDefaultButton.Size = new System.Drawing.Size(89, 23);
            this.setStartToDefaultButton.TabIndex = 30;
            this.setStartToDefaultButton.Text = "Set To Default";
            this.setStartToDefaultButton.UseVisualStyleBackColor = true;
            this.setStartToDefaultButton.Click += new System.EventHandler(this.SetStartToDefaultButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sound File On Simulation Start ( .wav only ) :";
            // 
            // sfxStartTestButton
            // 
            this.sfxStartTestButton.Location = new System.Drawing.Point(12, 51);
            this.sfxStartTestButton.Name = "sfxStartTestButton";
            this.sfxStartTestButton.Size = new System.Drawing.Size(75, 23);
            this.sfxStartTestButton.TabIndex = 28;
            this.sfxStartTestButton.Text = "Test";
            this.sfxStartTestButton.UseVisualStyleBackColor = true;
            this.sfxStartTestButton.Click += new System.EventHandler(this.TestStartSfxButton_Click);
            // 
            // sfxStartPathBrowseButton
            // 
            this.sfxStartPathBrowseButton.Location = new System.Drawing.Point(227, 23);
            this.sfxStartPathBrowseButton.Name = "sfxStartPathBrowseButton";
            this.sfxStartPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sfxStartPathBrowseButton.TabIndex = 27;
            this.sfxStartPathBrowseButton.Text = "Browse";
            this.sfxStartPathBrowseButton.UseVisualStyleBackColor = true;
            this.sfxStartPathBrowseButton.Click += new System.EventHandler(this.SfxStartPathBrowseButton_Click);
            // 
            // sfxStartPathBox
            // 
            this.sfxStartPathBox.Location = new System.Drawing.Point(12, 25);
            this.sfxStartPathBox.Name = "sfxStartPathBox";
            this.sfxStartPathBox.ReadOnly = true;
            this.sfxStartPathBox.Size = new System.Drawing.Size(209, 20);
            this.sfxStartPathBox.TabIndex = 26;
            // 
            // setCompleteToDefaultButton
            // 
            this.setCompleteToDefaultButton.Location = new System.Drawing.Point(93, 128);
            this.setCompleteToDefaultButton.Name = "setCompleteToDefaultButton";
            this.setCompleteToDefaultButton.Size = new System.Drawing.Size(89, 23);
            this.setCompleteToDefaultButton.TabIndex = 25;
            this.setCompleteToDefaultButton.Text = "Set To Default";
            this.setCompleteToDefaultButton.UseVisualStyleBackColor = true;
            this.setCompleteToDefaultButton.Click += new System.EventHandler(this.SetCompleteToDefaultButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sound File On Simulation Complete ( .wav only ) :";
            // 
            // sfxCompleteTestButton
            // 
            this.sfxCompleteTestButton.Location = new System.Drawing.Point(12, 128);
            this.sfxCompleteTestButton.Name = "sfxCompleteTestButton";
            this.sfxCompleteTestButton.Size = new System.Drawing.Size(75, 23);
            this.sfxCompleteTestButton.TabIndex = 23;
            this.sfxCompleteTestButton.Text = "Test";
            this.sfxCompleteTestButton.UseVisualStyleBackColor = true;
            this.sfxCompleteTestButton.Click += new System.EventHandler(this.TestCompleteSfxButton_Click);
            // 
            // sfxCompletePathBrowseButton
            // 
            this.sfxCompletePathBrowseButton.Location = new System.Drawing.Point(227, 101);
            this.sfxCompletePathBrowseButton.Name = "sfxCompletePathBrowseButton";
            this.sfxCompletePathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.sfxCompletePathBrowseButton.TabIndex = 22;
            this.sfxCompletePathBrowseButton.Text = "Browse";
            this.sfxCompletePathBrowseButton.UseVisualStyleBackColor = true;
            this.sfxCompletePathBrowseButton.Click += new System.EventHandler(this.SfxCompletePathBrowseButton_Click);
            // 
            // sfxCompletePathBox
            // 
            this.sfxCompletePathBox.Location = new System.Drawing.Point(12, 103);
            this.sfxCompletePathBox.Name = "sfxCompletePathBox";
            this.sfxCompletePathBox.ReadOnly = true;
            this.sfxCompletePathBox.Size = new System.Drawing.Size(209, 20);
            this.sfxCompletePathBox.TabIndex = 21;
            // 
            // MinimizeToTrayBox
            // 
            this.MinimizeToTrayBox.AutoSize = true;
            this.MinimizeToTrayBox.Location = new System.Drawing.Point(13, 158);
            this.MinimizeToTrayBox.Name = "MinimizeToTrayBox";
            this.MinimizeToTrayBox.Size = new System.Drawing.Size(106, 17);
            this.MinimizeToTrayBox.TabIndex = 31;
            this.MinimizeToTrayBox.Text = "Minimize To Tray";
            this.MinimizeToTrayBox.UseVisualStyleBackColor = true;
            this.MinimizeToTrayBox.CheckedChanged += new System.EventHandler(this.MinimizeToTrayBox_CheckedChanged);
            // 
            // AlwaysShowTrayIconBox
            // 
            this.AlwaysShowTrayIconBox.AutoSize = true;
            this.AlwaysShowTrayIconBox.Location = new System.Drawing.Point(12, 181);
            this.AlwaysShowTrayIconBox.Name = "AlwaysShowTrayIconBox";
            this.AlwaysShowTrayIconBox.Size = new System.Drawing.Size(137, 17);
            this.AlwaysShowTrayIconBox.TabIndex = 32;
            this.AlwaysShowTrayIconBox.Text = "Always Show Tray Icon";
            this.AlwaysShowTrayIconBox.UseVisualStyleBackColor = true;
            this.AlwaysShowTrayIconBox.CheckedChanged += new System.EventHandler(this.AlwaysShowTrayIconBox_CheckedChanged);
            // 
            // LaunchWithWindows
            // 
            this.LaunchWithWindows.AutoSize = true;
            this.LaunchWithWindows.Location = new System.Drawing.Point(12, 250);
            this.LaunchWithWindows.Name = "LaunchWithWindows";
            this.LaunchWithWindows.Size = new System.Drawing.Size(138, 17);
            this.LaunchWithWindows.TabIndex = 33;
            this.LaunchWithWindows.Text = "Launch With Windows*";
            this.LaunchWithWindows.UseVisualStyleBackColor = true;
            this.LaunchWithWindows.CheckedChanged += new System.EventHandler(this.LaunchWithWindows_CheckedChanged);
            // 
            // LaunchMinimized
            // 
            this.LaunchMinimized.AutoSize = true;
            this.LaunchMinimized.Location = new System.Drawing.Point(12, 227);
            this.LaunchMinimized.Name = "LaunchMinimized";
            this.LaunchMinimized.Size = new System.Drawing.Size(111, 17);
            this.LaunchMinimized.TabIndex = 34;
            this.LaunchMinimized.Text = "Launch Minimized";
            this.LaunchMinimized.UseVisualStyleBackColor = true;
            this.LaunchMinimized.CheckedChanged += new System.EventHandler(this.LaunchMinimized_CheckedChanged);
            // 
            // StartOnLaunch
            // 
            this.StartOnLaunch.AutoSize = true;
            this.StartOnLaunch.Location = new System.Drawing.Point(12, 204);
            this.StartOnLaunch.Name = "StartOnLaunch";
            this.StartOnLaunch.Size = new System.Drawing.Size(104, 17);
            this.StartOnLaunch.TabIndex = 35;
            this.StartOnLaunch.Text = "Start On Launch";
            this.StartOnLaunch.UseVisualStyleBackColor = true;
            this.StartOnLaunch.CheckedChanged += new System.EventHandler(this.StartOnLaunch_CheckedChanged);
            // 
            // DisableRunningWarningBox
            // 
            this.DisableRunningWarningBox.AutoSize = true;
            this.DisableRunningWarningBox.Enabled = false;
            this.DisableRunningWarningBox.Location = new System.Drawing.Point(125, 157);
            this.DisableRunningWarningBox.Name = "DisableRunningWarningBox";
            this.DisableRunningWarningBox.Size = new System.Drawing.Size(147, 17);
            this.DisableRunningWarningBox.TabIndex = 36;
            this.DisableRunningWarningBox.Text = "Disable Running Warning";
            this.DisableRunningWarningBox.UseVisualStyleBackColor = true;
            this.DisableRunningWarningBox.CheckedChanged += new System.EventHandler(this.DisableRunningWarningBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "*Creates Shortcut in user startup folder (appdata)";
            // 
            // ShowErrorBox
            // 
            this.ShowErrorBox.AutoSize = true;
            this.ShowErrorBox.Location = new System.Drawing.Point(12, 286);
            this.ShowErrorBox.Name = "ShowErrorBox";
            this.ShowErrorBox.Size = new System.Drawing.Size(129, 17);
            this.ShowErrorBox.TabIndex = 38;
            this.ShowErrorBox.Text = "Show Error Messages";
            this.ShowErrorBox.UseVisualStyleBackColor = true;
            this.ShowErrorBox.CheckedChanged += new System.EventHandler(this.ShowErrorBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 306);
            this.Controls.Add(this.ShowErrorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisableRunningWarningBox);
            this.Controls.Add(this.StartOnLaunch);
            this.Controls.Add(this.LaunchMinimized);
            this.Controls.Add(this.LaunchWithWindows);
            this.Controls.Add(this.AlwaysShowTrayIconBox);
            this.Controls.Add(this.MinimizeToTrayBox);
            this.Controls.Add(this.setStartToDefaultButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sfxStartTestButton);
            this.Controls.Add(this.sfxStartPathBrowseButton);
            this.Controls.Add(this.sfxStartPathBox);
            this.Controls.Add(this.setCompleteToDefaultButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sfxCompleteTestButton);
            this.Controls.Add(this.sfxCompletePathBrowseButton);
            this.Controls.Add(this.sfxCompletePathBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setStartToDefaultButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sfxStartTestButton;
        private System.Windows.Forms.Button sfxStartPathBrowseButton;
        private System.Windows.Forms.TextBox sfxStartPathBox;
        private System.Windows.Forms.Button setCompleteToDefaultButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sfxCompleteTestButton;
        private System.Windows.Forms.Button sfxCompletePathBrowseButton;
        private System.Windows.Forms.TextBox sfxCompletePathBox;
        private System.Windows.Forms.CheckBox MinimizeToTrayBox;
        private System.Windows.Forms.CheckBox AlwaysShowTrayIconBox;
        private System.Windows.Forms.CheckBox LaunchWithWindows;
        private System.Windows.Forms.CheckBox LaunchMinimized;
        private System.Windows.Forms.CheckBox StartOnLaunch;
        private System.Windows.Forms.CheckBox DisableRunningWarningBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ShowErrorBox;
    }
}