Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.myPopupContainerEdit1 = New WindowsApplication1.MyPopupContainerEdit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.myPopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.simpleButton1)
			Me.popupContainerControl1.Location = New System.Drawing.Point(12, 60)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(200, 100)
			Me.popupContainerControl1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.simpleButton1.Location = New System.Drawing.Point(0, 0)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(200, 100)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Hello"
			' 
			' myPopupContainerEdit1
			' 
			Me.myPopupContainerEdit1.Location = New System.Drawing.Point(12, 12)
			Me.myPopupContainerEdit1.Name = "myPopupContainerEdit1"
			Me.myPopupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.myPopupContainerEdit1.Properties.PopupControl = Me.popupContainerControl1
			Me.myPopupContainerEdit1.Size = New System.Drawing.Size(457, 20)
			Me.myPopupContainerEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(494, 311)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.myPopupContainerEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			CType(Me.myPopupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myPopupContainerEdit1 As MyPopupContainerEdit
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

