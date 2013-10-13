
Imports Microsoft.Phone.Tasks

Public Class SendAnEmailCommand
	Implements ICommand
	Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
		Return True
	End Function

	Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

	Public Sub Execute(parameter As Object) Implements ICommand.Execute
		Dim emailTask As New EmailComposeTask()
		emailTask.[To] = "info@company.com"
		emailTask.Show()
	End Sub
End Class
