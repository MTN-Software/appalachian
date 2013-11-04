Imports Spanish_Conjugator.RegularVerbs


Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()
    End Sub
    Private strCurrentVerb As String


    Private Sub btnConjugate_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnConjugate.Click
        Dim intVerbLength As Integer = txtCurrentVerb.Text.Length
        Dim intVerbCut As Integer = intVerbLength - 2
        Dim strVerbType As String = txtCurrentVerb.Text.Substring(intVerbCut, 2)
        Dim strVerbStem As String = txtCurrentVerb.Text.Substring(0, intVerbCut)

        Select Case strVerbType
            Case "er"
                txtVerb.Text = strVerbStem & PresentRegular.strERVerbs(intSubject)
            Case "ar"
                txtVerb.Text = strVerbStem & PresentRegular.strARVerbs(intSubject)
            Case "ir"
                txtVerb.Text = strVerbStem & PresentRegular.strIRVerbs(intSubject)
            Case Else
                txtVerb.Text = "Error: Unknown verb ending"
        End Select
    End Sub

    Private Sub listYo_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listYo.Tap
        intSubject = 0
        txtSubjectLable.Text = "Subject:  Yo"
    End Sub

    Private Sub listTu_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listTu.Tap
        intSubject = 1
        txtSubjectLable.Text = "Subject:  Tú"
    End Sub

    Private Sub ListEl_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles ListEl.Tap
        intSubject = 2
        txtSubjectLable.Text = "Subject:  Él/Ella/Usted"
    End Sub

    Private Sub listNosostros_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listNosostros.Tap
        intSubject = 3
        txtSubjectLable.Text = "Subject:  Nosotros"
    End Sub

    Private Sub listVosotros_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listVosotros.Tap
        intSubject = 4
        txtSubjectLable.Text = "Subject:  Vosotros"
    End Sub

    Private Sub listEllos_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listEllos.Tap
        intSubject = 5
        txtSubjectLable.Text = "Subject:  Ellos/Ellas/Uds"
    End Sub

    Private Sub txtVerb_LostFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtVerb.LostFocus
        strCurrentVerb = txtVerb.Text
        txtCurrentVerb.Text = strCurrentVerb

    End Sub

    Private Sub txtVerb_GotFocus(sender As Object, e As System.Windows.RoutedEventArgs) Handles txtVerb.GotFocus
        txtVerb.Text = String.Empty

    End Sub
End Class
