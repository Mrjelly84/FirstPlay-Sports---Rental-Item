Public Class Form1

    Private inv As New Inventory
    Private inFile As New InventoryFile("H:\coding\vb dot net\FirstPlay Sports - Rental Item\Inventory.txt")





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            inFile.LoadData(inv)
            FillCombo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cannot load data file")
        End Try

    End Sub

    Private Sub FillCombo()
        cboIdNumber.Items.Clear()
        For Each anItem As Item In inv.Items
            cboIdNumber.Items.Add(anItem.IDNumber)
        Next
        If cboIdNumber.Items.Count > 0 Then
            cboIdNumber.SelectedIndex = 0
        End If
    End Sub




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub cboIdNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdNumber.SelectedIndexChanged
        Dim anitem As Item = inv.GetItem(cboIdNumber.Text)
        If anitem Is Nothing Then
            MessageBox.Show("This item ID was not found")
            ClearFields()
        Else
            txtDescription.Text = anitem.Description
            txtDaily.Text = anitem.DailyRate.ToString()
            txtWeekly.Text = anitem.WeeklyRate.ToString()
            txtMonthly.Text = anitem.MonthlyRate.ToString()
            txtQuantity.Text = anitem.Quantity.ToString()

        End If

    End Sub

    Private Sub ClearFields()
        txtDescription.Clear()
        txtDaily.Clear()
        txtMonthly.Clear()
        txtQuantity.Clear()
        txtWeekly.Clear()
        cboIdNumber.Text = String.Empty

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim anItem As New Item
            With anItem
                .IDNumber = cboIdNumber.Text
                .Description = txtDescription.Text
                .DailyRate = CSng(txtDaily.Text)
                .WeeklyRate = CSng(txtWeekly.Text)
                .MonthlyRate = CSng(txtMonthly.Text)
                .Quantity = CInt(txtQuantity.Text)
            End With
            inv.AddItem(anItem)
            FillCombo()
            MessageBox.Show("The item was add to the inventory")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
    End Sub
End Class
