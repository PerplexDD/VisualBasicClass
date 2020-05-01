'Distance Calculator
'William Butler 
'1/10/20
'A short program to display accumulative distance travled and total distance traveled

Option Strict On

Public Class Form1

    '   Basic exit program button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '   Clears the textbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDistDisplay.Text = String.Empty
    End Sub

    '   Calculates the traveled distance
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Try

            '   Declare needed variables and inputboxes
            Dim speed As Integer
            Dim hours As Integer
            speed = CInt(InputBox("Enter the Speed:", "Speed"))
            hours = CInt(InputBox("Enter the Hours traveled:", "Hours"))
            Dim milesTraveled As Integer = speed * hours

            '   Quick conditional to make sure no negative integers
            If speed < 0 Or hours < 0 Then
                MessageBox.Show("Positive numbers only.",
                                "Error")
                txtDistDisplay.Text = String.Empty

            Else

                '   Declare the string for the textbox
                Dim distoutput As String = "Vehicle Speed: " & speed & " MPH" & Environment.NewLine
                distoutput &= "Time Traveled: " & hours & " Hours" & Environment.NewLine
                distoutput &= "Hours     Distance Traveled" & Environment.NewLine
                distoutput &= "-------------------------------------" & Environment.NewLine

                '   Basic for loop in the range of 1 to amount of hours traveled with string added to textbox each iteration
                '   to show hours relative to distance traveled
                For i As Integer = 1 To hours

                    distoutput &= CStr(i) & "             " & CStr(speed * i) & Environment.NewLine

                Next

                '   Outputs the string needed for the textbox after all is complete
                distoutput &= "Total Distance: " & CStr(milesTraveled) & " Miles"
                txtDistDisplay.Text = distoutput

            End If



        Catch ex As System.InvalidCastException

            MessageBox.Show("Please use numbers only.",
                            "Error")

        Catch ex As Exception

            MessageBox.Show("An unknown error as occured, try again.",
                            "Error")

        End Try


    End Sub

End Class
