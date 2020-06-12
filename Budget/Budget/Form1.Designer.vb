<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtRent = New System.Windows.Forms.TextBox()
        Me.txtElectric = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGas = New System.Windows.Forms.TextBox()
        Me.txtGroceries = New System.Windows.Forms.TextBox()
        Me.txtLoans = New System.Windows.Forms.TextBox()
        Me.lblDirExpenses = New System.Windows.Forms.Label()
        Me.lblDirIncome = New System.Windows.Forms.Label()
        Me.lblDirSavings = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.txtSavings = New System.Windows.Forms.TextBox()
        Me.chkRent = New System.Windows.Forms.CheckBox()
        Me.chkElectric = New System.Windows.Forms.CheckBox()
        Me.chkPhone = New System.Windows.Forms.CheckBox()
        Me.chkGas = New System.Windows.Forms.CheckBox()
        Me.chkGroceries = New System.Windows.Forms.CheckBox()
        Me.chkLoans = New System.Windows.Forms.CheckBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(135, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(335, 53)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Fill in the text boxes below to calculate the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "amount of money left over for the" & _
    " month."
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCalculate.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(22, 530)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(76, 42)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnFile
        '
        Me.btnFile.AutoSize = True
        Me.btnFile.BackColor = System.Drawing.Color.PaleGreen
        Me.btnFile.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFile.Location = New System.Drawing.Point(185, 530)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(75, 42)
        Me.btnFile.TabIndex = 8
        Me.btnFile.Text = "Create " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File"
        Me.btnFile.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClear.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(331, 530)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 42)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.PaleGreen
        Me.btnExit.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(499, 530)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 42)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtRent
        '
        Me.txtRent.Location = New System.Drawing.Point(455, 145)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(100, 20)
        Me.txtRent.TabIndex = 11
        Me.txtRent.Text = "0.00"
        '
        'txtElectric
        '
        Me.txtElectric.Location = New System.Drawing.Point(455, 199)
        Me.txtElectric.Name = "txtElectric"
        Me.txtElectric.Size = New System.Drawing.Size(100, 20)
        Me.txtElectric.TabIndex = 12
        Me.txtElectric.Text = "0.00"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(455, 251)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 13
        Me.txtPhone.Text = "0.00"
        '
        'txtGas
        '
        Me.txtGas.Location = New System.Drawing.Point(455, 306)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(100, 20)
        Me.txtGas.TabIndex = 14
        Me.txtGas.Text = "0.00"
        '
        'txtGroceries
        '
        Me.txtGroceries.Location = New System.Drawing.Point(455, 361)
        Me.txtGroceries.Name = "txtGroceries"
        Me.txtGroceries.Size = New System.Drawing.Size(100, 20)
        Me.txtGroceries.TabIndex = 15
        Me.txtGroceries.Text = "0.00"
        '
        'txtLoans
        '
        Me.txtLoans.Location = New System.Drawing.Point(455, 424)
        Me.txtLoans.Name = "txtLoans"
        Me.txtLoans.Size = New System.Drawing.Size(100, 20)
        Me.txtLoans.TabIndex = 16
        Me.txtLoans.Text = "0.00"
        '
        'lblDirExpenses
        '
        Me.lblDirExpenses.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirExpenses.Location = New System.Drawing.Point(313, 108)
        Me.lblDirExpenses.Name = "lblDirExpenses"
        Me.lblDirExpenses.Size = New System.Drawing.Size(300, 27)
        Me.lblDirExpenses.TabIndex = 17
        Me.lblDirExpenses.Text = "Input the cost of each expense for the month"
        '
        'lblDirIncome
        '
        Me.lblDirIncome.AutoSize = True
        Me.lblDirIncome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirIncome.Location = New System.Drawing.Point(19, 108)
        Me.lblDirIncome.Name = "lblDirIncome"
        Me.lblDirIncome.Size = New System.Drawing.Size(145, 17)
        Me.lblDirIncome.TabIndex = 18
        Me.lblDirIncome.Text = "Input Monthly Income"
        '
        'lblDirSavings
        '
        Me.lblDirSavings.AutoSize = True
        Me.lblDirSavings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirSavings.Location = New System.Drawing.Point(19, 224)
        Me.lblDirSavings.Name = "lblDirSavings"
        Me.lblDirSavings.Size = New System.Drawing.Size(146, 17)
        Me.lblDirSavings.TabIndex = 19
        Me.lblDirSavings.Text = "Input Monthly Savings"
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.Location = New System.Drawing.Point(17, 152)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(50, 17)
        Me.lblIncome.TabIndex = 20
        Me.lblIncome.Text = "Income"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Savings"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(73, 149)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtIncome.TabIndex = 22
        Me.txtIncome.Text = "0.00"
        '
        'txtSavings
        '
        Me.txtSavings.Location = New System.Drawing.Point(70, 265)
        Me.txtSavings.Name = "txtSavings"
        Me.txtSavings.Size = New System.Drawing.Size(100, 20)
        Me.txtSavings.TabIndex = 23
        Me.txtSavings.Text = "0.00"
        '
        'chkRent
        '
        Me.chkRent.AutoSize = True
        Me.chkRent.Location = New System.Drawing.Point(331, 145)
        Me.chkRent.Name = "chkRent"
        Me.chkRent.Size = New System.Drawing.Size(99, 17)
        Me.chkRent.TabIndex = 24
        Me.chkRent.Text = "Mortgage/Rent"
        Me.chkRent.UseVisualStyleBackColor = True
        '
        'chkElectric
        '
        Me.chkElectric.AutoSize = True
        Me.chkElectric.Location = New System.Drawing.Point(331, 202)
        Me.chkElectric.Name = "chkElectric"
        Me.chkElectric.Size = New System.Drawing.Size(71, 17)
        Me.chkElectric.TabIndex = 25
        Me.chkElectric.Text = "Electricity"
        Me.chkElectric.UseVisualStyleBackColor = True
        '
        'chkPhone
        '
        Me.chkPhone.AutoSize = True
        Me.chkPhone.Location = New System.Drawing.Point(331, 254)
        Me.chkPhone.Name = "chkPhone"
        Me.chkPhone.Size = New System.Drawing.Size(57, 17)
        Me.chkPhone.TabIndex = 26
        Me.chkPhone.Text = "Phone"
        Me.chkPhone.UseVisualStyleBackColor = True
        '
        'chkGas
        '
        Me.chkGas.AutoSize = True
        Me.chkGas.Location = New System.Drawing.Point(331, 308)
        Me.chkGas.Name = "chkGas"
        Me.chkGas.Size = New System.Drawing.Size(118, 17)
        Me.chkGas.TabIndex = 27
        Me.chkGas.Text = "Transportation/Gas"
        Me.chkGas.UseVisualStyleBackColor = True
        '
        'chkGroceries
        '
        Me.chkGroceries.AutoSize = True
        Me.chkGroceries.Location = New System.Drawing.Point(331, 361)
        Me.chkGroceries.Name = "chkGroceries"
        Me.chkGroceries.Size = New System.Drawing.Size(71, 17)
        Me.chkGroceries.TabIndex = 28
        Me.chkGroceries.Text = "Groceries"
        Me.chkGroceries.UseVisualStyleBackColor = True
        '
        'chkLoans
        '
        Me.chkLoans.AutoSize = True
        Me.chkLoans.Location = New System.Drawing.Point(331, 424)
        Me.chkLoans.Name = "chkLoans"
        Me.chkLoans.Size = New System.Drawing.Size(112, 17)
        Me.chkLoans.TabIndex = 29
        Me.chkLoans.Text = "Credit Card/Loans"
        Me.chkLoans.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(41, 324)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResult.Size = New System.Drawing.Size(219, 139)
        Me.txtResult.TabIndex = 30
        Me.txtResult.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(625, 611)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.chkLoans)
        Me.Controls.Add(Me.chkGroceries)
        Me.Controls.Add(Me.chkGas)
        Me.Controls.Add(Me.chkPhone)
        Me.Controls.Add(Me.chkElectric)
        Me.Controls.Add(Me.chkRent)
        Me.Controls.Add(Me.txtSavings)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.lblDirSavings)
        Me.Controls.Add(Me.lblDirIncome)
        Me.Controls.Add(Me.lblDirExpenses)
        Me.Controls.Add(Me.txtLoans)
        Me.Controls.Add(Me.txtGroceries)
        Me.Controls.Add(Me.txtGas)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtElectric)
        Me.Controls.Add(Me.txtRent)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "Form1"
        Me.Text = "Budget"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtRent As System.Windows.Forms.TextBox
    Friend WithEvents txtElectric As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtGas As System.Windows.Forms.TextBox
    Friend WithEvents txtGroceries As System.Windows.Forms.TextBox
    Friend WithEvents txtLoans As System.Windows.Forms.TextBox
    Friend WithEvents lblDirExpenses As System.Windows.Forms.Label
    Friend WithEvents lblDirIncome As System.Windows.Forms.Label
    Friend WithEvents lblDirSavings As System.Windows.Forms.Label
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIncome As System.Windows.Forms.TextBox
    Friend WithEvents txtSavings As System.Windows.Forms.TextBox
    Friend WithEvents chkRent As System.Windows.Forms.CheckBox
    Friend WithEvents chkElectric As System.Windows.Forms.CheckBox
    Friend WithEvents chkPhone As System.Windows.Forms.CheckBox
    Friend WithEvents chkGas As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroceries As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoans As System.Windows.Forms.CheckBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
