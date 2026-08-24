using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class ChooseOne : Question
    {
       public List<string> Answers { get; set; } = new List<string>();
        public int CorrectAnswer {  get; set; }

    }
}
