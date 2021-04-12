namespace pomodoro_forms
{
    public static class Extensions
    {
        public static string ToTimeString(this int value)
        {
            return value.ToString(@"00");
        }
    }
}
