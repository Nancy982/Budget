'Nancy Medina
'CS105
'Spring-2020

'I pledge that I have neither given nor received help from anyone other than the instructor and TA
'for all program components included here.

Imports System.IO
Public Class Form2

    'declare class scope variables for writing and reading files
    Dim strFileName As String = "TotalLeftOver.txt"
    Dim strFileInfo As String = CStr(Form1.txtResult.Text)

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        'declare the object that "knows" how to write to file
        Dim fileWriter As StreamWriter
        'put code in the Try block of a Try/Catch in case there is an error
        Try
            'open the file so that it can written to
            fileWriter = File.CreateText(strFileName)
            'use fileWriter to write to file all the info stored in the class scope fileInfo variable
            fileWriter.WriteLine(strFileInfo)
            'close the file
            fileWriter.Close()
            'use MessageBox to inform user that info has been written to file
            MessageBox.Show("The info has been written to file")
            'now that there is a file availiable to be read, make btnRead visible
            btnRead.Visible = True
            'we no longer need the btnWrite visible, so we make it invisible
            btnWrite.Visible = False
        Catch ex As Exception
            MessageBox.Show("Error: The file cannnot be created")
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'declare the object that "knows how to read files
        Dim fileReader As StreamReader
        Try
            Dim strLine As String = ""
            'open the file so that it can be read
            fileReader = File.OpenText(strFileName)
            'declare local string variable to store info read from the file
            'use a Do Until loop to read the file one line at a time
            Do Until fileReader.EndOfStream()
                strLine &= fileReader.ReadLine() & vbCrLf
            Loop
            'after exiting the loop, close file
            fileReader.Close()

            'assign info in local string varialbe to Text property of txtResult on the form
            txtResult.Text = strLine
            'make visible property of txtResult true,so it can be seen by the user
            txtResult.Visible = True
            'no longer need the btnRead true, so make it invisible
            btnRead.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error: The file cannnot be opened")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class