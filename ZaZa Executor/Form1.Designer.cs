using System.Drawing;
using System.Windows.Forms;

namespace ZaZa_Executor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.chromiumWebBrowser2 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Load2 = new Guna.UI2.WinForms.Guna2Button();
            this.Kill = new Guna.UI2.WinForms.Guna2Button();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.Clear = new Guna.UI2.WinForms.Guna2Button();
            this.Execute = new Guna.UI2.WinForms.Guna2Button();
            this.Status = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.SettingsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTopMost = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoRoundedCorners = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel2.Controls.Add(this.Minimize);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.Exit);
            this.guna2Panel2.Location = new System.Drawing.Point(-9, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1016, 47);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(957, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "v0.4";
            // 
            // Minimize
            // 
            this.Minimize.BorderRadius = 10;
            this.Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Minimize.Image = global::ZaZa_Executor.Properties.Resources.minus;
            this.Minimize.Location = new System.Drawing.Point(933, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 10;
            this.Minimize.Click += new System.EventHandler(this.Minimize2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZaZa Executor";
            // 
            // Exit
            // 
            this.Exit.BorderRadius = 10;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Exit.Image = global::ZaZa_Executor.Properties.Resources.x_;
            this.Exit.Location = new System.Drawing.Point(969, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.TabIndex = 9;
            this.Exit.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel2;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.label1;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(12, 53);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(979, 308);
            this.chromiumWebBrowser1.TabIndex = 8;
            // 
            // chromiumWebBrowser2
            // 
            this.chromiumWebBrowser2.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser2.Location = new System.Drawing.Point(12, 418);
            this.chromiumWebBrowser2.Name = "chromiumWebBrowser2";
            this.chromiumWebBrowser2.Size = new System.Drawing.Size(979, 186);
            this.chromiumWebBrowser2.TabIndex = 10;
            // 
            // Load2
            // 
            this.Load2.BorderRadius = 10;
            this.Load2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Load2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Load2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Load2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Load2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Load2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Load2.Image = global::ZaZa_Executor.Properties.Resources.folder_open;
            this.Load2.Location = new System.Drawing.Point(357, 367);
            this.Load2.Name = "Load2";
            this.Load2.Size = new System.Drawing.Size(109, 45);
            this.Load2.TabIndex = 9;
            this.Load2.Text = "Load";
            this.Load2.Click += new System.EventHandler(this.Load_Click);
            // 
            // Kill
            // 
            this.Kill.BorderRadius = 10;
            this.Kill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Kill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Kill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Kill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Kill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Kill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Kill.Image = global::ZaZa_Executor.Properties.Resources.bug_off;
            this.Kill.Location = new System.Drawing.Point(767, 367);
            this.Kill.Name = "Kill";
            this.Kill.Size = new System.Drawing.Size(109, 45);
            this.Kill.TabIndex = 6;
            this.Kill.Text = "Kill";
            this.Kill.Click += new System.EventHandler(this.Kill_Click);
            // 
            // Inject
            // 
            this.Inject.BorderRadius = 10;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Inject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Inject.Image = global::ZaZa_Executor.Properties.Resources.unplug;
            this.Inject.Location = new System.Drawing.Point(882, 367);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(109, 45);
            this.Inject.TabIndex = 5;
            this.Inject.Text = "Inject";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // Save
            // 
            this.Save.BorderRadius = 10;
            this.Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Save.Image = global::ZaZa_Executor.Properties.Resources.save;
            this.Save.Location = new System.Drawing.Point(242, 367);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 45);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Log_Click);
            // 
            // Clear
            // 
            this.Clear.BorderRadius = 10;
            this.Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Clear.Image = global::ZaZa_Executor.Properties.Resources.eraser;
            this.Clear.Location = new System.Drawing.Point(127, 367);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(109, 45);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Execute
            // 
            this.Execute.BorderRadius = 10;
            this.Execute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Execute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Execute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Execute.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Execute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Execute.Image = global::ZaZa_Executor.Properties.Resources.play;
            this.Execute.Location = new System.Drawing.Point(12, 367);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(109, 45);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute";
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Status
            // 
            this.Status.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Status.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Status.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Status.Location = new System.Drawing.Point(12, 628);
            this.Status.Name = "Status";
            this.Status.PressedColor = this.Status.FillColor;
            this.Status.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Status.Size = new System.Drawing.Size(10, 10);
            this.Status.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(28, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Not Injected";
            // 
            // statusTimer
            // 
            this.statusTimer.Enabled = true;
            this.statusTimer.Interval = 10;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingsPanel.BorderRadius = 50;
            this.SettingsPanel.BorderThickness = 10;
            this.SettingsPanel.Controls.Add(this.cbTopMost);
            this.SettingsPanel.Location = new System.Drawing.Point(350, 175);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(300, 300);
            this.SettingsPanel.TabIndex = 13;
            this.SettingsPanel.Visible = false;
            // 
            // cbTopMost
            // 
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTopMost.CheckedState.BorderRadius = 0;
            this.cbTopMost.CheckedState.BorderThickness = 0;
            this.cbTopMost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTopMost.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTopMost.Location = new System.Drawing.Point(12, 12);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.Size = new System.Drawing.Size(115, 23);
            this.cbTopMost.TabIndex = 0;
            this.cbTopMost.Text = "Always on top";
            this.cbTopMost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbTopMost.UncheckedState.BorderRadius = 0;
            this.cbTopMost.UncheckedState.BorderThickness = 0;
            this.cbTopMost.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.cbTopMost_CheckedChanged_1);
            // 
            // Settings
            // 
            this.Settings.BorderRadius = 10;
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Settings.Image = global::ZaZa_Executor.Properties.Resources.settings;
            this.Settings.Location = new System.Drawing.Point(652, 367);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(109, 45);
            this.Settings.TabIndex = 14;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragMode = Guna.UI2.WinForms.Enums.DragMode.Control;
            this.guna2DragControl1.TargetControl = this.SettingsPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.chromiumWebBrowser2);
            this.Controls.Add(this.Load2);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.Kill);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.guna2Panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZaZa Executor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Button Execute;
        private Guna.UI2.WinForms.Guna2Button Clear;
        private Guna.UI2.WinForms.Guna2Button Save;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private Guna.UI2.WinForms.Guna2Button Kill;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private Guna.UI2.WinForms.Guna2Button Load2;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton Status;
        private Label label3;
        private Timer statusTimer;
        private Guna.UI2.WinForms.Guna2Panel SettingsPanel;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2CheckBox cbTopMost;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

