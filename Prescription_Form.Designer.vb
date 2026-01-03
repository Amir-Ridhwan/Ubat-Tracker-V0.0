<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescription_Form
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
        Button2 = New Button()
        Button1 = New Button()
        Display_IC = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        submit_button = New Button()
        cancel_button = New Button()
        Label6 = New Label()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(213, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 52)
        Button2.TabIndex = 4
        Button2.Text = "Sign-Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(104, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 52)
        Button1.TabIndex = 3
        Button1.Text = "Back To Main Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Display_IC
        ' 
        Display_IC.AutoSize = True
        Display_IC.BackColor = SystemColors.InactiveCaption
        Display_IC.Location = New Point(158, 98)
        Display_IC.Name = "Display_IC"
        Display_IC.Size = New Size(59, 15)
        Display_IC.TabIndex = 13
        Display_IC.Text = "Display IC"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.InactiveCaption
        Label1.Location = New Point(19, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 15)
        Label1.TabIndex = 12
        Label1.Text = "Identification Card (IC): "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.InactiveCaption
        Label3.Location = New Point(88, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 15
        Label3.Text = "Pill Name: "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(158, 128)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(167, 23)
        ComboBox1.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.InactiveCaption
        Label4.Location = New Point(81, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 17
        Label4.Text = "Pill Dosage: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.InactiveCaption
        Label5.Location = New Point(74, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 15)
        Label5.TabIndex = 19
        Label5.Text = "Pill Quantity: "
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(158, 242)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(167, 23)
        TextBox2.TabIndex = 20
        ' 
        ' submit_button
        ' 
        submit_button.Location = New Point(104, 285)
        submit_button.Name = "submit_button"
        submit_button.Size = New Size(103, 40)
        submit_button.TabIndex = 21
        submit_button.Text = "Submit"
        submit_button.UseVisualStyleBackColor = True
        ' 
        ' cancel_button
        ' 
        cancel_button.Location = New Point(222, 285)
        cancel_button.Name = "cancel_button"
        cancel_button.Size = New Size(103, 40)
        cancel_button.TabIndex = 22
        cancel_button.Text = "Cancel"
        cancel_button.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.InactiveCaption
        Label6.Location = New Point(100, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 23
        Label6.Text = "Disease: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(158, 205)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 18
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(158, 171)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(167, 23)
        ComboBox2.TabIndex = 24
        ' 
        ' Prescription_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox2)
        Controls.Add(Label6)
        Controls.Add(cancel_button)
        Controls.Add(submit_button)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Display_IC)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Prescription_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prescription"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Display_IC As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents submit_button As Button
    Friend WithEvents cancel_button As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
