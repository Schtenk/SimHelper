using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Media;
using SimHelper.Services;

namespace SimHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Variables
        ClipboardService _clipboardService = null;
        string exePath = "";
        string iterations = "";
        string length = "";
        string varyLength = "";
        string threads = "";
        string processPriority = "";
        SoundPlayer sfxStart;
        SoundPlayer sfxComplete;
        bool stopSimulating = false;

        List<string> classes = new List<string>
        {
            "deathknight",
            "demonhunter",
            "druid",
            "hunter",
            "mage",
            "monk",
            "paladin",
            "priest",
            "rogue",
            "shaman",
            "warlock",
            "warrior"
        };

        Dictionary<string, string> stats = new Dictionary<string, string>
        {
            { "Str", "Strength" },
            { "Int", "Intellect" },
            { "Agi", "Agility" }
        };

        Dictionary<string, string> varyLengthTable = new Dictionary<string, string>
        {
            { "0", "0" },
            { "10", "0.1" },
            { "20", "0.2" },
            { "30", "0.3" },
            { "40", "0.4" },
            { "50", "0.5" }
        };
        #endregion

        #region LoadClose
        private void MainForm_Load(object sender, EventArgs e)
        {
            TaskBarIcon.Visible = Properties.Settings.Default.alwaysShowTrayIcon;
            if (Properties.Settings.Default.launchMinimized)
                WindowState = FormWindowState.Minimized;

            exePathBox.Text = Properties.Settings.Default.exePath;
            iterationsBox.SelectedIndex = Properties.Settings.Default.iterations;
            lengthBox.SelectedIndex = Properties.Settings.Default.length;
            varyLengthBox.SelectedIndex = Properties.Settings.Default.varyLength;
            threadsBox.SelectedIndex = Properties.Settings.Default.threads;
            processPriorityBox.SelectedIndex = Properties.Settings.Default.processPriority;
            
            exePathBox.TextChanged += ExePathBox_TextChanged;
            iterationsBox.SelectedIndexChanged += IterationsBox_SelectedIndexChanged;
            lengthBox.SelectedIndexChanged += LengthBox_SelectedIndexChanged;
            varyLengthBox.SelectedIndexChanged += VaryLengthBox_SelectedIndexChanged;
            threadsBox.SelectedIndexChanged += ThreadsBox_SelectedIndexChanged;
            processPriorityBox.SelectedIndexChanged += ProcessPriorityBox_SelectedIndexChanged;
            
            StatusLabel.Text = "Ready to Start!";

            

            var args = Environment.GetCommandLineArgs().ToList();
            if (args.Contains("-Start") || Properties.Settings.Default.startOnLaunch)
            {
                Start();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaskBarIcon.Dispose();
            if(_clipboardService != null)
            {
                _clipboardService.Dispose();
            }
        }
        #endregion

        #region Core
        private void Stop()
        {
            if(_clipboardService != null)
            {
                _clipboardService.Dispose();
                _clipboardService = null;
            }

            stopSimulating = true;

            startButton.Enabled = true;
            stopButton.Enabled = false;

            exePathBrowseButton.Enabled = true;
            iterationsBox.Enabled = true;
            lengthBox.Enabled = true;
            varyLengthBox.Enabled = true;
            threadsBox.Enabled = true;
            processPriorityBox.Enabled = true;
            SettingsButton.Enabled = true;

            TaskbarMenu.Items["StartMenuitem"].Enabled = true;
            TaskbarMenu.Items["StopMenuItem"].Enabled = false;
            TaskbarMenu.Items["SettingsMenuItem"].Enabled = true;

            StatusLabel.Text = "Ready to Start!";
        }
        private void Start()
        {
            bool success = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;

            exePathBrowseButton.Enabled = false;
            iterationsBox.Enabled = false;
            lengthBox.Enabled = false;
            varyLengthBox.Enabled = false;
            threadsBox.Enabled = false;
            processPriorityBox.Enabled = false;
            SettingsButton.Enabled = false;

            TaskbarMenu.Items["StartMenuitem"].Enabled = false;
            TaskbarMenu.Items["StopMenuItem"].Enabled = true;
            TaskbarMenu.Items["SettingsMenuItem"].Enabled = false;

            if (File.Exists(exePathBox.Text))
            {
                exePath = exePathBox.Text;
            }
            else
            {
                success = false;
                MessageBox.Show("simc.exe file not found");
            }

            if(string.IsNullOrWhiteSpace(Properties.Settings.Default.sfxStartPath))
            {
                sfxStart = new SoundPlayer(Properties.Resources.start);
            }
            else
            {
                if (File.Exists(Properties.Settings.Default.sfxStartPath))
                {
                    sfxStart = new SoundPlayer(Properties.Settings.Default.sfxStartPath);
                }
                else
                {
                    success = false;
                    MessageBox.Show("Sound file not found");
                }
            }

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.sfxCompletePath))
            {
                sfxComplete = new SoundPlayer(Properties.Resources.success);
            }
            else
            {
                if (File.Exists(Properties.Settings.Default.sfxCompletePath))
                {
                    sfxComplete = new SoundPlayer(Properties.Settings.Default.sfxCompletePath);
                }
                else
                {
                    success = false;
                    MessageBox.Show("Sound file not found");
                }
            }
            
            if (success)
            {
                iterations = iterationsBox.Text;
                length = lengthBox.Text;
                varyLength = varyLengthTable[varyLengthBox.Text];
                threads = threadsBox.Text;
                processPriority = processPriorityBox.Text;

                _clipboardService = new ClipboardService();
                _clipboardService.NewTextFound += NewTextFound;
                _clipboardService.Start();
                StatusLabel.Text = "Waiting for simulation text...";
            }
            else
            {
                Stop();
            }
        }

        private void Settings()
        {
            using (var settingsForm = new SettingsForm())
            {
                settingsForm.ShowDialog(this);
                TaskBarIcon.Visible = Properties.Settings.Default.alwaysShowTrayIcon;
            }
        }
        private void Help()
        {
            MessageBox.Show(
@"Warning: sound can be potentially loud, change volume in windows volumecontrol.
Simulation will start as soon as a Simulationcraft string is copied to the clipboard.
A sound will play when simulation starts(Check settings if you want to change sound), when simulation is complete another sound will play.
If start no start sound plays but complete sound does the Simulationcraft string may not have been fully copied, please try again.");
        }
#       endregion

        #region Simulation
        private void NewTextFound(string Text)
        {
            var regex = new Regex(@"(\b" + string.Join("|", classes.Select(Regex.Escape).ToArray()) + @"\b)" + "=\"" + @"(\w*)" + "\"");
            var lines = Regex.Split(Text, "\r\n|\r|\n");
            if (lines.Length > 1)
            {
                var match = regex.Match(lines[0]);
                if (regex.IsMatch(lines[0]))
                {

                    var name = match.Groups[2].Value;
                    var simText = "### Begin GUI options ###" +
                        "\nitem_db_source=local/bcpapi/wowhead" +
                        "\ntarget_error=0" +
                        $"\niterations={iterations}" +
                        "\ndefault_world_lag=0.1" +
                        $"\nmax_time={length}" +
                        $"\nvary_combat_length={varyLength}" +
                        "\nfight_style=Patchwerk" +
                        "\ntmi_window_global=6" +
                        "\ntarget_level+=3" +
                        "\ntarget_race=Humanoid" +
                        "\ndefault_skill=1.0" +
                        "\noptimal_raid=0" +
                        "\noverride.bloodlust=1" +
                        "\noverride.bleeding=1" +
                        "\noverride.mortal_wounds=1" +
                        $"\nthreads={threads}" +
                        $"\nprocess_priority={processPriority}" +
                        "\ncalculate_scale_factors=1" +
                        "\nscale_only=str,agi,int,crit,haste,mastery,vers" +
                        "\nstatistics_level=1" +
                        "\n### End GUI options ###" +
                        "\n### Begin simulateText ###\n" +
                        Text +
                        "\n### End simulateText ###" +
                        "\ndesired_targets=1" +
                        "\n### Begin overrides ###" +
                        "\n# User-specified persistent global and player parameters will be set here." +
                        "\n### End overrides ###" +
                        "\n### Begin final options ###" +
                        "\n### End final options ###" +
                        "\n### END ###";

                    var simFilePath = Path.GetTempPath() + "\\temp.simc";
                    using (StreamWriter writer = new StreamWriter(simFilePath))
                    {
                        writer.Write(simText);
                    }

                    var startInfo = new ProcessStartInfo
                    {
                        FileName = exePath,
                        Arguments = $"\"{simFilePath}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    };
                    Process process = null;
                    try
                    {
                        StatusLabel.GetCurrentParent().Invoke(new MethodInvoker(delegate
                        {
                            StatusLabel.Text = "Simulating...";
                        }));
                        process = Process.Start(startInfo);
                        string pawnString = "";
                        if (!process.StandardOutput.EndOfStream)
                        {
                            sfxStart.Play();
                            statusStrip.Invoke(new MethodInvoker(delegate
                            {
                                StatusProgressBar.Visible = true;
                            }));
                        }
                        while (!process.StandardOutput.EndOfStream)
                        {
                            string line = process.StandardOutput.ReadLine();
                            if (line.StartsWith("Generating") && !line.Contains("reports"))
                            {
                                if (stopSimulating)
                                {
                                    process.Kill();
                                    break;
                                }
                                try
                                {
                                    Regex progressRegex = new Regex(@"(\d*)/(\d*)");
                                    var progressMatch = progressRegex.Match(line);
                                    var currentProgress = int.Parse(progressMatch.Groups[1].Value);
                                    var maxProgress = int.Parse(progressMatch.Groups[2].Value);
                                    StatusLabel.GetCurrentParent().Invoke(new MethodInvoker(delegate
                                    {
                                        StatusLabel.Text = string.Join(" ", line.Split().Take(2)) + $" {currentProgress}/{maxProgress}";
                                    }));
                                    StatusProgressBar.GetCurrentParent().Invoke(new MethodInvoker(delegate
                                    {
                                        StatusProgressBar.Value = currentProgress * 100 / maxProgress;
                                    }));
                                }
                                catch (Exception e)
                                {
                                    if (Properties.Settings.Default.showErrorMessages)
                                        MessageBox.Show($"{e}-{e.Message}");
                                }

                            }
                            else
                            {
                                Regex statRegex = new Regex(@"\b(Str|Int|Agi)\b=([\d*\.]*).*Crit=([\d*\.]*).*Haste=([\d*\.]*).*Mastery=([\d*\.]*).*Vers=([\d*\.]*)");
                                var statMatch = statRegex.Match(line);
                                if (statMatch.Groups.Count > 1)
                                {
                                    pawnString = $"( Pawn: v1: \"{ name }\": {stats[statMatch.Groups[1].Value]}={statMatch.Groups[2].Value}, CritRating={statMatch.Groups[3].Value}, HasteRating={statMatch.Groups[4].Value}, MasteryRating={statMatch.Groups[5].Value}, Versatility={statMatch.Groups[6].Value} )";
                                }
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(pawnString))
                        {
                            _clipboardService.SetClipboardText(pawnString);
                        }

                        sfxComplete.Play();
                        StatusProgressBar.GetCurrentParent().Invoke(new MethodInvoker(delegate
                        {
                            StatusProgressBar.Value = 0;
                            StatusProgressBar.Visible = false;
                        }));
                        StatusLabel.GetCurrentParent().Invoke(new MethodInvoker(delegate
                        {
                            if (stopSimulating)
                            {
                                StatusLabel.Text = "Ready to start!";
                                stopSimulating = false;
                            }
                            else
                            {
                                StatusLabel.Text = "Done, Waiting for Simulation text...";
                            }
                        }));
                    }
                    catch (Exception e)
                    {
                        if (Properties.Settings.Default.showErrorMessages)
                            MessageBox.Show($"{e}-{e.Message}");
                    }
                    finally
                    {
                        process.Dispose();
                    }
                }
                        
             }
        }
        #endregion

        #region Resize
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (Properties.Settings.Default.minimizeToTray)
                {
                    TaskBarIcon.Visible = true;
                    ShowInTaskbar = false;
                    if (!Properties.Settings.Default.disableRunningWarning)
                        TaskBarIcon.ShowBalloonTip(500);
                }

            }
            else
            {
                TaskBarIcon.Visible = Properties.Settings.Default.alwaysShowTrayIcon;
            }
        }
        #endregion

        #region ClickFunctions
        private void StartButton_Click(object sender, EventArgs e)
        {
            Start();

        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }
        private void ExePathBrowseButon_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                exePathBox.Text = ofd.FileName;
            }
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings();
        }

        private void StartMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void StopMenuItem_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            Settings();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void ShowWindowMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            TaskBarIcon.Visible = Properties.Settings.Default.alwaysShowTrayIcon;
        }

        
        private void HelpWindowButton_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            Help();
        }
        #endregion

        #region PropertiesSaving
        private void ExePathBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.exePath = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }
        private void IterationsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iterations = ((ComboBox)sender).SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void LengthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.length = ((ComboBox)sender).SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void VaryLengthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.varyLength = ((ComboBox)sender).SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void ThreadsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.threads = ((ComboBox)sender).SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void ProcessPriorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.processPriority = ((ComboBox)sender).SelectedIndex;
            Properties.Settings.Default.Save();
        }
        #endregion

    }
}
