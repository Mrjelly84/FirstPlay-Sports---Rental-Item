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

End Class
