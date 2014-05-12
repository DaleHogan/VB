'Your client requires an application to determine the age of the oldest person in any family.
'Your program will use a textbox to accept ages and add the numbers to a listbox.
'To find the oldest member of a family the user will click a button which will use a loop (see text p.295) to find the largest number in the listbox.
'As this exercise is designed to give you practice with looping do not sort the listbox for your solution.

Public Class Form1

    Private AgeValidator As Boolean
    Private OldestAge As Integer

    'Adds the Age entered in the TextBox to the list box.
    Private Sub EnterAgeButton_Click(sender As Object, e As EventArgs) Handles EnterAgeButton.Click
        AgeValidatorLabel.Visible = False
        ValidateAge()
        If (AgeValidator = True) Then
            AgeListBox.Items.Add(AgeTextBox.Text)
        End If
    End Sub

    'Validates the users input and assigns true or false to AgeValidator boolean
    Private Function ValidateAge()
        If (AgeTextBox.Text.Equals("") Or IsNumeric(AgeTextBox.Text) = False) Then
            AgeValidator = False
            AgeValidatorLabel.Text = "Please enter a valid Age"
            AgeValidatorLabel.Visible = True
            Return AgeValidator
        ElseIf (Convert.ToInt16(AgeTextBox.Text) <= 0) Then
            AgeValidator = False
            AgeValidatorLabel.Text = "You can't be less than 0 years dummy"
            AgeValidatorLabel.Visible = True
            Return AgeValidator
        End If
        AgeValidator = True
        Return AgeValidator
    End Function

    'Finds the value of the oldest member of the family
    Private Sub OldMemberButton_Click(sender As Object, e As EventArgs) Handles OldMemberButton.Click
        For Each Age In AgeListBox.Items
            If (Age >= OldestAge) Then
                OldestAge = Age
            End If
        Next
        MessageBox.Show("The oldest Age is: " + OldestAge.ToString())
    End Sub

    'Closes the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
