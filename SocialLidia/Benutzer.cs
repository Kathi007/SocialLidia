using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SocialLidia
{
    public class Benutzer
    {
        public Datei Benutzerdatei; //Speicherort des Nutzers

        static List<int> IDs = new List<int>(); //Already used IDs


        public string Benutzername { get; }

        public string Passwort
        {
            get
            {
                return InfoLesen('p');
            }

            set
            {
                InfoAendern('p', value);
            }
        }

        public char Geschlecht
        {
            get
            {
                string geschlechtString = InfoLesen('g');
                return Convert.ToChar(geschlechtString);
            }

            set
            {
                InfoAendern('g', Convert.ToString(value));
            }
        }

        public string Alter
        {
            get
            {
                string alterString = InfoLesen('a');
                return alterString;
            }

            set
            {
                InfoAendern('a', value);
            }
        }

        public string Vorname
        {
            get
            {
                return InfoLesen('v');
            }

            set
            {
                InfoAendern('v', value);
            }
        }

        public string Nachname
        {
            get
            {
                return InfoLesen('n');
            }

            set
            {
                InfoAendern('n', value);
            }
        }

        //Konstruktor
        public Benutzer(Datei newDatei, string newBenutzername, string newPasswort)
        {
            Benutzerdatei = newDatei;
            Benutzername = newBenutzername;
            string neueZeile = $"{Benutzername};{newPasswort};LEER;0;LEER;LEER;";
            Benutzerdatei.Hinzufuegen(neueZeile);
        }

        //Prüfen, ob User existiert
        public static bool BenutzerExistiert(string benutzername, Datei speicherort)
        {
            string[] benutzerZeile = speicherort.getZeile(0, benutzername);
            if (benutzerZeile == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //User löschen
        public void NutzerLoeschen()
        {
            int nutzerZeileNr = Benutzerdatei.SucheZeile(0, Benutzername);
            Benutzerdatei.Loeschen(nutzerZeileNr);
        }


        //Bestimmtes Feld des Users ändern:
        private void InfoAendern(char feld, string inhalt) //Welche Eigenschaft wird geändert, neue Infos
        {
            char.ToLower(feld);

            switch (feld)
            {
                case 'p':
                    Benutzerdatei.Aendern(Benutzername, 0, inhalt, 1);
                    return;

                case 'g':
                    Benutzerdatei.Aendern(Benutzername,0,inhalt,2);
                    return;

                case 'a':
                    Benutzerdatei.Aendern(Benutzername, 0, inhalt, 3);
                    return;

                case 'v':
                    Benutzerdatei.Aendern(Benutzername, 0, inhalt, 4);
                    return;

                case 'n':
                    Benutzerdatei.Aendern(Benutzername, 0, inhalt, 5);
                    return;
            }
        }

        //Bestimmtes Feld des Users lesen:
        internal string InfoLesen(char feld)
        {
            char.ToLower(feld);

            switch (feld)
            {
                case 'p':
                    return Benutzerdatei.Lesen(0, Benutzername, 1);

                case 'g':
                    return Benutzerdatei.Lesen(0, Benutzername, 2);

                case 'a':
                    return Benutzerdatei.Lesen(0, Benutzername, 3);

                case 'v':
                    return Benutzerdatei.Lesen(0, Benutzername, 4);

                case 'n':
                    return Benutzerdatei.Lesen(0, Benutzername, 5);
            }
            return "Fehler: Feld nicht vorhanden. Felder: p,g,a,v,n";
        }
    }
}
