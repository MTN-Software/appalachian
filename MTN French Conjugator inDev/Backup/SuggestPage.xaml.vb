Imports Microsoft.Phone.Tasks

Partial Public Class SuggestPage
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnSendSuggestion_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSendSuggestion.Click
        Dim emailcomposer = New EmailComposeTask() With { _
            .To = String.Concat("mailto:", "ThomasTNF@live.com"), _
            .Subject = "Feature Suggestion", _
            .Body = txtSuggestion.Text _
        }

        emailcomposer.Show()
    End Sub
End Class
