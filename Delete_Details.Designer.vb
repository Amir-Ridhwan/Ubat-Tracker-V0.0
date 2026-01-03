<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox_Delete = New TextBox()
        Delete_Button = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(85, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 50)
        Label1.TabIndex = 0
        Label1.Text = "Delete Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 50)
        Label2.TabIndex = 1
        Label2.Text = "Enter IC: "
        ' 
        ' TextBox_Delete
        ' 
        TextBox_Delete.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Delete.Location = New Point(172, 105)
        TextBox_Delete.Name = "TextBox_Delete"
        TextBox_Delete.Size = New Size(265, 39)
        TextBox_Delete.TabIndex = 2
        ' 
        ' Delete_Button
        ' 
        Delete_Button.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Delete_Button.Location = New Point(78, 164)
        Delete_Button.Name = "Delete_Button"
        Delete_Button.Size = New Size(102, 48)
        Delete_Button.TabIndex = 3
        Delete_Button.Text = "Delete!"
        Delete_Button.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(217, 164)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 48)
        Button1.TabIndex = 4
        Button1.Text = "Back To Main Dashboard"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Delete_Details
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(449, 282)
        Controls.Add(Button1)
        Controls.Add(Delete_Button)
        Controls.Add(TextBox_Delete)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Delete_Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delete Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Delete As TextBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Button1 As Button
End Class
