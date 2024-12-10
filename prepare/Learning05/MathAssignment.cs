using System;

public class MathAssignment : Assignment
{
    private string _problems;
    private string _textbookSection;
    

        public MathAssignment(string studentName, string topic, string textbookSection ,string problems)
            : base(studentName, topic)
            {
                _textbookSection = textbookSection;
                _problems = problems;
                

            }

        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
}