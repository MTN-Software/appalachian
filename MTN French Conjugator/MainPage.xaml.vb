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

    Private strTextbox As String
    Private intSubject As Integer

    Private Sub MainPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        txtVerb.Text = "Enter Verb Here"
        txtCurrentVerb.Text = "Enter Verb"
    End Sub

    Private Sub radioPast_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles radioPast.Checked
        MessageBox.Show("This feature will be included in a future update.", "Coming Soon", MessageBoxButton.OK)
        radioPresent.IsChecked = True
    End Sub

    Private Sub txtVerb_GotFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtVerb.GotFocus
        txtVerb.Text = String.Empty
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
            Select Case intVerb
                Case 1
                    txtVerb.Text = Irregular.strAller(intSubject)

                Case 2
                    txtVerb.Text = Irregular.strAppeler(intSubject)

                Case 3
                    txtVerb.Text = Irregular.strAvoir(intSubject)

                Case 4
                    txtVerb.Text = Irregular.strConduire(intSubject)

                Case 5
                    txtVerb.Text = Irregular.strCourir(intSubject)

                Case 6
                    txtVerb.Text = Irregular.strDire(intSubject)

                Case 7
                    txtVerb.Text = Irregular.strDormir(intSubject)

                Case 8
                    txtVerb.Text = Irregular.strEtre(intSubject)

                Case 9
                    txtVerb.Text = Irregular.strFaire(intSubject)

                Case 10
                    txtVerb.Text = Irregular.strMettre(intSubject)

                Case 11
                    txtVerb.Text = Irregular.strPartir(intSubject)

                Case 12
                    txtVerb.Text = Irregular.strPrefere(intSubject)

                Case 13
                    txtVerb.Text = Irregular.strPrendre(intSubject)

                Case 14
                    txtVerb.Text = Irregular.strRire(intSubject)

                Case 15
                    txtVerb.Text = Irregular.strSortir(intSubject)

                Case 16
                    txtVerb.Text = Irregular.strTraduire(intSubject)

                Case Else
                    txtVerb.Text = "Error: No Verb Selected"

            End Select




        Else
            Dim intVerbLength As Integer = txtCurrentVerb.Text.Length
            Dim intVerbCut As Integer = intVerbLength - 2
            Dim strVerbType As String = txtCurrentVerb.Text.Substring(intVerbCut, 2)
            Dim strVerbStem As String = txtCurrentVerb.Text.Substring(0, intVerbCut)
            strRegularVerbEnding = strVerbType

            Select Case strVerbType
                Case "er"
                    txtVerb.Text = strVerbStem & Regular.strErVerb(intSubject)
                Case "re"
                    txtVerb.Text = strVerbStem & Regular.strReVerb(intSubject)
                Case "ir"
                    txtVerb.Text = strVerbStem & Regular.strIrVerb(intSubject)
                Case Else
                    txtVerb.Text = "Error: Unknown verb ending"
            End Select

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

    Private Sub listAller_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listAller.Tap
        intVerb = 1
        txtVerb.Text = Irregular.strIrregularVerbs(1)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(1)
        blnIsIrregular = True
    End Sub

    Private Sub listAppeller_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listAppeller.Tap
        intVerb = 2
        txtVerb.Text = Irregular.strIrregularVerbs(2)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(2)
        blnIsIrregular = True
    End Sub

    Private Sub listAvoir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listAvoir.Tap
        intVerb = 3
        txtVerb.Text = Irregular.strIrregularVerbs(3)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(3)
        blnIsIrregular = True
    End Sub

    Private Sub listConduire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listConduire.Tap
        intVerb = 4
        txtVerb.Text = Irregular.strIrregularVerbs(4)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(4)
        blnIsIrregular = True
    End Sub

    Private Sub listCourir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listCourir.Tap
        intVerb = 5
        txtVerb.Text = Irregular.strIrregularVerbs(5)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(5)
        blnIsIrregular = True
    End Sub

    Private Sub listDire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listDire.Tap
        intVerb = 6
        txtVerb.Text = Irregular.strIrregularVerbs(6)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(6)
        blnIsIrregular = True
    End Sub

    Private Sub listDormir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listDormir.Tap
        intVerb = 7
        txtVerb.Text = Irregular.strIrregularVerbs(7)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(7)
        blnIsIrregular = True
    End Sub

    Private Sub listEtre_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listEtre.Tap
        intVerb = 8
        txtVerb.Text = Irregular.strIrregularVerbs(8)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(8)
        blnIsIrregular = True
    End Sub

    Private Sub listFaire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listFaire.Tap
        intVerb = 9
        txtVerb.Text = Irregular.strIrregularVerbs(9)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(9)
        blnIsIrregular = True
    End Sub

    Private Sub listMettre_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listMettre.Tap
        intVerb = 10
        txtVerb.Text = Irregular.strIrregularVerbs(10)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(10)
        blnIsIrregular = True
    End Sub

    Private Sub listPartir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPartir.Tap
        intVerb = 11
        txtVerb.Text = Irregular.strIrregularVerbs(11)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(11)
        blnIsIrregular = True
    End Sub

    Private Sub listPreferer_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPreferer.Tap
        intVerb = 12
        txtVerb.Text = Irregular.strIrregularVerbs(12)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(12)
        blnIsIrregular = True
    End Sub

    Private Sub listPrendre_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPrendre.Tap
        intVerb = 13
        txtVerb.Text = Irregular.strIrregularVerbs(13)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(13)
        blnIsIrregular = True
    End Sub

    Private Sub listRire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listRire.Tap
        intVerb = 14
        txtVerb.Text = Irregular.strIrregularVerbs(14)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(14)
        blnIsIrregular = True
    End Sub

    Private Sub listSortir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listSortir.Tap
        intVerb = 15
        txtVerb.Text = Irregular.strIrregularVerbs(15)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(15)
        blnIsIrregular = True
    End Sub

    Private Sub listTraduire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listTraduire.Tap
        intVerb = 16
        txtVerb.Text = Irregular.strIrregularVerbs(16)
        txtCurrentVerb.Text = Irregular.strIrregularVerbs(16)
        blnIsIrregular = True
    End Sub


    Private Sub chkIsIrregular_Click(sender As Object, e As System.Windows.RoutedEventArgs) Handles chkIsIrregular.Click
        If (chkIsIrregular.IsChecked = True) Then
            listIrregularVerbs.IsEnabled = True
        Else
            listIrregularVerbs.IsEnabled = False
            blnIsIrregular = False

        End If
    End Sub

    Private Sub txtVerb_LostFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtVerb.LostFocus
        strTextbox = txtVerb.Text
        Select Case strTextbox.Length
            Case 0 To 2
                txtCurrentVerb.Text = "None"
            Case Else
                txtCurrentVerb.Text = strTextbox
        End Select

    End Sub
End Class
