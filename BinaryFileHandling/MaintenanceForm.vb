'Program: BinaryFileHandling
'Me: MaintenanceForm.vb
'Date: 4/30/2019
'Author: Jason Welch
'Purpose: Read and Write from a Binary File

Option Strict On
Option Explicit On

Imports System.ComponentModel

Public Class MaintenanceForm
    '==========================================================================================
    'Name: exitButton_Click
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Starts program closing process
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub
    '==========================================================================================
    'Name: MaintenanceForm_Closing
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose: Gives user opportunity to not leave program
    Private Sub MaintenanceForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (MessageBox.Show("Are you sure?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
    'Name: addButton_Click
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose:
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

    End Sub
    'Name: removeButton_Click
    'Date: 4/30/2019
    'Author: Jason Welch
    'Purpose:
    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click

    End Sub
End Class
