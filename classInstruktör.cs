

namespace Inlämning4
{
   public class Instruktör : Elev
    {
        public string Email {  get; set; }
        public List<string> Kurser {  get; set; } = new List<string>();

        //konstruktor för instruktör
        public Instruktör (string namn,  string email) : base(namn)
        {
            this .Email = email;
        }
        
        //Metod för att skapa kurs
        public void SkapaKurs(string kurs)
        {
            Kurser.Add(kurs);

            Console.WriteLine($"Instruktören{Namn} har skapar kursen: {kurs}");
        }
    }
}
