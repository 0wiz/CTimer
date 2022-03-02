namespace CTimer
{
    partial class StarterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarterForm));
            this.StarterDayInput = new System.Windows.Forms.TextBox();
            this.StarterColon0 = new System.Windows.Forms.Label();
            this.StarterHourInput = new System.Windows.Forms.TextBox();
            this.StarterColon1 = new System.Windows.Forms.Label();
            this.StarterMinInput = new System.Windows.Forms.TextBox();
            this.StarterColon2 = new System.Windows.Forms.Label();
            this.StarterSecInput = new System.Windows.Forms.TextBox();
            this.StarterSwitch = new System.Windows.Forms.Button();
            this.StarterChooseAction = new System.Windows.Forms.Button();
            this.StarterStart = new System.Windows.Forms.Button();
            this.StarterDateInput = new System.Windows.Forms.Label();
            this.StarterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StarterClock = new System.Windows.Forms.Timer(this.components);
            this.StarterTimeLeft = new System.Windows.Forms.Label();
            this.StarterActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ActionShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionLock = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionHibernate = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionRunFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StarterChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.StarterActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // StarterDayInput
            // 
            this.StarterDayInput.AcceptsReturn = true;
            this.StarterDayInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterDayInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StarterDayInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterDayInput.Location = new System.Drawing.Point(60, -4);
            this.StarterDayInput.MaxLength = 4;
            this.StarterDayInput.Multiline = true;
            this.StarterDayInput.Name = "StarterDayInput";
            this.StarterDayInput.ShortcutsEnabled = false;
            this.StarterDayInput.Size = new System.Drawing.Size(29, 20);
            this.StarterDayInput.TabIndex = 1;
            this.StarterDayInput.Text = "00";
            this.StarterDayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StarterDayInput.Enter += new System.EventHandler(this.DayInput_Enter);
            this.StarterDayInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DayInput_KeyDown);
            this.StarterDayInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DayInput_KeyPress);
            this.StarterDayInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DayInput_KeyUp);
            this.StarterDayInput.Leave += new System.EventHandler(this.DayInput_Leave);
            // 
            // StarterColon0
            // 
            this.StarterColon0.AutoSize = true;
            this.StarterColon0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterColon0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterColon0.Location = new System.Drawing.Point(91, -6);
            this.StarterColon0.Name = "StarterColon0";
            this.StarterColon0.Size = new System.Drawing.Size(13, 20);
            this.StarterColon0.TabIndex = 2;
            this.StarterColon0.Text = ":";
            // 
            // StarterHourInput
            // 
            this.StarterHourInput.AcceptsReturn = true;
            this.StarterHourInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterHourInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StarterHourInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterHourInput.Location = new System.Drawing.Point(94, -4);
            this.StarterHourInput.MaxLength = 2;
            this.StarterHourInput.Multiline = true;
            this.StarterHourInput.Name = "StarterHourInput";
            this.StarterHourInput.ShortcutsEnabled = false;
            this.StarterHourInput.Size = new System.Drawing.Size(29, 20);
            this.StarterHourInput.TabIndex = 3;
            this.StarterHourInput.Text = "00";
            this.StarterHourInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StarterHourInput.Enter += new System.EventHandler(this.HourInput_Enter);
            this.StarterHourInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HourInput_KeyDown);
            this.StarterHourInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourInput_KeyPress);
            this.StarterHourInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HourInput_KeyUp);
            this.StarterHourInput.Leave += new System.EventHandler(this.HourInput_Leave);
            // 
            // StarterColon1
            // 
            this.StarterColon1.AutoSize = true;
            this.StarterColon1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterColon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterColon1.Location = new System.Drawing.Point(125, -6);
            this.StarterColon1.Name = "StarterColon1";
            this.StarterColon1.Size = new System.Drawing.Size(13, 20);
            this.StarterColon1.TabIndex = 4;
            this.StarterColon1.Text = ":";
            // 
            // StarterMinInput
            // 
            this.StarterMinInput.AcceptsReturn = true;
            this.StarterMinInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterMinInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StarterMinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterMinInput.Location = new System.Drawing.Point(134, -4);
            this.StarterMinInput.MaxLength = 2;
            this.StarterMinInput.Multiline = true;
            this.StarterMinInput.Name = "StarterMinInput";
            this.StarterMinInput.ShortcutsEnabled = false;
            this.StarterMinInput.Size = new System.Drawing.Size(23, 20);
            this.StarterMinInput.TabIndex = 5;
            this.StarterMinInput.Text = "00";
            this.StarterMinInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StarterMinInput.Enter += new System.EventHandler(this.MinInput_Enter);
            this.StarterMinInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MinInput_KeyDown);
            this.StarterMinInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinInput_KeyPress);
            this.StarterMinInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MinInput_KeyUp);
            this.StarterMinInput.Leave += new System.EventHandler(this.MinInput_Leave);
            // 
            // StarterColon2
            // 
            this.StarterColon2.AutoSize = true;
            this.StarterColon2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterColon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterColon2.Location = new System.Drawing.Point(159, -6);
            this.StarterColon2.Name = "StarterColon2";
            this.StarterColon2.Size = new System.Drawing.Size(13, 20);
            this.StarterColon2.TabIndex = 6;
            this.StarterColon2.Text = ":";
            // 
            // StarterSecInput
            // 
            this.StarterSecInput.AcceptsReturn = true;
            this.StarterSecInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterSecInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StarterSecInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterSecInput.Location = new System.Drawing.Point(168, -4);
            this.StarterSecInput.MaxLength = 2;
            this.StarterSecInput.Multiline = true;
            this.StarterSecInput.Name = "StarterSecInput";
            this.StarterSecInput.ShortcutsEnabled = false;
            this.StarterSecInput.Size = new System.Drawing.Size(23, 20);
            this.StarterSecInput.TabIndex = 7;
            this.StarterSecInput.Text = "00";
            this.StarterSecInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StarterSecInput.Enter += new System.EventHandler(this.SecInput_Enter);
            this.StarterSecInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecInput_KeyDown);
            this.StarterSecInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecInput_KeyPress);
            this.StarterSecInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SecInput_KeyUp);
            this.StarterSecInput.Leave += new System.EventHandler(this.SecInput_Leave);
            // 
            // StarterSwitch
            // 
            this.StarterSwitch.BackColor = System.Drawing.SystemColors.Control;
            this.StarterSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarterSwitch.Location = new System.Drawing.Point(-1, 31);
            this.StarterSwitch.Name = "StarterSwitch";
            this.StarterSwitch.Size = new System.Drawing.Size(90, 32);
            this.StarterSwitch.TabIndex = 8;
            this.StarterSwitch.Text = "Switch to date";
            this.StarterSwitch.UseVisualStyleBackColor = false;
            this.StarterSwitch.Click += new System.EventHandler(this.Switch_Click);
            // 
            // StarterChooseAction
            // 
            this.StarterChooseAction.BackColor = System.Drawing.SystemColors.Control;
            this.StarterChooseAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarterChooseAction.Location = new System.Drawing.Point(88, 31);
            this.StarterChooseAction.Name = "StarterChooseAction";
            this.StarterChooseAction.Size = new System.Drawing.Size(90, 32);
            this.StarterChooseAction.TabIndex = 9;
            this.StarterChooseAction.Text = "Choose action";
            this.StarterChooseAction.UseVisualStyleBackColor = false;
            this.StarterChooseAction.Click += new System.EventHandler(this.ChooseAction_Click);
            // 
            // StarterStart
            // 
            this.StarterStart.BackColor = System.Drawing.SystemColors.Control;
            this.StarterStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StarterStart.Location = new System.Drawing.Point(177, 31);
            this.StarterStart.Name = "StarterStart";
            this.StarterStart.Size = new System.Drawing.Size(90, 32);
            this.StarterStart.TabIndex = 10;
            this.StarterStart.Text = "Start";
            this.StarterStart.UseVisualStyleBackColor = false;
            this.StarterStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // StarterDateInput
            // 
            this.StarterDateInput.AutoSize = true;
            this.StarterDateInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StarterDateInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StarterDateInput.Enabled = false;
            this.StarterDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarterDateInput.Location = new System.Drawing.Point(28, -4);
            this.StarterDateInput.Name = "StarterDateInput";
            this.StarterDateInput.Size = new System.Drawing.Size(91, 20);
            this.StarterDateInput.TabIndex = 11;
            this.StarterDateInput.Text = "0000-00-00";
            this.StarterDateInput.Visible = false;
            this.StarterDateInput.Click += new System.EventHandler(this.DateInput_Click);
            // 
            // StarterDatePicker
            // 
            this.StarterDatePicker.Location = new System.Drawing.Point(28, -4);
            this.StarterDatePicker.Name = "StarterDatePicker";
            this.StarterDatePicker.Size = new System.Drawing.Size(10, 20);
            this.StarterDatePicker.TabIndex = 12;
            this.StarterDatePicker.Visible = false;
            this.StarterDatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // StarterClock
            // 
            this.StarterClock.Interval = 1000;
            this.StarterClock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // StarterTimeLeft
            // 
            this.StarterTimeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StarterTimeLeft.Location = new System.Drawing.Point(101, 14);
            this.StarterTimeLeft.Name = "StarterTimeLeft";
            this.StarterTimeLeft.Size = new System.Drawing.Size(64, 13);
            this.StarterTimeLeft.TabIndex = 13;
            this.StarterTimeLeft.Text = "00:00:00:00";
            this.StarterTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StarterTimeLeft.Visible = false;
            // 
            // StarterActions
            // 
            this.StarterActions.AutoSize = false;
            this.StarterActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionShutdown,
            this.ActionRestart,
            this.ActionLogout,
            this.ActionLock,
            this.ActionSleep,
            this.ActionHibernate,
            this.ActionRunFile});
            this.StarterActions.Name = "ActionOptions";
            this.StarterActions.ShowImageMargin = false;
            this.StarterActions.Size = new System.Drawing.Size(90, 158);
            // 
            // ActionShutdown
            // 
            this.ActionShutdown.Enabled = false;
            this.ActionShutdown.Name = "ActionShutdown";
            this.ActionShutdown.Size = new System.Drawing.Size(103, 22);
            this.ActionShutdown.Text = "Shutdown";
            this.ActionShutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // ActionRestart
            // 
            this.ActionRestart.Name = "ActionRestart";
            this.ActionRestart.Size = new System.Drawing.Size(103, 22);
            this.ActionRestart.Text = "Restart";
            this.ActionRestart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // ActionLogout
            // 
            this.ActionLogout.Name = "ActionLogout";
            this.ActionLogout.Size = new System.Drawing.Size(103, 22);
            this.ActionLogout.Text = "Logout";
            this.ActionLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ActionLock
            // 
            this.ActionLock.Name = "ActionLock";
            this.ActionLock.Size = new System.Drawing.Size(103, 22);
            this.ActionLock.Text = "Lock";
            this.ActionLock.Click += new System.EventHandler(this.Lock_Click);
            // 
            // ActionSleep
            // 
            this.ActionSleep.Name = "ActionSleep";
            this.ActionSleep.Size = new System.Drawing.Size(103, 22);
            this.ActionSleep.Text = "Sleep";
            this.ActionSleep.Click += new System.EventHandler(this.ActionSleep_Click);
            // 
            // ActionHibernate
            // 
            this.ActionHibernate.Name = "ActionHibernate";
            this.ActionHibernate.Size = new System.Drawing.Size(103, 22);
            this.ActionHibernate.Text = "Hibernate";
            this.ActionHibernate.Click += new System.EventHandler(this.ActionHibernate_Click);
            // 
            // ActionRunFile
            // 
            this.ActionRunFile.Name = "ActionRunFile";
            this.ActionRunFile.Size = new System.Drawing.Size(127, 22);
            this.ActionRunFile.Text = "Run file";
            this.ActionRunFile.Click += new System.EventHandler(this.RunFile_Click);
            // 
            // StarterChooseFile
            // 
            this.StarterChooseFile.Multiselect = true;
            this.StarterChooseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ChooseFile_FileOk);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(266, 62);
            this.Controls.Add(this.StarterDayInput);
            this.Controls.Add(this.StarterColon0);
            this.Controls.Add(this.StarterHourInput);
            this.Controls.Add(this.StarterColon1);
            this.Controls.Add(this.StarterMinInput);
            this.Controls.Add(this.StarterColon2);
            this.Controls.Add(this.StarterSecInput);
            this.Controls.Add(this.StarterSwitch);
            this.Controls.Add(this.StarterChooseAction);
            this.Controls.Add(this.StarterStart);
            this.Controls.Add(this.StarterDateInput);
            this.Controls.Add(this.StarterDatePicker);
            this.Controls.Add(this.StarterTimeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StarterForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTimer 2.0";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.StarterActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StarterDayInput;
        private System.Windows.Forms.Label StarterColon0;
        private System.Windows.Forms.TextBox StarterHourInput;
        private System.Windows.Forms.Label StarterColon1;
        private System.Windows.Forms.TextBox StarterMinInput;
        private System.Windows.Forms.Label StarterColon2;
        private System.Windows.Forms.TextBox StarterSecInput;
        private System.Windows.Forms.Button StarterSwitch;
        private System.Windows.Forms.Button StarterChooseAction;
        private System.Windows.Forms.Button StarterStart;
        private System.Windows.Forms.Label StarterDateInput;
        private System.Windows.Forms.DateTimePicker StarterDatePicker;
        private System.Windows.Forms.Timer StarterClock;
        private System.Windows.Forms.Label StarterTimeLeft;
        private System.Windows.Forms.ContextMenuStrip StarterActions;
        private System.Windows.Forms.ToolStripMenuItem ActionShutdown;
        private System.Windows.Forms.ToolStripMenuItem ActionRestart;
        private System.Windows.Forms.ToolStripMenuItem ActionLogout;
        private System.Windows.Forms.ToolStripMenuItem ActionLock;
        private System.Windows.Forms.ToolStripMenuItem ActionRunFile;
        private System.Windows.Forms.OpenFileDialog StarterChooseFile;
        private System.Windows.Forms.ToolStripMenuItem ActionHibernate;
        private System.Windows.Forms.ToolStripMenuItem ActionSleep;
    }
}

