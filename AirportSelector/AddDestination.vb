Public Class AddDestination
    Public Destination As Destination

    Public Sub AddDestination()
        InitializeComponent()
    End Sub

    Private Sub btnAddDestination_Click(sender As Object, e As EventArgs) Handles btnAddDestination.Click
        Destination = New Destination(txtDestinationName.Text.Trim(), numLength.Value, numPrice.Value)
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelDestination_Click(sender As Object, e As EventArgs) Handles btnCancelDestination.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class