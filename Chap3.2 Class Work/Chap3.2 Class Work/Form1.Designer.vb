<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAge
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
        Me.lblDayofBirth = New System.Windows.Forms.Label()
        Me.mtbDayofBirth = New System.Windows.Forms.MaskedTextBox()
        Me.btnComputeofBirth = New System.Windows.Forms.Button()
        Me.lblFullDateOfBirth = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.lblAgeInDays = New System.Windows.Forms.Label()
        Me.txtFullDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtToday = New System.Windows.Forms.TextBox()
        Me.txtAgeInDays = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDayofBirth
        '
        Me.lblDayofBirth.AutoSize = True
        Me.lblDayofBirth.Location = New System.Drawing.Point(13, 13)
        Me.lblDayofBirth.Name = "lblDayofBirth"
        Me.lblDayofBirth.Size = New System.Drawing.Size(68, 13)
        Me.lblDayofBirth.TabIndex = 0
        Me.lblDayofBirth.Text = "Date Of Birth"
        '
        'mtbDayofBirth
        '
        Me.mtbDayofBirth.Location = New System.Drawing.Point(199, 13)
        Me.mtbDayofBirth.Mask = "00/00/0000"
        Me.mtbDayofBirth.Name = "mtbDayofBirth"
        Me.mtbDayofBirth.Size = New System.Drawing.Size(103, 20)
        Me.mtbDayofBirth.TabIndex = 1
        Me.mtbDayofBirth.ValidatingType = GetType(Date)
        '
        'btnComputeofBirth
        '
        Me.btnComputeofBirth.Location = New System.Drawing.Point(16, 59)
        Me.btnComputeofBirth.Name = "btnComputeofBirth"
        Me.btnComputeofBirth.Size = New System.Drawing.Size(286, 56)
        Me.btnComputeofBirth.TabIndex = 2
        Me.btnComputeofBirth.Text = "Compute Data"
        Me.btnComputeofBirth.UseVisualStyleBackColor = True
        '
        'lblFullDateOfBirth
        '
        Me.lblFullDateOfBirth.AutoSize = True
        Me.lblFullDateOfBirth.Location = New System.Drawing.Point(13, 136)
        Me.lblFullDateOfBirth.Name = "lblFullDateOfBirth"
        Me.lblFullDateOfBirth.Size = New System.Drawing.Size(87, 13)
        Me.lblFullDateOfBirth.TabIndex = 3
        Me.lblFullDateOfBirth.Text = "Full Date Of Birth"
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.Location = New System.Drawing.Point(13, 198)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(70, 13)
        Me.lblToday.TabIndex = 4
        Me.lblToday.Text = "Today's Date"
        '
        'lblAgeInDays
        '
        Me.lblAgeInDays.AutoSize = True
        Me.lblAgeInDays.Location = New System.Drawing.Point(13, 248)
        Me.lblAgeInDays.Name = "lblAgeInDays"
        Me.lblAgeInDays.Size = New System.Drawing.Size(64, 13)
        Me.lblAgeInDays.TabIndex = 5
        Me.lblAgeInDays.Text = "Age in Days"
        '
        'txtFullDateOfBirth
        '
        Me.txtFullDateOfBirth.Location = New System.Drawing.Point(106, 136)
        Me.txtFullDateOfBirth.Name = "txtFullDateOfBirth"
        Me.txtFullDateOfBirth.ReadOnly = True
        Me.txtFullDateOfBirth.Size = New System.Drawing.Size(196, 20)
        Me.txtFullDateOfBirth.TabIndex = 6
        '
        'txtToday
        '
        Me.txtToday.Location = New System.Drawing.Point(106, 198)
        Me.txtToday.Name = "txtToday"
        Me.txtToday.ReadOnly = True
        Me.txtToday.Size = New System.Drawing.Size(196, 20)
        Me.txtToday.TabIndex = 7
        '
        'txtAgeInDays
        '
        Me.txtAgeInDays.Location = New System.Drawing.Point(106, 248)
        Me.txtAgeInDays.Name = "txtAgeInDays"
        Me.txtAgeInDays.ReadOnly = True
        Me.txtAgeInDays.Size = New System.Drawing.Size(196, 20)
        Me.txtAgeInDays.TabIndex = 8
        '
        'frmAge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 306)
        Me.Controls.Add(Me.txtAgeInDays)
        Me.Controls.Add(Me.txtToday)
        Me.Controls.Add(Me.txtFullDateOfBirth)
        Me.Controls.Add(Me.lblAgeInDays)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.lblFullDateOfBirth)
        Me.Controls.Add(Me.btnComputeofBirth)
        Me.Controls.Add(Me.mtbDayofBirth)
        Me.Controls.Add(Me.lblDayofBirth)
        Me.Name = "frmAge"
        Me.Text = "Age In Days"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDayofBirth As System.Windows.Forms.Label
    Friend WithEvents mtbDayofBirth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnComputeofBirth As System.Windows.Forms.Button
    Friend WithEvents lblFullDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents lblToday As System.Windows.Forms.Label
    Friend WithEvents lblAgeInDays As System.Windows.Forms.Label
    Friend WithEvents txtFullDateOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents txtToday As System.Windows.Forms.TextBox
    Friend WithEvents txtAgeInDays As System.Windows.Forms.TextBox

End Class
