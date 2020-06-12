'Nancy Medina
'CS105
'Spring-2020

'I pledge that I have neither given nor received help from anyone other than the instructor and TA
'for all program components included here.

Public Class Form1

    'declare class scope variables for writing and reading files
    Dim strFileInfo As String = ""

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'variable that obtains the mooney left over from the function
        Dim dblLeftOver = GetAmountLeft()
        'Create string that states how much money was left over
        Dim strResult As String = "There is a total of " & dblLeftOver.ToString("C") & " left over for this month."
        strFileInfo &= vbCrLf & "There is a total of " & dblLeftOver.ToString("C") & " left over for this month." & vbCrLf
        'Show the user the amount of money left over
        MessageBox.Show(strResult, "Money Left Over")
        txtResult.Text = strFileInfo
    End Sub

    'create function to calculate the amount of money left
    Function GetAmountLeft() As Double
        'declare all variables to calculate the total money left over
        Dim dblTotalExpense As Double = 0
        Dim LeftOver As Double
        Dim dblIncome As Double = CDbl(txtIncome.Text)
        Dim dblSave As Double = CDbl(txtSavings.Text)
        Dim dblRent As Double = CDbl(txtRent.Text)
        Dim dblElectric As Double = CDbl(txtElectric.Text)
        Dim dblPhone As Double = CDbl(txtPhone.Text)
        Dim dblGas As Double = CDbl(txtGas.Text)
        Dim dblGroceries As Double = CDbl(txtGroceries.Text)
        Dim dblLoans As Double = CDbl(txtLoans.Text)

        dblTotalExpense += dblSave
        'check the cost of each expense 
        If (chkRent.Checked) Then
            dblTotalExpense += dblRent
            strFileInfo &= "Mortgage/Rent: $" & dblRent & vbCrLf
        End If
        If (chkElectric.Checked) Then
            dblTotalExpense += dblElectric
            strFileInfo &= "Electricity: $" & dblElectric & vbCrLf
        End If
        If (chkPhone.Checked) Then
            dblTotalExpense += dblPhone
            strFileInfo &= "Phone: $" & dblPhone & vbCrLf
        End If
        If (chkGas.Checked) Then
            dblTotalExpense += dblGas
            strFileInfo &= "Transportation: $" & dblGas & vbCrLf
        End If
        If (chkGroceries.Checked) Then
            dblTotalExpense += dblGroceries
            strFileInfo &= "Groceries: $" & dblGroceries & vbCrLf
        End If
        If (chkLoans.Checked) Then
            dblTotalExpense += dblLoans
            strFileInfo &= "Loans: $" & dblLoans & vbCrLf
        End If
        'Calculate the total money left over
        LeftOver = dblIncome - dblTotalExpense
        'return result
        Return LeftOver
    End Function

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        'open form 2
        Form2.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all text boxes, check boxes and results
        txtElectric.Text = 0.0
        txtGas.Text = 0.0
        txtGroceries.Text = 0.0
        txtIncome.Text = 0.0
        txtLoans.Text = 0.0
        txtRent.Text = 0.0
        txtResult.Text = ""
        txtPhone.Text = 0.0
        txtSavings.Text = 0.0
        chkElectric.Checked = False
        chkGas.Checked = False
        chkGroceries.Checked = False
        chkLoans.Checked = False
        chkPhone.Checked = False
        chkRent.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class



