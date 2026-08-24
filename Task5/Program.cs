using System.Transactions;
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>();
            while (true)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1- Doctor");
                Console.WriteLine("2- Student");
                Console.WriteLine("3- Exit");
                Console.Write("Choose: ");
                int input;
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input == 1)
                    {
                        Console.Write("How Many Questions Do You Want To Add: ");
                        int NumberOfQuestions = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= NumberOfQuestions; i++)
                        {
                            Console.WriteLine($"Adding Question {i}");
                            Console.WriteLine("Select Question Type: 1- True/False, 2- ChooseOne, 3- MultipleChoice");
                            int TypeofQuestion;
                            if (int.TryParse(Console.ReadLine(), out TypeofQuestion))
                            {
                                if (TypeofQuestion == 1)
                                {
                                    TrueOrFalse q = new TrueOrFalse();
                                    q.Type = "True/False";
                                    Console.Write("Enter Question Level (Easy/Medium/Hard): ");
                                    string level = Console.ReadLine().Trim().ToLower();
                                    if (level == "easy" || level == "medium" || level == "hard")
                                        q.Level = level;
                                    else
                                        Console.WriteLine("Invalid Level");
                                    Console.Write("Enter Question Header: ");
                                    string header = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(header))
                                    {
                                        q.Header = header;
                                    }
                                    else
                                        Console.WriteLine("Invalid Header");

                                    Console.Write("Enter Question Marks: ");
                                    int marks;
                                    if (int.TryParse(Console.ReadLine(), out marks))
                                    {
                                        q.Marks = marks;
                                    }
                                    else
                                        Console.WriteLine("Invalid Input");
                                    Console.Write("Enter The Correct Answer (True/False): ");
                                    string CorrectAnswer = Console.ReadLine().Trim().ToLower();
                                    if (CorrectAnswer == "true" || CorrectAnswer == "false")
                                    {
                                        q.CorrectAnswer = CorrectAnswer;
                                    }
                                    else
                                        Console.WriteLine("Invalid Answer");

                                    questions.Add(q);
                                }
                                else if (TypeofQuestion == 2)
                                {
                                    ChooseOne q = new ChooseOne();
                                    q.Type = "ChooseOne";
                                    Console.Write("Enter Question Level (Easy/Medium/Hard): ");
                                    string level = Console.ReadLine().Trim().ToLower();
                                    if (level == "easy" || level == "medium" || level == "hard")
                                    {
                                        q.Level = level;
                                    }
                                    else
                                        Console.WriteLine("Invalid Level");
                                    Console.Write("Enter Question Header: ");
                                    string header = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(header))
                                    {
                                        q.Header = header;
                                    }
                                    else
                                        Console.WriteLine("Invalid Header");

                                    Console.Write("Enter Question Marks: ");
                                    int marks;
                                    if (int.TryParse(Console.ReadLine(), out marks))
                                    {
                                        q.Marks = marks;
                                    }
                                    else
                                        Console.WriteLine("Invalid Input");
                                    for (int j = 1; j <= 4; j++)
                                    {
                                        Console.Write($"Enter Choice {j}:");
                                        string Choice = Console.ReadLine().Trim();
                                        if (!string.IsNullOrEmpty(Choice))
                                            q.Answers.Add(Choice);
                                        else
                                            Console.WriteLine("Invalid Choice");
                                    }
                                    Console.Write("Enter The Correct Answer (1-4): ");
                                    int CorrectAnswer;
                                    if (int.TryParse(Console.ReadLine(), out CorrectAnswer))
                                    {
                                        if (CorrectAnswer >= 1 && CorrectAnswer <= 4)
                                            q.CorrectAnswer = CorrectAnswer;
                                        else
                                            Console.WriteLine("Invalid Choice");
                                    }
                                    else
                                        Console.WriteLine("Invalid Choice");
                                    questions.Add(q);
                                }
                                else if (TypeofQuestion == 3)
                                {
                                    MulipleChoice q = new MulipleChoice();
                                    q.Type = "MultipleChoice";
                                    Console.Write("Enter Question Level (Easy/Medium/Hard): ");
                                    string level = Console.ReadLine().Trim().ToLower();
                                    if (level == "easy" || level == "medium" || level == "hard")
                                    {
                                        q.Level = level;
                                    }
                                    else
                                        Console.WriteLine("Invalid Level");
                                    Console.Write("Enter Question Header: ");
                                    string header = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(header))
                                    {
                                        q.Header = header;
                                    }
                                    else
                                        Console.WriteLine("Invalid Header");

                                    Console.Write("Enter Question Marks: ");
                                    int marks;
                                    if (int.TryParse(Console.ReadLine(), out marks))
                                    {
                                        q.Marks = marks;
                                    }
                                    else
                                        Console.WriteLine("Invalid Input");
                                    for (int j = 1; j <= 4; j++)
                                    {
                                        Console.Write($"Enter Choice {j}:");
                                        string Choice = Console.ReadLine().Trim();
                                        if (!string.IsNullOrEmpty(Choice))
                                            q.Answers.Add(Choice);
                                        else
                                            Console.WriteLine("Invalid Choice");
                                    }
                                    Console.Write("Enter Correct Answers (Comma Separated, e.g. 1,3): ");
                                    string CorrectAnswers = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(CorrectAnswers))
                                    {
                                        string[] Answers = CorrectAnswers.Split(',');
                                        q.CorrectAnswers = Answers;
                                    }
                                    else
                                        Console.WriteLine("Invalid Answers");
                                    questions.Add(q);
                                }
                                else
                                    Console.WriteLine("Invalid Number");
                            }
                            else
                                Console.WriteLine("Invalid Input");
                        }
                    }
                    else if (input == 2)
                    {
                        int mymarks = 0;
                        int totalmarks = 0;
                        Console.Write("Choose Exam Type: 1- Practical Exam, 2- Final Exam: ");
                        int ExamType;
                        if(int.TryParse(Console.ReadLine(),out ExamType))
                        {
                            if (ExamType == 1)
                            {
                                Console.Write("Enter the Level of the Exam (easy/medium/hard): ");
                                string Level = Console.ReadLine().Trim().ToLower();
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("--- Exam Started ---");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                List<Question> examQuestions = new List<Question>();
                                for(int i = 0; i < questions.Count; i++)
                                {
                                    if (questions[i].Level == Level)
                                    {
                                        examQuestions.Add(questions[i]);
                                    }
                                }
                                for (int i = 0; i < examQuestions.Count/2; i++)
                                {             
                                    if (examQuestions[i].Type == "True/False")
                                    {
                                        if (examQuestions[i] is TrueOrFalse des) {
                                            Console.WriteLine($"{des.Header}  ({des.Type}) - Marks {des.Marks}");
                                            Console.Write("Your Answer: ");
                                            string YourAnswer = Console.ReadLine().Trim().ToLower();
                                            if (YourAnswer == des.CorrectAnswer)
                                                mymarks += des.Marks;
                                            totalmarks += des.Marks;
                                        }
                                    }
                                    else if (examQuestions[i].Type == "ChooseOne")
                                    {
                                        if (examQuestions[i] is ChooseOne des)
                                        {
                                            Console.WriteLine($"{des.Header}  ({des.Type}) - Marks {des.Marks}");
                                            for(int j = 0; j < 4; j++)
                                            {
                                                Console.WriteLine($"{j+1}-  {des.Answers[j]}");
                                            }
                                            Console.Write("Your Answer (1-4): ");
                                            int YourAnswer;
                                            if (int.TryParse(Console.ReadLine(), out YourAnswer)) 
                                            {
                                                if (YourAnswer == des.CorrectAnswer)
                                                {
                                                    mymarks += des.Marks;
                                                }
                                            }
                                            else
                                                Console.WriteLine("Invalid Input");
                                            totalmarks += des.Marks;

                                        }
                                    }
                                    else
                                    {
                                        bool flag = true;
                                        if (examQuestions[i] is MulipleChoice des)
                                        {
                                            Console.WriteLine($"{des.Header}  ({des.Type}) - Marks {des.Marks}");
                                            for (int j = 0; j < 4; j++)
                                            {
                                                Console.WriteLine($"{j+1}-  {des.Answers[j]}");
                                            }
                                            Console.Write("Your Answer (e.g. 1,4): ");
                                            string YourAnswer=Console.ReadLine();
                                            if (!string.IsNullOrEmpty(YourAnswer))
                                            {
                                                string[] myanswers = YourAnswer.Split(',');
                                                for (int j = 0; j < des.CorrectAnswers.Length; j++)
                                                {
                                                    if (myanswers[j] != des.CorrectAnswers[j])
                                                    {
                                                        flag = false;
                                                        break;
                                                    }
                                                }
                                                if (flag)
                                                {
                                                    mymarks += des.Marks;
                                                }
                                            }
                                            totalmarks += des.Marks;
                                        }

                                    }
                                    
                                }
                                Console.WriteLine("");
                                Console.WriteLine($"Your Total Score: {mymarks}/{totalmarks}");
                                Console.WriteLine("Exam Finished");
                            }
                            else if (ExamType == 2) 
                            {
                                Console.Write("Enter the Level of the Exam (easy/medium/hard): ");
                                string Level = Console.ReadLine().Trim().ToLower();
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("--- Exam Started ---");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                for (int i = 0; i < questions.Count; i++)
                                {
                                    if (questions[i].Level == Level)
                                    {
                                        if (questions[i].Type == "True/False")
                                        {
                                            if (questions[i] is TrueOrFalse des)
                                            {
                                                Console.WriteLine($"{des.Header}  ({des.Type}) - Marks {des.Marks}");
                                                Console.Write("Your Answer: ");
                                                string YourAnswer = Console.ReadLine().Trim().ToLower();
                                                if (YourAnswer == des.CorrectAnswer)
                                                    mymarks += des.Marks;
                                                totalmarks += des.Marks;
                                            }
                                        }
                                        else if (questions[i].Type == "ChooseOne")
                                        {
                                            if (questions[i] is ChooseOne des)
                                            {
                                                Console.WriteLine($"{des.Header}  ({des.Type}) - Marks {des.Marks}");
                                                for (int j = 0; j < 4; j++)
                                                {
                                                    Console.WriteLine($"{j+1}-  {des.Answers[j]}");
                                                }
                                                Console.Write("Your Answer (1-4): ");
                                                int YourAnswer;
                                                if (int.TryParse(Console.ReadLine(), out YourAnswer))
                                                {
                                                    if (YourAnswer == des.CorrectAnswer)
                                                    {
                                                        mymarks += des.Marks;
                                                    }
                                                }
                                                else
                                                    Console.WriteLine("Invalid Input");
                                                totalmarks += des.Marks;

                                            }
                                        }
                                        else
                                        {
                                            bool flag = true;
                                            if (questions[i] is MulipleChoice des)
                                            {
                                                Console.WriteLine($"{des.Header}  ({des.Type}) - Marks {des.Marks}");
                                                for (int j = 0; j < 4; j++)
                                                {
                                                    Console.WriteLine($"{j+1}-  {des.Answers[j]}");
                                                }
                                                Console.Write("Your Answer (e.g. 1,4): ");
                                                string? YourAnswer = Console.ReadLine();
                                                if (!string.IsNullOrEmpty(YourAnswer))
                                                {
                                                    string[] myanswers = YourAnswer.Split(',');
                                                    for (int j = 0; j < des.CorrectAnswers.Length; j++)
                                                    {
                                                        if (myanswers[j] != des.CorrectAnswers[j])
                                                        {
                                                            flag = false;
                                                            break;
                                                        }
                                                    }
                                                    if (flag)
                                                        mymarks += des.Marks;
                                                }
                                                totalmarks += des.Marks;
                                            }
                                        }
                                    }
                                }
                                Console.WriteLine("");
                                Console.WriteLine($"Your Total Score: {mymarks}/{totalmarks}");
                                Console.WriteLine("Exam Finished");
                            }
                            else
                                Console.WriteLine("Invalid Type");
                        }
                        else
                            Console.WriteLine("Invalid Input");
                    }
                    else if (input == 3)
                    {
                        break;
                    }
                    else
                        Console.WriteLine("Invalid Number");
                }
                else
                    Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("Good Bye...!");
        }
    }
}
