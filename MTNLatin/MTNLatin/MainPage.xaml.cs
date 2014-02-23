using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MTNLatin.Resources;

namespace MTNLatin
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Variables
        private int conjugateN, person, princP;
        private string verbEnd;
        private bool getPPartSucceeded;
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnI_Click(object sender, RoutedEventArgs e)
        {
            person = 0;
            lblCurrentPerson.Text = "Person: I";
        }

        private void btnYouS_Click(object sender, RoutedEventArgs e)
        {
            person = 1;
            lblCurrentPerson.Text = "Person: You";
        }

        private void btnIt_Click(object sender, RoutedEventArgs e)
        {
            person = 2;
            lblCurrentPerson.Text = "Person: She, He, It";
        }

        private void btnWe_Click(object sender, RoutedEventArgs e)
        {
            person = 3;
            lblCurrentPerson.Text = "Person: We";
        }

        private void btnYouP_Click(object sender, RoutedEventArgs e)
        {
            person = 4;
            lblCurrentPerson.Text = "Person: You (Plural)";
        }

        private void btnThey_Click(object sender, RoutedEventArgs e)
        {
            person = 5;
            lblCurrentPerson.Text = "Person: They";
        }

        private string findVerbEnding()
        {
            string verb = lblCurrentVerb.Text;
            try
            {
                string ppart = verb.Substring(verb.Length - 3, 3);
                getPPartSucceeded = true;
                return ppart;
            }
            catch (Exception)
            {
                Exception up = new Exception();
                getPPartSucceeded = false;
                MessageBox.Show("ERROR");
                throw up;       // huehuehue
            }
        }

        private void btnConj_Click(object sender, RoutedEventArgs e)
        {
            findVerbEnding();
            if (getPPartSucceeded)
            {
                string conjugate = conj();
                txtVerb.Text = conjugate;
            }
            else if (!getPPartSucceeded)
            {
                lblCurrentVerb.Text = "None";
                txtVerb.Text = "Error: Invalid Input (Probably not supported, will most-likely be soon)";
            }
        }

        private void txtVerb_LostFocus(object sender, RoutedEventArgs e)
        {
            lblCurrentVerb.Text = txtVerb.Text;
        }

        private string conj()
        {
            Verbs verbs = new Verbs();
            verbEnd = findVerbEnding();
            /*switch (verbEnd)
            {
                case "are":
                    conjugateN = 0;
                    break;
                case "ere":
                    conjugateN = 1;     // It could be two, but it's 2:16am, cut me some slack
                    break;
                case "ire":
                    conjugateN = 3;
                    break;
                default:
                    break;
            }*/
            verbs.initialize(conjugateN, verbEnd, lblCurrentVerb.Text, lblCurrentVerb.Text, princP);
            string people = verbs.searchArray(person);
            string princeVal = verbs.searchMultiArray(conjugateN, princP);
            return verbs.conjugate(people, princeVal);
        }

        private void btnFirstP_Click(object sender, RoutedEventArgs e)
        {
            lblPrincipalPart.Text = "PP: 1";
            princP = 0;
        }

        private void btnSecondP_Click(object sender, RoutedEventArgs e)
        {
            lblPrincipalPart.Text = "PP: 2";
            princP = 1;
        }

        private void btnThirdP_Click(object sender, RoutedEventArgs e)
        {
            lblPrincipalPart.Text = "PP: 3";
            princP = 2;
        }

        private void btnFourthP_Click(object sender, RoutedEventArgs e)
        {
            lblPrincipalPart.Text = "PP: 4";
            princP = 3;
        }

        private void txtVerb_GotFocus(object sender, RoutedEventArgs e)
        {
            txtVerb.Text = string.Empty;
        }

        private void btnFirstConj_Click(object sender, RoutedEventArgs e)
        {
            lblConjNum.Text = "Conj: I";
            conjugateN = 0;
        }

        private void btnSecondConj_Click(object sender, RoutedEventArgs e)
        {
            lblConjNum.Text = "Conj: II";
            conjugateN = 1;
        }

        private void btnThirdConj_Click(object sender, RoutedEventArgs e)
        {
            lblConjNum.Text = "Conj: III";
            conjugateN = 2;
        }
        private void btnThirdIOConj_Click(object sender, RoutedEventArgs e)
        {
            lblConjNum.Text = "Conj: III-io";
            conjugateN = 3;
        }

        private void btnFourthConj_Click(object sender, RoutedEventArgs e)
        {
            lblConjNum.Text = "Conj: IV";
            conjugateN = 4;
        }

        private void txtVerb_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                pageMain.Focus();
            }

        }

        // Sample code for building a localized ApplicationBar
        /* private void BuildLocalizedApplicationBar()
         {
             // Set the page's ApplicationBar to a new instance of ApplicationBar.
             ApplicationBar = new ApplicationBar();

             // Create a new button and set the text value to the localized string from AppResources.
             ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
             appBarButton.Text = AppResources.AppBarButtonText;
             ApplicationBar.Buttons.Add(appBarButton);

             // Create a new menu item with the localized string from AppResources.
             ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
             ApplicationBar.MenuItems.Add(appBarMenuItem);
         }*/


    }
}