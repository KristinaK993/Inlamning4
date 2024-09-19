

namespace Inlämning4
{
    //Här är klassen för kurs
    public class Kurs
    {
        public string Titel { get; set; }
        public string Beskrivning { get; set; }

        public string Varaktighet { get; set; }

        public Kurs(string Titel, string Beskrivning,  string Varaktighet)
        {
            Titel = Titel;
            Beskrivning = Beskrivning;
            Varaktighet = Varaktighet;

        }
        public void VisaInfo()
        {
            Console.WriteLine($"Kurs: {Titel}");        }
       

    // Här skriver jag metoderna
    public string GetTitel()
        {
            return Titel;
        }
        public string GetBeskrivning()
        {
            return Beskrivning;
        }
        public string GetVaraktighet()
        {
            return Varaktighet;
        }
    }

 
}