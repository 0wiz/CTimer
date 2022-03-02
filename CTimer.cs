using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CTimer
{
    public partial class TimerForm : Form
    {
        [DllImport("user32")]
        private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        [DllImport("user32")]
        private static extern void LockWorkStation();

        bool priOne = true;
        int prevSec, action;
        string[] files;
        DateTime time;

        public TimerForm(int action, string[] files, DateTime time)
        {
            InitializeComponent();

            ShowInTaskbar = false;
            TimerClock.Start();

            this.action = action;
            this.files = files;
            this.time = time;
        }

        private string FormatTime(int value)
        {
            if (value > 9) return value.ToString();
            else return '0' + value.ToString();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            if (priOne) TopMost = true;
            if (prevSec != DateTime.Now.Second)
            {
                prevSec = DateTime.Now.Second;
                if (time.CompareTo(DateTime.Now) < 1)
                {
                    TimerClock.Stop();
                    TimerDisplay.Text = "00:00";
                    if (action == 0) Process.Start("shutdown", "/s /t 0");
                    else if (action == 1) Process.Start("shutdown", "/r /t 0");
                    else if (action == 2) { ExitWindowsEx(0, 0); Application.Exit(); }
                    else if (action == 3) { LockWorkStation(); Application.Exit(); }
                    else if (action == 4) { Application.SetSuspendState(PowerState.Suspend, true, true); Application.Exit(); }
                    else if (action == 5) { Application.SetSuspendState(PowerState.Hibernate, true, true); Application.Exit(); }
                    else
                    {
                        for (int i = 0; i < files.Length; i++) Process.Start(files[i]);
                        Application.Exit();
                    }
                }
                else
                {
                    TimeSpan dist = time.Subtract(DateTime.Now);
                    TimerDisplay.Text = "";
                    if ((int)dist.TotalDays > 0) TimerDisplay.Text += FormatTime((int)dist.TotalDays) + ":" + FormatTime(dist.Hours) + ":";
                    else if (dist.Hours > 0) TimerDisplay.Text += FormatTime(dist.Hours) + ":";
                    TimerDisplay.Text += FormatTime(dist.Minutes) + ":" + FormatTime(dist.Seconds);
                }
                Width = TimerDisplay.Text.Length * 18 + 15;
            }
        }

        private void Menu_Opening(object sender, CancelEventArgs e)
        {
            priOne = false;
            TopMost = false;
        }
        private void Menu_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            priOne = true;
        }

        private void RestartMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Close();
        }
        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            Hide();
            priOne = false;
        }
        private void Icon_Click(object sender, EventArgs e)
        {
            Show();
            priOne = true;
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            Height = 32;
            Clock_Tick(null, null);
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerIcon.Dispose();
        }
    }
}