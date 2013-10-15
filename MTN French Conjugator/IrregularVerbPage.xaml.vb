Imports French_Conjugator.VerbAndSubjectVals

'Yeah, I know this is a terrible way of achieving what I'm trying to, but I need to get this done.

Partial Public Class Page1
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    'These handle what happens when you tap an item from the menu.

    Private Sub listAller_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listAller.Tap
        intVerb = 1
        blnIsIrregular = True
    End Sub

    Private Sub listAppeller_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listAppeller.Tap
        intVerb = 2
        blnIsIrregular = True
    End Sub

    Private Sub listAvoir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listAvoir.Tap
        intVerb = 3
        blnIsIrregular = True
    End Sub

    Private Sub listConduire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listConduire.Tap
        intVerb = 4
        blnIsIrregular = True
    End Sub

    Private Sub listCourir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listCourir.Tap
        intVerb = 5
        blnIsIrregular = True
    End Sub

    Private Sub listDire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listDire.Tap
        intVerb = 6
        blnIsIrregular = True
    End Sub

    Private Sub listDormir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listDormir.Tap
        intVerb = 7
        blnIsIrregular = True
    End Sub

    Private Sub listEtre_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listEtre.Tap
        intVerb = 8
        blnIsIrregular = True
    End Sub

    Private Sub listFaire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listFaire.Tap
        intVerb = 9
        blnIsIrregular = True
    End Sub

    Private Sub listMettre_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listMettre.Tap
        intVerb = 10
        blnIsIrregular = True
    End Sub

    Private Sub listPartir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPartir.Tap
        intVerb = 11
        blnIsIrregular = True
    End Sub

    Private Sub listPreferer_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPreferer.Tap
        intVerb = 12
        blnIsIrregular = True
    End Sub

    Private Sub listPrendre_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listPrendre.Tap
        intVerb = 13
        blnIsIrregular = True
    End Sub

    Private Sub listRire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listRire.Tap
        intVerb = 14
        blnIsIrregular = True
    End Sub

    Private Sub listSortir_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listSortir.Tap
        intVerb = 15
        blnIsIrregular = True
    End Sub

    Private Sub listTraduire_Tap(sender As Object, e As System.Windows.Input.GestureEventArgs) Handles listTraduire.Tap
        intVerb = 16
        blnIsIrregular = True
    End Sub

    Private Sub btnUseRegularVerbs_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnUseRegularVerbs.Click
        blnIsIrregular = False
        intVerb = 0
        NavigationService.GoBack()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnBack.Click
        NavigationService.GoBack()
    End Sub
End Class
