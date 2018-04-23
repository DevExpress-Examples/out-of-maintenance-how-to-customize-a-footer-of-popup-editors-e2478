Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Popup

Namespace WindowsApplication1
	Public Class MyCustomBlobPopupFormViewInfo
		Inherits CustomBlobPopupFormViewInfo
		Public Sub New(ByVal form As PopupBaseForm)
			MyBase.New(form)

		End Sub
		Private Function GetMyCustomButtonHeight() As Integer
			Dim form As MyPopupContainerForm = TryCast(Me.Form, MyPopupContainerForm)
			Return form.CustomButtonSize.Height + 2* form.Indent
		End Function


		Protected Overrides Function CalcSizeBarContentHeight() As Integer
			Return Math.Max(MyBase.CalcSizeBarContentHeight(), GetMyCustomButtonHeight())
		End Function


	End Class
End Namespace
