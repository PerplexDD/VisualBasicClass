'Fat Percentage Calculator
'William Butler
'1/10/20
'A short program to calculate the percentage of fat in a certain amount of calories

Option Strict On

Public Class Form1

    '   A short function to clear select textbox and label controls
    Function ClearBoxes() As Object

        txtCalories.Text = String.Empty
        txtFatGrams.Text = String.Empty
        lblPercentage.Text = String.Empty
        Return String.Empty

    End Function

    '   A button click event to exit the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '   A button click event to Clear select text and label controls
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearBoxes()

    End Sub

    '   A button click event to calculate the user input and show the appropiate output
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        '   Try and catch block for making sure only numbers are used and to catch unknown errors.
        Try

            '   Create variables for controls needed for calculation
            Dim totalcal As Decimal = CDec(txtCalories.Text)
            Dim fatgrams As Decimal = CDec(txtFatGrams.Text)
            Dim percentfat As Decimal
            Dim calfromfat As Decimal

            '   If statements to make sure totalcal and fatgrams are less than 0 as well as fatgrams do not exceed total calories
            If totalcal < 0 Or fatgrams < 0 Then
                MessageBox.Show("Please enter numbers 0 or higher. Re-enter data.",
                                "Error")
            ElseIf fatgrams > totalcal Then
                MessageBox.Show("Grams of fat cannot be higher than total calories, please re-enter data.",
                                "Error")
            Else
                calfromfat = fatgrams * 9
                percentfat = calfromfat / totalcal
                lblPercentage.Text = FormatPercent(percentfat)

                '   Nested If statement to determine if the total percent is under 30% and display a message if its True
                If percentfat < 0.3 Then
                    MessageBox.Show("That's a low fat food!")
                End If
            End If

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter only numbers. Re-enter data.",
                            "Error")
            ClearBoxes()

        Catch ex As Exception

            MessageBox.Show("An unknown error has occured. Retry.",
                            "Error")

        End Try


    End Sub
End Class
