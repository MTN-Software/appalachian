
Imports Telerik.Windows.Controls

Namespace ViewModels
	Public Class DataItemViewModel
		Inherits ViewModelBase
		Private m_imageSource As Uri
		Private m_imageThumbnailSource As Uri
		Private m_title As String
		Private m_information As String
		Private m_group As String

		''' <summary>
		''' Gets or sets the image source.
		''' </summary>
		Public Property ImageSource() As Uri
			Get
				Return Me.m_imageSource
			End Get
			Set(value As Uri)
				If Me.m_imageSource <> value Then
					Me.m_imageSource = value
					Me.OnPropertyChanged("ImageSource")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets the image thumbnail source.
		''' </summary>
		Public Property ImageThumbnailSource() As Uri
			Get
				Return Me.m_imageThumbnailSource
			End Get
			Set(value As Uri)
				If Me.m_imageThumbnailSource <> value Then
					Me.m_imageThumbnailSource = value
					Me.OnPropertyChanged("ImageThumbnailSource")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets the title.
		''' </summary>
		Public Property Title() As String
			Get
				Return Me.m_title
			End Get
			Set(value As String)
				If Me.m_title <> value Then
					Me.m_title = value
					Me.OnPropertyChanged("Title")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets the information.
		''' </summary>
		Public Property Information() As String
			Get
				Return Me.m_information
			End Get
			Set(value As String)
				If Me.m_information <> value Then
					Me.m_information = value
					Me.OnPropertyChanged("Information")
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets the group.
		''' </summary>
		Public Property Group() As String
			Get
				Return Me.m_group
			End Get
			Set(value As String)
				If Me.m_group <> value Then
					Me.m_group = value
					Me.OnPropertyChanged("Group")
				End If
			End Set
		End Property

		''' <summary>
		''' Returns a <see cref="System.String"/> that represents this instance.
		''' </summary>
		''' <returns>
		''' A <see cref="System.String"/> that represents this instance.
		''' </returns>
		Public Overrides Function ToString() As String
			Return Me.m_title
		End Function

		''' <summary> 
		''' Determines whether the specified <see cref="System.Object"/> is equal to this instance. 
		''' </summary> 
		''' <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param> 
		''' <returns> 
		'''   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.  

		''' </returns> 
		Public Overrides Function Equals(obj As Object) As Boolean
			Dim typedObject As DataItemViewModel = TryCast(obj, DataItemViewModel)
			If typedObject Is Nothing Then
				Return False
			End If
			Return Me.Title = typedObject.Title AndAlso Me.Information = typedObject.Information
		End Function

		''' <summary> 
		''' Returns a hash code for this instance. 
		''' </summary> 
		''' <returns> 
		''' A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.   

		''' </returns> 
		Public Overrides Function GetHashCode() As Integer
			Return Me.Title.GetHashCode() Xor Me.Information.GetHashCode()
		End Function
	End Class
End Namespace
