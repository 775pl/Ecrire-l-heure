using System;
using System.Collections.Generic;
using System.Text;

namespace AssistantVocal
{
    public class Assistant
    {
        private static readonly int hour = DateTime.Now.Hour; // fonctionne avec les horaires actuelles
        readonly int heure = hour;
        int minute = DateTime.Now.Minute;
        int heureavant = hour - 1;
        int heureapres = hour + 1;
        string heure2, minutes2, matinousoir2, minutes3;
        // déclaration des unités :
        string h1 = "et un"; string h2 = "deux"; string h3 = "trois"; string h4 = "quatre"; string h5 = "cinq"; string h6 = "six"; string h7 = "sept"; string h8 = "huit"; string h9 = "neuf";
        public void AfficherHeure()
        {
            string afficherMatinousoir = AfficherMatinSoir();
            string afficherHeure = AfficherHeures();
            string afficherMinute = AfficherMinute();
            while (true) {
                if (heure == 12 || heure == 0)
                {
                    if (minute == 55) { 
                        Console.WriteLine($"Il est {heure2} {minutes2} {minutes3}. Il est donc {heureapres} heures moins cinq");
                    break;
                    }
                    if (minute == 45)
                    {
                        Console.WriteLine($"Il est {heure2} {minutes2} {minutes3}. Il est donc {heureapres} heures moins le quart"); // ne gère pas le pluriel
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Il est {heure2} heures {minutes2} {minutes3} {matinousoir2}");
                    break;
                }

                if (minute == 15)
                {
                    Console.WriteLine($"Il est {heure2} et quart");
                    break;
                }
                else if (minute == 5 || minute == 10 || minute == 20)
                {
                    Console.WriteLine($"Il est {heure2} {minutes2} {minutes3}");
                    break;
                }
                else if (minute == 30)
                {
                    Console.WriteLine($"Il est {heure2} et demi");
                    break;
                }
                else if (minute == 45)
                {
                    Console.WriteLine($"Il est {heure - 1} moins le quart");
                    break;
                }
                else if (minute == 50 || minute == 40)
                {
                    Console.WriteLine($"Il est {heureavant} moins {minutes2}");
                    break;
                }

                if(minute == 1 || minute == 2 || minute == 3 || minute == 4)
                {
                    Console.WriteLine($"Il est {heure2} 5 à {5 - minute} minutes près");
                    break;
                }

                if (minute == 54 || minute == 53 || minute == 52 || minute == 51)
                {
                    Console.WriteLine($"Il sera {hour + 1} heures dans {60 - minute} minutes ");
                    break;
                }
            }
        }
        public string AfficherMatinSoir()
        {
            if (heure >= 0 && heure <= 23)
            {
                if (heure >= 1 && heure < 12)
                {
                    matinousoir2 = "du matin";
                }
                else if (heure > 12 && heure <= 18)
                {
                    matinousoir2 = "de l'apres midi";
                }
                else if (heure >= 19 && heure <= 23)
                {
                    matinousoir2 = "du soir";
                }
                else
                {
                    matinousoir2 = "";
                }
            }
            return matinousoir2;
        }
        public string AfficherHeures()
        {
            if(heure == 0)
            {
                heure2 = "minuit";
            }
            else if (heure == 1 || heure == 13)
            {
                heure2 = "un";
            }else if (heure == 2 || heure == 14)
            {
                heure2 = "deux";
            }
            else if (heure == 3 || heure == 15)
            {
                heure2 = "trois";
            }
            else if (heure == 4 || heure == 16)
            {
                heure2 = "quatre";
            }
            else if (heure == 5 || heure == 17)
            {
                heure2 = "cinq";
            }
            else if (heure == 6 || heure == 18)
            {
                heure2 = "six";
            }
            else if (heure == 7 || heure == 19)
            {
                heure2 = "sept";
            }
            else if (heure == 8 || heure == 20)
            {
                heure2 = "huit";
            }
            else if (heure == 9 || heure == 21)
            {
                heure2 = "neuf";
            }
            else if (heure == 10 || heure == 22)
            {
                heure2 = "dix";
            }
            else if (heure == 11 || heure == 23)
            {
                heure2 = "onze";
            }
            else if (heure == 12)
            {
                heure2 = "midi";
            }
            else
            {
                Console.WriteLine("Format invalide");
            }
            return heure2;
        }
        public string AfficherMinute()
        {
            if (minute >= 17 && minute < 20)
            {
                minutes2 = "dix";
            }
            else if (minute == 11)
            {
                minutes2 = "onze";
            }
            else if (minute == 12)
            {
                minutes2 = "douze";
            }
            else if (minute == 13)
            {
                minutes2 = "treize";
            }
            else if (minute == 14)
            {
                minutes2 = "quatorze";
            }
            else if (minute == 15)
            {
                minutes2 = "quinze";
            }
            else if (minute == 16)
            {
                minutes2 = "seize";
            }
            else if (minute > 20 && minute < 30)
            {
                minutes2 = "vingt";
            }
            else if (minute > 30 && minute < 40)
            {
                minutes2 = "trente";
            }
            else if (minute > 40 && minute < 50)
            {
                minutes2 = "quarante";
            }
            else if (minute > 50 && minute < 60)
            {
                minutes2 = "cinquante";
            }else 
            {
                minutes2 = "";
            }

            if (minute == 1)
            {
                minutes3 = "un";
            }
            else if (minute == 2)
            {
                minutes2 = "deux";
            }
            else if (minute == 3)
            {
                minutes2 = "trois";
            }
            else if (minute == 4)
            {
                minutes2 = "quatre";
            }
            else if (minute == 5)
            {
                minutes2 = "cinq";
            }
            else if (minute == 6)
            {
                minutes2 = "six";
            }
            else if (minute == 7)
            {
                minutes2 = "sept";
            }
            else if (minute == 8)
            {
                minutes2 = "huit";
            }
            else if (minute == 9)
            {
                minutes2 = "neuf";
            }
            if (minute == 21 || minute == 31 || minute == 41 || minute == 51)
            {
                minutes3 = h1;
            }
            if (minute == 22 || minute == 32 || minute == 42 || minute == 52)
            {
                minutes3 = h2;
            }
            if (minute == 23 || minute == 33 || minute == 43 || minute == 53)
            {
                minutes3 = h3;
            }
            if (minute == 24 || minute == 34 || minute == 44 || minute == 54)
            {
                minutes3 = h4;
            }
            if (minute == 25 || minute == 35 || minute == 45 || minute == 55)
            {
                minutes3 = h5;
            }
            if (minute == 26 || minute == 36 || minute == 46 || minute == 56)
            {
                minutes3 = h6;
            }
            if (minute == 27 || minute == 37 || minute == 47 || minute == 57)
            {
                minutes3 = h7;
            }
            if (minute == 28 || minute == 38 || minute == 48 || minute == 58)
            {
                minutes3 = h8;
            }
            if (minute == 29 || minute == 39 || minute == 49 || minute == 59)
            {
                minutes3 = h9;
            }
            return minutes2;
        }
        public Assistant(int heure, int minute)
        {

            this.heure = heure;
            this.minute = minute;
        }
        #region Accesseurs
        public int Heure => heure;
        public int Minute => minute;
        #endregion
    }
}