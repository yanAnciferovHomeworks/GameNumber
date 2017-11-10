using System;

namespace WordPad
{
    partial class Form1
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
            this.Box = new System.Windows.Forms.GroupBox();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.TimerProgress = new System.Windows.Forms.Timer(this.components);
            this.ControlsParam = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SizeSpin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackTime = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.NumericUpDown();
            this.Max = new System.Windows.Forms.NumericUpDown();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ControlsParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(13, 13);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(290, 290);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(12, 332);
            this.Progress.MarqueeAnimationSpeed = 1;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(514, 41);
            this.Progress.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(314, 275);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 23);
            this.Start.TabIndex = 8;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(427, 275);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(100, 23);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // TimerProgress
            // 
            this.TimerProgress.Interval = 1000;
            this.TimerProgress.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ControlsParam
            // 
            this.ControlsParam.Controls.Add(this.label4);
            this.ControlsParam.Controls.Add(this.SizeSpin);
            this.ControlsParam.Controls.Add(this.label3);
            this.ControlsParam.Controls.Add(this.TrackTime);
            this.ControlsParam.Controls.Add(this.label2);
            this.ControlsParam.Controls.Add(this.Time);
            this.ControlsParam.Controls.Add(this.label1);
            this.ControlsParam.Controls.Add(this.Min);
            this.ControlsParam.Controls.Add(this.Max);
            this.ControlsParam.Location = new System.Drawing.Point(305, 13);
            this.ControlsParam.Name = "ControlsParam";
            this.ControlsParam.Size = new System.Drawing.Size(222, 201);
            this.ControlsParam.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "size";
            // 
            // SizeSpin
            // 
            this.SizeSpin.Location = new System.Drawing.Point(32, 137);
            this.SizeSpin.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.SizeSpin.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SizeSpin.Name = "SizeSpin";
            this.SizeSpin.Size = new System.Drawing.Size(84, 20);
            this.SizeSpin.TabIndex = 16;
            this.SizeSpin.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SizeSpin.ValueChanged += new System.EventHandler(this.SizeSpin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "time";
            // 
            // TrackTime
            // 
            this.TrackTime.LargeChange = 9;
            this.TrackTime.Location = new System.Drawing.Point(27, 11);
            this.TrackTime.Maximum = 120;
            this.TrackTime.Minimum = 10;
            this.TrackTime.Name = "TrackTime";
            this.TrackTime.Size = new System.Drawing.Size(166, 45);
            this.TrackTime.TabIndex = 11;
            this.TrackTime.TickFrequency = 5;
            this.TrackTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackTime.Value = 10;
            this.TrackTime.Scroll += new System.EventHandler(this.TrackTime_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "max";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(190, 15);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(13, 13);
            this.Time.TabIndex = 11;
            this.Time.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "min";
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(32, 62);
            this.Min.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(84, 20);
            this.Min.TabIndex = 11;
            this.Min.ValueChanged += new System.EventHandler(this.Min_ValueChanged);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(32, 99);
            this.Max.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(84, 20);
            this.Max.TabIndex = 12;
            this.Max.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Max.ValueChanged += new System.EventHandler(this.Max_ValueChanged);
            // 
            // ToolTip
            // 
            this.ToolTip.IsBalloon = true;
            this.ToolTip.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 385);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.ControlsParam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Кликай по числам!";
            this.ControlsParam.ResumeLayout(false);
            this.ControlsParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void TrackTime_Scroll(object sender, EventArgs e)
        {
            Time.Text = TrackTime.Value.ToString();
            ToolTip.SetToolTip(TrackTime, TrackTime.Value.ToString());
        }

        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Timer TimerProgress;
        private System.Windows.Forms.Panel ControlsParam;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TrackBar TrackTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Min;
        private System.Windows.Forms.NumericUpDown Max;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SizeSpin;
    }
}

