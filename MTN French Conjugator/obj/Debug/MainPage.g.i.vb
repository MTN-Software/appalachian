﻿#ExternalChecksum("C:\Users\Thomas\Documents\GitHub\appalachian\MTN French Conjugator\MainPage.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","7719360FE93A3CF80A726CBC435A79D0")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainPage
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents pageMain As Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents TitlePanel As System.Windows.Controls.StackPanel
    
    Friend WithEvents ApplicationTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents PageTitle As System.Windows.Controls.TextBlock
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents txtVerb As System.Windows.Controls.TextBox
    
    Friend WithEvents listSubject As System.Windows.Controls.ListBox
    
    Friend WithEvents listJe As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents listTu As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents ListElle As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents listNous As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents listVous As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents listElles As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents btnConjugate As System.Windows.Controls.Button
    
    Friend WithEvents listVerbTense As System.Windows.Controls.ListBox
    
    Friend WithEvents listPresent As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents listPast As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents ListImperfectPast As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents ListFuturProche As System.Windows.Controls.ListBoxItem
    
    Friend WithEvents txtSubjectLable As System.Windows.Controls.TextBlock
    
    Friend WithEvents txtVerbTenseLable As System.Windows.Controls.TextBlock
    
    Friend WithEvents txtCurrentVerb As System.Windows.Controls.TextBlock
    
    Friend WithEvents txtCurrentVerbLable As System.Windows.Controls.TextBlock
    
    Friend WithEvents appBar As Microsoft.Phone.Shell.ApplicationBar
    
    Friend WithEvents btnHelp As Microsoft.Phone.Shell.ApplicationBarIconButton
    
    Friend WithEvents btnRefresh As Microsoft.Phone.Shell.ApplicationBarIconButton
    
    Friend WithEvents mnuReport As Microsoft.Phone.Shell.ApplicationBarMenuItem
    
    Friend WithEvents mnuSuggest As Microsoft.Phone.Shell.ApplicationBarMenuItem
    
    Friend WithEvents mnuAbout As Microsoft.Phone.Shell.ApplicationBarMenuItem
    
    Friend WithEvents mnuCredits As Microsoft.Phone.Shell.ApplicationBarMenuItem
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/French%20Conjugator;component/MainPage.xaml", System.UriKind.Relative))
        Me.pageMain = CType(Me.FindName("pageMain"),Microsoft.Phone.Controls.PhoneApplicationPage)
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.TitlePanel = CType(Me.FindName("TitlePanel"),System.Windows.Controls.StackPanel)
        Me.ApplicationTitle = CType(Me.FindName("ApplicationTitle"),System.Windows.Controls.TextBlock)
        Me.PageTitle = CType(Me.FindName("PageTitle"),System.Windows.Controls.TextBlock)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.txtVerb = CType(Me.FindName("txtVerb"),System.Windows.Controls.TextBox)
        Me.listSubject = CType(Me.FindName("listSubject"),System.Windows.Controls.ListBox)
        Me.listJe = CType(Me.FindName("listJe"),System.Windows.Controls.ListBoxItem)
        Me.listTu = CType(Me.FindName("listTu"),System.Windows.Controls.ListBoxItem)
        Me.ListElle = CType(Me.FindName("ListElle"),System.Windows.Controls.ListBoxItem)
        Me.listNous = CType(Me.FindName("listNous"),System.Windows.Controls.ListBoxItem)
        Me.listVous = CType(Me.FindName("listVous"),System.Windows.Controls.ListBoxItem)
        Me.listElles = CType(Me.FindName("listElles"),System.Windows.Controls.ListBoxItem)
        Me.btnConjugate = CType(Me.FindName("btnConjugate"),System.Windows.Controls.Button)
        Me.listVerbTense = CType(Me.FindName("listVerbTense"),System.Windows.Controls.ListBox)
        Me.listPresent = CType(Me.FindName("listPresent"),System.Windows.Controls.ListBoxItem)
        Me.listPast = CType(Me.FindName("listPast"),System.Windows.Controls.ListBoxItem)
        Me.ListImperfectPast = CType(Me.FindName("ListImperfectPast"),System.Windows.Controls.ListBoxItem)
        Me.ListFuturProche = CType(Me.FindName("ListFuturProche"),System.Windows.Controls.ListBoxItem)
        Me.txtSubjectLable = CType(Me.FindName("txtSubjectLable"),System.Windows.Controls.TextBlock)
        Me.txtVerbTenseLable = CType(Me.FindName("txtVerbTenseLable"),System.Windows.Controls.TextBlock)
        Me.txtCurrentVerb = CType(Me.FindName("txtCurrentVerb"),System.Windows.Controls.TextBlock)
        Me.txtCurrentVerbLable = CType(Me.FindName("txtCurrentVerbLable"),System.Windows.Controls.TextBlock)
        Me.appBar = CType(Me.FindName("appBar"),Microsoft.Phone.Shell.ApplicationBar)
        Me.btnHelp = CType(Me.FindName("btnHelp"),Microsoft.Phone.Shell.ApplicationBarIconButton)
        Me.btnRefresh = CType(Me.FindName("btnRefresh"),Microsoft.Phone.Shell.ApplicationBarIconButton)
        Me.mnuReport = CType(Me.FindName("mnuReport"),Microsoft.Phone.Shell.ApplicationBarMenuItem)
        Me.mnuSuggest = CType(Me.FindName("mnuSuggest"),Microsoft.Phone.Shell.ApplicationBarMenuItem)
        Me.mnuAbout = CType(Me.FindName("mnuAbout"),Microsoft.Phone.Shell.ApplicationBarMenuItem)
        Me.mnuCredits = CType(Me.FindName("mnuCredits"),Microsoft.Phone.Shell.ApplicationBarMenuItem)
    End Sub
End Class

