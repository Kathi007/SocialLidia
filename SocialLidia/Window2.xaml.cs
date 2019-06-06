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
using System.IO;
using System.Diagnostics;

namespace SocialLidia
{
    /// <summary>
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<string> aktuelleBeitraege = new List<string>();
        Benutzer angemeldeterBenutzer;
        Datei BenutzerDatei = new Datei("../../../files/Nutzerdaten.txt"); //Speicherort der Benutzer
        Datei BeitragsDatei = new Datei("../../../files/Beitragsdaten.txt"); //Speicherort der Beiträge

        public Window2(Benutzer newUser) //On Load: Beiträge, Freunde anzeigen
        {
            //Beiträge anzeigen:

            //BeiträgeFinden Geht alle Beiträge durch, sucht nach username
            List<string> Beitraege = Beitragx.BeitraegeFinden(newUser.Benutzername, BeitragsDatei.Pfad);

            //Beitrags-Felder trennen, Inhalt nehmen & in Liste speichern
            foreach (string gesamtBeitrag in Beitraege)
            {
                string[] beitragsfelder = gesamtBeitrag.Split(';');
                string beitragsinhalt = beitragsfelder[2];
                aktuelleBeitraege.Add(beitragsinhalt);
            }
            Beitraege_Listbox.ItemsSource = aktuelleBeitraege; //Liste der Listox zuweisen

            //Benutzer speichern, Bneutzername anzeigen
            angemeldeterBenutzer = newUser;
            Username_Label.Content = newUser.Benutzername;

            //Freunde anzeigen:
            List<string> aktuelleFreunde = new List<string>();

            //Alle Benutzer aus File lesen
            //Alle Felder eines Users in 1 string
            string[] benutzerArray = File.ReadAllLines(BenutzerDatei.Pfad);

            //Benutzer durchgehen, Felder trennen, prüfen ob Freund, freunde in Liste speichern
            foreach (string Benutzer in benutzerArray)
            {
                string[] benutzerFelder = Benutzer.Split(';');
                string benutzername = benutzerFelder[0];
                //Prüfen, ob Benutzer ein Freund des angemeldeten Benutzers ist
                if (angemeldeterBenutzer.Freunde.Contains(benutzername))
                {
                    aktuelleFreunde.Add(benutzername);
                }
            }
            //Liste mit Benutzernamen der Freunde der zweiten ListBox zuweisen
            Freunde_ListBox.ItemsSource = aktuelleFreunde;

            //NeuesFenster Anzeigen:
            InitializeComponent();

        }

        private void Posten_Btn_Click(object sender, RoutedEventArgs e) //Öffentliches Posting erstellen
        {
            //UserInput speichern, Textbox für nächsten Beitrag leeren
            string postInhalt = NeuPost_Textbox.Text;
            NeuPost_Textbox.Text = "";

            //Neue Beitrag ins File schreiben
            Beitragx neuerBeitrag = new Beitragx(BeitragsDatei, angemeldeterBenutzer.Benutzername, postInhalt);

            //Beitragsliste aktualisieren, ListBox aktualisieren
            aktuelleBeitraege.Add(postInhalt);
            Beitraege_Listbox.Items.Refresh();

        }

        private void Privat_Btn_Click(object sender, RoutedEventArgs e) //Privates Posting erstellen
        {
            //UserInput speichern, Textbox für nächsten Beitrag leeren
            string postInhalt = NeuPost_Textbox.Text;
            NeuPost_Textbox.Text = "";

            //Neues Privatposting ins File schreiben: Private und öffentliche Beiträge werden im selben File gespeichert
            //Privatpostings haben eine Liste von Usern, die sie ansehen dürfen, Öffentliche nicht
            //Noch sind auch Privatbeiträge für alle sichtbar, das "Verstecken" implementieren wir nächste Woche
            Privat_Post neuerPrivatPost = new Privat_Post(BeitragsDatei, angemeldeterBenutzer.Benutzername, postInhalt, angemeldeterBenutzer.Freunde);

            //Beitragsliste aktualisieren, ListBox aktualisieren
            aktuelleBeitraege.Add(postInhalt);
            Beitraege_Listbox.Items.Refresh();
        }

        private void FreundAnzeigen_Btn_Click(object sender, RoutedEventArgs e) //Öffnen eines neuen Fensters mit Informationen zu ausgewähltem Freund
        {
            //Username des Freundes aus ListBox lesen, Daraus Benutzer erstellen
            string username_freund = Convert.ToString(Freunde_ListBox.SelectedValue);
            Benutzer freund = new Benutzer(BenutzerDatei, username_freund);

            //Neues Info-Fenster für Freund öffnen, aktuelles Fenster schließen
            Window3 fenster_FreundInfo = new Window3(freund);
            fenster_FreundInfo.Show();
            Close();
        }
    }
}
