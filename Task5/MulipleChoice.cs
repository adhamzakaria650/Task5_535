using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class MulipleChoice : Question
    {
        public List<string> Answers { get; set; } = new List<string>();
        public string[] CorrectAnswers { get; set; } = new string[4];
    }
}
