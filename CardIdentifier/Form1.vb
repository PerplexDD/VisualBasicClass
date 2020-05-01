'Card Identifier
'William Butler
'01/10/2019
'A simple program to display 5 card and when clicked on will display the cards name

Option Strict On

'   Simple exit call to close the program
Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    '   Click event handlers for each card with appropiate card name displayed in a string
    Private Sub picCardOne_Click(sender As Object, e As EventArgs) Handles picCardOne.Click

        lblCardName.Text = "Eight of Spades"

    End Sub

    Private Sub picCardTwo_Click(sender As Object, e As EventArgs) Handles picCardTwo.Click

        lblCardName.Text = "Jack of Hearts"

    End Sub

    Private Sub picCardThree_Click(sender As Object, e As EventArgs) Handles picCardThree.Click

        lblCardName.Text = "Queen of Clubs"

    End Sub

    Private Sub picCardFour_Click(sender As Object, e As EventArgs) Handles picCardFour.Click

        lblCardName.Text = "Red Joker"

    End Sub

    Private Sub picCardFive_Click(sender As Object, e As EventArgs) Handles picCardFive.Click

        lblCardName.Text = "Three of Spades"

    End Sub

End Class
