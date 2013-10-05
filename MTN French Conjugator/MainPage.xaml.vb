Imports System.String

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub radioPast_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles radioPast.Checked
        MessageBox.Show("This feature will be included in a future update.", "Coming Soon", MessageBoxButton.OK)
        radioPresent.IsChecked = True
    End Sub

    Private Sub txtVerb_GotFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtVerb.GotFocus
        txtVerb.Text = String.Empty
    End Sub

    Private Sub btnEr_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnEr.Click
        Dim intStrLength As Integer = txtVerb.Text.Length
        Dim intStrChop As Integer = intStrLength - 2
        Dim strVerb As String = txtVerb.Text.Substring(0, intStrChop)

        If (listJe.IsSelected = True) Then
            txtVerb.Text = strVerb & "e"
        End If

        If (listTu.IsSelected = True) Then
            txtVerb.Text = strVerb & "es"
        End If

        If (ListElle.IsSelected = True) Then
            txtVerb.Text = strVerb & "e"
        End If

        If (listNous.IsSelected = True) Then
            txtVerb.Text = strVerb & "ons"
        End If

        If (listVous.IsSelected = True) Then
            txtVerb.Text = strVerb & "ez"
        End If

        If (listElles.IsSelected = True) Then
            txtVerb.Text = strVerb & "ent"
        End If
    End Sub


   

    Private Sub btnRe_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnRe.Click
        Dim intStrLength As Integer = txtVerb.Text.Length
        Dim intStrChop As Integer = intStrLength - 2
        Dim strVerb As String = txtVerb.Text.Substring(0, intStrChop)

        If (listJe.IsSelected = True) Then
            txtVerb.Text = strVerb & "s"
        End If

        If (listTu.IsSelected = True) Then
            txtVerb.Text = strVerb & "s"
        End If

        If (ListElle.IsSelected = True) Then
            txtVerb.Text = strVerb
        End If

        If (listNous.IsSelected = True) Then
            txtVerb.Text = strVerb & "ons"
        End If

        If (listVous.IsSelected = True) Then
            txtVerb.Text = strVerb & "ez"
        End If

        If (listElles.IsSelected = True) Then
            txtVerb.Text = strVerb & "ent"
        End If
    End Sub

    Private Sub btnIr_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnIr.Click
        Dim intStrLength As Integer = txtVerb.Text.Length
        Dim intStrChop As Integer = intStrLength - 2
        Dim strVerb As String = txtVerb.Text.Substring(0, intStrChop)

        If (listJe.IsSelected = True) Then
            txtVerb.Text = strVerb & "is"
        End If

        If (listTu.IsSelected = True) Then
            txtVerb.Text = strVerb & "is"
        End If

        If (ListElle.IsSelected = True) Then
            txtVerb.Text = strVerb & "it"
        End If

        If (listNous.IsSelected = True) Then
            txtVerb.Text = strVerb & "issons"
        End If

        If (listVous.IsSelected = True) Then
            txtVerb.Text = strVerb & "issez"
        End If

        If (listElles.IsSelected = True) Then
            txtVerb.Text = strVerb & "issent"
        End If
    End Sub

    Private Sub btnIrregular_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnIrregular.Click
        'MessageBox.Show("This feature, like a few others, will be included in future updates", "Coming Soon", MessageBoxButton.OK)
        NavigationService.Navigate(New Uri("/IrregularVerbPage.xaml", UriKind.Relative))
    End Sub

    Public Sub mnuAbout_Click(sender As Object, e As System.EventArgs) Handles mnuAbout.Click
        NavigationService.Navigate(New Uri("/AboutPage.xaml", UriKind.Relative))
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs) Handles btnRefresh.Click

    End Sub


    Public Sub btnHelp_Click(sender As Object, e As System.EventArgs) Handles btnHelp.Click
        MessageBox.Show("Enter in a french verb, select the subject, then what type of verb it is.", "Help", MessageBoxButton.OK)
    End Sub


    Public Sub mnuReport_Click(sender As Object, e As System.EventArgs) Handles mnuReport.Click
        NavigationService.Navigate(New Uri("/ReportPage.xaml", UriKind.Relative))
    End Sub

    Private Sub mnuSuggest_Click(sender As Object, e As System.EventArgs) Handles mnuSuggest.Click
        NavigationService.Navigate(New Uri("/SuggestPage.xaml", UriKind.Relative))
    End Sub

    Private Sub erOnClick(ByVal sender as Object, ByVal e as System.Windows.RoutedEventArgs)
    	'TODO: Add event handler implementation here.
		
    End Sub
End Class
