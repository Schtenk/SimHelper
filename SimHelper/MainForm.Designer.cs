namespace SimHelper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.exePathBrowseButton = new System.Windows.Forms.Button();
            this.exePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processPriorityBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.threadsBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.varyLengthBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.ComboBox();
            this.iterationsBox = new System.Windows.Forms.ComboBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.TaskBarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskbarMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpWindowButton = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TaskbarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 51);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(93, 51);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // exePathBrowseButton
            // 
            this.exePathBrowseButton.Location = new System.Drawing.Point(227, 23);
            this.exePathBrowseButton.Name = "exePathBrowseButton";
            this.exePathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.exePathBrowseButton.TabIndex = 2;
            this.exePathBrowseButton.Text = "Browse";
            this.exePathBrowseButton.UseVisualStyleBackColor = true;
            this.exePathBrowseButton.Click += new System.EventHandler(this.ExePathBrowseButon_Click);
            // 
            // exePathBox
            // 
            this.exePathBox.Location = new System.Drawing.Point(12, 25);
            this.exePathBox.Name = "exePathBox";
            this.exePathBox.ReadOnly = true;
            this.exePathBox.Size = new System.Drawing.Size(209, 20);
            this.exePathBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "simc.exe path:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.StatusProgressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 231);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(314, 20);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(118, 15);
            this.StatusLabel.Text = "toolStripStatusLabel1";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 15);
            this.StatusProgressBar.ToolTipText = "progress";
            this.StatusProgressBar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processPriorityBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.threadsBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.varyLengthBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lengthBox);
            this.groupBox1.Controls.Add(this.iterationsBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation Options";
            // 
            // processPriorityBox
            // 
            this.processPriorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processPriorityBox.FormattingEnabled = true;
            this.processPriorityBox.Items.AddRange(new object[] {
            "Low",
            "Below_normal",
            "Normal",
            "Above_normal",
            "High"});
            this.processPriorityBox.Location = new System.Drawing.Point(163, 76);
            this.processPriorityBox.Name = "processPriorityBox";
            this.processPriorityBox.Size = new System.Drawing.Size(121, 21);
            this.processPriorityBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Process Priority:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Threads:";
            // 
            // threadsBox
            // 
            this.threadsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.threadsBox.FormattingEnabled = true;
            this.threadsBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.threadsBox.Location = new System.Drawing.Point(163, 36);
            this.threadsBox.Name = "threadsBox";
            this.threadsBox.Size = new System.Drawing.Size(121, 21);
            this.threadsBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vary Length (%):";
            // 
            // varyLengthBox
            // 
            this.varyLengthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.varyLengthBox.FormattingEnabled = true;
            this.varyLengthBox.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.varyLengthBox.Location = new System.Drawing.Point(6, 116);
            this.varyLengthBox.Name = "varyLengthBox";
            this.varyLengthBox.Size = new System.Drawing.Size(121, 21);
            this.varyLengthBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iterations:";
            // 
            // lengthBox
            // 
            this.lengthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lengthBox.FormattingEnabled = true;
            this.lengthBox.Items.AddRange(new object[] {
            "100",
            "150",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "500",
            "600"});
            this.lengthBox.Location = new System.Drawing.Point(6, 76);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(121, 21);
            this.lengthBox.TabIndex = 1;
            // 
            // iterationsBox
            // 
            this.iterationsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iterationsBox.FormattingEnabled = true;
            this.iterationsBox.Items.AddRange(new object[] {
            "1",
            "100",
            "1000",
            "10000",
            "25000",
            "50000",
            "100000",
            "250000",
            "500000"});
            this.iterationsBox.Location = new System.Drawing.Point(6, 36);
            this.iterationsBox.Name = "iterationsBox";
            this.iterationsBox.Size = new System.Drawing.Size(121, 21);
            this.iterationsBox.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(227, 51);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 10;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // TaskBarIcon
            // 
            this.TaskBarIcon.BalloonTipText = "SimHelper Running In Background";
            this.TaskBarIcon.BalloonTipTitle = "SimHelper Warning";
            this.TaskBarIcon.ContextMenuStrip = this.TaskbarMenu;
            this.TaskBarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskBarIcon.Icon")));
            this.TaskBarIcon.Text = "SimHelper";
            // 
            // TaskbarMenu
            // 
            this.TaskbarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowWindowMenuItem,
            this.StartMenuItem,
            this.StopMenuItem,
            this.SettingsMenuItem,
            this.HelpMenuItem,
            this.ExitMenuItem});
            this.TaskbarMenu.Name = "TaskbarMenu";
            this.TaskbarMenu.Size = new System.Drawing.Size(151, 136);
            // 
            // ShowWindowMenuItem
            // 
            this.ShowWindowMenuItem.Name = "ShowWindowMenuItem";
            this.ShowWindowMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ShowWindowMenuItem.Text = "Show Window";
            this.ShowWindowMenuItem.Click += new System.EventHandler(this.ShowWindowMenuItem_Click);
            // 
            // StartMenuItem
            // 
            this.StartMenuItem.Name = "StartMenuItem";
            this.StartMenuItem.Size = new System.Drawing.Size(150, 22);
            this.StartMenuItem.Text = "Start";
            this.StartMenuItem.Click += new System.EventHandler(this.StartMenuItem_Click);
            // 
            // StopMenuItem
            // 
            this.StopMenuItem.Enabled = false;
            this.StopMenuItem.Name = "StopMenuItem";
            this.StopMenuItem.Size = new System.Drawing.Size(150, 22);
            this.StopMenuItem.Text = "Stop";
            this.StopMenuItem.Click += new System.EventHandler(this.StopMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(150, 22);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(150, 22);
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HelpWindowButton
            // 
            this.HelpWindowButton.Location = new System.Drawing.Point(175, 51);
            this.HelpWindowButton.Name = "HelpWindowButton";
            this.HelpWindowButton.Size = new System.Drawing.Size(46, 23);
            this.HelpWindowButton.TabIndex = 11;
            this.HelpWindowButton.Text = "Help";
            this.HelpWindowButton.UseVisualStyleBackColor = true;
            this.HelpWindowButton.Click += new System.EventHandler(this.HelpWindowButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 251);
            this.Controls.Add(this.HelpWindowButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exePathBox);
            this.Controls.Add(this.exePathBrowseButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SimHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TaskbarMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button exePathBrowseButton;
        private System.Windows.Forms.TextBox exePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lengthBox;
        private System.Windows.Forms.ComboBox iterationsBox;
        private System.Windows.Forms.ComboBox processPriorityBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox threadsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox varyLengthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.NotifyIcon TaskBarIcon;
        private System.Windows.Forms.ContextMenuStrip TaskbarMenu;
        private System.Windows.Forms.ToolStripMenuItem StartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowWindowMenuItem;
        private System.Windows.Forms.Button HelpWindowButton;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
    }
}

