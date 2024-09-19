

namespace Inlämning4
{
  //Klass för uppgifter

public class Uppgift
    {
        public string Titel { get; set; }

        public string Info { get; set; }
        public Uppgift(string titel, string info)
        {
            titel = titel;
            Info = Info;
        }
        public string GetTitel()
        {
            return Titel;
        }
        public string GetInfo()
        {
            return Info;
        }
    }
}
