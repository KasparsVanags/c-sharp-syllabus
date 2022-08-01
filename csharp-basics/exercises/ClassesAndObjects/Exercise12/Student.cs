using System;

namespace Exercise12
{
    public class Student : IStudent
    {
        private string [] _testsTaken;
        private int _testIndex = 0;
        public Student()
        {
            _testsTaken = new string[0];
        }
        
        public string[] TestsTaken => _testsTaken;

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            Array.Resize(ref _testsTaken, _testsTaken.Length + 1);
            var score = TestScore(paper, answers);
            var testResults = $"{paper.Subject}: {IsTestPassed(paper, score)} ({score})";
            _testsTaken[_testIndex] = testResults;
            _testIndex++;
        }

        private string IsTestPassed(ITestpaper paper, string score)
        {
            if (ConvertToNumber(score) >= ConvertToNumber(paper.PassMark))
            {
                return "Passed!";
            }

            return "Failed!";
        }

        private string TestScore(ITestpaper paper, string[] answers)
        {
            var totalQuestions = 0;
            var correctAnswers = 0;
            for (var i = 0; i < answers.Length; i++)
            {
                if (paper.MarkScheme[i] == answers[i])
                {
                    correctAnswers++;
                }

                totalQuestions++;
            }

            if (correctAnswers == 0)
            {
                return "0%";
            }
            
            return Math.Round((decimal)correctAnswers / totalQuestions * 100) + "%";
        }

        private int ConvertToNumber(string input)
        {
            return int.Parse(input.Replace("%", ""));
        }
    }
}