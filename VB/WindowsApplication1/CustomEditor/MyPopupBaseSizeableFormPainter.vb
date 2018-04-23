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
	Public Class MyPopupBaseSizeableFormPainter
		Inherits PopupBaseSizeableFormPainter
		Protected Overrides Sub DrawContent(ByVal info As PopupFormGraphicsInfoArgs)
			MyBase.DrawContent(info)
			Dim vi As MyCustomBlobPopupFormViewInfo = TryCast(info.ViewInfo, MyCustomBlobPopupFormViewInfo)
			Dim form As MyPopupContainerForm = TryCast(vi.Form, MyPopupContainerForm)
			Dim rect As Rectangle = form.myButton.Bounds
			rect.X = rect.Right
			rect.Width = vi.SizeGripRect.X - rect.X
			info.Graphics.DrawString("MyPopupBaseSizeableFormPainter", info.ViewInfo.Appearance.GetFont(), Brushes.Red, rect)
		End Sub

	End Class
End Namespace
