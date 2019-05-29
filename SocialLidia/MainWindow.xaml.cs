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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SocialLidia
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Datei NutzerDatei = new Datei("../../../files/Nutzerdaten.txt");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Registrieren(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            Close();
        }

        private void Anmelden(object sender, RoutedEventArgs e)
        {
            string inputUserName = username_textbox.Text;
            string inputPasswort = passwort_textbox.Text;
            if (Benutzer.BenutzerExistiert(inputUserName, NutzerDatei))
            {
                string richtigesPasswort = NutzerDatei.Lesen(0, inputUserName, 1);
                if ( richtigesPasswort == inputPasswort)
                {
                    Benutzer aktuellerBenutzer = new Benutzer(NutzerDatei, inputUserName, inputPasswort);
                    Window2 Window2 = new Window2(aktuellerBenutzer);
                    Window2.Show();
                    Close();
                }
                else
                {
                    FehlerLabel.Content = "Falsches Passwort";
                    FehlerLabel.Opacity = 100;
                }
            }
            else //Fehlermeldung anzeigen
            {
                FehlerLabel.Content = "Benutzername nicht gefunden";
                FehlerLabel.Opacity = 100;
            }
        }
    }
}
