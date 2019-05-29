using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace SocialLidia
{
    public class Datei //Textdateien fürs schreiben & lesen
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

        //Löschen einer Zeile
        public void Loeschen(int zeilennummer)
        {
            //File-Inhalt als Array holen, zu Liste casten, Listenitem entfernen, zu Array casten:
            string[] fileLines = File.ReadAllLines(Pfad);
            List<string> fileLinesList = fileLines.ToList<string>();
            fileLinesList.RemoveAt(zeilennummer);
            fileLines = fileLinesList.ToArray();

            //Neuen Inhalt zurück ins File schreiben:
            using (StreamWriter writer = new StreamWriter(Pfad))
            {
                foreach (string item in fileLines)
                {
                    writer.WriteLine(item);
                }
            }
        }

        //Ändern eines bestimmten Felds
        public void Aendern(string bekanntesFeld, int bekanntesFeldNr, string neuerInhalt, int gesuchtesFeldNr) //Ändert User Info: feldindex = position der info in zeile
        {
            string[] fileLines = File.ReadAllLines(Pfad);

            //Zeile finden und als String Array speichern
            string[] zeileAlsArray = getZeile(bekanntesFeldNr, bekanntesFeld);
            string neuZeile = "";            
            
            //Array ändern
            zeileAlsArray[gesuchtesFeldNr] = neuerInhalt;

            //Erstellen der neuen String-Zeile aus Array
            foreach (string feld in zeileAlsArray)
            {
                neuZeile += $"{feld};"; 
            }
            
            //Anhängen der neuen Zeile an File
            Hinzufuegen(neuZeile);
        }

        //Lesen eines bestimmten Felds
        internal string Lesen(int bekanntesFeld, string bekannteInfo, int gesuchtesFeld)
        {
            string[] zeilenArray = getZeile(bekanntesFeld,bekannteInfo); //Ganze Zeile als Array
            return zeilenArray[gesuchtesFeld];
        }

        //Zeile als String Array holen
        internal string[] getZeile (int feldNr, string suchInfo) //zeilenNummer = Position der Zeile im File
        {
            //ZeilenNr mit feld suchen
            int zeilenNummer = SucheZeile(feldNr, suchInfo);
            //Fehler: Zeile nicht gefunden 
            if(zeilenNummer == -1)
            {
                return null;
            }

            //Zu gewünschter Zeile gehen, Zeile lesen, trennen, Array zurückgeben:
            string[] text = File.ReadAllLines(Pfad);
            string zeilenString = ""; //Inhalt der Zeile als String
            using (StreamReader reader = new StreamReader(Pfad))
            {
                text.Skip(zeilenNummer);
                zeilenString = reader.ReadLine();
            }

            string[] felderArray = zeilenString.Split(';');
            return felderArray; //Jedes Feld aus Textfile ist ein Element im Array
        }

        //Suchen einer Zeile, Rückgabe = ZeilenNr
        public int SucheZeile(int feldNr, string suchInfo)
        {
            int zeilenindex = 0;
            using (StreamReader reader = new StreamReader(Pfad))
            {
                //Durchgehen aller Zeilen:
                while (true)
                {
                    string zeile = reader.ReadLine();
                    if (zeile == null) //Ende der Datei  
                    {
                        return -1; //Zeile nicht gefunden!
                    }
                    else //In jeder Zeile:
                    {
                        string[] nutzerdaten = zeile.Split(';');
                        Debug.WriteLine(nutzerdaten[feldNr]);
                        if (nutzerdaten[feldNr] == suchInfo) //Zeile für gesuchten nutzer gefunden:
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