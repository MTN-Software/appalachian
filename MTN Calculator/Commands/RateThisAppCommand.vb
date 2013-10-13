
Imports Microsoft.Phone.Tasks

Public Class RateThisAppCommand
	Implements ICommand
	Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
		Return True
	End Function

	Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

	Public Sub Execute(parameter As Object)  Implements ICommand.Execute
		Dim reviewTask As New MarketplaceReviewTask()
		reviewTask.Show()
	End Sub
End Class
