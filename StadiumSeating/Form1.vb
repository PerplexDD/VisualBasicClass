'Stadium Seating Revenue Calculator
'William Butler
'1/9/20
'A short program to calculate stadium seating revenue per ticket

Option Strict On

Public Class Form1

    '   A simple function to clear text as needed, function made for easy reuse
    Function ClearText() As Object
        txtClassA.Text = String.Empty
        txtClassB.Text = String.Empty
        txtClassC.Text = String.Empty
        lblClassARev.Text = String.Empty
        lblClassBRev.Text = String.Empty
        lblClassCRev.Text = String.Empty
        lblTotRevDollars.Text = String.Empty
        txtClassA.Focus()
        Return String.Empty
    End Function

    '   A button click to exit the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '   A button click to clear all values and start fresh
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        '   Calls ClearText to clear all text
        ClearText()

    End Sub

    '   A simple calcuation done to generate totals of revenue for each needed category
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        '   Set up variables for ticket prices per seat
        Dim clsATicket As Integer = 15
        Dim clsBTicket As Integer = 12
        Dim clsCTicket As Integer = 9

        '   Set up try and catch block incase of unknown error
        '   Uses ClearText to empty input/output boxes as well
        '   If Elseif else statement to check for empty text boxes and values not positive integers
        Try
            If String.IsNullOrEmpty(txtClassA.Text) _
                Or String.IsNullOrEmpty(txtClassB.Text) _
                Or String.IsNullOrEmpty(txtClassC.Text) Then
                MessageBox.Show("A positive numerical value must be entered.")

            ElseIf IsNumeric(CInt(txtClassA.Text)) And CInt(txtClassA.Text) > 0 _
                And IsNumeric(CInt(txtClassB.Text)) And CInt(txtClassB.Text) > 0 _
                And IsNumeric(CInt(txtClassC.Text)) And CInt(txtClassC.Text) > 0 Then

                lblClassARev.Text = String.Format("{0:C2}", CInt(txtClassA.Text) * clsATicket)
                lblClassBRev.Text = String.Format("{0:C2}", CInt(txtClassB.Text) * clsBTicket)
                lblClassCRev.Text = String.Format("{0:C2}", CInt(txtClassC.Text) * clsCTicket)
                lblTotRevDollars.Text = String.Format("{0:C2}", CInt(lblClassARev.Text) + CInt(lblClassBRev.Text) + CInt(lblClassCRev.Text))

            Else

                MessageBox.Show("Only positive numerical values must be entered.")

            End If

        Catch ex As System.InvalidCastException

            MessageBox.Show("Only positive numerical values must be entered.",
                            "Error")

            ClearText()

        Catch ex As Exception

            MessageBox.Show("An unexpected error has occured",
                            "Error")
            ClearText()

        End Try


    End Sub
End Class
