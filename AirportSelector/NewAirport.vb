Public Class NewAirport
    Public Airport As Airport

    Public Sub NewAirport()
        InitializeComponent()
    End Sub

    Private Sub ShortName_Validating(sender As Object, e As EventArgs)
        If txtShortName.Text.Trim().Length <> 3 Then
            Dim errorProvider As ErrorProvider = New ErrorProvider("shortname needs to be 3 chars!")
            'Throw errorProvider
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Airport = New Airport(txtAirportName.Text.Trim, txtCityName.Text.Trim, txtShortName.Text.Trim)
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class