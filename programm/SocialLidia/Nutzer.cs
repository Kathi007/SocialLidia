using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SocialLidia
{
    class Nutzer //Felderdaten lesen/schreiben
    {
        public string Benutzername;
        public Datei Nutzerdatei;

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

        public int Alter
        {
            get
            {
                string alterString = InfoLesen('a');
                return Convert.ToInt16(alterString);
            }

            set
            {
                InfoAendern('a', Convert.ToString(value));
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
        public Nutzer(string newBenutzername, string newPasswort, Datei newNutzerDatei) //Benutzername, Passwort & File
        {
            Benutzername = newBenutzername;
            Nutzerdatei = newNutzerDatei;
            string neueZeile = $"{Benutzername};{newPasswort};LEER;0;LEER;LEER;";
            Nutzerdatei.Hinzufuegen(neueZeile);
        }


        //Bestimmtes Feld des Users ändern:
        private void InfoAendern(char feld, string inhalt) //Welche Eigenschaft wird geändert, neue Infos
        {
            char.ToLower(feld);

            switch (feld)
            {
                case 'b':
                    Nutzerdatei.Aendern(Benutzername, 0, inhalt);
                    return;

                case 'p':
                    Nutzerdatei.Aendern(Benutzername, 1, inhalt);
                    return;

                case 'g':
                    Nutzerdatei.Aendern(Benutzername, 2, inhalt);
                    return;

                case 'a':
                    Nutzerdatei.Aendern(Benutzername, 3, inhalt);
                    return;

                case 'v':
                    Nutzerdatei.Aendern(Benutzername, 4, inhalt);
                    return;

                case 'n':
                    Nutzerdatei.Aendern(Benutzername, 5, inhalt);
                    return;
            }
        }


        //Bestimmtes Feld des Users lesen:
        internal string InfoLesen(char feld)
        {
            char.ToLower(feld);

            switch (feld)
            {
                case 'b':
                    return Nutzerdatei.Lesen(Benutzername,0);

                case 'p':
                    return Nutzerdatei.Lesen(Benutzername, 1);

                case 'g':
                    return Nutzerdatei.Lesen(Benutzername, 2);

                case 'a':
                    return Nutzerdatei.Lesen(Benutzername, 3);

                case 'v':
                    return Nutzerdatei.Lesen(Benutzername, 4);

                case 'n':
                    return Nutzerdatei.Lesen(Benutzername, 5);
            }
            return "Fehler: Feld nicht vorhanden. Felder: b,p,g,a,v,n";
        }


        //Alle Felder des Users lesen
        internal string AlleInfosLesen()
        {
            string bezeichnung = "";
            if(InfoLesen('g') == "w")
            {
                bezeichnung = "Die Nutzerin";
            }
            else
            {
                bezeichnung = "Der Nutzer";
            }
            string returnString = $"{bezeichnung} {Benutzername} heißt {Vorname} {Nachname} und ist {Alter} Jahre alt. {bezeichnung} hat das Passwort {Passwort}";
            return returnString;
        }
    }
}
