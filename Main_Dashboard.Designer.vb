<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Dashboard))
        Clock1 = New Label()
        Timer1 = New Timer(components)
        welcome = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        PictureBox4 = New PictureBox()
        Label9 = New Label()
        PictureBox5 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Clock1
        ' 
        Clock1.Anchor = AnchorStyles.None
        Clock1.BorderStyle = BorderStyle.FixedSingle
        Clock1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Clock1.ImageAlign = ContentAlignment.TopCenter
        Clock1.Location = New Point(22, 79)
        Clock1.Name = "Clock1"
        Clock1.Size = New Size(287, 39)
        Clock1.TabIndex = 0
        Clock1.Text = "12:00:00"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' welcome
        ' 
        welcome.AutoSize = True
        welcome.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcome.Location = New Point(22, 23)
        welcome.Name = "welcome"
        welcome.Size = New Size(152, 40)
        welcome.TabIndex = 1
        welcome.Text = "Welcome "
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(801, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 40)
        Button1.TabIndex = 2
        Button1.Text = "Sign-Out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(22, 175)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(356, 161)
        Panel1.TabIndex = 3
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(139, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 46)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 15)
        Label4.TabIndex = 2
        Label4.Text = "Ontime Taking Pills"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 15)
        Label2.TabIndex = 0
        Label2.Text = "Next Appointment Date: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(273, 37)
        Label1.TabIndex = 4
        Label1.Text = "Status and Statistics"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(423, 175)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(231, 161)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(448, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 37)
        Label5.TabIndex = 6
        Label5.Text = "Add New Pill"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(707, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(209, 37)
        Label6.TabIndex = 7
        Label6.Text = "Change Details"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(707, 175)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(195, 161)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(707, 392)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(209, 161)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(707, 352)
        Label7.Name = "Label7"
        Label7.Size = New Size(197, 37)
        Label7.TabIndex = 10
        Label7.Text = "Delete Details"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(448, 352)
        Label8.Name = "Label8"
        Label8.Size = New Size(173, 37)
        Label8.TabIndex = 11
        Label8.Text = "Prescription"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(423, 392)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(231, 161)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(203, 352)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 37)
        Label9.TabIndex = 13
        Label9.Text = "Report"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(131, 392)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(231, 161)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' Main_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(938, 565)
        Controls.Add(PictureBox5)
        Controls.Add(Label9)
        Controls.Add(PictureBox4)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(welcome)
        Controls.Add(Clock1)
        Name = "Main_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Clock1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents welcome As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
