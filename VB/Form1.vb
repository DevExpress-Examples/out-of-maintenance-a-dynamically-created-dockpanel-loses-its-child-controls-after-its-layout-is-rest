Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking

Namespace DynamicPanels
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			CreateDockPanels()
			RestoreSettings()
		End Sub

		Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			SaveSettings()
		End Sub

		Private Sub CreateDockPanels()
			Dim panel1 As DockPanel = dockManager1.AddPanel(DockingStyle.Left)
			panel1.Text = "Panel 1"
			panel1.ID = New Guid("{00000000-0000-0000-0000-000000000001}")
			panel1.Controls.Add(New UserControl1())

			Dim panel2 As DockPanel = dockManager1.AddPanel(DockingStyle.Right)
			panel2.Text = "Panel 2"
			panel2.ID = New Guid("{00000000-0000-0000-0000-000000000002}")
			panel2.Controls.Add(New UserControl2())
		End Sub

		Private Const DockingLayoutFile As String = "DockingLayoutFile.xml"

		Private Sub RestoreSettings()
			If System.IO.File.Exists(DockingLayoutFile) Then
				dockManager1.RestoreLayoutFromXml(DockingLayoutFile)
			End If
		End Sub

		Private Sub SaveSettings()
			dockManager1.SaveLayoutToXml(DockingLayoutFile)
		End Sub
	End Class
End Namespace