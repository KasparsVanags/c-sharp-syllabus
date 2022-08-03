namespace Exercise12
{
    public class Testpaper : ITestpaper
    {
        public string Subject { get; }
        public string[] MarkScheme { get; }
        public string PassMark { get; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }
}