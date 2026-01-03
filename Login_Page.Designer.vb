<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Page))
        TextBox2 = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Button3 = New Button()
        Label5 = New Label()
        ImageList1 = New ImageList(components)
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(88, 63)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(150, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(31, 113)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(88, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(125, 113)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 23)
        Button2.TabIndex = 4
        Button2.Text = "Reset Password"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 0
        Label1.Text = "Email"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(35, 210)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(254, 180)
        Panel1.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 21)
        Label3.TabIndex = 7
        Label3.Text = "Sign In "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(353, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(282, 21)
        Label4.TabIndex = 8
        Label4.Text = "No Account? Please Register Details"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(353, 210)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(268, 180)
        Panel2.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 21)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(237, 142)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(224, 413)
        Button3.Name = "Button3"
        Button3.Size = New Size(95, 23)
        Button3.TabIndex = 10
        Button3.Text = "Bypass button"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(74, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(528, 50)
        Label5.TabIndex = 11
        Label5.Text = "UBAT TRACKER SYSTEM V0.0"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(124, 71)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(464, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(353, 413)
        Button4.Name = "Button4"
        Button4.Size = New Size(101, 42)
        Button4.TabIndex = 13
        Button4.Text = "Check Mysql Connection"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Login_Page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        ClientSize = New Size(660, 496)
        Controls.Add(Button4)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "Login_Page"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button

End Class
