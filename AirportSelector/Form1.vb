﻿Public Class Form1
    Dim airports As ArrayList = New ArrayList()

    Public Sub Form1()
        InitializeComponent()
        Dim airport As Airport = New Airport("Александар Велики", "Скопје", "SKP")
        AirportListBox.Items.Add(airport.toString)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newAirport As NewAirport = New NewAirport()

        If newAirport.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            AirportListBox.Items.Add(newAirport.Airport)
            AirportListBox.DisplayMember = newAirport.Airport.toString()
        End If
    End Sub

    Private Sub btnAddDestination_Click(sender As Object, e As EventArgs) Handles btnAddDestination.Click

    End Sub

    Private Sub AirportListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AirportListBox.SelectedIndexChanged
        Dim airport As Airport
        For Each airport In AirportListBox.Items
            AirportListBox.DisplayMember = airport.toString()
        Next
    End Sub
End Class