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

        //Für Benutzername, Passwort, Vorname, Nachname
        public void InfoAendern(char feld, string inhalt) //Welche Eigenschaft wird geändert, neue Infos
        {
            int feldIndex = 0;
            char.ToLower(feld);

            switch (feld)
            {
                case 'b':
                    feldIndex = 0;
                    return;

                case 'p':
                    feldIndex = 1;
                    return;

                case 'v':
                    feldIndex = 2;
                    return;

                case 'n':
                    feldIndex = 3;
                    return;
            }

            FileFunktionen.Aendern(Benutzername, feldIndex, inhalt);
            GetInformation();
        }

        //Für Geschlecht:
        private void InfoAendern(string inhalt) //Welche Eigenschaft wird geändert, neue Infos
        {
            FileFunktionen.Aendern(Benutzername, 3, inhalt);
        }

        //Für Alter:
        private void InfoAendern(int inhalt) //Welche Eigenschaft wird geändert, neue Infos
        {
            string stringInhalt = Convert.ToString(inhalt);
            FileFunktionen.Aendern(Benutzername, 4, stringInhalt);
        }

        private void GetInformation()
        {
            Console.WriteLine(Benutzername);
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
                        
                            //Information aus dem File in Feldern speichern:
                            Passwort = nutzerdaten[1];
                            Geschlecht = Convert.ToChar(nutzerdaten[2]);
                            Alter = Convert.ToInt16(nutzerdaten[3]);
                            Vorname = nutzerdaten[4];
                            Nachname = nutzerdaten[5];
                            break;
                     }
                    }
                }
            }
        }
    }
