Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator

Namespace WindowsApplication1
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyPopupContainerEdit
		Inherits RepositoryItemPopupContainerEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyPopupContainerEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyPopupContainerEdit), GetType(RepositoryItemMyPopupContainerEdit), GetType(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property


	End Class
End Namespace
