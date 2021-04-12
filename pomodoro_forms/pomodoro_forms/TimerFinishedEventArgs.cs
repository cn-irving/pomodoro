using System;

namespace pomodoro_forms
{
    public class TimerFinishedEventArgs : EventArgs
    {
        public string TimerName { get; set; }
    }
}
