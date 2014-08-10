using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.UI.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MTN_French
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void applyInfo(string[] conjugations)
        {
            GridViewHeaderItem[] gridblocks = { txtJe, txtTu, txtElle, txtNous, txtVous, txtElles };
            for(int i = 0; i < conjugations.Length; i ++)
            {
                gridblocks[i].Content = conjugations[i];
            }
        }
        private void btnConjugate_Click(object sender, RoutedEventArgs e)
        {
            Verbs verb = new Verbs();
            txtVerbType.Content = verb.DetermineVerbType(txtVerb.Text);
            
            switch (verb.DetermineVerbType(txtVerb.Text))
            {
                case "irregular":
                    IrregularVerbs ir = new IrregularVerbs();
                    applyInfo(ir.ConjugateAll(txtVerb.Text));
                    break;
                case "regular":
                    RegularVerbs regular = new RegularVerbs();
                    applyInfo(regular.ConjugateAll(txtVerb.Text));
                    break;
                default:
                    MessageDialog msg = new MessageDialog("Looks like and error occured", "Well this is not good...");
                    msg.Commands.Add(new UICommand("Send Report"));
                    msg.Options = MessageDialogOptions.None;
                    msg.Commands.Add(new UICommand("Cancel"));
                    msg.ShowAsync();
                    
                    break;
            }
        }
    }
}
