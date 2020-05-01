'Employee Data
'William Butler
'1/22/20
'A program to add info about an employee into a text document for storage and record

Option Strict On
Imports System
Imports System.IO

Public Class Form1

    '   Set variables as needed to hold filepath, filename, combobox options and an array to loop through for info needed writing the text file
    Dim empFileName As String
    ReadOnly filePath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    ReadOnly dptNames() As String = {"Accounting", "Administration", "Marketing", "MIS", "Sales"}
    ReadOnly emplabels() As String = {"First Name: ", "Middle Name: ", "Last Name: ", "Employee Number: ",
                                      "Department: ", "Telephone: ", "Extension: ", "E-mail Address: "}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '   Input box for user to add a name for the text file for the employee record
        '   If the file doesn't exist, create it, close it so its ready for use.
        empFileName = InputBox("Please enter a filename for the employee record: ")
        If Not File.Exists(empFileName) Then
            File.CreateText(filePath & "\" & empFileName & ".txt").Dispose()
        End If

        '   Populate the combobox items
        For Each dept In dptNames
            cboDeptName.Items.Add(dept)
        Next

    End Sub

    Private Sub TextBox_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles cboDeptName.Validating, txtEmailAddy.Validating, txtEmpNumb.Validating, txtFirstName.Validating,
                                                                                                  txtLastName.Validating, txtMidName.Validating, txtPhoneExt.Validating, txtPhoneNumb.Validating

        '   Sets a check to make sure each textbox has info entered into it by looping through all
        '   controls listed in handles if not uses error provider control
        Dim ctl As Control = CType(sender, Control)
        If ctl.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(ctl, "Please fill out all fields.")
        End If

    End Sub

    Private Function IsItNumericPositive() As Boolean

        '   Checks to make sure the info entered into phone number and extension are numbers
        If Not IsNumeric(txtPhoneExt.Text) Then
            MessageBox.Show("The extension field accepts numbers only.")
            Return False
        ElseIf Not IsNumeric(txtPhoneNumb.Text) Then
            MessageBox.Show("The phone number field accepts numbers only.")
            Return False
        End If

        If Val(txtPhoneNumb.Text) < 0 Then
            MessageBox.Show("Phone number cannot be a negative number.")
            Return False
        ElseIf Val(txtPhoneExt.Text) < 0 Then
            MessageBox.Show("Phone extension cannot be a negative number.")
            Return False
        End If

        Return True
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '   Closes the program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '   Clears all text boxes and resets combobox to blank
        ClearAllTxt()
    End Sub

    Private Sub btnSaveRec_Click(sender As Object, e As EventArgs) Handles btnSaveRec.Click

        '   Runs the validating sub, checks to make sure number and extension are numerical/not negative and gathers textbox input
        ErrorProvider1.Clear()

        If Not IsItNumericPositive() Then Exit Sub

        If Me.ValidateChildren() Then
            GatherTextInput()
        End If

    End Sub

    Private Sub ClearAllTxt()

        '   Sets a simple way to loop through each control if it is a textbox and clears it until all are cleared
        '   Sets a variable for the loop to go through each control
        Dim ctrl As Control = Me.GetNextControl(Me, True)

        '   Starts a loop until the control specified are nothing
        Do Until ctrl Is Nothing
            '   If the type of control is textbox use clear() on that textbox
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
            '   Goes to next control
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
        cboDeptName.SelectedItem = Nothing

    End Sub

    Private Sub GatherTextInput()

        '   Sets a list of strings with the textbox inputs, formatting the phone number string.
        Dim tempstring As New List(Of String)
        tempstring.Add(txtFirstName.Text)
        tempstring.Add(txtMidName.Text)
        tempstring.Add(txtLastName.Text)
        tempstring.Add(txtEmpNumb.Text)
        tempstring.Add(cboDeptName.SelectedItem.ToString)
        tempstring.Add(String.Format("{0:(###) ###-####}", Long.Parse(txtPhoneNumb.Text)))
        tempstring.Add(txtPhoneExt.Text)
        tempstring.Add(txtEmailAddy.Text)

        '   Calls to write to the file created in the form load event in the given path of my documents
        '   and append to the file
        Using infoWriter As New StreamWriter(filePath & "\" & empFileName & ".txt", True)

            '   Loops through the emplabel array and tempstring array  to make a formatted entry into the textfile
            For x = 0 To 7
                infoWriter.WriteLine(emplabels(x).ToString & " " & tempstring(x))
            Next

        End Using
        '   Lets the user know the text file was created and information entered
        MessageBox.Show("Employee record for " & tempstring(0) & " " & tempstring(2) & " created sucessfully.")

    End Sub

End Class
