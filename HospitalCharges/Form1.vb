Option Strict On

Public Class Form1

    '   Make a constant variable for daily charge
    Private Const perDayCharge As Decimal = 350

    '   Make variables to hold the input from textboxes
    Dim daysStayed As Integer
    Dim medCharges As Decimal
    Dim surgicalCharges As Decimal
    Dim labFees As Decimal
    Dim physRehab As Decimal


    '   Function to validate all text inputs in order to make sure they are numerical
    Private Function ValidateInputFields() As Boolean

        If Not Integer.TryParse(txtDaysInput.Text, daysStayed) Then
            lblTotalCostOutput.Text = "Days stayed must be numerical."
            Return False
        End If

        If Not Decimal.TryParse(txtMedInput.Text, medCharges) Then
            lblTotalCostOutput.Text = "Medication charges must be numerical."
            Return False
        End If

        If Not Decimal.TryParse(txtSurgChargesInput.Text, surgicalCharges) Then
            lblTotalCostOutput.Text = "Surgical charges must be numerical."
            Return False
        End If

        If Not Decimal.TryParse(txtLabFeesInput.Text, labFees) Then
            lblTotalCostOutput.Text = "Lab fees must be numerical."
            Return False
        End If

        If Not Decimal.TryParse(txtPhysRehabInput.Text, physRehab) Then
            lblTotalCostOutput.Text = "Physical rehab costs must be numerical."
            Return False
        End If

        If CInt(txtDaysInput.Text) < 0 Then
            lblTotalCostOutput.Text = "Days stayed must be a positive number."
            Return False
        End If

        If CInt(txtMedInput.Text) < 0 Then
            lblTotalCostOutput.Text = "Medical costs must be a positive amount."
            Return False
        End If

        If CInt(txtSurgChargesInput.Text) < 0 Then
            lblTotalCostOutput.Text = "Surgical costs must be a positive amount."
            Return False
        End If

        If CInt(txtLabFeesInput.Text) < 0 Then
            lblTotalCostOutput.Text = "Lab fee must be a positive amount."
            Return False
        End If

        If CInt(txtPhysRehabInput.Text) < 0 Then
            lblTotalCostOutput.Text = "Physical rehab cost must be a positive amount."
            Return False
        End If

        Return True
    End Function

    '   Function to calculate the charges for staying each night
    Private Function CalcStayCharges() As Decimal

        '   Create variable to hold the full charges
        Dim chargesDaysStayed As Decimal

        chargesDaysStayed = daysStayed * perDayCharge

        Return chargesDaysStayed
    End Function

    '   Function to calculate sum of misc charges
    Private Function CalcMiscCharges() As Decimal

        '   Create variable for sum of all misc charges
        Dim sumMiscCharges As Decimal

        sumMiscCharges = surgicalCharges + labFees + physRehab + medCharges

        Return sumMiscCharges
    End Function

    '   Function to calculate sum of misc charges and daily stay charges
    Private Function CalcTotalCharges() As Decimal

        '   Create variable to hold sum
        Dim totalCharges As Decimal

        totalCharges = CalcMiscCharges() + CalcStayCharges()

        Return totalCharges
    End Function

    '   A click event to calculate total for all charges
    Private Sub btnCalcCharges_Click(sender As Object, e As EventArgs) Handles btnCalcCharges.Click

        '   Create variable to hold full sum
        Dim displayTotalCharges As Decimal
        If ValidateInputFields() Then
            displayTotalCharges = CalcTotalCharges()
            lblTotalCostOutput.Text = displayTotalCharges.ToString("c")
        End If

    End Sub

    '   A click event to clear the form for data re-entry
    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click

        txtDaysInput.Text = String.Empty
        txtLabFeesInput.Text = String.Empty
        txtMedInput.Text = String.Empty
        txtPhysRehabInput.Text = String.Empty
        txtSurgChargesInput.Text = String.Empty
        lblTotalCostOutput.Text = String.Empty

        '   Returns focus to the daysinput text box
        txtDaysInput.Focus()
    End Sub

    '   Simple Exit call to close the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
