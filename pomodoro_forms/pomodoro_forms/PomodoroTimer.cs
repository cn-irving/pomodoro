using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using NotifyIcon = System.Windows.Forms.NotifyIcon;

namespace pomodoro_forms
{
    class PomodoroTimer
    {
        int _startingMinutes;
        int _startingSeconds;
        private DateTime? _startTime;
        private DateTime? _endTime;
        private string _finishMessage;

        public PomodoroTimer(string name, TextBox minutesTextBox, TextBox secondsTextBox, Button startButton, NotifyIcon notifyIcon, Label invalidLabel, string finishMessage, int defaultMinutes, int defaultSeconds)
        {
            _finishMessage = finishMessage;
            MinutesTextbox = minutesTextBox;
            SecondsTextbox = secondsTextBox;
            StartButton = startButton;
            NotifyIcon = notifyIcon;
            InvalidLabel = invalidLabel;

            SetValues(defaultMinutes, defaultSeconds);

            Name = name;
            Timer = new Timer { Interval = 1000 };
            Timer.Tick += new EventHandler(_tick);
        }

        public string Name { get; set; }
        public Timer Timer;
        public event EventHandler Finished;

        public TextBox MinutesTextbox;
        public TextBox SecondsTextbox;
        public Button StartButton;
        public NotifyIcon NotifyIcon;
        public Label InvalidLabel;

        public int TotalSecondsRemaining => (int)(_endTime.Value - DateTime.Now).TotalSeconds;
        public int MinutesRemaining => TotalSecondsRemaining / 60;
        public int SecondsRemaining => TotalSecondsRemaining % 60;

        public PomodoroTimer Start()
        {
            if (int.TryParse(MinutesTextbox.Text, out var minutes) & int.TryParse(SecondsTextbox.Text, out var seconds))
            {
                var timerSpan = new TimeSpan(0, minutes, seconds);

                SetValues(minutes, seconds);

                _startTime = DateTime.Now;
                _endTime = _startTime + timerSpan;
                Timer.Start();

                StartButton.Text = "Stop";
            }
            else
            {
                InvalidLabel.Show();
            }

            return this;
        }

        public PomodoroTimer Stop()
        {
            Timer.Stop();
            _startTime = null;

            StartButton.Text = "Start";

            return null;
        }

        public void Finish(EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            var soundFileLocation = Path.Combine(projectDirectory, @"Content\Sounds\confirmation.wav");

            var simpleSound = new SoundPlayer(soundFileLocation);
            simpleSound.Play();
            NotifyIcon.Visible = true;
            NotifyIcon.ShowBalloonTip(10000, $"{Name} timer finished", _finishMessage, ToolTipIcon.Info);
            Stop();

            MinutesTextbox.Text = _startingMinutes.ToTimeString();
            SecondsTextbox.Text = _startingSeconds.ToTimeString();

            Finished.Invoke(this, e);
        }

        public void SetValues(int minutes, int seconds)
        {
            _startingMinutes = minutes;
            _startingSeconds = seconds;

            MinutesTextbox.Text = minutes.ToTimeString();
            SecondsTextbox.Text = seconds.ToTimeString();
        }

        private void _tick(object sender, EventArgs e)
        {
            if (TotalSecondsRemaining <= 0)
            {
                Finish(new TimerFinishedEventArgs { TimerName = Name });
            }
            else
            {
                var minutesRemaining = MinutesRemaining.ToTimeString();
                var secondsRemaining = SecondsRemaining.ToTimeString();

                MinutesTextbox.Text = minutesRemaining;
                SecondsTextbox.Text = secondsRemaining;

                NotifyIcon.Text = $"{minutesRemaining}:{secondsRemaining}";
            }
        }
    }
}
