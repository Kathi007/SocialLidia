using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SocialLidia
{
    class Nutzer
    {
        public string Benutzername;
        public string Passwort;
        public char Geschlecht;
        public int Alter;
        public string Vorname;
        public string Nachname;

        public Nutzer(string newBenutzername) //Benutzername wird für Erstellen eines Accounts gebraucht
        {
            Benutzername = newBenutzername;
            GetInformation();
        }

        private void SetInformation()
        {
            
        }

        static public void AddBenutzer()
        {

        }

        private void GetInformation() //Setzt Felder
        {
            string dateipfad = "Daten.txt";
            using (StreamReader reader = new StreamReader(dateipfad))
            {
                while (true)
                {
                    string zeile = reader.ReadLine();
                    if (zeile == null) //Ende der Datei
                    {
                        break;
                    }
                    else //In jeder Zeile:
                    {
                        string[] nutzerdaten = zeile.Split(';');
                        if (nutzerdaten[0] == Benutzername) //Bei Zeile des momentanen Nutzers:
                        {
                            //Information aus dem File in Feldern speichern:
                            Passwort = nutzerdaten[1];
                            Geschlecht = Convert.ToChar(nutzerdaten[2]);
                            Alter = Convert.ToInt16(nutzerdaten[3]);
                            Vorname = nutzerdaten[4];
                            Nachname = nutzerdaten[5];
                        }
                    }
                }
            }
        }

        static public bool SucheUser(string suchName) //return: true = User existiert
        {
            string dateipfad = "Daten.txt";
            using (StreamReader reader = new StreamReader(dateipfad))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null) //Ende der Datei
                    {
                        return false; 
                    }
                    else //In jeder Zeile:
                    {
                        string zeile = reader.ReadLine();
                        string[] nutzerdaten = zeile.Split(';');
                        if (nutzerdaten[0] == suchName) //Zeile für gesuchten benutzernamen gefunden:
                        {
                            return true;
                        }
                    }
                }
            }
        }

    }
}
