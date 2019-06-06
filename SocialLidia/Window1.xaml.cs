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
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Datei NutzerDatei = new Datei("../../../files/Nutzerdaten.txt");

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string InputUsername = Username_Textbox.Text;
            string InputPasswort = Passwort_Textbox.Text;
            int InputAlter = Convert.ToInt16(Alter_Textbox.Text);

            //Geschlecht auslesen:
            char InputGeschlecht = ' ';
            if (Convert.ToBoolean(m_RadioButton.IsChecked))
            {
                InputGeschlecht = 'm';
            }
            else if (Convert.ToBoolean(w_Radiobutton.IsChecked))
            {
                InputGeschlecht = 'w';
            }

            //Eingaben prüfen´:
            if (InputUsername != "")
            {
                if(InputPasswort != "")
                {
                    if (Benutzer.BenutzerExistiert(InputUsername, NutzerDatei) == false) //Username noch nicht vergeben:
                    {
                        if(InputAlter >= 10 && InputAlter <= 100)
                        {
                            //Neuen Benutzer erstellen:
                            Benutzer aktuellerBenutzer = new Benutzer(NutzerDatei, InputUsername, InputPasswort);
                            aktuellerBenutzer.Geschlecht = InputGeschlecht;
                            aktuellerBenutzer.Alter = Convert.ToString(InputAlter);
                            aktuellerBenutzer.Vorname = Vorname_Textbox1.Text;
                            aktuellerBenutzer.Nachname = Nachname_Textbox.Text;

                            //Startseiten Fenster öffnen:
                            Window2 Window2 = new Window2(aktuellerBenutzer);
                            Window2.Show();
                            Close();
                        }
                        else
                        {
                            Fehler_Label.Content = "Bitte geben Sie ein Alter zwischen 10 und 100 ein.";
                        }
                    }
                    else
                    {
                        Fehler_Label.Content = "Dieser Username existiert bereits. Bitte wählen Sie einen neuen.";
                    }
                }
                else
                {
                    Fehler_Label.Content = "Bitte geben Sie ein Passwort ein!";
                }
            }
            else
            {
                Fehler_Label.Content = "Bitte geben Sie einen Usernamen ein!";
            }
        }

        //Passwort verstecken:
        private void Passwort_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string alterInhalt = Passwort_Textbox.Text;
            string neuerInhalt = "";
            foreach (char buchstabe in alterInhalt)
            {
                neuerInhalt += "*";
            }
            Passwort_Textbox.Text = neuerInhalt;
        }
    }
}
