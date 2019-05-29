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
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<string> aktuelleBeitraege = new List<string>();
        Benutzer angemeldeterBenutzer;
        Datei BenutzerDatei = new Datei("../../../files/Nutzerdaten.txt");
        Datei BeitragsDatei = new Datei("../../../files/Beitragsdaten.txt");

        public Window2(Benutzer newUser)
        {
            List<string> Beitraege = Beitragx.BeitraegeFinden(newUser.Benutzername, BeitragsDatei.Pfad);
            foreach (string gesamtBeitrag in Beitraege)
            {
                string[] beitragsfelder = gesamtBeitrag.Split(';');
                string beitragsinhalt = beitragsfelder[2];
                aktuelleBeitraege.Add(beitragsinhalt);
            }

            angemeldeterBenutzer = newUser;
            InitializeComponent();
            Username_Label.Content = newUser.Benutzername;
            Beitraege_Listbox.ItemsSource = aktuelleBeitraege;
        }

        private void Posten_Btn_Click(object sender, RoutedEventArgs e)
        {
            string postInhalt = NeuPost_Textbox.Text;
            NeuPost_Textbox.Text = "";
            Beitragx neuerBeitrag = new Beitragx(BeitragsDatei, angemeldeterBenutzer.Benutzername, postInhalt);
            aktuelleBeitraege.Add(postInhalt);
            Beitraege_Listbox.Items.Refresh();

        }

        private void Privat_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
