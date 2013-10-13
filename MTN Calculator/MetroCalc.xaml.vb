Partial Public Class MetroCalc
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private decFirstVal As Decimal
    Private decSecondVal As Decimal
    Private decCurrentVal As Decimal
    Private blnSubtract As Boolean
    Private blnAdd As Boolean
    Private blnMultiply As Boolean
    Private blnDiv As Boolean
    Private blnParse As Boolean
    Private decMem As Decimal
    Const decMaxVal As Decimal = Decimal.MaxValue
    Const decMinVal As Decimal = Decimal.MinValue


    Private Sub btnZero_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnZero.Click
        txtDisp.Text = txtDisp.Text & "0"
    End Sub

    Private Sub btnOne_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnOne.Click
        txtDisp.Text = txtDisp.Text & "1"
    End Sub

    Private Sub btnTwo_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnTwo.Click
        txtDisp.Text = txtDisp.Text & "2"
    End Sub

    Private Sub btnThree_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnThree.Click
        txtDisp.Text = txtDisp.Text & "3"
    End Sub

    Private Sub btnFour_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnFour.Click
        txtDisp.Text = txtDisp.Text & "4"
    End Sub

    Private Sub btnFive_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnFive.Click
        txtDisp.Text = txtDisp.Text & "5"
    End Sub

    Private Sub btnSix_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSix.Click
        txtDisp.Text = txtDisp.Text & "6"
    End Sub

    Private Sub btnSeven_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSeven.Click
        txtDisp.Text = txtDisp.Text & "7"
    End Sub

    Private Sub btnEight_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnEight.Click
        txtDisp.Text = txtDisp.Text & "8"
    End Sub

    Private Sub btnNine_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnNine.Click
        txtDisp.Text = txtDisp.Text & "9"
    End Sub

    Private Sub btnPoint_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnPoint.Click
        txtDisp.Text = txtDisp.Text & "."
    End Sub

    Private Sub MetroCalc_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        txtDisp.Text = String.Empty
        blnAdd = False
        blnSubtract = False
        blnMultiply = False
        blnDiv = False

    End Sub



    Private Sub btnCalc_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnCalc.Click
        Decimal.TryParse(txtDisp.Text, decSecondVal)
        If (((decFirstVal + decSecondVal) < decMaxVal) And ((decFirstVal * decSecondVal) < decMaxVal) And ((decFirstVal + decSecondVal) > decMinVal) And ((decFirstVal * decSecondVal) > decMinVal)) Then
            Dim decAdd As Decimal = (decFirstVal + decSecondVal)
            Dim decSub As Decimal = (decFirstVal - decSecondVal)
            Dim decMultiply As Decimal = (decFirstVal * decSecondVal)
            If (decSecondVal <> 0) Then

                Dim decDiv As Decimal = (decFirstVal / decSecondVal)


                If (blnAdd = True) Then
                    txtDisp.Text = decAdd.ToString()

                ElseIf (blnSubtract = True) Then
                    txtDisp.Text = decSub.ToString()

                ElseIf (blnDiv = True) Then
                    txtDisp.Text = decDiv.ToString()

                ElseIf (blnMultiply = True) Then
                    txtDisp.Text = decMultiply.ToString()

                Else
                    txtDisp.Text = decSecondVal.ToString()

                End If

            Else
                If (blnAdd = True) Then
                    txtDisp.Text = decAdd.ToString()

                ElseIf (blnSubtract = True) Then
                    txtDisp.Text = decSub.ToString()

                ElseIf (blnDiv = True) Then
                    txtDisp.Text = "You cannot divide by zero!"

                ElseIf (blnMultiply = True) Then
                    txtDisp.Text = decMultiply.ToString()

                Else
                    txtDisp.Text = decSecondVal.ToString()

                End If

            End If

        Else
            txtDisp.Text = "Error: Decimal Overflow"
        End If


    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnClear.Click
        txtDisp.Text = String.Empty
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnAdd.Click
        Decimal.TryParse(txtDisp.Text, decFirstVal)
        blnAdd = True
        blnSubtract = False
        txtDisp.Text = String.Empty
    End Sub

    Private Sub btnSubtract_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSubtract.Click
        Decimal.TryParse(txtDisp.Text, decFirstVal)
        blnSubtract = True
        blnAdd = False
        txtDisp.Text = String.Empty
    End Sub

    Private Sub btnMemAdd_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMemAdd.Click
        Decimal.TryParse(txtDisp.Text, decMem)
    End Sub

    Private Sub btnDelMem_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnDelMem.Click
        decMem = 0
    End Sub

    Private Sub btnMemDisp_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMemDisp.Click
        txtDisp.Text = decMem.ToString()
    End Sub

    Private Sub btnMultiply_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnMultiply.Click
        Decimal.TryParse(txtDisp.Text, decFirstVal)
        blnAdd = False
        blnSubtract = False
        blnDiv = False
        blnMultiply = True
        txtDisp.Text = String.Empty
    End Sub

    Private Sub btnDivide_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnDivide.Click
        Decimal.TryParse(txtDisp.Text, decFirstVal)
        blnAdd = False
        blnSubtract = False
        blnDiv = True
        blnMultiply = False
        txtDisp.Text = String.Empty
    End Sub


    Private Sub txtDisp_Tap(sender As System.Object, e As System.Windows.Input.GestureEventArgs) Handles txtDisp.Tap
        txtDisp.Text = String.Empty
    End Sub

    Private Sub btnSqrt_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnSqrt.Click
        Decimal.TryParse(txtDisp.Text, decCurrentVal)
        If (decCurrentVal < 0) Then
            txtDisp.Text = "Error: Not a real number"
        Else
            txtDisp.Text = Math.Sqrt(decCurrentVal)
        End If
    End Sub

    Private Sub btnNegative_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnNegative.Click

        If (Decimal.TryParse(txtDisp.Text, decCurrentVal)) Then
            txtDisp.Text = (0 - decCurrentVal)
        Else
            txtDisp.Text = txtDisp.Text
        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles btnDelete.Click
        Decimal.TryParse(txtDisp.Text, decCurrentVal)
        Dim intDispLength As Integer = txtDisp.Text.Length
        If (intDispLength > 1) Then
            Dim intDispCut As Integer = (intDispLength - 1)
            Dim strNewDisp As String = txtDisp.Text.Substring(0, intDispCut)
            txtDisp.Text = strNewDisp
        Else
            txtDisp.Text = "0"
        End If
    End Sub

    Private Sub imgButtonBack_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles imgButtonBack.Click
        NavigationService.GoBack()
    End Sub
End Class
