using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLidia
{
    class Privat_Post : Beitragx
    {
        public string[] BerechtigteUser
        {
            get
            {
                string userString = InfoLesen('b');
                string[] userArray = userString.Split(',');
                return userArray;
            }
            set
            {
                string[] userArray = value;
                string userString = Convert.ToString(userArray);
                InfoAendern('f', userString);
            }
        }

        //Konstruktor: neuer Privat Beitrag
        public Privat_Post(Datei newDatei, string erstellerName, string newText, string[] newBerechtigte) : base(newDatei,erstellerName,newText)
        {
            // Random ID-Zuordnung:
            Random myRandom = new Random();
            int newID = myRandom.Next();
            while (true)
            {
                if (benutzteIDs.Contains(newID))
                {
                    newID = myRandom.Next();
                }
                else
                {
                    break;
                }
            }
            ID = Convert.ToString(newID);

            // Felder setzen:
            BeitragsDatei = newDatei;
            string neueZeile = $"{newID};{erstellerName};{newText};LEER;0;{newBerechtigte}";
            BeitragsDatei.Hinzufuegen(neueZeile);
        }
    }
}
