Public Class Form1
    'This button closes the first form and opens the second form
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Me.Hide()
        Form2.Show()
    End Sub

    'This will give the user a message box to choose to either close the application or cancel
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim answer As MsgBoxResult

        answer = MsgBox("Are you sure you want to close this application?", MsgBoxStyle.YesNo, "Are you sure?")
        If answer = MsgBoxResult.No Then e.Cancel = True
        If answer = MsgBoxResult.Yes Then Application.Exit()

    End Sub

End Class
