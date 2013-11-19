﻿Imports French_Conjugator.IrregularVerbsvb

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
            vbNewLine & "We are working on updates when ever we can and " & _
            vbNewLine & "appreciate any feed back. The list of available " & _
            vbNewLine & "irregular verbs is listed below: " & vbNewLine & vbNewLine
        Call currentIrregularVerbs()

    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As System.EventArgs) Handles mnuAbout.Click
        NavigationService.Navigate(New Uri("/AboutPage.xaml", UriKind.Relative))
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs) Handles btnRefresh.Click
        txtAppName.Text = "French Conjugator"
        txtVersion.Text = "1.1.4"
        txtCopyright.Text = "Copyright © MTN Software 2013"
        txtCompanyName.Text = "MTN Software"
    End Sub


    Private Sub btnHelp_Click(sender As Object, e As System.EventArgs) Handles btnHelp.Click
        MessageBox.Show("This shows information about the application.", "Help", MessageBoxButton.OK)
    End Sub


    Private Sub mnuReport_Click(sender As Object, e As System.EventArgs) Handles mnuReport.Click
        NavigationService.Navigate(New Uri("/ReportPage.xaml", UriKind.Relative))
    End Sub

    Private Sub mnuSuggest_Click(sender As Object, e As System.EventArgs) Handles mnuSuggest.Click
        NavigationService.Navigate(New Uri("/SuggestPage.xaml", UriKind.Relative))
    End Sub

    Private Sub currentIrregularVerbs()
        For intVerbDisp = 1 To 16
            txtDesc.Text = txtDesc.Text & Irregular.strIrregularVerbs(intVerbDisp) & vbNewLine & vbNewLine

        Next

    End Sub
End Class
