using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SocialLidia
{
    class Datei //Textdateien fürs schreiben & lesen
    {
        public string Pfad;

        //Konstruktor
        public Datei(string dateipfad)
        {
            Pfad = dateipfad;
        }
         
        //Hinzufügen einer Zeile
        public void Hinzufuegen(string ZeilenInhalt)
        {
            //String ZeilenInhalt wird ungeändert ans Ende des Files geschrieben
            string[] fileLines = File.ReadAllLines(Pfad);
            using (StreamWriter writer = new StreamWriter(Pfad))
            {
                foreach (string item in fileLines)
                {
                    writer.WriteLine(item);
                }
                writer.WriteLine(ZeilenInhalt);
            }
        }

        //Ändern eines bestimmten Felds
        public void Aendern(string benutzername, int feldindex, string neuerInhalt) //Ändert User Info: feldindex = position der info in zeile
        {
            string[] fileLines = File.ReadAllLines(Pfad);

            //Zeile finden und als String Array speichern
            string[] zeileAlsArray = getUserZeile(benutzername);
            string neuZeile = "";            
            
            //Array ändern
            zeileAlsArray[feldindex] = neuerInhalt;

            //Erstellen der neuen String-Zeile aus Array
            foreach (string feld in zeileAlsArray)
            {
                neuZeile += $"{feld};"; 
            }
            
            //Anhängen der neuen Zeile an File
            Hinzufuegen(neuZeile);
        }

        //Lesen eines bestimmten Felds
        internal string Lesen(string benutzername, int feldindex)
        {
            string[] zeilenArray = getUserZeile(benutzername);
            return zeilenArray[feldindex];
        }

        //Zeile als String Array holen
        internal string[] getUserZeile (string suchName) //zeilenNummer = Position der Zeile im File
        {
            //Ganzen Inhalt des Files in Array speichern
            string[] text = File.ReadAllLines(Pfad);

            //Zeile des Users mit benutzernamen suchen
            int zeilenNummer = sucheUser(suchName);

            //Fehler: Username nicht gefunden
            if(zeilenNummer == -1)
            {
                return null;
            }

            //Zu gewünschter Zeile gehen, Zeile lesen, trennen, Array zurückgeben:
            using (StreamReader reader = new StreamReader(Pfad))
            {
                text.Skip(zeilenNummer);
                string zeilenString = reader.ReadLine();
                string[] felderArray = zeilenString.Split(';');
                return felderArray; //Jedes Feld aus Textfile ist ein Element im Array
            }
        }

        //Position der Zeile eines Users suchen 
        static private int sucheUser(string suchName) //suchName = Benutzername | return -1 = kein Nutzer gefunden
        {
            string dateipfad = "Daten.txt";
            using (StreamReader reader = new StreamReader(dateipfad))
            {
                int zeilenindex = 0;
                while (true)
                {
                    string zeile = reader.ReadLine();
                    if (zeile == null) //Ende der Datei  
                    {
                        return -1;  
                    }
                    else //In jeder Zeile:
                    {
                        string[] nutzerdaten = zeile.Split(';');
                        if (nutzerdaten[0] == suchName) //Zeile für gesuchten benutzernamen gefunden:
                        {
                            return zeilenindex;
                        }
                    }
                    zeilenindex++; 
                }
            }
        }
    }
}