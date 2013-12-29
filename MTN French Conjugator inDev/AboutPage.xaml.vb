Imports French_Conjugator.IrregularVerbsvb

Partial Public Class AboutPage
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private intLengthOfArray As Integer
    Private strListOfVerbs As String

    Private Sub AboutPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        intLengthOfArray = Irregular.strIrregularVerbs.Length
        txtAppName.Text = "French Conjugator"
        txtVersion.Text = "1.1.9"
        txtCopyright.Text = "Copyright © MTN Software 2013"
        txtCompanyName.Text = "MTN Software"
        txtDesc.Text = "Thank you for downloading our French Conjugator. " & _
              "We are working on updates when ever we can and " & _
              "appreciate any feed back. The list of available " & _
              "irregular verbs is listed below: " & vbNewLine & vbNewLine
        Call currentIrregularVerbs()
        txtDesc.Text = txtDesc.Text & strListOfVerbs

    End Sub

    
    Private Sub currentIrregularVerbs()
        Array.Sort(Irregular.strIrregularVerbs)
        strListOfVerbs = ""
        Try
            For intVerbDisp = 0 To Irregular.strIrregularVerbs.Length

                strListOfVerbs = strListOfVerbs & Irregular.strIrregularVerbs(intVerbDisp) & vbNewLine

            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
