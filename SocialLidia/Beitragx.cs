using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SocialLidia
{
    class Beitragx
    {
        public Datei BeitragsDatei;
        static List<int> benutzteIDs = new List<int>();
        private string ID;

        public string Ersteller
        {
            get
            {
                return InfoLesen('e');
            }

            set
            {
                InfoAendern('e', value);
            }
        }

        public string Text
        {
            get
            {
                return InfoLesen('t');
            }

            set
            {
                InfoAendern('t', value);
            }
        }

        public string Likes
        {
            get
            {
                return InfoLesen('l');
            }

            set
            {
                InfoAendern('l', value);
            }
        }

        public string Kommentare
        {
            get
            {
                return InfoLesen('k');
            }

            set
            {
                InfoAendern('k', value);
            }
        }

        //Konstruktor: neuer Beitrag
        public Beitragx(Datei newDatei, string erstellerName, string newText)
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
            string neueZeile = $"{newID};{erstellerName};{newText};LEER;0;LEER;LEER;";
            BeitragsDatei.Hinzufuegen(neueZeile);
        }

        //Alle Beiträge für bestimmten User finden
        static public List<string> BeitraegeFinden(string nutzername, string beitragsDateiPfad)
        {
            List<string> nutzerBeiträge = new List<string>();
            string[] alleBeitraege = File.ReadAllLines(beitragsDateiPfad);
            foreach (string beitrag in alleBeitraege)
            {
                string[] beitragsFelder = beitrag.Split(';');
                string beitragsersteller = beitragsFelder[1];
                Debug.WriteLine(beitragsersteller);
                if (beitragsersteller == nutzername)
                {
                    nutzerBeiträge.Add(beitrag);
                }
            }
            return nutzerBeiträge;
        }

        //Beitrag Löschen
        public void BeitragLoeschen()
        {
            int beitragsZeileNr = BeitragsDatei.SucheZeile(0, Convert.ToString(ID));
            BeitragsDatei.Loeschen(beitragsZeileNr);
        }

        //Bestimmtes Feld des Beitrags ändern:
        private void InfoAendern(char feld, string neuInhalt) //Welche Eigenschaft wird geändert, neue Infos
        {
            char.ToLower(feld);

            switch (feld)
            {
                case 'e':
                    BeitragsDatei.Aendern(ID, 0, neuInhalt, 1);
                    return;

                case 't':
                    BeitragsDatei.Aendern(ID, 0, neuInhalt, 2);
                    return;

                case 'l':
                    BeitragsDatei.Aendern(ID, 0, neuInhalt, 3);
                    return;

                case 'k':
                    BeitragsDatei.Aendern(ID, 0, neuInhalt, 4);
                    return;
            }
        }


        //Bestimmtes Feld des Beitrags lesen:
        internal string InfoLesen(char feld)
        {
            char.ToLower(feld);

            switch (feld)
            {
                case 'e':
                    return BeitragsDatei.Lesen(0, ID, 1);

                case 't':
                    return BeitragsDatei.Lesen(0, ID, 2);

                case 'l':
                    return BeitragsDatei.Lesen(0, ID, 3);

                case 'k':
                    return BeitragsDatei.Lesen(0, ID, 4);
            }
            return "Fehler: Feld nicht vorhanden. Felder: e,t,l,k";
        }
    }
}
