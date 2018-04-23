Imports Microsoft.VisualBasic
Imports System
Namespace DynamicPanels
	Partial Public Class UserControl1
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.labelControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(109, 99)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "User Control #1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(5, 23)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(25, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Label"
			' 
			' UserControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.groupControl1)
			Me.Name = "UserControl1"
			Me.Size = New System.Drawing.Size(109, 99)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace
