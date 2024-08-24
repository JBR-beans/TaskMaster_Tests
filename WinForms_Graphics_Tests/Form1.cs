

namespace WinForms_Graphics_Tests
{
	public partial class frmMain : Form
	{
		private int hours = 0;
		private int multiHours = 3600000;
		private int elapsedHours;

		private int minutes = 30 * 60000;
		private int multiMinutes = 60000;
		private int elapsedMinutes;

		private int seconds = 0;
		private int multiSeconds = 1000;
		private int elapsedSeconds;

		private int totalTime;
		private int timeElapsed;

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{/*
			this.TopMost = chxTopMost.Checked;
			this.Opacity = .1f;*/
			/*this.BackColor = Color.LimeGreen;
			this.TransparencyKey = Color.LimeGreen;*/
		}


		private void chxTopMost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = chxTopMost.Checked;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			//panel1.BackColor = Color.LimeGreen;
		}

		private void tmrMainDraw_Tick(object sender, EventArgs e)
		{
			if (timeElapsed >= totalTime)
			{
				tmrMainDraw.Stop();
				MessageBox.Show("Times up.");
			}

			if (timeElapsed < totalTime)
			{
				timeElapsed += tmrMainDraw.Interval;
			}

			lblTickDebug.Text = string.Format("{0} | {1}", timeElapsed.ToString(), totalTime.ToString());

			Random randomr = new Random();
			Random randomb = new Random();
			Random randomg = new Random();

			int r = randomr.Next(0, 255);
			int g = randomg.Next(0, 255);
			int b = randomb.Next(0, 255);

			Color tmpcolor = Color.FromArgb(r, g, b);

			panel1.BackColor = tmpcolor;

			lblTimerTicks.Text = string.Format("Time Elapsed: {0} | Time left:  {2} | Color: {1}", timeElapsed.ToString(), tmpcolor.ToString(), (totalTime-timeElapsed).ToString());

			Random meow = new Random();
			lbl3.Font = new Font(FontFamily.GenericSansSerif, meow.Next(1, 200));
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			tmrMainDraw.Stop();
			timeElapsed = 0;
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			tmrMainDraw.Stop();
		}

		private void btnStartTimer_Click(object sender, EventArgs e)
		{
			// start timer
			tmrMainDraw.Start();
		}

		private void txtHours_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtHours.Text, out int hour);
			hours = hour * multiHours;

			if (hours <= 0 || txtHours.Text == "")
			{
				hours = 0;
			}

			totalTime = hours + minutes + seconds;
			lblHours.Text = (hours / multiHours).ToString();
			TotalTime.Text = string.Format("{0:00}:{1:11}:{2:22}", (hours / multiHours).ToString(), (minutes / multiMinutes).ToString(), (seconds / multiSeconds).ToString());
		}

		private void txtMinutes_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtMinutes.Text, out int minute);

			minutes = minute * 60000;

			if (minutes <= 0 || txtMinutes.Text == "")
			{
				minutes = 0;
			}

			totalTime = hours + minutes + seconds;
			lblMinutes.Text = (minutes / multiMinutes).ToString();
			TotalTime.Text = string.Format("{0:00}:{1:11}:{2:22}", (hours / multiHours).ToString(), (minutes / multiMinutes).ToString(), (seconds / multiSeconds).ToString());
		}

		private void txtSeconds_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtSeconds.Text, out int second);
			seconds = second * 1000;

			if (seconds <= 0 || txtSeconds.Text == "")
			{
				seconds = 0;
			}

			totalTime = hours + minutes + seconds;
			lblSeconds.Text = (seconds / multiSeconds).ToString();
			TotalTime.Text = string.Format("{0:00}:{1:11}:{2:22}", (hours / multiHours).ToString(), (minutes / multiMinutes).ToString(), (seconds / multiSeconds).ToString());
		}

		
	}
}
