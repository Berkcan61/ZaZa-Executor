using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CloudyApi;

namespace ZaZa_Executor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoLoadEditor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CloudyApi.Api.External.RegisterExecutor("ZaZa");

            Api.misc.SetDiscordRpc("ZaZa Executor", "1363485258271686807", "https://github.com/Berkcan61/Logo/blob/main/ZaZa%20(1).png?raw=true", "Idling...");

            this.Icon = new Icon("C:\\Users\\bozku\\source\\repos\\ZaZa Executor\\ZaZa Executor\\bin\\ico\\64px.ico");
        }

        private async void AutoLoadEditor()
        {
            await Editor.EnsureCoreWebView2Async(null);

            string htmlPath = Path.Combine(Application.StartupPath, "C:\\Users\\bozku\\source\\repos\\ZaZa Executor\\ZaZa Executor\\bin\\monaco-editor\\monaco.html");

            Editor.CoreWebView2.Navigate("file:///" + htmlPath.Replace("\\", "/"));
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!CloudyApi.Api.External.IsInjected())
            {
                AppendTextToConsole("Execution failed: ZaZa is not injected.", "error");
                return;
            }

            string raw = await Editor.ExecuteScriptAsync("getCode()");
            string script = Regex.Unescape(raw.Trim('"'));

            if (string.IsNullOrWhiteSpace(script))
            {
                AppendTextToConsole("Execution failed: Editor is empty.", "warning");
                return;
            }

            try
            {
                CloudyApi.Api.External.execute(script);
                AppendTextToConsole("Execute button pressed. Script sent to Roblox.", "info");
            }
            catch (Exception ex)
            {
                AppendTextToConsole("Execution error: " + ex.Message, "error");
            }
        }

        private void ExecuteCommand(string command)
        {
            try
            {
                AppendTextToConsole("> " + command);

                if (command == "clear")
                {
                    console.Clear();
                }
                else if (command == "inject")
                {
                    AppendTextToConsole("Injection wird durchgeführt...");
                }
                else if (command == "execute")
                {
                    AppendTextToConsole("Befehl wird ausgeführt...");
                }
                else
                {
                    AppendTextToConsole("Unbekannter Befehl.");
                }

                console.Clear();
            }
            catch (Exception ex)
            {
                AppendTextToConsole("Fehler: " + ex.Message);
            }
        }

        private void AppendTextToConsole(string message, string type = "info")
        {
            if (console.InvokeRequired)
            {
                console.Invoke(new Action<string, string>(AppendTextToConsole), message, type);
                return;
            }

            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string prefix = $"[{timestamp}] ";

            Color color;

            switch (type.ToLower())
            {
                case "error":
                    color = Color.Red;
                    prefix += "[ERROR] ";
                    break;
                case "success":
                    color = Color.Green;
                    prefix += "[SUCCESS] ";
                    break;
                case "warning":
                    color = Color.Orange;
                    prefix += "[WARNING] ";
                    break;
                case "info":
                default:
                    color = Color.White;
                    prefix += "[INFO] ";
                    break;
            }

            int start = console.TextLength;
            console.AppendText(prefix + message + Environment.NewLine);
            int end = console.TextLength;

            console.Select(start, end - start);
            console.SelectionColor = color;
            console.SelectionLength = 0;
            console.SelectionStart = console.TextLength;
            console.ScrollToCaret();
        }

        private string CleanCode(string code)
        {
            return code.Replace("\r\n", "\n").Replace("\n", "\n");
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Editor.CoreWebView2 != null)
            {
                await Editor.ExecuteScriptAsync("editor.setValue('');");

                console.Clear();
                AppendTextToConsole("Console log cleared.", "info");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (CloudyApi.Api.External.IsInjected())
            {
                AppendTextToConsole("Injection: ZaZa is already injected.");
            }
            else if (IsRobloxRunning())
            {
                AppendTextToConsole("Injection started...");
                CloudyApi.Api.External.inject();
            }
            else
            {
                AppendTextToConsole("Roblox is not running.", "warning");
            }
        }

        private bool IsRobloxRunning()
        {
            return Process.GetProcesses().Any(p => p.ProcessName.ToLower().Contains("roblox"));
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void Editor_Click(object sender, EventArgs e)
        {
            await Editor.EnsureCoreWebView2Async(null);

            string htmlPath = Path.Combine(Application.StartupPath, "C:\\Users\\bozku\\source\\repos\\ZaZa Executor\\ZaZa Executor\\bin\\monaco-editor\\monaco.html");

            Editor.CoreWebView2.Navigate("file:///" + htmlPath.Replace("\\", "/"));
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (IsRobloxRunning())
            {
                Api.misc.killRoblox();
                AppendTextToConsole("Roblox successfully killed.", "success");
            }
            else
            {
                AppendTextToConsole("Roblox is not running, nothing to kill.", "warning");
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.Title = "Save Log";
                sfd.FileName = "ZaZaConsoleLog.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, console.Text);
                        AppendTextToConsole("Log file saved to: " + sfd.FileName, "success");
                    }
                    catch (Exception ex)
                    {
                        AppendTextToConsole("Failed to save log: " + ex.Message, "error");
                    }
                }
                else
                {
                    AppendTextToConsole("Log file save operation was cancelled.", "info");
                }
            }
        }
    }
}
