using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace CTimer
{
    public partial class StarterForm : Form
    {
        int action = 0, lastAct = -1;
        float clickTotal = 0f, clickAdd = 2f;
        List<string> files = new List<string>();

        TimerForm timerForm;

        public StarterForm()
        {
            InitializeComponent();
            Select();
        }

        private string FormatTime(int value)
        {
            if (value > 9) return value.ToString();
            else return '0' + value.ToString();
        }
        
        private void DayInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)13) StarterColon2.Focus();
        }
        private void DayInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lastAct != 0) { lastAct = 0; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterDayInput.Text); } catch { number = 0; }
                    StarterDayInput.Text = FormatTime(number + 1);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lastAct != 1) { lastAct = 1; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterDayInput.Text); } catch { number = 0; }
                    if (number > 0) StarterDayInput.Text = FormatTime(number - 1);
                }
            }
        }
        private void DayInput_KeyUp(object sender, KeyEventArgs e)
        {
            lastAct = -1;
        }
        private void HourInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)13) StarterColon2.Focus();
        }
        private void HourInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lastAct != 0) { lastAct = 0; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterHourInput.Text); } catch { number = 0; }
                    if (number < 23) StarterHourInput.Text = FormatTime(number + 1);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lastAct != 1) { lastAct = 1; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterHourInput.Text); } catch { number = 0; }
                    if (number > 0) StarterHourInput.Text = FormatTime(number - 1);
                }
            }
        }
        private void HourInput_KeyUp(object sender, KeyEventArgs e)
        {
            lastAct = -1;
        }
        private void MinInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)13) StarterColon2.Focus();
        }
        private void MinInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lastAct != 0) { lastAct = 0; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterMinInput.Text); } catch { number = 0; }
                    if (number < 59) StarterMinInput.Text = FormatTime(number + 1);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lastAct != 1) { lastAct = 1; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterMinInput.Text); } catch { number = 0; }
                    if (number > 0) StarterMinInput.Text = FormatTime(number - 1);
                }
            }
        }
        private void MinInput_KeyUp(object sender, KeyEventArgs e)
        {
            lastAct = -1;
        }
        private void SecInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)13) StarterColon2.Focus();
        }
        private void SecInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (lastAct != 0) { lastAct = 0; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterSecInput.Text); } catch { number = 0; }
                    if (number < 59) StarterSecInput.Text = FormatTime(number + 1);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lastAct != 1) { lastAct = 1; clickAdd = 0.1f; clickTotal = 1f; }
                if (clickAdd < 1f) clickAdd += 0.002f;
                clickTotal += clickAdd;
                if (clickTotal >= 1f)
                {
                    clickTotal--;
                    int number;
                    try { number = int.Parse(StarterSecInput.Text); } catch { number = 0; }
                    if (number > 0) StarterSecInput.Text = FormatTime(number - 1);
                }
            }
        }
        private void SecInput_KeyUp(object sender, KeyEventArgs e)
        {
            lastAct = -1;
        }

        private void DayInput_Enter(object sender, EventArgs e)
        {
            StarterDayInput.Text = "";
        }
        private void DayInput_Leave(object sender, EventArgs e)
        {
            if (StarterDayInput.Text != "") StarterDayInput.Text = FormatTime(int.Parse(StarterDayInput.Text));
            else StarterDayInput.Text = "00";
            lastAct = -1;
            Clock_Tick(null, null);
        }
        private void HourInput_Enter(object sender, EventArgs e)
        {
            StarterHourInput.Text = "";
        }
        private void HourInput_Leave(object sender, EventArgs e)
        {
            int time;
            if (StarterHourInput.Text != "")
            {
                time = int.Parse(StarterHourInput.Text);
                if (time > 23) time = 23;
            }
            else time = 0;
            StarterHourInput.Text = FormatTime(time);
            StarterDatePicker.Value = StarterDatePicker.Value.AddHours(time - StarterDatePicker.Value.Hour);
            lastAct = -1;
            Clock_Tick(null, null);
        }
        private void MinInput_Enter(object sender, EventArgs e)
        {
            StarterMinInput.Text = "";
        }
        private void MinInput_Leave(object sender, EventArgs e)
        {
            int time;
            if (StarterMinInput.Text != "")
            {
                time = int.Parse(StarterMinInput.Text);
                if (time > 59) time = 59;
            }
            else time = 0;
            StarterMinInput.Text = FormatTime(time);
            StarterDatePicker.Value = StarterDatePicker.Value.AddMinutes(time - StarterDatePicker.Value.Minute);
            lastAct = -1;
            Clock_Tick(null, null);
        }
        private void SecInput_Enter(object sender, EventArgs e)
        {
            StarterSecInput.Text = "";
        }
        private void SecInput_Leave(object sender, EventArgs e)
        {
            int time;
            if (StarterSecInput.Text != "")
            {
                time = int.Parse(StarterSecInput.Text);
                if (time > 59) time = 59;
            }
            else time = 0;
            StarterSecInput.Text = FormatTime(time);
            StarterDatePicker.Value = StarterDatePicker.Value.AddSeconds(time - StarterDatePicker.Value.Second);
            lastAct = -1;
            Clock_Tick(null, null);
        }
        
        private void DateInput_Click(object sender, EventArgs e)
        {
            StarterDatePicker.Select();
            SendKeys.Send("%{DOWN}");
        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (StarterDatePicker.Value.CompareTo(DateTime.Now) == -1) StarterDatePicker.Value = DateTime.Now;
            StarterDateInput.Text = StarterDatePicker.Value.ToShortDateString();
            Clock_Tick(null, null);
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            if (StarterDatePicker.Visible)
                if (StarterDatePicker.Value.CompareTo(DateTime.Now) == -1)
                {
                    StarterDatePicker.Value = DateTime.Now;
                    StarterDateInput.Text = StarterDatePicker.Value.ToShortDateString();
                    if (!StarterHourInput.Focused) StarterHourInput.Text = FormatTime(StarterDatePicker.Value.Hour);
                    if (!StarterMinInput.Focused) StarterMinInput.Text = FormatTime(StarterDatePicker.Value.Minute);
                    if (!StarterSecInput.Focused) StarterSecInput.Text = FormatTime(StarterDatePicker.Value.Second);
                    StarterTimeLeft.Visible = false;
                } else {
                    TimeSpan dist = StarterDatePicker.Value.Subtract(DateTime.Now);
                    StarterTimeLeft.Text = "";
                    if ((int)dist.TotalDays > 0) StarterTimeLeft.Text += FormatTime((int)dist.TotalDays) + ":" + FormatTime(dist.Hours) + ":";
                    else if (dist.Hours > 0) StarterTimeLeft.Text += FormatTime(dist.Hours) + ":";
                    StarterTimeLeft.Text += FormatTime(dist.Minutes) + ":" + FormatTime(dist.Seconds);
                    StarterTimeLeft.Visible = true;
                }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            StarterColon2.Focus();
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            if (StarterSwitch.Text == "Switch to date")
            {
                StarterSwitch.Text = "Switch to time";
                StarterDatePicker.Value = DateTime.Now;
                StarterDateInput.Text = StarterDatePicker.Value.ToShortDateString();
                StarterHourInput.Text = FormatTime(StarterDatePicker.Value.Hour);
                StarterMinInput.Text = FormatTime(StarterDatePicker.Value.Minute);
                StarterSecInput.Text = FormatTime(StarterDatePicker.Value.Second);
                StarterClock.Enabled = true;
                StarterDatePicker.Visible = true;
                StarterDateInput.Enabled = true;
                StarterDateInput.Visible = true;
                StarterDayInput.Enabled = false;
                StarterDayInput.Visible = false;
                StarterColon0.Visible = false;
                StarterHourInput.Location = new Point(StarterHourInput.Location.X + 30, StarterHourInput.Location.Y);
                StarterColon1.Location = new Point(StarterColon1.Location.X + 30, StarterColon1.Location.Y);
                StarterMinInput.Location = new Point(StarterMinInput.Location.X + 30, StarterMinInput.Location.Y);
                StarterColon2.Location = new Point(StarterColon2.Location.X + 30, StarterColon2.Location.Y);
                StarterSecInput.Location = new Point(StarterSecInput.Location.X + 30, StarterSecInput.Location.Y);
            }
            else
            {
                StarterSwitch.Text = "Switch to date";
                StarterDayInput.Text = "00";
                StarterHourInput.Text = "00";
                StarterMinInput.Text = "00";
                StarterSecInput.Text = "00";
                StarterClock.Enabled = false;
                StarterDatePicker.Visible = false;
                StarterDateInput.Enabled = false;
                StarterDateInput.Visible = false;
                StarterDayInput.Enabled = true;
                StarterDayInput.Visible = true;
                StarterColon0.Visible = true;
                StarterHourInput.Location = new Point(StarterHourInput.Location.X - 30, StarterHourInput.Location.Y);
                StarterColon1.Location = new Point(StarterColon1.Location.X - 30, StarterColon1.Location.Y);
                StarterMinInput.Location = new Point(StarterMinInput.Location.X - 30, StarterMinInput.Location.Y);
                StarterColon2.Location = new Point(StarterColon2.Location.X - 30, StarterColon2.Location.Y);
                StarterSecInput.Location = new Point(StarterSecInput.Location.X - 30, StarterSecInput.Location.Y);
                StarterTimeLeft.Visible = false;
            }
            StarterColon2.Focus();
        }
        private void ChooseAction_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            StarterActions.Show(ptLowerLeft);
            StarterColon2.Focus();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (StarterSwitch.Text == "Switch to date")
            {
                if (StarterDayInput.Text == "00" && StarterHourInput.Text == "00" && StarterMinInput.Text == "00" && StarterSecInput.Text == "00") StarterSecInput.Text = "10";
                timerForm = new TimerForm(action, files.ToArray(), DateTime.Now.Add(new TimeSpan(int.Parse(StarterDayInput.Text), int.Parse(StarterHourInput.Text), int.Parse(StarterMinInput.Text), int.Parse(StarterSecInput.Text))).AddMilliseconds(300));
            }
            else
            {
                if (!StarterTimeLeft.Visible) StarterDatePicker.Value = StarterDatePicker.Value.AddSeconds(10);
                timerForm = new TimerForm(action, files.ToArray(), StarterDatePicker.Value.AddMilliseconds(300));
            }
            timerForm.Show();
            StarterDayInput.Dispose();
            StarterColon0.Dispose();
            StarterHourInput.Dispose();
            StarterColon1.Dispose();
            StarterMinInput.Dispose();
            StarterColon2.Dispose();
            StarterSecInput.Dispose();
            StarterSwitch.Dispose();
            StarterChooseAction.Dispose();
            StarterStart.Dispose();
            StarterDateInput.Dispose();
            StarterDatePicker.Dispose();
            StarterClock.Dispose();
            StarterTimeLeft.Dispose();
            StarterActions.Dispose();
            ActionShutdown.Dispose();
            ActionRestart.Dispose();
            ActionLogout.Dispose();
            ActionLock.Dispose();
            ActionRunFile.Dispose();
            StarterChooseFile.Dispose();
            ActionHibernate.Dispose();
            ActionSleep.Dispose();
            files = null;
            Hide();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            action = 0;
            StarterStart.Enabled = true;
            ActionShutdown.Enabled = false;
            ActionRestart.Enabled = true;
            ActionLogout.Enabled = true;
            ActionLock.Enabled = true;
            ActionSleep.Enabled = true;
            ActionHibernate.Enabled = true;
            ActionRunFile.ForeColor = Color.Black;
            ActionRunFile.Text = "Run file";
            files.Clear();
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            action = 1;
            StarterStart.Enabled = true;
            ActionShutdown.Enabled = true;
            ActionRestart.Enabled = false;
            ActionLogout.Enabled = true;
            ActionLock.Enabled = true;
            ActionSleep.Enabled = true;
            ActionHibernate.Enabled = true;
            ActionRunFile.ForeColor = Color.Black;
            ActionRunFile.Text = "Run file";
            files.Clear();
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            action = 2;
            StarterStart.Enabled = true;
            ActionShutdown.Enabled = true;
            ActionRestart.Enabled = true;
            ActionLogout.Enabled = false;
            ActionLock.Enabled = true;
            ActionSleep.Enabled = true;
            ActionHibernate.Enabled = true;
            ActionRunFile.ForeColor = Color.Black;
            ActionRunFile.Text = "Run file";
            files.Clear();
        }
        private void Lock_Click(object sender, EventArgs e)
        {
            action = 3;
            StarterStart.Enabled = true;
            ActionShutdown.Enabled = true;
            ActionRestart.Enabled = true;
            ActionLogout.Enabled = true;
            ActionLock.Enabled = false;
            ActionSleep.Enabled = true;
            ActionHibernate.Enabled = true;
            ActionRunFile.ForeColor = Color.Black;
            ActionRunFile.Text = "Run file";
            files.Clear();
        }
        private void ActionSleep_Click(object sender, EventArgs e)
        {
            action = 4;
            StarterStart.Enabled = true;
            ActionShutdown.Enabled = true;
            ActionRestart.Enabled = true;
            ActionLogout.Enabled = true;
            ActionLock.Enabled = true;
            ActionSleep.Enabled = false;
            ActionHibernate.Enabled = true;
            ActionRunFile.ForeColor = Color.Black;
            ActionRunFile.Text = "Run file";
            files.Clear();
        }
        private void ActionHibernate_Click(object sender, EventArgs e)
        {
            action = 5;
            StarterStart.Enabled = true;
            ActionShutdown.Enabled = true;
            ActionRestart.Enabled = true;
            ActionLogout.Enabled = true;
            ActionLock.Enabled = true;
            ActionSleep.Enabled = true;
            ActionHibernate.Enabled = false;
            ActionRunFile.ForeColor = Color.Black;
            ActionRunFile.Text = "Run file";
            files.Clear();
        }
        private void RunFile_Click(object sender, EventArgs e)
        {
            action = 6;
            if (files.Count == 0) StarterStart.Enabled = false;
            ActionShutdown.Enabled = true;
            ActionRestart.Enabled = true;
            ActionLogout.Enabled = true;
            ActionLock.Enabled = true;
            ActionSleep.Enabled = true;
            ActionHibernate.Enabled = true;
            ActionRunFile.ForeColor = Color.Gray;
            StarterChooseFile.ShowDialog();
        }
        
        private void ChooseFile_FileOk(object sender, CancelEventArgs e)
        {
            StarterStart.Enabled = true;
            foreach (string file in StarterChooseFile.FileNames) if (!files.Contains(file)) files.Add(file);
            ActionRunFile.Text = "Run " + files.Count + " file";
            if (files.Count > 1) ActionRunFile.Text += "s";
        }
    }
}