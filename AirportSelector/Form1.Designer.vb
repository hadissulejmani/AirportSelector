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
        Me.components = New System.ComponentModel.Container()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddDestination = New System.Windows.Forms.Button()
        Me.btnRemoveAirport = New System.Windows.Forms.Button()
        Me.lblAirports = New System.Windows.Forms.Label()
        Me.lblDestinations = New System.Windows.Forms.Label()
        Me.AirportListBox = New System.Windows.Forms.ListBox()
        Me.DestinationsListBox = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WINFORMS_DBDataSet = New AirportSelector.WINFORMS_DBDataSet()
        Me.AirportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AirportTableAdapter = New AirportSelector.WINFORMS_DBDataSetTableAdapters.AirportTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WINFORMS_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnRemoveAirport
        '
        Me.btnRemoveAirport.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRemoveAirport.Location = New System.Drawing.Point(41, 408)
        Me.btnRemoveAirport.Name = "btnRemoveAirport"
        Me.btnRemoveAirport.Size = New System.Drawing.Size(378, 45)
        Me.btnRemoveAirport.TabIndex = 11
        Me.btnRemoveAirport.Text = "Избриши аеродром"
        Me.btnRemoveAirport.UseVisualStyleBackColor = False
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
        Me.AirportListBox.DataSource = Me.AirportBindingSource
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.ShortNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AirportBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(488, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 18
        '
        'WINFORMS_DBDataSet
        '
        Me.WINFORMS_DBDataSet.DataSetName = "WINFORMS_DBDataSet"
        Me.WINFORMS_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AirportBindingSource
        '
        Me.AirportBindingSource.DataMember = "Airport"
        Me.AirportBindingSource.DataSource = Me.WINFORMS_DBDataSet
        '
        'AirportTableAdapter
        '
        Me.AirportTableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 150
        '
        'ShortNameDataGridViewTextBoxColumn
        '
        Me.ShortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName"
        Me.ShortNameDataGridViewTextBoxColumn.HeaderText = "ShortName"
        Me.ShortNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ShortNameDataGridViewTextBoxColumn.Name = "ShortNameDataGridViewTextBoxColumn"
        Me.ShortNameDataGridViewTextBoxColumn.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 566)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DestinationsListBox)
        Me.Controls.Add(Me.AirportListBox)
        Me.Controls.Add(Me.lblDestinations)
        Me.Controls.Add(Me.lblAirports)
        Me.Controls.Add(Me.btnRemoveAirport)
        Me.Controls.Add(Me.btnAddDestination)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WINFORMS_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddDestination As Button
    Friend WithEvents btnRemoveAirport As Button
    Friend WithEvents lblAirports As Label
    Friend WithEvents lblDestinations As Label
    Friend WithEvents AirportListBox As ListBox
    Friend WithEvents DestinationsListBox As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WINFORMS_DBDataSet As WINFORMS_DBDataSet
    Friend WithEvents AirportBindingSource As BindingSource
    Friend WithEvents AirportTableAdapter As WINFORMS_DBDataSetTableAdapters.AirportTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
