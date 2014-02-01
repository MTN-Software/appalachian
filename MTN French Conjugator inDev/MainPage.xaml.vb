Imports System.String
Imports French_Conjugator.VerbAndSubjectVals
Imports French_Conjugator.IrregularVerbsvb
Imports French_Conjugator.RegularVerbs
Imports French_Conjugator.VerbTenses
Imports Microsoft.Phone.Tasks
Imports Coding4Fun.Toolkit.Controls



Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    Private getIPVerbCong As IPVerbs

    Dim msgHelp As New MessagePrompt


    Private Sub MainPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        intTense = 1
        intSubject = 0
        txtVerb.Text = "Enter Verb Here"
        txtCurrentVerb.Text = "Enter Verb"
        blnIsIrregular = False
    End Sub


    Private Sub txtVerb_GotFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtVerb.GotFocus
        txtVerb.Text = String.Empty
    End Sub

    Public Sub mnuAbout_Click(sender As Object, e As System.EventArgs) Handles mnuAbout.Click
        NavigationService.Navigate(New Uri("/AboutPage.xaml", UriKind.Relative))
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs) Handles btnRefresh.Click
        intTense = 1
        intSubject = 0
        txtVerb.Text = "Enter Verb Here"
        txtCurrentVerb.Text = "Enter Verb"
        blnIsIrregular = False

    End Sub


    Public Sub btnHelp_Click(sender As Object, e As System.EventArgs) Handles btnHelp.Click
        msgHelp.Title = "Help"
        msgHelp.Message = "Enter a verb then select the tense and subject, then press the conjugate button."
        msgHelp.Show()
    End Sub


    Public Sub mnuReport_Click(sender As Object, e As System.EventArgs) Handles mnuReport.Click
        NavigationService.Navigate(New Uri("/ReportPage.xaml", UriKind.Relative))
    End Sub

    Private Sub mnuSuggest_Click(sender As Object, e As System.EventArgs) Handles mnuSuggest.Click
        NavigationService.Navigate(New Uri("/SuggestPage.xaml", UriKind.Relative))
    End Sub




    Private Sub btnConjugate_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnConjugate.Click
        strVerb = txtVerb.Text
        strCurrentVerb = txtCurrentVerb.Text
        getIrregular()
        getPCExceptions()
        If (intTense = 1) Then
            Call Present_Conj()
            txtVerb.Text = strVerb
        ElseIf (intTense = 2) Then
            Call PC_Conj()
            txtVerb.Text = strVerb
        ElseIf (intTense = 3) Then
            Call IPVerbs.ImperfectPast_Conj(intVerb)
            txtVerb.Text = strVerb
        End If

    End Sub

    Private Sub listJe_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listJe.Tap
        intSubject = 0
        txtSubjectLable.Text = "Subject:  Je"
    End Sub

    Private Sub listTu_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listTu.Tap
        intSubject = 1
        txtSubjectLable.Text = "Subject:  Tu"
    End Sub

    Private Sub ListElle_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles ListElle.Tap
        intSubject = 2
        txtSubjectLable.Text = "Subject:  Elle/Il/On"
    End Sub

    Private Sub listNous_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listNous.Tap
        intSubject = 3
        txtSubjectLable.Text = "Subject:  Nous"
    End Sub

    Private Sub listVous_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listVous.Tap
        intSubject = 4
        txtSubjectLable.Text = "Subject:  Vous"
    End Sub

    Private Sub listElles_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listElles.Tap
        intSubject = 5
        txtSubjectLable.Text = "Subject:  Elles/Ils"
    End Sub

    Private Sub getIrregular()
        Dim strTempVerb As String = txtCurrentVerb.Text.ToLower
        For intIndex = 1 To 49
            If (strTempVerb = Irregular.strIrregularVerbs(intIndex)) Then
                intVerb = intIndex
                blnIsIrregular = True
                Exit For
            Else
                blnIsIrregular = False
            End If
        Next

    End Sub

    Private Sub getPCExceptions()
        Try


            Dim strTempVerb As String = txtCurrentVerb.Text.ToLower
            For intIndex = 0 To 43
                If (strTempVerb = PCVerbs.strListOfIrregularPC(intIndex)) Then
                    intPCIrregularVerb = intIndex
                    blnIsIrregularInPC = True
                    Exit For
                Else
                    blnIsIrregularInPC = False
                End If
            Next

            For intIndexes = 0 To 17
                If (strTempVerb = PCVerbs.strEtreInPC(intIndexes)) Then
                    intPCEtreVerb = intIndexes
                    blnUseEtreInPC = True
                    Exit For
                Else
                    blnUseEtreInPC = False
                End If
            Next

        Catch ex As Exception
            Dim dlgResponce As MessageBoxResult
            dlgResponce = MessageBox.Show("Would you like to report this?" & vbNewLine & ex.Message, _
                            "Err... This is embarrassing.", MessageBoxButton.OKCancel)

            If (dlgResponce = MessageBoxResult.OK) Then
                Dim emailcomposer = New EmailComposeTask() With { _
                .To = String.Concat("mailto:", "ThomasTNF@live.com"), _
                .Subject = "French Conj App Error Report", _
                .Body = ex.InnerException.ToString() _
                }
                emailcomposer.Show()
            Else

            End If
        End Try
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

    Private Sub listPresent_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPresent.Tap
        txtVerbTenseLable.Text = "Verb Tense :  Present"
        intTense = 1
    End Sub

    Private Sub listPast_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPast.Tap
        txtVerbTenseLable.Text = "Verb Tense :  Past"
        intTense = 2
    End Sub

    Private Sub ListImperfectPast_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles ListImperfectPast.Tap
        txtVerbTenseLable.Text = "Verb Tense :  Imp. Past"
        intTense = 3
    End Sub

    Private Sub ListFuturProche_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles ListFuturProche.Tap
        txtVerbTenseLable.Text = "Verb Tense :  Futur Proche"
        intTense = 4
    End Sub


    Private Sub txtVerb_KeyDown(sender As System.Object, e As System.Windows.Input.KeyEventArgs) Handles txtVerb.KeyDown
        If (e.Key = Key.Enter) Then
            pageMain.Focus()


        End If
    End Sub

    Private Sub mnuCredits_Click(sender As Object, e As EventArgs)
        Dim msgCredits As New MessagePrompt
        Dim brushColor As Brush
        'msgCredits.Background.Opacity() = 0.6
        msgCredits.Title = "credits"
        msgCredits.Message = "MTN Software would like to thank //insert names"
        msgCredits.Opacity = 0.6

        msgCredits.Show()

    End Sub
End Class
