Option Explicit On
Option Strict On

'Title: Quiz 3
'Author: Dale Hogan
'Version: n/a
'Date: April 2014

Public Class Form1
    'Use Exercise 8.4 pg 375 in Programming in Visual Basic PDF
    'Create a solution to search states by their name and abbreviation
    'Show error message if null result
    ' Use radio buttons with a shared event procedure and a Select case
    'to determine which text box (whole name or abbreviation) should have the
    'focus and which should be set to ReadOnly.

    Private Structure State
        Dim StateName As String
        Dim StateAcronymn As String
    End Structure

    Private States(6) As State
    Private FoundBoolean As Boolean = False
    Private NullResult As Integer = 1

    Private Sub SearchState(sender As Object, e As EventArgs) Handles StateRadioButton.Click, AbreviatedRadioButton.Click
        SearchButton.PerformClick()
        Do While FoundBoolean = False
            Select Case True
                Case AbreviatedRadioButton.Checked
                    For Each Item In AbreviationListBox.Items
                        If (Item.Equals(InputTextBox.Text)) Then
                            AbreviationListBox.SelectedItem = Item
                            FoundBoolean = True
                            Exit For
                        End If
                    Next

                Case StateRadioButton.Checked
                    For Each Item In StateNameListBox.Items
                        If (Item.Equals(InputTextBox.Text)) Then
                            StateNameListBox.SelectedItem = Item
                            FoundBoolean = True
                            Exit For
                        End If
                    Next
            End Select
            If FoundBoolean = False Then
                MessageBox.Show("No Matches", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                FoundBoolean = True
                Exit Do
            End If
        Loop
        FoundBoolean = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        States(0).StateAcronymn = "NSW"
        States(1).StateAcronymn = "QLD"
        States(2).StateAcronymn = "SA"
        States(3).StateAcronymn = "TAS"
        States(4).StateAcronymn = "VIC"
        States(5).StateAcronymn = "WA"
        States(6).StateAcronymn = "NT"
        States(0).StateName = "New South Wales"
        States(1).StateName = "Queensland"
        States(2).StateName = "South Australia"
        States(3).StateName = "Tasmania"
        States(4).StateName = "Victoria"
        States(5).StateName = "Western Australia"
        States(6).StateName = "Northern Territory"
        For Each State As State In States
            AbreviationListBox.Items.Add(State.StateAcronymn)
            StateNameListBox.Items.Add(State.StateName)
        Next
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If InputTextBox.Text.Equals("") Or IsNumeric(InputTextBox.Text) = True Then
            MessageBox.Show("Please enter a valid input e.g. alpha characters", "Data Entry Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AbreviatedRadioButton.Checked = False
            StateRadioButton.Checked = False
        End If
    End Sub
End Class
