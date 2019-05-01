using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLidia
{
    interface IBeitrag
    {
        Nutzer Ersteller { get; set; }
        string Inhalt { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Testfall:
            Datei SocialLidiaUsers = new Datei("Daten.txt");
            Nutzer meinAccount = new Nutzer("kathi07", "passwort123", SocialLidiaUsers);
            meinAccount.Vorname = "Kathi";
            meinAccount.Nachname = "Schrenk";
            meinAccount.Alter = 17;
            meinAccount.Geschlecht = 'w';

            Console.WriteLine(meinAccount.AlleInfosLesen());

            Console.ReadKey();
        }
    }
}
