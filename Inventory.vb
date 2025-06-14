Public Class Inventory
    Private InventoryList As New Dictionary(Of String, Item)
    Public ReadOnly Property Items As Dictionary(Of String, Item).ValueCollection
        Get
            Return InventoryList.Values
        End Get
    End Property

    Public Sub AddItem(item As Item)
        InventoryList.Add(item.IDNumber, item)
    End Sub

    Public Sub RemoveItem(Id As String)

        InventoryList.Remove(Id)

    End Sub

    Public Function GetItem(Id As String) As Item
        Try
            Return InventoryList(Id)
        Catch ex As Exception

            Return Nothing
        End Try

    End Function


End Class
