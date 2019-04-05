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
            Nutzer 
            Nutzer meinAccount = new Nutzer("kaddi07");
            Console.WriteLine("Alter:"+meinAccount.Alter.ToString());
            Console.WriteLine("Name: " + meinAccount.Vorname + " " + meinAccount.Nachname);
            

            Console.ReadKey();
        }
    }
}
