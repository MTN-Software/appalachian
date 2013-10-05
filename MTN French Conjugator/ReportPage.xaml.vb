Imports Microsoft.Phone.Tasks

Partial Public Class ReportPage
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub txtReport_GotFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtReport.GotFocus
        txtReport.Text = String.Empty
    End Sub

    Private Sub btnSendReport_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSendReport.Click
        Dim emailcomposer = New EmailComposeTask() With { _
            .To = String.Concat("mailto:", "ThomasTNF@live.com"), _
            .Subject = "Bug Report", _
            .Body = txtReport.Text _
        }

        emailcomposer.Show()
    End Sub
End Class
