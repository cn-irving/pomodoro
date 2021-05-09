using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace pomodoro_forms
{
    public partial class FormPomodoro : Form
    {
        private const string USER_SETTINGS = "..\\..\\userSettings.json";

        private readonly int DEFAULT_ACTIVITY_MINUTES;
        private readonly int DEFAULT_ACTIVITY_SECONDS;
        private readonly int DEFAULT_REST_MINUTES;
        private readonly int DEFAULT_REST_SECONDS;
        private readonly int DEFAULT_LONG_REST_MINUTES;
        private readonly int DEFAULT_LONG_REST_SECONDS;
        private readonly int DEFAULT_CYCLES;

        private List<PomodoroTimer> _timers;
        private PomodoroTimer _activityTimer;
        private PomodoroTimer _restTimer;
        private PomodoroTimer _longRestTimer;
        private PomodoroTimer _activeTimer;

        public FormPomodoro()
        {
            InitializeComponent();

            using (StreamReader r = new StreamReader(USER_SETTINGS))
            {
                var settingsFileContents = r.ReadToEnd();
                var settings = JsonConvert.DeserializeObject<UserSettings>(settingsFileContents);

                DEFAULT_ACTIVITY_MINUTES = settings.ActivityMinutes;
                DEFAULT_ACTIVITY_SECONDS = settings.ActivitySeconds;
                DEFAULT_REST_MINUTES = settings.RestMinutes;
                DEFAULT_REST_SECONDS = settings.RestSeconds;
                DEFAULT_LONG_REST_MINUTES = settings.LongRestMinutes;
                DEFAULT_LONG_REST_SECONDS = settings.LongRestSeconds;
                DEFAULT_CYCLES = settings.Cycles;
            }

            _activityTimer = new PomodoroTimer("Activity", txtActivityMinutes, txtActivitySeconds, btnActivityStart, nfyFinished, lblNotValid, "Take a break", DEFAULT_ACTIVITY_MINUTES, DEFAULT_ACTIVITY_SECONDS);
            _restTimer = new PomodoroTimer("Rest", txtRestMinutes, txtRestSeconds, btnRestStart, nfyFinished, lblNotValid, "Back to it", DEFAULT_REST_MINUTES, DEFAULT_REST_SECONDS);
            _longRestTimer = new PomodoroTimer("Long rest", txtLongRestMinutes, txtLongRestSeconds, btnLongRestStart, nfyFinished, lblNotValid, "Back to it", DEFAULT_LONG_REST_MINUTES, DEFAULT_LONG_REST_SECONDS);
            _timers = new List<PomodoroTimer> { _activityTimer, _restTimer, _longRestTimer };

            txtDfActivityMinutes.Text = DEFAULT_ACTIVITY_MINUTES.ToTimeString();
            txtDfActivitySeconds.Text = DEFAULT_ACTIVITY_SECONDS.ToTimeString();
            txtDfRestMinutes.Text = DEFAULT_REST_MINUTES.ToTimeString();
            txtDfRestSeconds.Text = DEFAULT_REST_SECONDS.ToTimeString();
            txtDfLongRestMinutes.Text = DEFAULT_LONG_REST_MINUTES.ToTimeString();
            txtDfLongRestSeconds.Text = DEFAULT_LONG_REST_SECONDS.ToTimeString();
            txtDfCycles.Text = DEFAULT_CYCLES.ToString();

            txtActivityMinutes.Text = DEFAULT_ACTIVITY_MINUTES.ToTimeString();
            txtActivitySeconds.Text = DEFAULT_ACTIVITY_SECONDS.ToTimeString();
            txtRestMinutes.Text = DEFAULT_REST_MINUTES.ToTimeString();
            txtRestSeconds.Text = DEFAULT_REST_SECONDS.ToTimeString();
            txtLongRestMinutes.Text = DEFAULT_LONG_REST_MINUTES.ToTimeString();
            txtLongRestSeconds.Text = DEFAULT_LONG_REST_SECONDS.ToTimeString();
            txtCurrentCycle.Text = "1";
            txtCycles.Text = DEFAULT_CYCLES.ToString();

            _activityTimer.Finished += new EventHandler(_switchTimers);
            _restTimer.Finished += new EventHandler(_switchTimers);
            _longRestTimer.Finished += new EventHandler(_switchTimers);
            nfyFinished.BalloonTipClicked += new EventHandler(nfyFinished_Click);
        }

        private void FormPomodoro_Load(object sender, EventArgs e)
        {
        }

        private void btnActivityStart_Click(object sender, EventArgs e)
        {
            if (_activeTimer == _activityTimer)
            {
                StopTimer(_activityTimer);
            }
            else
            {
                StopTimers(GetOtherTimers(_activityTimer));
                StartTimer(_activityTimer);
            }
        }

        private void btnRestStart_Click(object sender, EventArgs e)
        {
            if (_activeTimer == _restTimer)
            {
                StopTimer(_restTimer);
            }
            else
            {
                StopTimers(GetOtherTimers(_restTimer));
                StartTimer(_restTimer);
            }
        }

        private void btnLongRestStart_Click(object sender, EventArgs e)
        {
            if (_activeTimer == _longRestTimer)
            {
                StopTimer(_longRestTimer);
            }
            else
            {
                StopTimers(GetOtherTimers(_longRestTimer));
                txtCurrentCycle.Text = txtCycles.Text;
                StartTimer(_longRestTimer);
            }
        }

        private IEnumerable<PomodoroTimer> GetOtherTimers(PomodoroTimer timer)
        {
            return _timers.Where(x => x.Name != timer.Name);
        }

        private void MakeInputsReadOnly()
        {
            ((Control)tabDefaults).Enabled = false;

            if (_activeTimer.Name == "Activity")
            {
                txtActivityMinutes.ReadOnly = true;
                txtActivitySeconds.ReadOnly = true;
                txtRestMinutes.ReadOnly = false;
                txtRestSeconds.ReadOnly = false;
                txtLongRestMinutes.ReadOnly = false;
                txtLongRestSeconds.ReadOnly = false;

                btnActivityStart.Enabled = true;
                btnRestStart.Enabled = false;
                btnLongRestStart.Enabled = false;
            }
            else if (_activeTimer.Name == "Rest")
            {
                txtActivityMinutes.ReadOnly = false;
                txtActivitySeconds.ReadOnly = false;
                txtRestMinutes.ReadOnly = true;
                txtRestSeconds.ReadOnly = true;
                txtLongRestMinutes.ReadOnly = false;
                txtLongRestSeconds.ReadOnly = false;

                btnActivityStart.Enabled = false;
                btnRestStart.Enabled = true;
                btnLongRestStart.Enabled = false;
            }
            else if (_activeTimer.Name == "Long rest")
            {
                txtActivityMinutes.ReadOnly = false;
                txtActivitySeconds.ReadOnly = false;
                txtRestMinutes.ReadOnly = false;
                txtRestSeconds.ReadOnly = false;
                txtLongRestMinutes.ReadOnly = true;
                txtLongRestSeconds.ReadOnly = true;

                btnActivityStart.Enabled = false;
                btnRestStart.Enabled = false;
                btnLongRestStart.Enabled = true;
            }
        }

        private void MakeInputsEditable()
        {
            ((Control)tabDefaults).Enabled = true;

            txtActivityMinutes.ReadOnly = false;
            txtActivitySeconds.ReadOnly = false;

            txtRestMinutes.ReadOnly = false;
            txtRestSeconds.ReadOnly = false;

            txtLongRestMinutes.ReadOnly = false;
            txtLongRestSeconds.ReadOnly = false;

            btnActivityStart.Enabled = true;
            btnRestStart.Enabled = true;
            btnLongRestStart.Enabled = true;
        }

        private void txtActivityMinutes_TextChanged(object sender, EventArgs e)
        {
            HideValidation();
        }

        private void txtActivitySeconds_TextChanged(object sender, EventArgs e)
        {
            HideValidation();
        }

        private void StartTimer(PomodoroTimer timer)
        {
            _activeTimer = timer.Start();
            MakeInputsReadOnly();
        }

        private void StopTimer(PomodoroTimer timer)
        {
            _activeTimer = timer.Stop();
            MakeInputsEditable();
        }

        private void StopTimers(IEnumerable<PomodoroTimer> timers)
        {
            foreach (var timer in timers)
            {
                StopTimer(timer);
            }
        }

        private void HideValidation()
        {
            lblNotValid.Hide();
        }

        private void _switchTimers(object sender, EventArgs e)
        {
            var timerName = ((TimerFinishedEventArgs)e).TimerName;

            int currentCycle, cycles;
            var hasCycles = int.TryParse(txtCurrentCycle.Text, out currentCycle) & int.TryParse(txtCycles.Text, out cycles);

            if (timerName == _activityTimer.Name)
            {
                if (!hasCycles || currentCycle < cycles)
                {
                    StartTimer(_restTimer);
                }
                else
                {
                    StartTimer(_longRestTimer);
                }
            }
            else
            {
                ProgressCycle(currentCycle, cycles);
                StartTimer(_activityTimer);
            }
        }

        private void ProgressCycle(int currentCycle, int cycles)
        {
            if (currentCycle == 0 || cycles == 0)
            {
                return;
            }

            currentCycle++;

            if (currentCycle > cycles)
            {
                currentCycle = 1;
            }

            txtCurrentCycle.Text = currentCycle.ToString();
        }

        private void FormPomodoro_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                nfyFinished.Visible = true;
            }
        }

        private void nfyFinished_Click(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            nfyFinished.Visible = false;
        }

        private void nfyFinished_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            nfyFinished.Visible = false;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDfActivityMinutes.Text, out var activityMinutes) && int.TryParse(txtDfActivitySeconds.Text, out var activitySeconds)
                && int.TryParse(txtDfRestMinutes.Text, out var restMinutes) && int.TryParse(txtDfRestSeconds.Text, out var restSeconds)
                && int.TryParse(txtDfLongRestMinutes.Text, out var longRestMinutes) && int.TryParse(txtDfLongRestSeconds.Text, out var longRestSeconds)
                && int.TryParse(txtDfCycles.Text, out var cycles)
                )
            {
                lblDfNotValid.Visible = false;

                var settings = new UserSettings
                {
                    ActivityMinutes = activityMinutes,
                    ActivitySeconds = activitySeconds,
                    RestMinutes = restMinutes,
                    RestSeconds = restSeconds,
                    LongRestMinutes = longRestMinutes,
                    LongRestSeconds = longRestSeconds,
                    Cycles = cycles
                };

                var settingsJson = JsonConvert.SerializeObject(settings);

                File.WriteAllText(USER_SETTINGS, settingsJson);

                txtActivityMinutes.Text = txtDfActivityMinutes.Text;
                txtActivitySeconds.Text = txtDfActivitySeconds.Text;
                txtRestMinutes.Text = txtDfRestMinutes.Text;
                txtRestSeconds.Text = txtDfRestSeconds.Text;
                txtLongRestMinutes.Text = txtDfLongRestMinutes.Text;
                txtLongRestSeconds.Text = txtDfLongRestSeconds.Text;
                txtCurrentCycle.Text = 1.ToString();
                txtCycles.Text = txtDfCycles.Text;

                tabMain.SelectedTab = tabTimer;
            }
            else
            {
                lblDfNotValid.Visible = true;
            }
        }
    }
}
