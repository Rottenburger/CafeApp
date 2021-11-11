Public Class Form2

    '
    ' Here is all the logic for form2
    '

    'All the Variables used for this form and form3
    Public Total As Decimal = 0.0
    Public VAT As Decimal = 0.2
    Public Percentage As Decimal
    Public DrinksPrice = {2.99, 2.99, 1.5, 1.99, 2.99, 3.99, 2.99, 1.0, 3.0}
    Public FoodPrice = {5.0, 5.0, 2.0, 6.0, 1.75, 4.0, 3.5, 6.99, 2.0, 3.0, 2.5}
    Public DrinksName = {"Latte", "Cappuccino", "Americano", "Espresso", "Mocha", "Affogato", "Hot Chocolate", "Coke", "Milkshake"}
    Public FoodName = {"Chocolate Cake", "Coffee Cake", "Brownie", "Cheesecake", "Flapjack", "Trifle", "Crème brûlée", "Fruit bowl", "Mousse", "Flan", "Custard"}


    'This button cancels the current transaction by reseting the total and clearing the purchase list before closing form2 and opening form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form1.Show()
        Total = 0.0
        TotalLbl.Text = "£ " + Total.ToString
        PurchaseList.Items.Clear()

    End Sub

    'This contains all the drinks buttons and their actions, once clicked they each add their respective drinks name to the pruchase list and their price to the Total
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        PurchaseList.Items.Add(DrinksName(0))
        Total = Total + DrinksPrice(0)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        PurchaseList.Items.Add(DrinksName(1))
        Total = Total + DrinksPrice(1)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        PurchaseList.Items.Add(DrinksName(2))
        Total = Total + DrinksPrice(2)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        PurchaseList.Items.Add(DrinksName(3))
        Total = Total + DrinksPrice(3)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        PurchaseList.Items.Add(DrinksName(4))
        Total = Total + DrinksPrice(4)

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        PurchaseList.Items.Add(DrinksName(5))
        Total = Total + DrinksPrice(5)

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        PurchaseList.Items.Add(DrinksName(6))
        Total = Total + DrinksPrice(6)

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

        PurchaseList.Items.Add(DrinksName(7))
        Total = Total + DrinksPrice(7)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        PurchaseList.Items.Add(DrinksName(8))
        Total = Total + DrinksPrice(8)

    End Sub

    'Whenever a food item is added to the purchase list using the add button, this will compare the selected item to every food item from the array and add whichever matches to the purchase list
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim SelectedListview As String
        SelectedListview = ListView2.FocusedItem.Text
        Select Case SelectedListview
            Case FoodName(0)
                PurchaseList.Items.Add(FoodName(0))
                Total = Total + FoodPrice(0)
            Case FoodName(1)
                PurchaseList.Items.Add(FoodName(1))
                Total = Total + FoodPrice(1)
            Case FoodName(2)
                PurchaseList.Items.Add(FoodName(2))
                Total = Total + FoodPrice(2)
            Case FoodName(3)
                PurchaseList.Items.Add(FoodName(3))
                Total = Total + FoodPrice(3)
            Case FoodName(4)
                PurchaseList.Items.Add(FoodName(4))
                Total = Total + FoodPrice(4)
            Case FoodName(5)
                PurchaseList.Items.Add(FoodName(5))
                Total = Total + FoodPrice(5)
            Case FoodName(6)
                PurchaseList.Items.Add(FoodName(6))
                Total = Total + FoodPrice(6)
            Case FoodName(7)
                PurchaseList.Items.Add(FoodName(7))
                Total = Total + FoodPrice(7)
            Case FoodName(8)
                PurchaseList.Items.Add(FoodName(8))
                Total = Total + FoodPrice(8)
            Case FoodName(9)
                PurchaseList.Items.Add(FoodName(9))
                Total = Total + FoodPrice(9)
            Case FoodName(10)
                PurchaseList.Items.Add(FoodName(10))
                Total = Total + FoodPrice(10)

        End Select

    End Sub

    'Handles whenever a button is pressed/item is added to list so that the total can be rounded to two decimal places
    Private Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles PictureBox1.Click, PictureBox2.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox8.Click, PictureBox10.Click, PictureBox9.Click, Button3.Click, PictureBox11.Click

        'Percentage = Total * VAT
        'Total = Total + Percentage
        Total = Math.Round([Total], 2, MidpointRounding.AwayFromZero)
        TotalLbl.Text = "£ " + Total.ToString

    End Sub

    'This handles the logic for removing items on the purchase list by comparing selected items to each of the arrays
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RemoveItemText As String
        RemoveItemText = PurchaseList.SelectedItem
        Select Case RemoveItemText
            'Drinks
            Case DrinksName(0)
                Total = Total - DrinksPrice(0)
            Case DrinksName(1)
                Total = Total - DrinksPrice(1)
            Case DrinksName(2)
                Total = Total - DrinksPrice(2)
            Case DrinksName(3)
                Total = Total - DrinksPrice(3)
            Case DrinksName(4)
                Total = Total - DrinksPrice(4)
            Case DrinksName(5)
                Total = Total - DrinksPrice(5)
            Case DrinksName(6)
                Total = Total - DrinksPrice(6)
            Case DrinksName(7)
                Total = Total - DrinksPrice(7)
            Case DrinksName(8)
                Total = Total - DrinksPrice(8)
            'Food
            Case FoodName(0)
                Total = Total - FoodPrice(0)
            Case FoodName(1)
                Total = Total - FoodPrice(1)
            Case FoodName(2)
                Total = Total - FoodPrice(2)
            Case FoodName(3)
                Total = Total - FoodPrice(3)
            Case FoodName(4)
                Total = Total - FoodPrice(4)
            Case FoodName(5)
                Total = Total - FoodPrice(5)
            Case FoodName(6)
                Total = Total - FoodPrice(6)
            Case FoodName(7)
                Total = Total - FoodPrice(7)
            Case FoodName(8)
                Total = Total - FoodPrice(8)
            Case FoodName(9)
                Total = Total - FoodPrice(9)
            Case FoodName(10)
                Total = Total - FoodPrice(10)
            Case Else

        End Select

        TotalLbl.Text = "£ " + Total.ToString
        PurchaseList.Items.RemoveAt(PurchaseList.SelectedIndex())

    End Sub

    'This handles the logic for selecting an item from the food menu and displaying it to the user
    Private Sub ListView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.Click

        Dim SelectedListview As String
        SelectedListview = ListView2.FocusedItem.Text
        Select Case SelectedListview
            Case FoodName(0)
                PictureBoxMenu.Image = My.Resources.chocolatecake
                FoodLbl.Text = FoodName(0) + " £" + FoodPrice(0).ToString
            Case FoodName(1)
                PictureBoxMenu.Image = My.Resources.coffeecake
                FoodLbl.Text = FoodName(1) + " £" + FoodPrice(1).ToString
            Case FoodName(2)
                PictureBoxMenu.Image = My.Resources.brownie
                FoodLbl.Text = FoodName(2) + " £" + FoodPrice(2).ToString
            Case FoodName(3)
                PictureBoxMenu.Image = My.Resources.cheesecake
                FoodLbl.Text = FoodName(3) + " £" + FoodPrice(3).ToString
            Case FoodName(4)
                PictureBoxMenu.Image = My.Resources.flapjack
                FoodLbl.Text = FoodName(4) + " £" + FoodPrice(4).ToString
            Case FoodName(5)
                PictureBoxMenu.Image = My.Resources.trifle
                FoodLbl.Text = FoodName(5) + " £" + FoodPrice(5).ToString
            Case FoodName(6)
                PictureBoxMenu.Image = My.Resources.cremebrulee
                FoodLbl.Text = FoodName(6) + " £" + FoodPrice(6).ToString
            Case FoodName(7)
                PictureBoxMenu.Image = My.Resources.fruitbowl
                FoodLbl.Text = FoodName(7) + " £" + FoodPrice(7).ToString
            Case FoodName(8)
                PictureBoxMenu.Image = My.Resources.mousse
                FoodLbl.Text = FoodName(8) + " £" + FoodPrice(8).ToString
            Case FoodName(9)
                PictureBoxMenu.Image = My.Resources.flan
                FoodLbl.Text = FoodName(9) + " £" + FoodPrice(9).ToString
            Case FoodName(10)
                PictureBoxMenu.Image = My.Resources.custard
                FoodLbl.Text = FoodName(10) + " £" + FoodPrice(10).ToString

            Case Else

        End Select


    End Sub

    'This will give the user a message box to choose to either close the application or cancel
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim answer As MsgBoxResult

        answer = MsgBox("Are you sure you want to close this application?", MsgBoxStyle.YesNo, "Are you sure?")
        If answer = MsgBoxResult.No Then e.Cancel = True
        If answer = MsgBoxResult.Yes Then Application.Exit()

    End Sub

    'This button closes the second form and opens the third one
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Form3.TotalLbl2.Text = "£ " + Total.ToString
        Me.Hide()
        Form3.Show()

    End Sub

End Class
