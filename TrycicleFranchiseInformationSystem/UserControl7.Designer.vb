﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryForms
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        PanelForms = New Panel()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.CornflowerBlue
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Black
        Button1.FlatAppearance.MouseOverBackColor = Color.Black
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(21, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(218, 54)
        Button1.TabIndex = 0
        Button1.Text = "Franchisee Form"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(259, 190)
        Button2.Name = "Button2"
        Button2.Size = New Size(0, 0)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = Color.CornflowerBlue
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Black
        Button3.FlatAppearance.MouseOverBackColor = Color.Black
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(21, 136)
        Button3.Name = "Button3"
        Button3.Size = New Size(218, 54)
        Button3.TabIndex = 2
        Button3.Text = "Franchise Form"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.AutoSize = True
        Button4.BackColor = Color.CornflowerBlue
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Black
        Button4.FlatAppearance.MouseOverBackColor = Color.Black
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(21, 213)
        Button4.Name = "Button4"
        Button4.Size = New Size(218, 54)
        Button4.TabIndex = 3
        Button4.Text = "Vehicle Form"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.AutoSize = True
        Button5.BackColor = Color.CornflowerBlue
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.Black
        Button5.FlatAppearance.MouseOverBackColor = Color.Black
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(21, 294)
        Button5.Name = "Button5"
        Button5.Size = New Size(218, 54)
        Button5.TabIndex = 4
        Button5.Text = "Regulatory Authority"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.AutoSize = True
        Button6.BackColor = Color.CornflowerBlue
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Black
        Button6.FlatAppearance.MouseOverBackColor = Color.Black
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(21, 368)
        Button6.Name = "Button6"
        Button6.Size = New Size(218, 54)
        Button6.TabIndex = 5
        Button6.Text = "Renewal Status"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' PanelForms
        ' 
        PanelForms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelForms.AutoSize = True
        PanelForms.BackColor = Color.RosyBrown
        PanelForms.Location = New Point(262, 3)
        PanelForms.Name = "PanelForms"
        PanelForms.Size = New Size(686, 555)
        PanelForms.TabIndex = 6
        ' 
        ' EntryForms
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.MistyRose
        Controls.Add(PanelForms)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "EntryForms"
        Size = New Size(949, 561)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PanelForms As Panel

End Class