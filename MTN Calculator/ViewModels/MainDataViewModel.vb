
Imports System.Collections.ObjectModel
Imports Telerik.Windows.Controls

Namespace ViewModels
	Public Class MainDataViewModel
		Inherits ViewModelBase
		Private m_items As ObservableCollection(Of DataItemViewModel)

		''' <summary>
		''' Initializes the items.
		''' </summary>
		Private Sub InitializeItems()
			Me.m_items = New ObservableCollection(Of DataItemViewModel)()
			For i As Integer = 1 To 7
				Me.m_items.Add(New DataItemViewModel() With { _
				 .ImageSource = New Uri("Images/Frame.png", UriKind.RelativeOrAbsolute), _
				 .ImageThumbnailSource = New Uri("Images/FrameThumbnail.png", UriKind.RelativeOrAbsolute), _
				 .Title = ("Title " & i), _
				 .Information = ("Information " & i), _
				 .Group = If((i Mod 2 = 0), "EVEN", "ODD") _
				})
			Next
		End Sub

		''' <summary>
		''' A collection for <see cref="DataItemViewModel"/> objects.
		''' </summary>
		Public Property Items() As ObservableCollection(Of DataItemViewModel)
			Get
				If Me.m_items Is Nothing Then
					Me.InitializeItems()
				End If
				Return Me.m_items
			End Get
			Private Set(value As ObservableCollection(Of DataItemViewModel))
				Me.m_items = value
			End Set
		End Property
	End Class
End Namespace
