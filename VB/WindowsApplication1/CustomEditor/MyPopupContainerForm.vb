Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Popup

Namespace WindowsApplication1
	Public Class MyPopupContainerForm
		Inherits PopupContainerForm
		Public myButton As New SimpleButton()
		Public Sub New(ByVal ownerEdit As PopupContainerEdit)
			MyBase.New(ownerEdit)
			myButton.Text = "Test"
			Controls.Add(myButton)
			AddHandler myButton.Click, AddressOf myButton_Click
		End Sub

		Private Sub myButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("Hello")
		End Sub

		Private _Indent As Integer = 5
		Public Property Indent() As Integer
			Get
				Return _Indent
			End Get
			Set(ByVal value As Integer)
				_Indent = value
			End Set
		End Property

		Private _CustomButtonSize As New Size(30, 30)
		Public Property CustomButtonSize() As Size
			Get
				Return _CustomButtonSize
			End Get
			Set(ByVal value As Size)
				_CustomButtonSize = value
			End Set
		End Property

		Protected Overrides Function CreateViewInfo() As PopupBaseFormViewInfo
			Return New MyCustomBlobPopupFormViewInfo(Me)
		End Function

		Protected Overrides Function CreatePainter() As PopupBaseFormPainter
			Return New MyPopupBaseSizeableFormPainter()
		End Function

		Protected Overrides Sub UpdateControlPositionsCore()
			MyBase.UpdateControlPositionsCore()
			UpdateMyButton()
		End Sub
		Private Sub UpdateMyButton()
			myButton.Location = New Point(ViewInfo.CloseButtonRect.Right + Indent, ViewInfo.SizeBarRect.Y + Indent)
			myButton.Width = CustomButtonSize.Width
			myButton.Height = CustomButtonSize.Height
		End Sub

	End Class
End Namespace