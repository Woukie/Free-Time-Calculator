using System;
using System.Windows.Forms;

namespace Free_Time_Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int _marks;
        private float _freeTimeEarned, _workToPlayRatio, _totalFreeTimeEarned, _totalTimeWorked;
        private long _timeStarted, _timeWhenPaused;
        private bool _running, _paused;

        public Form()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            _running = !_running;

            if (_running)
            {
                btn_start.Text = "Submit";

                btnPausePlay.Enabled = true;
                nudMarks.Enabled = false;
                nudWork.Enabled = false;
                nudPlay.Enabled = false;

                _marks = int.Parse(nudMarks.Text);
                _workToPlayRatio = float.Parse(nudWork.Text) / float.Parse(nudPlay.Text);
                _timeStarted = DateTime.Now.Ticks;

                timer.Start();

                return;
            }

            float sessionTimeWorked = (DateTime.Now.Ticks - _timeStarted) / 600000000f;
            _totalFreeTimeEarned += _freeTimeEarned;
            _totalTimeWorked += sessionTimeWorked;

            txtLog.Text += "Earned " + _freeTimeEarned + " in " + sessionTimeWorked + " minutes" + "\n";
            lblTotalEarned.Text = "Total time earned: " + _totalFreeTimeEarned;
            lblTotalWorked.Text = "Total time worked: " + _totalTimeWorked;
            btn_start.Text = "Start";

            btnPausePlay.Enabled = false;
            nudMarks.Enabled = true;
            nudWork.Enabled = true;
            nudPlay.Enabled = true;

            timer.Stop();
        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (_paused)
            {
                _paused = false;
                _timeStarted += DateTime.Now.Ticks - _timeWhenPaused;
                btnPausePlay.Text = "Pause";

                btn_start.Enabled = true;

                timer.Start();

                return;
            }

            _paused = true;
            _timeWhenPaused = DateTime.Now.Ticks;
            btnPausePlay.Text = "Play";

            btn_start.Enabled = false;

            timer.Stop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _totalTimeWorked = 0;
            _totalFreeTimeEarned = 0;
            lblTotalEarned.Text = "Total time earned: ";
            lblTotalWorked.Text = "Total time worked: ";
            txtLog.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_timeStarted == 0) return;
            if (!_running) timer.Stop();

            _freeTimeEarned = 2 * _marks * _marks / (_workToPlayRatio * (_marks + (DateTime.Now.Ticks - _timeStarted) / 600000000f));

            lblMinutesWorked.Text = "Minutes worked: " + (DateTime.Now.Ticks - _timeStarted) / 600000000f;
            lblFreeTime.Text = "Minutes of free time earned: " + _freeTimeEarned;
        }
    }
}
