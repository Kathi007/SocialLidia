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
            Nutzer meinAccount = new Nutzer("kathi07");
            Console.WriteLine("Alter:"+meinAccount.Alter.ToString());
            Console.WriteLine("Name: " + meinAccount.Vorname + " " + meinAccount.Nachname);

            meinAccount.InfoAendern('v', "kathi08");
            Console.WriteLine(meinAccount.Vorname);

            Console.ReadKey();
        }
    }
}
