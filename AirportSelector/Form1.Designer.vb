<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddDestination = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblAirports = New System.Windows.Forms.Label()
        Me.lblDestinations = New System.Windows.Forms.Label()
        Me.AirportListBox = New System.Windows.Forms.ListBox()
        Me.DestinationsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAdd.Location = New System.Drawing.Point(41, 341)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(378, 45)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Додади аеродром"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnAddDestination
        '
        Me.btnAddDestination.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAddDestination.Location = New System.Drawing.Point(41, 472)
        Me.btnAddDestination.Name = "btnAddDestination"
        Me.btnAddDestination.Size = New System.Drawing.Size(378, 45)
        Me.btnAddDestination.TabIndex = 10
        Me.btnAddDestination.Text = "Додади дестинација"
        Me.btnAddDestination.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.Location = New System.Drawing.Point(41, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(378, 45)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Избриши аеродром"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblAirports
        '
        Me.lblAirports.AutoSize = True
        Me.lblAirports.Location = New System.Drawing.Point(37, 24)
        Me.lblAirports.Name = "lblAirports"
        Me.lblAirports.Size = New System.Drawing.Size(64, 20)
        Me.lblAirports.TabIndex = 13
        Me.lblAirports.Text = "Airports"
        '
        'lblDestinations
        '
        Me.lblDestinations.AutoSize = True
        Me.lblDestinations.Location = New System.Drawing.Point(484, 24)
        Me.lblDestinations.Name = "lblDestinations"
        Me.lblDestinations.Size = New System.Drawing.Size(98, 20)
        Me.lblDestinations.TabIndex = 14
        Me.lblDestinations.Text = "Destinations"
        '
        'AirportListBox
        '
        Me.AirportListBox.FormattingEnabled = True
        Me.AirportListBox.ItemHeight = 20
        Me.AirportListBox.Location = New System.Drawing.Point(41, 53)
        Me.AirportListBox.Name = "AirportListBox"
        Me.AirportListBox.Size = New System.Drawing.Size(378, 244)
        Me.AirportListBox.TabIndex = 16
        '
        'DestinationsListBox
        '
        Me.DestinationsListBox.FormattingEnabled = True
        Me.DestinationsListBox.ItemHeight = 20
        Me.DestinationsListBox.Location = New System.Drawing.Point(488, 53)
        Me.DestinationsListBox.Name = "DestinationsListBox"
        Me.DestinationsListBox.Size = New System.Drawing.Size(378, 244)
        Me.DestinationsListBox.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 566)
        Me.Controls.Add(Me.DestinationsListBox)
        Me.Controls.Add(Me.AirportListBox)
        Me.Controls.Add(Me.lblDestinations)
        Me.Controls.Add(Me.lblAirports)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAddDestination)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddDestination As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblAirports As Label
    Friend WithEvents lblDestinations As Label
    Friend WithEvents AirportListBox As ListBox
    Friend WithEvents DestinationsListBox As ListBox
End Class
