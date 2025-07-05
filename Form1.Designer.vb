<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnAdd = New Button()
        btnRemove = New Button()
        btnClose = New Button()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtDaily = New TextBox()
        txtWeekly = New TextBox()
        txtMonthly = New TextBox()
        txtQuantity = New TextBox()
        txtDescription = New TextBox()
        cboIdNumber = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(308, 203)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(185, 23)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add Current Item"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(308, 246)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(185, 23)
        btnRemove.TabIndex = 1
        btnRemove.Text = "Remove Current Item"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(308, 292)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(185, 23)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtDaily)
        Panel1.Controls.Add(txtWeekly)
        Panel1.Controls.Add(txtMonthly)
        Panel1.Location = New Point(45, 135)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(227, 180)
        Panel1.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 10)
        Label7.Name = "Label7"
        Label7.Size = New Size(35, 15)
        Label7.TabIndex = 6
        Label7.Text = "Rates"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(28, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 5
        Label6.Text = "Monthly"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 15)
        Label5.TabIndex = 4
        Label5.Text = "Weekly"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 3
        Label4.Text = "Daily"
        ' 
        ' txtDaily
        ' 
        txtDaily.Location = New Point(92, 43)
        txtDaily.Name = "txtDaily"
        txtDaily.Size = New Size(100, 23)
        txtDaily.TabIndex = 2
        ' 
        ' txtWeekly
        ' 
        txtWeekly.Location = New Point(91, 85)
        txtWeekly.Name = "txtWeekly"
        txtWeekly.Size = New Size(100, 23)
        txtWeekly.TabIndex = 1
        ' 
        ' txtMonthly
        ' 
        txtMonthly.Location = New Point(91, 126)
        txtMonthly.Name = "txtMonthly"
        txtMonthly.Size = New Size(100, 23)
        txtMonthly.TabIndex = 0
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(159, 330)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(100, 23)
        txtQuantity.TabIndex = 4
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(45, 78)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(448, 23)
        txtDescription.TabIndex = 5
        ' 
        ' cboIdNumber
        ' 
        cboIdNumber.FormattingEnabled = True
        cboIdNumber.Location = New Point(48, 34)
        cboIdNumber.Name = "cboIdNumber"
        cboIdNumber.Size = New Size(121, 23)
        cboIdNumber.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 7
        Label1.Text = "ID Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(280, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 8
        Label2.Text = "Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 334)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 9
        Label3.Text = "Quantity"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 377)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cboIdNumber)
        Controls.Add(txtDescription)
        Controls.Add(txtQuantity)
        Controls.Add(Panel1)
        Controls.Add(btnClose)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "FirstPlay Sports - Rental Item"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDaily As TextBox
    Friend WithEvents txtWeekly As TextBox
    Friend WithEvents txtMonthly As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboIdNumber As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
