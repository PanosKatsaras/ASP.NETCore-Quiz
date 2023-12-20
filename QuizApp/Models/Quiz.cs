namespace QuizApp.Models
{
    //The Quiz model class
    public class Quiz
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string CorrectAnswer { get; set; }

        public Quiz()
        {

        }
    }

    
}
