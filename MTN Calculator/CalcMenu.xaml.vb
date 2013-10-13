Imports Microsoft.Phone.Tasks


Partial Public Class CalcMenu
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub





    Private Sub CalcMenu_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        If (chkMsgReview.IsChecked = True) Then
            Dim msgResult As MessageBoxResult
            msgResult = MessageBox.Show("Can you take a moment out of your time to rate this app? I really appreciate any feedback.", "Rate the App!", MessageBoxButton.OKCancel)
            If (msgResult = MessageBoxResult.OK) Then
                Dim marketplaceReviewTask As MarketplaceReviewTask = New MarketplaceReviewTask()

                marketplaceReviewTask.Show()

            Else

            End If

        Else

        End If


    End Sub

    Private Sub tileTrig_Tap(sender As System.Object, e As System.Windows.Input.GestureEventArgs) Handles tileTrig.Tap
        NavigationService.Navigate(New Uri("/trigCalc.xaml", UriKind.Relative))
    End Sub

    Private Sub tileBasicCalc_DoubleTap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles tileBasicCalc.DoubleTap
        NavigationService.Navigate(New Uri("/MainPage.xaml", UriKind.Relative))
    End Sub

    Private Sub tileBasicCalc_Tap(sender As System.Object, e As System.Windows.Input.GestureEventArgs) Handles tileBasicCalc.Tap
        NavigationService.Navigate(New Uri("/MainPage.xaml", UriKind.Relative))
    End Sub

    Private Sub tileMetro_DoubleTap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles tileMetro.DoubleTap
        NavigationService.Navigate(New Uri("/MetroCalc.xaml", UriKind.Relative))
    End Sub

    Private Sub tileMetro_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles tileMetro.Tap
        NavigationService.Navigate(New Uri("/MetroCalc.xaml", UriKind.Relative))
    End Sub

    Private Sub tileTrig_DoubleTap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles tileTrig.DoubleTap
        NavigationService.Navigate(New Uri("/trigCalc.xaml", UriKind.Relative))
    End Sub

    Private Sub btnSend_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSend.Click
        Dim emailcomposer = New EmailComposeTask() With { _
            .To = String.Concat("mailto:", "ThomasTNF@live.com"), _
            .Subject = "Bug Report", _
            .Body = txtReport.Text _
        }

        emailcomposer.Show()
    End Sub
End Class
