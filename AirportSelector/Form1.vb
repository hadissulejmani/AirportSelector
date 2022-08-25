Imports System.Data.SqlClient

Public Class Form1
    Dim airports As ArrayList = New ArrayList()

    Public Sub Form1()
        InitializeComponent()
        Dim airport As Airport = New Airport("Александар Велики", "Скопје", "SKP")
        AirportListBox.Items.Add(airport.toString)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newAirport As NewAirport = New NewAirport()

        If newAirport.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            AirportListBox.Items.Add(newAirport.Airport.toString)
        End If
    End Sub

    Private Sub btnAddDestination_Click(sender As Object, e As EventArgs) Handles btnAddDestination.Click
        Dim newDestination As AddDestination = New AddDestination()

        If newDestination.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DestinationsListBox.Items.Add(newDestination.Destination.toString)
        End If
    End Sub

    Private Sub AirportListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AirportListBox.SelectedIndexChanged
        Dim airport As Airport
        For Each airport In AirportListBox.Items
            AirportListBox.DisplayMember = airport.toString()
        Next
    End Sub

    Private Sub btnRemoveAirport_Click(sender As Object, e As EventArgs) Handles btnRemoveAirport.Click
        Dim DialogResult As DialogResult = MessageBox.Show("Are you sure you want to remove this airport?", "Remove airport", MessageBoxButtons.YesNo)
        If (DialogResult = DialogResult.Yes) Then
            'do something
        ElseIf (DialogResult = DialogResult.No) Then
            'do something else
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WINFORMS_DBDataSet.Airport' table. You can move, or remove it, as needed.
        Me.AirportTableAdapter.Fill(Me.WINFORMS_DBDataSet.Airport)

        'Dim connection As SqlConnection = New SqlConnection()
        'connection.ConnectionString = "Data Source=localhost;Initial Catalog=WINFORMS_DB;Integrated Security=True"
        'connection.Open()
        'Dim adp As SqlDataAdapter = New SqlDataAdapter("select * from Airport", connection)
        'Dim ds As DataSet = New DataSet()
        'adp.Fill(ds)

        'DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class
