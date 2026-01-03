<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_New_Pill
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
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Display_IC = New Label()
        Display_Email = New Label()
        Label6 = New Label()
        ComboBox_Unit = New ComboBox()
        update_pill_information = New Button()
        DataGridView1 = New DataGridView()
        new_pill_information = New Button()
        delete_pill_information = New Button()
        cancel_button = New Button()
        TextBox_Pill_Name = New TextBox()
        Label7 = New Label()
        ComboBox_Disease = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(242, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 50)
        Label1.TabIndex = 0
        Label1.Text = "Add New Pill"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(547, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 52)
        Button1.TabIndex = 1
        Button1.Text = "Back To Main Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(656, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 52)
        Button2.TabIndex = 2
        Button2.Text = "Sign-Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Location = New Point(100, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 3
        Label2.Text = "Pill Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaption
        Label4.Location = New Point(30, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 15)
        Label4.TabIndex = 7
        Label4.Text = "Identification Card (IC): "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Location = New Point(121, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 8
        Label5.Text = "Email: "
        ' 
        ' Display_IC
        ' 
        Display_IC.AutoSize = True
        Display_IC.BackColor = SystemColors.ActiveCaption
        Display_IC.Location = New Point(169, 111)
        Display_IC.Name = "Display_IC"
        Display_IC.Size = New Size(59, 15)
        Display_IC.TabIndex = 9
        Display_IC.Text = "Display IC"
        ' 
        ' Display_Email
        ' 
        Display_Email.AutoSize = True
        Display_Email.BackColor = SystemColors.ActiveCaption
        Display_Email.Location = New Point(169, 138)
        Display_Email.Name = "Display_Email"
        Display_Email.Size = New Size(77, 15)
        Display_Email.TabIndex = 10
        Display_Email.Text = "Display Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaption
        Label6.Location = New Point(84, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 15)
        Label6.TabIndex = 11
        Label6.Text = "Dosage Unit: "
        ' 
        ' ComboBox_Unit
        ' 
        ComboBox_Unit.FormattingEnabled = True
        ComboBox_Unit.Items.AddRange(New Object() {"kilogram (Kg)", "gram (g)", "milligram (mg)", "microgram (μg)", "litre (L)", "millilitre (ml)", "cubic centimetre (cc)"})
        ComboBox_Unit.Location = New Point(166, 215)
        ComboBox_Unit.Name = "ComboBox_Unit"
        ComboBox_Unit.Size = New Size(121, 23)
        ComboBox_Unit.TabIndex = 12
        ' 
        ' update_pill_information
        ' 
        update_pill_information.Location = New Point(293, 361)
        update_pill_information.Name = "update_pill_information"
        update_pill_information.Size = New Size(116, 48)
        update_pill_information.TabIndex = 15
        update_pill_information.Text = "Update Pill Information"
        update_pill_information.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 415)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(758, 213)
        DataGridView1.TabIndex = 17
        ' 
        ' new_pill_information
        ' 
        new_pill_information.Location = New Point(167, 361)
        new_pill_information.Name = "new_pill_information"
        new_pill_information.Size = New Size(120, 48)
        new_pill_information.TabIndex = 18
        new_pill_information.Text = "New Pill Information"
        new_pill_information.UseVisualStyleBackColor = True
        ' 
        ' delete_pill_information
        ' 
        delete_pill_information.Location = New Point(415, 361)
        delete_pill_information.Name = "delete_pill_information"
        delete_pill_information.Size = New Size(116, 48)
        delete_pill_information.TabIndex = 19
        delete_pill_information.Text = "Delete Pill Information"
        delete_pill_information.UseVisualStyleBackColor = True
        ' 
        ' cancel_button
        ' 
        cancel_button.Location = New Point(537, 361)
        cancel_button.Name = "cancel_button"
        cancel_button.Size = New Size(116, 48)
        cancel_button.TabIndex = 20
        cancel_button.Text = "Cancel"
        cancel_button.UseVisualStyleBackColor = True
        ' 
        ' TextBox_Pill_Name
        ' 
        TextBox_Pill_Name.Location = New Point(167, 183)
        TextBox_Pill_Name.Name = "TextBox_Pill_Name"
        TextBox_Pill_Name.Size = New Size(324, 23)
        TextBox_Pill_Name.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ActiveCaption
        Label7.Location = New Point(62, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 15)
        Label7.TabIndex = 22
        Label7.Text = "Disease/Disorder: "
        ' 
        ' ComboBox_Disease
        ' 
        ComboBox_Disease.AutoCompleteCustomSource.AddRange(New String() {"Covid19", "Hepatitis", "Bipolar Disorder"})
        ComboBox_Disease.FormattingEnabled = True
        ComboBox_Disease.Items.AddRange(New Object() {"Viral: Common Cold, Flu (Influenza), COVID-19, Measles, HIV/AIDS, Hepatitis, Chickenpox. ", "Bacterial: Strep Throat, Pneumonia, Tuberculosis, Lyme Disease, Tetanus, UTIs. ", "Parasitic: Malaria, Giardiasis, Hookworms. ", "Fungal: Athlete's Foot, Ringworm, Thrush. ", "Cardiovascular: Heart Disease, Stroke, Hypertension (High Blood Pressure). ", "Metabolic: Diabetes, High Cholesterol. ", "Respiratory: Asthma, COPD, Allergies. ", "Mental Health: Depression, Anxiety, Bipolar Disorder, ADHD, Alzheimer's. ", "Mental Health: Schizophrenia. ", "Digestive: Irritable Bowel Syndrome (IBS), Crohn's, Liver Disease (Cirrhosis). ", "Cancers: Breast, Lung, Colon, Skin (Melanoma), Leukemia, Lymphoma. "})
        ComboBox_Disease.Location = New Point(166, 249)
        ComboBox_Disease.Name = "ComboBox_Disease"
        ComboBox_Disease.Size = New Size(602, 23)
        ComboBox_Disease.TabIndex = 23
        ' 
        ' Add_New_Pill
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlueViolet
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 640)
        Controls.Add(ComboBox_Disease)
        Controls.Add(Label7)
        Controls.Add(TextBox_Pill_Name)
        Controls.Add(cancel_button)
        Controls.Add(delete_pill_information)
        Controls.Add(new_pill_information)
        Controls.Add(DataGridView1)
        Controls.Add(update_pill_information)
        Controls.Add(ComboBox_Unit)
        Controls.Add(Label6)
        Controls.Add(Display_Email)
        Controls.Add(Display_IC)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Add_New_Pill"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_New_Pill"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Display_IC As Label
    Friend WithEvents Display_Email As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_Unit As ComboBox
    Friend WithEvents update_pill_information As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents new_pill_information As Button
    Friend WithEvents delete_pill_information As Button
    Friend WithEvents cancel_button As Button
    Friend WithEvents TextBox_Pill_Name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_Disease As ComboBox
End Class
