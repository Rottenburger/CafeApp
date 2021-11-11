Public Class Form3
    Public Total = Form2.Total
    'This button sends the user back to form2 to change their purchase if they want to
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    'This cancels the current order and sends the user back to the start screen
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        Form1.Show()
        Form2.Total = 0.0
        Form2.TotalLbl.Text = "£ " + Form2.Total.ToString
        Form2.PurchaseList.Items.Clear()

    End Sub

    'This will give the user a message box to choose to either close the application or cancel
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim answer As MsgBoxResult

        answer = MsgBox("Are you sure you want to close this application?", MsgBoxStyle.YesNo, "Are you sure?")
        If answer = MsgBoxResult.No Then e.Cancel = True
        If answer = MsgBoxResult.Yes Then Application.Exit()

    End Sub

End Class