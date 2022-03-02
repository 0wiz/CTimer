namespace CTimer
{
    partial class TimerForm
    {
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
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.TimerDisplay = new System.Windows.Forms.Label();
            this.TimerIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TimerRestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerCloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerClock
            // 
            this.TimerClock.Interval = 1000;
            this.TimerClock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // TimerDisplay
            // 
            this.TimerDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TimerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerDisplay.Location = new System.Drawing.Point(2, -6);
            this.TimerDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.TimerDisplay.Name = "TimerDisplay";
            this.TimerDisplay.Size = new System.Drawing.Size(1308, 44);
            this.TimerDisplay.TabIndex = 0;
            this.TimerDisplay.Text = "00:00:00:00";
            this.TimerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimerDisplay.Click += new System.EventHandler(this.Display_Click);
            // 
            // TimerIcon
            // 
            this.TimerIcon.ContextMenuStrip = this.TimerMenu;
            this.TimerIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TimerIcon.Icon")));
            this.TimerIcon.Text = "CTimer 2.0";
            this.TimerIcon.Visible = true;
            this.TimerIcon.Click += new System.EventHandler(this.Icon_Click);
            // 
            // TimerMenu
            // 
            this.TimerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimerRestartMenuItem,
            this.TimerCloseMenuItem});
            this.TimerMenu.Name = "contextMenuStrip1";
            this.TimerMenu.Size = new System.Drawing.Size(167, 48);
            this.TimerMenu.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.Menu_Closing);
            this.TimerMenu.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_Opening);
            // 
            // TimerRestartMenuItem
            // 
            this.TimerRestartMenuItem.Name = "TimerRestartMenuItem";
            this.TimerRestartMenuItem.Size = new System.Drawing.Size(166, 22);
            this.TimerRestartMenuItem.Text = "Abort and Restart";
            this.TimerRestartMenuItem.Click += new System.EventHandler(this.RestartMenuItem_Click);
            // 
            // TimerCloseMenuItem
            // 
            this.TimerCloseMenuItem.Name = "TimerCloseMenuItem";
            this.TimerCloseMenuItem.Size = new System.Drawing.Size(166, 22);
            this.TimerCloseMenuItem.Text = "Abort and Quit";
            this.TimerCloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 35);
            this.ControlBox = false;
            this.Controls.Add(this.TimerDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.TimerMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerClock;
        private System.Windows.Forms.Label TimerDisplay;
        private System.Windows.Forms.NotifyIcon TimerIcon;
        private System.Windows.Forms.ContextMenuStrip TimerMenu;
        private System.Windows.Forms.ToolStripMenuItem TimerRestartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimerCloseMenuItem;
    }
}