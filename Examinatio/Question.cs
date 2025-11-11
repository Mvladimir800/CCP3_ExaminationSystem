namespace ExaminationSystem
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }
        public string CorrectAnswer { get; set; }
        public decimal Points { get; set; }
    }
}
