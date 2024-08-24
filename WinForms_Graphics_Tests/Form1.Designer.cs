namespace WinForms_Graphics_Tests
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			tmrMainDraw = new System.Windows.Forms.Timer(components);
			chxTopMost = new CheckBox();
			panel1 = new Panel();
			lblTimerTicks = new Label();
			TotalTime = new Label();
			txtHours = new TextBox();
			txtMinutes = new TextBox();
			txtSeconds = new TextBox();
			lblHours = new Label();
			lblMinutes = new Label();
			lblSeconds = new Label();
			btnStartTimer = new Button();
			btnPause = new Button();
			btnReset = new Button();
			lblTickDebug = new Label();
			lbl3 = new Label();
			SuspendLayout();
			// 
			// tmrMainDraw
			// 
			tmrMainDraw.Interval = 1000;
			tmrMainDraw.Tick += tmrMainDraw_Tick;
			// 
			// chxTopMost
			// 
			chxTopMost.AutoSize = true;
			chxTopMost.Checked = true;
			chxTopMost.CheckState = CheckState.Checked;
			chxTopMost.Location = new Point(687, 12);
			chxTopMost.Name = "chxTopMost";
			chxTopMost.Size = new Size(101, 19);
			chxTopMost.TabIndex = 0;
			chxTopMost.Text = "Always on top";
			chxTopMost.UseVisualStyleBackColor = true;
			chxTopMost.CheckedChanged += chxTopMost_CheckedChanged;
			// 
			// panel1
			// 
			panel1.Location = new Point(449, 279);
			panel1.Name = "panel1";
			panel1.Size = new Size(339, 159);
			panel1.TabIndex = 1;
			panel1.Paint += panel1_Paint;
			// 
			// lblTimerTicks
			// 
			lblTimerTicks.AutoSize = true;
			lblTimerTicks.Location = new Point(449, 261);
			lblTimerTicks.Name = "lblTimerTicks";
			lblTimerTicks.Size = new Size(76, 15);
			lblTimerTicks.TabIndex = 2;
			lblTimerTicks.Text = "lblTimerTicks";
			// 
			// TotalTime
			// 
			TotalTime.AutoSize = true;
			TotalTime.Location = new Point(118, 336);
			TotalTime.Name = "TotalTime";
			TotalTime.Size = new Size(50, 15);
			TotalTime.TabIndex = 3;
			TotalTime.Text = "lblTimer";
			// 
			// txtHours
			// 
			txtHours.Location = new Point(12, 357);
			txtHours.Name = "txtHours";
			txtHours.Size = new Size(100, 23);
			txtHours.TabIndex = 4;
			txtHours.TextChanged += txtHours_TextChanged;
			// 
			// txtMinutes
			// 
			txtMinutes.Location = new Point(12, 386);
			txtMinutes.Name = "txtMinutes";
			txtMinutes.Size = new Size(100, 23);
			txtMinutes.TabIndex = 5;
			txtMinutes.TextChanged += txtMinutes_TextChanged;
			// 
			// txtSeconds
			// 
			txtSeconds.Location = new Point(12, 415);
			txtSeconds.Name = "txtSeconds";
			txtSeconds.Size = new Size(100, 23);
			txtSeconds.TabIndex = 6;
			txtSeconds.TextChanged += txtSeconds_TextChanged;
			// 
			// lblHours
			// 
			lblHours.AutoSize = true;
			lblHours.Location = new Point(118, 365);
			lblHours.Name = "lblHours";
			lblHours.Size = new Size(39, 15);
			lblHours.TabIndex = 7;
			lblHours.Text = "Hours";
			// 
			// lblMinutes
			// 
			lblMinutes.AutoSize = true;
			lblMinutes.Location = new Point(118, 394);
			lblMinutes.Name = "lblMinutes";
			lblMinutes.Size = new Size(50, 15);
			lblMinutes.TabIndex = 8;
			lblMinutes.Text = "Minutes";
			// 
			// lblSeconds
			// 
			lblSeconds.AutoSize = true;
			lblSeconds.Location = new Point(118, 423);
			lblSeconds.Name = "lblSeconds";
			lblSeconds.Size = new Size(51, 15);
			lblSeconds.TabIndex = 9;
			lblSeconds.Text = "Seconds";
			// 
			// btnStartTimer
			// 
			btnStartTimer.Location = new Point(12, 328);
			btnStartTimer.Name = "btnStartTimer";
			btnStartTimer.Size = new Size(100, 23);
			btnStartTimer.TabIndex = 10;
			btnStartTimer.Text = "Start";
			btnStartTimer.UseVisualStyleBackColor = true;
			btnStartTimer.Click += btnStartTimer_Click;
			// 
			// btnPause
			// 
			btnPause.Location = new Point(12, 299);
			btnPause.Name = "btnPause";
			btnPause.Size = new Size(100, 23);
			btnPause.TabIndex = 11;
			btnPause.Text = "Pause";
			btnPause.UseVisualStyleBackColor = true;
			btnPause.Click += btnPause_Click;
			// 
			// btnReset
			// 
			btnReset.Location = new Point(12, 270);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(100, 23);
			btnReset.TabIndex = 12;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += btnReset_Click;
			// 
			// lblTickDebug
			// 
			lblTickDebug.AutoSize = true;
			lblTickDebug.Location = new Point(12, 9);
			lblTickDebug.Name = "lblTickDebug";
			lblTickDebug.Size = new Size(16, 15);
			lblTickDebug.TabIndex = 13;
			lblTickDebug.Text = ":3";
			// 
			// lbl3
			// 
			lbl3.AutoSize = true;
			lbl3.Location = new Point(324, 209);
			lbl3.Name = "lbl3";
			lbl3.Size = new Size(16, 15);
			lbl3.TabIndex = 14;
			lbl3.Text = ":3";
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lbl3);
			Controls.Add(lblTickDebug);
			Controls.Add(btnReset);
			Controls.Add(btnPause);
			Controls.Add(btnStartTimer);
			Controls.Add(lblSeconds);
			Controls.Add(lblMinutes);
			Controls.Add(lblHours);
			Controls.Add(txtSeconds);
			Controls.Add(txtMinutes);
			Controls.Add(txtHours);
			Controls.Add(TotalTime);
			Controls.Add(lblTimerTicks);
			Controls.Add(panel1);
			Controls.Add(chxTopMost);
			Name = "frmMain";
			Text = "Main";
			Load += frmMain_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer tmrMainDraw;
		private CheckBox chxTopMost;
		private Panel panel1;
		private Label lblTimerTicks;
		private Label TotalTime;
		private TextBox txtHours;
		private TextBox txtMinutes;
		private TextBox txtSeconds;
		private Label lblHours;
		private Label lblMinutes;
		private Label lblSeconds;
		private Button btnStartTimer;
		private Button btnPause;
		private Button btnReset;
		private Label lblTickDebug;
		private Label lbl3;
	}
}
