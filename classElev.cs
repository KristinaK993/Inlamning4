

namespace Inlämning4
{
   //Klass för elev
   
    public class Elev
    {
        public string Namn { get; set; }

        private List<Kurs> kurser = new List<Kurs>(); 


        public Elev(string namn)
        {
            Namn = namn;
        }

        public void Boka(Kurs kurs)
        {
            kurser.Add(kurs);
            Console.WriteLine($"{Namn} har bokat kurs : {kurs.Titel}");
        }

        public void VisaKurser()
        {
            Console.WriteLine($"{Namn} är bokad på följande kurser");
            foreach (var kurser in kurser)
            {
                kurser.VisaInfo();
            }
        }

    }



    

}
