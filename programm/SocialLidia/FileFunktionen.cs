using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SocialLidia
{
    class FileFunktionen //Stellt Funktionen fürs Arbeiten mit Textfiles zur Verfügung
    {

        //Speicherung in Files
        static internal void Aendern(string benutzername, int index, string aenderung) //Ändert User Info: index = position der info in zeile
        {
            string dateipfad = "Daten.txt";
            string[] fileLines = System.IO.File.ReadAllLines(dateipfad);
            using (StreamWriter writer = new StreamWriter(dateipfad))
            {
                //Zeile finden und als String Array speichern
                int zeilenNummer = sucheUser(benutzername);
                string[] zeilenArray = getZeilenArray(fileLines, dateipfad, zeilenNummer);

                //Array ändern
                zeilenArray[index] = aenderung;

                foreach (string item in zeilenArray)
                {
                    Console.WriteLine(item);
                }

                //Geändertes Array in File speichern
                fileLines.Skip(zeilenNummer);
                string neuZeile = Convert.ToString(zeilenArray);
                Console.WriteLine(neuZeile);
            }
        }

        static internal string[] getZeilenArray (string[] text, string dateipfad, int zeilenNummer) //liefert gesuchte Zeile als String Array
        {
            using (StreamReader reader = new StreamReader(dateipfad))
            {
                text.Skip(zeilenNummer);
                string zeilenString = reader.ReadLine();
                string[] felderArray = zeilenString.Split(';');
                return felderArray;
            }
        }

        static private int sucheUser(string suchName) //liefert index der Zeile des Users -1: User existiert nicht
        {
            string dateipfad = "Daten.txt";
            using (StreamReader reader = new StreamReader(dateipfad))
            {
                int zeilenindex = 0;
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null) //Ende der Datei  
                    {
                        return -1;
                    }
                    else //In jeder Zeile:
                    {
                        string zeile = reader.ReadLine();
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