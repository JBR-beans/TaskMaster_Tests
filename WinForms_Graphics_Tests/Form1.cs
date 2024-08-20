

namespace WinForms_Graphics_Tests
{
	public partial class frmMain : Form
	{
		private int ticks = 0;
		private int timeLeft = 10;

		private int hours = 0;
		private int multiHours = 3600000;

		private	int minutes = 30 * 60000;
		private int multiMinutes = 60000;

		private int seconds = 0;
		private int multiSeconds = 1000;

		private int totalTime;

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
			MessageBox.Show("Ticked.");
			/*ticks++;

			timeLeft--;

			if (timeLeft == 0)
			{
				tmrMainDraw.Stop();
			}*/


			Random randomr = new Random();
			Random randomb = new Random();
			Random randomg = new Random();

			int r = randomr.Next(0, 255);
			int g = randomg.Next(0, 255);
			int b = randomb.Next(0, 255);

			Color tmpcolor = Color.FromArgb(r, g, b);

			panel1.BackColor = tmpcolor;

			lblTimerTicks.Text = string.Format("Ticks: {0} | Time left:  {2} | Color: {1}", ticks.ToString(), tmpcolor.ToString(), timeLeft.ToString());
		}

		private void btnStartTimer_Click(object sender, EventArgs e)
		{

		}

		private void txtHours_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtHours.Text, out int hour);
			hours = hour * 3600000;

			if (hours <= 0 || txtHours.Text == "")
			{
				hours = 0;
			}

			totalTime = hours + minutes + seconds;

			lblTimer.Text = totalTime.ToString();
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

			lblTimer.Text = totalTime.ToString();
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

			lblTimer.Text = totalTime.ToString();
		}
	}
}
