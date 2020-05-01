' Dormitory and Meal Plan Calculator
' William Butler
' 1/18/20
' A short program with two forms to calculate dorm and meal plan costs given multiple options

Option Strict On

Public Class DormForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '   Adds the Dorms to the listbox
        lstDormitory.Items.Add("Allen Hall - " & mdlAllenHall.ToString("c"))
        lstDormitory.Items.Add("Pike Hall - " & mdlPikeHall.ToString("c"))
        lstDormitory.Items.Add("Farthing Hall - " & mdlFarthingHall.ToString("c"))
        lstDormitory.Items.Add("University Suites - " & mdlUniversitySuites.ToString("c"))

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '   Closes the Window
        Me.Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        '   Clears the Labels values
        lblDormitory.Text = String.Empty
        lblMealPlan.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub

    Private Sub BtnViewMealPlan_Click(sender As Object, e As EventArgs) Handles btnViewMealPlan.Click

        '   Show the MealPlans Form and makes sure a dorm was selected
        If lstDormitory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a dormitory please!")
        Else
            Me.Hide()
            MealForm.Show()
        End If


    End Sub

    Private Sub BtnAddDormitory_Click(sender As Object, e As EventArgs) Handles btnAddDormitory.Click

        '   Makes sure a dorm was selected and then relates the index selected to the correct dorm variable
        If lstDormitory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a dormitory please!")
        Else
            If lstDormitory.SelectedIndex = 0 Then
                lblDormitory.Text = mdlAllenHall.ToString("c2")
            ElseIf lstDormitory.SelectedIndex = 1 Then
                lblDormitory.Text = mdlPikeHall.ToString("c2")
            ElseIf lstDormitory.SelectedIndex = 2 Then
                lblDormitory.Text = mdlFarthingHall.ToString("c2")
            ElseIf lstDormitory.SelectedIndex = 3 Then
                lblDormitory.Text = mdlUniversitySuites.ToString("c2")
            End If
        End If

    End Sub

End Class
