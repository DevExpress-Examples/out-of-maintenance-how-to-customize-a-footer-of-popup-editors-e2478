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

	Public Class MyPopupContainerEdit
		Inherits PopupContainerEdit
		Shared Sub New()
			RepositoryItemMyPopupContainerEdit.Register()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyPopupContainerEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyPopupContainerEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyPopupContainerEdit)
			End Get
		End Property

		Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			Return New MyPopupContainerForm(Me)
		End Function
	End Class
End Namespace