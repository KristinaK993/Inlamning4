

namespace Inlämning4
{
    public class Quiz
    {
        public string Frågor { get; set; }

        public Quiz(string frågor)
        {
            Frågor = frågor;
        }
        public string GetFrågor()
        {
            return Frågor;
        }
    }
}
