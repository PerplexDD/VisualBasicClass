Option Strict On

Public Class Form1

    Private strClubNames() As String = {"Honors", "Golden Arrow", "Computer"}
    Private strStudentNames() As String = {"Adams, Ben", "Baker, Sally", "Canseco, Juan", "Davis, Sharon", "Etienne, Jean", "Gonzalez, Jose", "Koenig, Johann",
                                            "Matsunaga, Akiko", "Nakamura, Ken", "Ramirez, Maria"}
    Private intNamesTrack() As Integer = {}

    Private intEnrollmentSize(strClubNames.Count) As Integer

    Private strEnrollments(0, 0) As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '   Add student names to the listbox after making sure its empty
        lstStudentList.Items.Clear()
        For Each studentname As String In strStudentNames
            lstStudentList.Items.Add(studentname)
        Next

        '   Add club names to combo box
        For Each club As String In strClubNames
            cboClubs.Items.Add(club)
        Next

        ReDim strEnrollments(strClubNames.Count, lstStudentList.Items.Count)  ' strEnrollments(2, 10) 3 rows 11 columns

    End Sub

    Function CheckforSelection() As Boolean

        lblMemberCount.Text = String.Empty

        '   Make sure a selection was made in the student list
        If lstStudentList.SelectedIndex = -1 Then
            MessageBox.Show("Please select a name from the General Student List.")
            Return False
        End If

        '   Make sure a selection was made from the combo box
        If cboClubs.SelectedIndex = -1 Then
            MessageBox.Show("Please select a club from the drop down menu.")
            Return False
        End If

        '   Returns True after checking both conditionals
        Return True

    End Function

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click

        If Not CheckforSelection() Then Return

        '   Sets name as the selecteditem from student listbox as a string
        Dim name As String = lstStudentList.SelectedItem.ToString()

        '   clubindex becomes the value of selectedIndex ex. index 1, clubindex = 1
        Dim clubindex As Integer = cboClubs.SelectedIndex

        If Not lstMembershipList.Items.Contains(name) Then
            lstMembershipList.Items.Add(name)
            intEnrollmentSize(clubindex) += 1    '  intNamesTrack(0) = (cboClubs.SelectedIndex)
            lblMemberCount.Text = lstMembershipList.Items.Count.ToString()
        End If

        For i = 0 To lstMembershipList.Items.Count - 1
            strEnrollments(clubindex, i) = lstMembershipList.Items(i).ToString  ' the 2d array adds (index of combobox, and count of member listbox -1) 
        Next

    End Sub
End Class
