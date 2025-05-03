using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CloudyApi;
using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.WinForms;
using VelocityApiMadeBy_bubzie;

namespace ZaZa_Executor
{
    public partial class Form1 : Form
    {
        private readonly VelAPI BubzVelAPi = new VelAPI();
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            BubzVelAPi.StartCommunication();
            statusTimer.Tick += statusTimer_Tick;
            statusTimer.Start();

            cbTopMost.Checked = this.TopMost = Properties.Settings.Default.TopMost;
        }
        private async Task<string> GetEditorContent()
        {
            await chromiumWebBrowser1.WaitForInitialLoadAsync();

            string script = "editor.getValue()";
            var result = await chromiumWebBrowser1.EvaluateScriptAsync(script);
            return result?.Result?.ToString() ?? string.Empty;
        }

        private async Task ExecuteScriptAsync()
        {
            string scriptContent = await GetEditorContent();

            if (string.IsNullOrWhiteSpace(scriptContent) || IsScriptEffectivelyEmpty(scriptContent))
            {
                LogToConsole("Script is empty or has no executable content.", LogType.Warning);
                return;
            }

            if (!IsRobloxRunning())
            {
                LogToConsole("Roblox is not running. Please start Roblox before executing the script.", LogType.ERROR);
                return;
            }

            LogToConsole("Executing script...", LogType.INFO);

            try
            {
                BubzVelAPi.Execute(scriptContent);
                LogToConsole("Script executed successfully.", LogType.Success);
            }
            catch (Exception ex)
            {
                LogToConsole($"Error during script execution: {ex.Message}", LogType.ERROR);
            }

            LogToConsole("Script execution finished.", LogType.INFO);
        }

        private async Task Attachwithapi()
        {
            try
            {
                var proc = Process.GetProcessesByName("RobloxPlayerBeta").FirstOrDefault();
                if (proc == null)
                {
                    LogToConsole("Roblox isnt Running!", LogType.ERROR);
                    return;
                }
                if (BubzVelAPi.IsAttached(proc.Id))
                {
                    LogToConsole($"Already Injected into Roblox (PID: {proc.Id})", LogType.INFO);
                    return;
                }
                await BubzVelAPi.Attach(proc.Id);
                LogToConsole($"Injected into Roblox (PID: {proc.Id})", LogType.Success);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Injection failed: {ex.Message}", "Error");
            }
        }

        private async Task CleaWhiteitor()
        {
            string script = "editor.setValue('')";
            await chromiumWebBrowser1.EvaluateScriptAsync(script);
        }

        private async Task SaveTextAsLua()
        {
            string scriptsPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Scripts");


            Directory.CreateDirectory(scriptsPath);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = scriptsPath,
                Filter = "Lua files (*.lua)|*.lua",
                DefaultExt = "lua",
                Title = "Save Lua File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = await GetEditorContent();
                File.WriteAllText(saveFileDialog.FileName, content);
            }
        }

        private async Task LoadTextFromFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Lua files (*.lua)|*.lua",
                Title = "Open Lua File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog.FileName);
                await chromiumWebBrowser1.EvaluateScriptAsync($"editor.setValue(`{content}`);");
            }
        }

        private void Startup()
        {
            chromiumWebBrowser1.Load(System.Windows.Forms.Application.StartupPath + "\\bin\\monaco-editor\\monaco.html");
            chromiumWebBrowser2.Load(System.Windows.Forms.Application.StartupPath + "\\bin\\console.html");
        }

        public enum LogType
        {
            INFO,
            ERROR,
            Warning,
            Success
        }

        public static class ConsoleLogger
        {
            public static Color GetLogColor(LogType type)
            {
                if (type == LogType.INFO)
                    return Color.White;
                if (type == LogType.ERROR)
                    return Color.Red;
                if (type == LogType.Warning)
                    return Color.Yellow;
                if (type == LogType.Success)
                    return Color.Green;

                return Color.White;
            }
        }

        private void LogToConsole(string message, LogType type)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string logMessage = $"[{timestamp}] [{type}] {message}";

            string typeString = type.ToString().ToLower();

            string script = $"logMessage('{logMessage}', '{typeString}');";
            chromiumWebBrowser2.ExecuteScriptAsync(script);
        }

        private void SetRoundedRegion()
        {
            int radius = 10;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startup();
            SetRoundedRegion();

            Api.misc.SetDiscordRpc("ZaZa Executor", "1363485258271686807", "https://github.com/Berkcan61/Logo/blob/main/ZaZa%20(1).png?raw=true", "Idling...");
        }

        private bool IsRobloxRunning()
        {
            return Process.GetProcesses().Any(p => p.ProcessName.ToLower().Contains("roblox"));
        }

        private bool IsScriptEffectivelyEmpty(string script)
        {
            var lines = script.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                string trimmed = line.Trim();
                if (!trimmed.StartsWith("--") && trimmed.Length > 0)
                {
                    return false;
                }
            }
            return true;
        }
        private async void Execute_Click(object sender, EventArgs e)
        {
            var task = await chromiumWebBrowser1.EvaluateScriptAsync("editor.getValue()");

            if (!task.Success || task.Result == null)
            {
                LogToConsole("Failed to retrieve script from editor.", LogType.ERROR);
                return;
            }

            string script = task.Result.ToString();

            if (string.IsNullOrWhiteSpace(script) || IsScriptEffectivelyEmpty(script))
            {
                LogToConsole("Script is empty or has no executable content.", LogType.Warning);
                return;
            }

            LogToConsole("Executing script...", LogType.INFO);

            try
            {
                await ExecuteScriptAsync();
                LogToConsole("Script execution finished. No errors reported.", LogType.INFO);
            }
            catch (Exception ex)
            {
                LogToConsole($"Error while executing script: {ex.Message}", LogType.ERROR);
            }
        }


        private async void Clear_Click(object sender, EventArgs e)
        {
            await CleaWhiteitor();
        }

        private async void Inject_Click(object sender, EventArgs e)
        {
            await Attachwithapi();

            UpdateStatus();
        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            var robloxProcess = Process.GetProcessesByName("RobloxPlayerBeta").FirstOrDefault();

            if (robloxProcess != null && BubzVelAPi.IsAttached(robloxProcess.Id))
            {
                Status.FillColor = Color.FromArgb(50, 200, 100);
                label3.Text = "Injected";
            }
            else
            {
                Status.FillColor = Color.FromArgb(200, 50, 50);
                label3.Text = "Not Injected";
            }
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            if (IsRobloxRunning())
            {
                Api.misc.killRoblox();
                LogToConsole("Roblox successfully killed", LogType.Success);
            }
            else
            {
                LogToConsole("Roblox is not running, nothing to kill", LogType.Warning);
            }
        }

        private async void Log_Click(object sender, EventArgs e)
        {
            await SaveTextAsLua();
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Minimize2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Load_Click(object sender, EventArgs e)
        {
            LoadTextFromFile();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = !SettingsPanel.Visible;
        }

        private void cbTopMost_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TopMost = cbTopMost.Checked;
            Properties.Settings.Default.TopMost = cbTopMost.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
