using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLidia
{
    interface IBeitrag
    {
        Nutzerdatei Ersteller { get; set; }
        string Inhalt { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Testfall:
            Datei SocialLidiaUsers = new Datei("Daten.txt");
            Nutzerdatei meinAccount = new Nutzerdatei("kathi07", "passwort123", SocialLidiaUsers);
            meinAccount.Vorname = "Kathi";
            meinAccount.Nachname = "Schrenk";
            meinAccount.Alter = 17;
            meinAccount.Geschlecht = 'w';

            Console.WriteLine(meinAccount.AlleInfosLesen());

            Console.ReadKey();
        }
    }
}
