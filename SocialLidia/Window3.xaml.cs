using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SocialLidia
{
    /// <summary>
    /// Interaktionslogik für Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        List<string> aktuelleBeitraege = new List<string>();
        Benutzer Freund;
        Datei BenutzerDatei = new Datei("../../../files/Nutzerdaten.txt");
        Datei BeitragsDatei = new Datei("../../../files/Beitragsdaten.txt");

        public Window3(Benutzer newUser)
        {
            InitializeComponent();

            //Beiträge des Freundes anzeigen
            List<string> Beitraege = Beitragx.BeitraegeFinden(newUser.Benutzername, BeitragsDatei.Pfad);
            foreach (string gesamtBeitrag in Beitraege)
            {
                string[] beitragsfelder = gesamtBeitrag.Split(';');

                string beitragsinhalt = beitragsfelder[2];
                aktuelleBeitraege.Add(beitragsinhalt);
            }

            Freund = newUser;
            InitializeComponent();
            Username_Label.Content = newUser.Benutzername;
            Beitraege_Listbox_Friend.ItemsSource = aktuelleBeitraege;
        }
    }
}
