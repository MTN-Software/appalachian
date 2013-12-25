Imports French_Conjugator.IrregularVerbsvb

Partial Public Class AboutPage
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AboutPage_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        txtAppName.Text = "French Conjugator"
        txtVersion.Text = "1.1.4"
        txtCopyright.Text = "Copyright © MTN Software 2013"
        txtCompanyName.Text = "MTN Software"
        txtDesc.Text = "Thank you for downloading our French Conjugator." & _
              "We are working on updates when ever we can and " & _
              "appreciate any feed back. The list of available " & _
              "irregular verbs is listed below: " & vbNewLine & vbNewLine
        Call currentIrregularVerbs()

    End Sub

    
    Private Sub currentIrregularVerbs()
        Array.Sort(Irregular.strIrregularVerbs)
        For intVerbDisp = 1 To 27

            txtDesc.Text = txtDesc.Text & Irregular.strIrregularVerbs(intVerbDisp) & vbNewLine & vbNewLine

        Next

    End Sub
End Class
