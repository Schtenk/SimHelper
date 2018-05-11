using IWshRuntimeLibrary;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace SimHelper
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private string shortcutPath = ""; 

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            shortcutPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Startup)}\{Program.ApplicationName}.lnk";

            sfxStartPathBox.Text = Properties.Settings.Default.sfxStartPath;
            sfxCompletePathBox.Text = Properties.Settings.Default.sfxCompletePath;
            MinimizeToTrayBox.Checked = Properties.Settings.Default.minimizeToTray;
            AlwaysShowTrayIconBox.Checked = Properties.Settings.Default.alwaysShowTrayIcon;
            StartOnLaunch.Checked = Properties.Settings.Default.startOnLaunch;
            LaunchMinimized.Checked = Properties.Settings.Default.launchMinimized;
            DisableRunningWarningBox.Checked = Properties.Settings.Default.disableRunningWarning;
            DisableRunningWarningBox.Enabled = Properties.Settings.Default.minimizeToTray;
            ShowErrorBox.Checked = Properties.Settings.Default.showErrorMessages;

            if (System.IO.File.Exists(shortcutPath))
            {
                LaunchWithWindows.Checked = true;
            }
        }

        #region SoundButtons
        private void SfxStartPathBrowseButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SoundPlayer sfxTest = new SoundPlayer(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sound file working, try another .wav (Exception{ex.Message}-{ex})");
                }

                sfxStartPathBox.Text = ofd.FileName;
                Properties.Settings.Default.sfxStartPath = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void SfxCompletePathBrowseButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SoundPlayer sfxTest = new SoundPlayer(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sound file working, try another .wav (Exception{ex.Message}-{ex})");
                }

                sfxCompletePathBox.Text = ofd.FileName;
                Properties.Settings.Default.sfxCompletePath = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }
        private void TestStartSfxButton_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sfxTest = null;
                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.sfxStartPath))
                {
                    sfxTest = new SoundPlayer(Properties.Resources.start);
                }
                else
                {
                    sfxTest = new SoundPlayer(Properties.Settings.Default.sfxStartPath);
                }
                sfxTest.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sound file not working, try another .wav (Exception{ex.Message}-{ex})");
            }
        }
        private void TestCompleteSfxButton_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer sfxTest = null;
                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.sfxCompletePath))
                {
                    sfxTest = new SoundPlayer(Properties.Resources.success);
                }
                else
                {
                    sfxTest = new SoundPlayer(Properties.Settings.Default.sfxCompletePath);
                }
                sfxTest.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sound file not working, try another .wav (Exception{ex.Message}-{ex})");
            }
        }
        private void SetStartToDefaultButton_Click(object sender, EventArgs e)
        {
            sfxStartPathBox.Text = "";
            Properties.Settings.Default.sfxStartPath = "";
            Properties.Settings.Default.Save();
        }
        private void SetCompleteToDefaultButton_Click(object sender, EventArgs e)
        {
            sfxCompletePathBox.Text = "";
            Properties.Settings.Default.sfxCompletePath = "";
            Properties.Settings.Default.Save();
        }
        #endregion

        #region PropertiesSaving
        private void MinimizeToTrayBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minimizeToTray = MinimizeToTrayBox.Checked;
            Properties.Settings.Default.Save();

            DisableRunningWarningBox.Enabled = MinimizeToTrayBox.Checked;
        }

        private void AlwaysShowTrayIconBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.alwaysShowTrayIcon = AlwaysShowTrayIconBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void StartOnLaunch_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.startOnLaunch = StartOnLaunch.Checked;
            Properties.Settings.Default.Save();
        }

        private void LaunchMinimized_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.launchMinimized = LaunchMinimized.Checked;
            Properties.Settings.Default.Save();
        }

        private void LaunchWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (LaunchWithWindows.Checked)
            {
                if(!System.IO.File.Exists(shortcutPath))
                {
                    WshShell shell = new WshShell();

                    IWshShortcut shortcut = shell.CreateShortcut(shortcutPath) as IWshShortcut;
                    shortcut.Description = "Autostartup shortcut for SimHelper";
                    shortcut.TargetPath = Application.ExecutablePath;
                    shortcut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    shortcut.Save();
                }
                
            }
            else
            {
                if(System.IO.File.Exists(shortcutPath))
                {
                    System.IO.File.Delete(shortcutPath);
                }
            }
        }

        private void DisableRunningWarningBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.disableRunningWarning= DisableRunningWarningBox.Checked;
            Properties.Settings.Default.Save();
        }
        #endregion

        private void ShowErrorBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.showErrorMessages = ShowErrorBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
