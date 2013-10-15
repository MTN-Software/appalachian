Imports System.String
Imports French_Conjugator.VerbAndSubjectVals
Imports French_Conjugator.IrregularVerbsvb
Imports French_Conjugator.RegularVerbs





Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private intSubject As Integer

    Private Sub radioPast_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles radioPast.Checked
        MessageBox.Show("This feature will be included in a future update.", "Coming Soon", MessageBoxButton.OK)
        radioPresent.IsChecked = True
    End Sub

    Private Sub txtVerb_GotFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtVerb.GotFocus
        txtVerb.Text = String.Empty
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


    Private Sub btnConjugate_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnConjugate.Click
        If (blnIsIrregular = True) Then
            If (intVerb = 1) Then
                txtVerb.Text = Irregular.strAller(intSubject)

            ElseIf (intVerb = 2) Then
                txtVerb.Text = Irregular.strAppeler(intSubject)

            ElseIf (intVerb = 3) Then
                txtVerb.Text = Irregular.strAvoir(intSubject)

            ElseIf (intVerb = 4) Then
                txtVerb.Text = Irregular.strConduire(intSubject)

            ElseIf (intVerb = 5) Then
                txtVerb.Text = Irregular.strCourir(intSubject)

            ElseIf (intVerb = 6) Then
                txtVerb.Text = Irregular.strDire(intSubject)

            ElseIf (intVerb = 7) Then
                txtVerb.Text = Irregular.strDormir(intSubject)

            ElseIf (intVerb = 8) Then
                txtVerb.Text = Irregular.strEtre(intSubject)

            ElseIf (intVerb = 9) Then
                txtVerb.Text = Irregular.strFaire(intSubject)

            ElseIf (intVerb = 10) Then
                txtVerb.Text = Irregular.strMettre(intSubject)

            ElseIf (intVerb = 11) Then
                txtVerb.Text = Irregular.strPartir(intSubject)

            ElseIf (intVerb = 12) Then
                txtVerb.Text = Irregular.strPrefere(intSubject)

            ElseIf (intVerb = 13) Then
                txtVerb.Text = Irregular.strPrendre(intSubject)

            ElseIf (intVerb = 14) Then
                txtVerb.Text = Irregular.strRire(intSubject)

            ElseIf (intVerb = 15) Then
                txtVerb.Text = Irregular.strSortir(intSubject)

            ElseIf (intVerb = 16) Then
                txtVerb.Text = Irregular.strTraduire(intSubject)

            Else
                txtVerb.Text = "Error: No Verb Selected"
            End If


        Else
            Dim intVerbLength As Integer = txtVerb.Text.Length
            Dim intVerbCut As Integer = intVerbLength - 2
            Dim strVerbType As String = txtVerb.Text.Substring(intVerbCut, 2)
            Dim strVerbStem As String = txtVerb.Text.Substring(0, intVerbCut)
            strRegularVerbEnding = strVerbType

            If (strVerbType = "er") Then
                txtVerb.Text = strVerbStem & Regular.strErVerb(intSubject)

            ElseIf (strVerbType = "re") Then
                txtVerb.Text = strVerbStem & Regular.strReVerb(intSubject)

            ElseIf (strVerbType = "ir") Then
                txtVerb.Text = strVerbStem & Regular.strIrVerb(intSubject)

            Else
                txtVerb.Text = "Error: Unknown verb ending"
            End If
        End If


    End Sub

    Private Sub listJe_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listJe.Tap
        intSubject = 0
    End Sub

    Private Sub listTu_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listTu.Tap
        intSubject = 1
    End Sub

    Private Sub ListElle_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles ListElle.Tap
        intSubject = 2
    End Sub

    Private Sub listNous_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listNous.Tap
        intSubject = 3
    End Sub

    Private Sub listVous_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listVous.Tap
        intSubject = 4
    End Sub

    Private Sub listElles_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listElles.Tap
        intSubject = 5
    End Sub

    Private Sub MainPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        If (blnIsIrregular = True) Then
            If (intVerb = 1) Then
                txtVerb.Text = Irregular.strAller(6)

            ElseIf (intVerb = 2) Then
                txtVerb.Text = Irregular.strAppeler(6)

            ElseIf (intVerb = 3) Then
                txtVerb.Text = Irregular.strAvoir(6)

            ElseIf (intVerb = 4) Then
                txtVerb.Text = Irregular.strConduire(6)

            ElseIf (intVerb = 5) Then
                txtVerb.Text = Irregular.strCourir(6)

            ElseIf (intVerb = 6) Then
                txtVerb.Text = Irregular.strDire(6)

            ElseIf (intVerb = 7) Then
                txtVerb.Text = Irregular.strDormir(6)

            ElseIf (intVerb = 8) Then
                txtVerb.Text = Irregular.strEtre(6)

            ElseIf (intVerb = 9) Then
                txtVerb.Text = Irregular.strFaire(6)

            ElseIf (intVerb = 10) Then
                txtVerb.Text = Irregular.strMettre(6)

            ElseIf (intVerb = 11) Then
                txtVerb.Text = Irregular.strPartir(6)

            ElseIf (intVerb = 12) Then
                txtVerb.Text = Irregular.strPrefere(6)

            ElseIf (intVerb = 13) Then
                txtVerb.Text = Irregular.strPrendre(6)

            ElseIf (intVerb = 14) Then
                txtVerb.Text = Irregular.strRire(6)

            ElseIf (intVerb = 15) Then
                txtVerb.Text = Irregular.strSortir(6)

            ElseIf (intVerb = 16) Then
                txtVerb.Text = Irregular.strTraduire(6)

            Else
                txtVerb.Text = "Error: No Verb Selected"

            End If
        Else
            txtVerb.Text = "Enter Verb Here"
        End If

    End Sub
End Class
