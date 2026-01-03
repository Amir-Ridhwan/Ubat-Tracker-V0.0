<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_Form
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
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 15)
        Label1.TabIndex = 0
        Label1.Text = "IC: "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(140, 31)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(204, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(350, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 23)
        Button1.TabIndex = 2
        Button1.Text = "Generate Report"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(604, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 52)
        Button2.TabIndex = 4
        Button2.Text = "Sign-Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.BackgroundImageLayout = ImageLayout.Center
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(495, 13)
        Button3.Name = "Button3"
        Button3.Size = New Size(103, 52)
        Button3.TabIndex = 3
        Button3.Text = "Back To Main Dashboard"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ReportViewer1
        ' 
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc"
        ReportViewer1.Location = New Point(10, 80)
        ReportViewer1.Name = "ReportViewer"
        ReportViewer1.ServerReport.BearerToken = Nothing
        ReportViewer1.Size = New Size(1000, 400)
        ReportViewer1.TabIndex = 0
        ' 
        ' Report_Form
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1024, 525)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(ReportViewer1)
        Name = "Report_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Report Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
