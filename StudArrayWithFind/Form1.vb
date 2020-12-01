'Tom Nguyen 1.7.2 Improved design and validation
Public Class Form1
    'set up a record or "class" for a student
    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public DOB As Date
        Public gender As Char
        Public avMk As Single
        Public phoneNo As String
        Public paid As Boolean
    End Class
    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'load 4 test records
        students(0).firstname = "Johnny"
        students(0).lastname = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "m"
        students(0).avMk = 78.2
        students(0).phoneNo = 473759347
        students(0).paid = False
        students(1).firstname = "Jennifer"
        students(1).lastname = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "f"
        students(1).avMk = 88.2
        students(1).phoneNo = 709377653
        students(1).paid = True
        students(2).firstname = "George"
        students(2).lastname = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "f"
        students(2).avMk = 68.2
        students(2).phoneNo = 476983470
        students(2).paid = True
        students(3).firstname = "Scarlett"
        students(3).lastname = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "f"
        students(3).avMk = 72.2
        students(3).phoneNo = 481704007
        students(3).paid = False
        'set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        'VALIDATION:'
        'Validate if anything has been inputted in the "First Name" box:'
        If txtFirstName.Text = "" Then
            MsgBox("Please enter a 'first name'.", MsgBoxStyle.Exclamation, "Go to the First Name field and input a name, please!")
            txtFirstName.Focus()
            Exit Sub
        End If

        'Validate that name is less than 20 characters'
        If Len(txtFirstName.Text) > 20 Then
            MsgBox("Please enter a 'first name' less than 20 characters.", MsgBoxStyle.Exclamation, "Go to the First Name field and input a proper name, please!")
            txtFirstName.Focus()
            Exit Sub
        End If


        'Validate if anything has been inputted in the "Last Name" box:'
        If txtLastName.Text = "" Then
            MsgBox("Please enter a 'last name'.", MsgBoxStyle.Exclamation, "Go to the Last Name field and input a name, please!")
            txtLastName.Focus()
            Exit Sub
        End If

        'Validate that name is less than 20 characters'
        If Len(txtLastName.Text) > 20 Then
            MsgBox("Please enter a 'last name' less than 20 characters.", MsgBoxStyle.Exclamation, "Go to the Last Name field and input a proper name, please!")
            txtLastName.Focus()
            Exit Sub
        End If

        'Validate if actual DoB:'
        If Not IsDate(txtDOB.Text) Then
            MsgBox("Please enter in a DoB between 1960 and 2010 in the format of 'd/mm/yy'", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtDOB.Focus()
            Exit Sub
        End If

        'Validate that the gender field holds "m" of "f":'
        If Not (LCase(txtGender.Text) = "m" Or LCase(txtGender.Text) = "f") Then
            MsgBox("Please enter 'f' or 'm' ", MsgBoxStyle.Exclamation, "Check Gender field")
            txtGender.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtAvMk.Text) Then
            MsgBox("Please enter an 'average mark' (between 0-100).", MsgBoxStyle.Exclamation, "Go to the Average Mark field and input a mark, please!")
            txtAvMk.Focus()
            Exit Sub
        End If

        If Not Len(Trim(txtPhone.Text)) = 10 Then
            MsgBox("Please enter 10 digits for the phone number", MsgBoxStyle.Exclamation, "Check Phone Number field (10 digits)")
            txtPhone.Focus()
            Exit Sub
        End If

        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstname = txtFirstName.Text
        students(studentCount).lastname = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = txtGender.Text
        students(studentCount).avMk = txtAvMk.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).paid = chkPaid.Checked
        studentCount += 1

        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = ""
        txtGender.Text = ""
        txtAvMk.Text = ""
        txtPhone.Text = ""
        chkPaid.Text = "Paid"
        displayList()
    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            lstStud.Items.Add(students(i).firstname & " - " & students(i).lastname & " - " &
                              students(i).DOB & " - " & students(i).gender & " - " & students(i).avMk &
                              " - " & students(i).phoneNo & " - " & students(i).paid & ".")
        Next
    End Sub

    Private Sub lstStud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStud.SelectedIndexChanged

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.Validating

    End Sub

    Private Sub txtDOB_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtGender_TextChanged(sender As Object, e As EventArgs) Handles txtGender.TextChanged

    End Sub

    Private Sub txtAvMk_TextChanged(sender As Object, e As EventArgs) Handles txtAvMk.TextChanged

    End Sub

    Private Sub chkPaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaid.CheckedChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
