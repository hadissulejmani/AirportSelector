<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAirport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblShortName = New System.Windows.Forms.Label()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        Me.lblCityName = New System.Windows.Forms.Label()
        Me.txtCityName = New System.Windows.Forms.TextBox()
        Me.lblAirportName = New System.Windows.Forms.Label()
        Me.txtAirportName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblShortName
        '
        Me.lblShortName.AutoSize = True
        Me.lblShortName.Location = New System.Drawing.Point(238, 214)
        Me.lblShortName.Name = "lblShortName"
        Me.lblShortName.Size = New System.Drawing.Size(90, 20)
        Me.lblShortName.TabIndex = 14
        Me.lblShortName.Text = "ShortName"
        '
        'txtShortName
        '
        Me.txtShortName.Location = New System.Drawing.Point(345, 211)
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(218, 26)
        Me.txtShortName.TabIndex = 13
        '
        'lblCityName
        '
        Me.lblCityName.AutoSize = True
        Me.lblCityName.Location = New System.Drawing.Point(238, 160)
        Me.lblCityName.Name = "lblCityName"
        Me.lblCityName.Size = New System.Drawing.Size(35, 20)
        Me.lblCityName.TabIndex = 12
        Me.lblCityName.Text = "City"
        '
        'txtCityName
        '
        Me.txtCityName.Location = New System.Drawing.Point(345, 157)
        Me.txtCityName.Name = "txtCityName"
        Me.txtCityName.Size = New System.Drawing.Size(218, 26)
        Me.txtCityName.TabIndex = 11
        '
        'lblAirportName
        '
        Me.lblAirportName.AutoSize = True
        Me.lblAirportName.Location = New System.Drawing.Point(238, 110)
        Me.lblAirportName.Name = "lblAirportName"
        Me.lblAirportName.Size = New System.Drawing.Size(51, 20)
        Me.lblAirportName.TabIndex = 10
        Me.lblAirportName.Text = "Name"
        '
        'txtAirportName
        '
        Me.txtAirportName.Location = New System.Drawing.Point(345, 107)
        Me.txtAirportName.Name = "txtAirportName"
        Me.txtAirportName.Size = New System.Drawing.Size(218, 26)
        Me.txtAirportName.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAdd.Location = New System.Drawing.Point(345, 291)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 53)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'NewAirport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblShortName)
        Me.Controls.Add(Me.txtShortName)
        Me.Controls.Add(Me.lblCityName)
        Me.Controls.Add(Me.txtCityName)
        Me.Controls.Add(Me.lblAirportName)
        Me.Controls.Add(Me.txtAirportName)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "NewAirport"
        Me.Text = "NewAirport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShortName As Label
    Friend WithEvents txtShortName As TextBox
    Friend WithEvents lblCityName As Label
    Friend WithEvents txtCityName As TextBox
    Friend WithEvents lblAirportName As Label
    Friend WithEvents txtAirportName As TextBox
    Friend WithEvents btnAdd As Button
End Class
