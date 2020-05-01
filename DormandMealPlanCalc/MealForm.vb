Public Class MealForm

    Private Sub MealPlansForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '   Adds the Meal plans to the list box
        lstMealPlans.Items.Add("7 Meals - " & mdlSevenMeals.ToString("c2"))
        lstMealPlans.Items.Add("14 Meals - " & mdlFourteenMeals.ToString("c2"))
        lstMealPlans.Items.Add("Unlimited Meals - " & mdlUnlimitedMeals.ToString("c2"))

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        '   Closes the Window
        Me.Close()

    End Sub

    Private Sub BtnAddMealPlan_Click(sender As Object, e As EventArgs) Handles btnAddMealPlan.Click

        '   Set variable to hold value for meal plan to add to dorm cost
        Dim decMealPlan As Decimal

        '   Determine if a meal plan is selected and which value was selected then sends to main form
        If lstMealPlans.SelectedIndex = -1 Then
            MessageBox.Show("Please select a meal plan!")
        Else
            If lstMealPlans.SelectedIndex = 0 Then
                DormForm.lblMealPlan.Text = mdlSevenMeals.ToString("c2")
                decMealPlan = mdlSevenMeals.ToString("c2")
            ElseIf lstMealPlans.SelectedIndex = 1 Then
                DormForm.lblMealPlan.Text = mdlFourteenMeals.ToString("c2")
                decMealPlan = mdlFourteenMeals.ToString("c2")
            ElseIf lstMealPlans.SelectedIndex = 2 Then
                DormForm.lblMealPlan.Text = mdlUnlimitedMeals.ToString("c2")
                decMealPlan = mdlUnlimitedMeals.ToString("c2")
            End If
        End If

        '   Calculate the total of dorm and meal play then display on mainform
        DormForm.lblTotal.Text = (DormForm.lblDormitory.Text + decMealPlan).ToString("c2")

        '   Switch back to the main form
        Me.Hide()
        DormForm.Show()

    End Sub
End Class