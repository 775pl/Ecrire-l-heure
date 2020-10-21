using System;

namespace AssistantVocal
{
    public class Program
    {

        static void Main(string[] args)
        {

            int heure = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            Assistant p1 = new Assistant(heure, minute);

            //Assistant p1 = new Assistant(12, 54); // sers à tester pour n'importe quelle heure

            p1.AfficherHeure();
        }
    }
}
