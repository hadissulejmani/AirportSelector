<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddDestination
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
        Me.lblDestinationPrice = New System.Windows.Forms.Label()
        Me.lblDestinationLength = New System.Windows.Forms.Label()
        Me.lblDestinationName = New System.Windows.Forms.Label()
        Me.txtDestinationName = New System.Windows.Forms.TextBox()
        Me.btnAddDestination = New System.Windows.Forms.Button()
        Me.numLength = New System.Windows.Forms.NumericUpDown()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnCancelDestination = New System.Windows.Forms.Button()
        CType(Me.numLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDestinationPrice
        '
        Me.lblDestinationPrice.AutoSize = True
        Me.lblDestinationPrice.Location = New System.Drawing.Point(238, 214)
        Me.lblDestinationPrice.Name = "lblDestinationPrice"
        Me.lblDestinationPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblDestinationPrice.TabIndex = 21
        Me.lblDestinationPrice.Text = "Price"
        '
        'lblDestinationLength
        '
        Me.lblDestinationLength.AutoSize = True
        Me.lblDestinationLength.Location = New System.Drawing.Point(238, 160)
        Me.lblDestinationLength.Name = "lblDestinationLength"
        Me.lblDestinationLength.Size = New System.Drawing.Size(59, 20)
        Me.lblDestinationLength.TabIndex = 19
        Me.lblDestinationLength.Text = "Length"
        '
        'lblDestinationName
        '
        Me.lblDestinationName.AutoSize = True
        Me.lblDestinationName.Location = New System.Drawing.Point(238, 110)
        Me.lblDestinationName.Name = "lblDestinationName"
        Me.lblDestinationName.Size = New System.Drawing.Size(51, 20)
        Me.lblDestinationName.TabIndex = 17
        Me.lblDestinationName.Text = "Name"
        '
        'txtDestinationName
        '
        Me.txtDestinationName.Location = New System.Drawing.Point(345, 107)
        Me.txtDestinationName.Name = "txtDestinationName"
        Me.txtDestinationName.Size = New System.Drawing.Size(218, 26)
        Me.txtDestinationName.TabIndex = 16
        '
        'btnAddDestination
        '
        Me.btnAddDestination.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddDestination.Location = New System.Drawing.Point(267, 282)
        Me.btnAddDestination.Name = "btnAddDestination"
        Me.btnAddDestination.Size = New System.Drawing.Size(107, 53)
        Me.btnAddDestination.TabIndex = 15
        Me.btnAddDestination.Text = "Add"
        Me.btnAddDestination.UseVisualStyleBackColor = False
        '
        'numLength
        '
        Me.numLength.Location = New System.Drawing.Point(345, 160)
        Me.numLength.Name = "numLength"
        Me.numLength.Size = New System.Drawing.Size(218, 26)
        Me.numLength.TabIndex = 22
        '
        'numPrice
        '
        Me.numPrice.Location = New System.Drawing.Point(345, 212)
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(218, 26)
        Me.numPrice.TabIndex = 23
        '
        'btnCancelDestination
        '
        Me.btnCancelDestination.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancelDestination.Location = New System.Drawing.Point(419, 282)
        Me.btnCancelDestination.Name = "btnCancelDestination"
        Me.btnCancelDestination.Size = New System.Drawing.Size(107, 53)
        Me.btnCancelDestination.TabIndex = 24
        Me.btnCancelDestination.Text = "Cancel"
        Me.btnCancelDestination.UseVisualStyleBackColor = False
        '
        'AddDestination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelDestination)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.numLength)
        Me.Controls.Add(Me.lblDestinationPrice)
        Me.Controls.Add(Me.lblDestinationLength)
        Me.Controls.Add(Me.lblDestinationName)
        Me.Controls.Add(Me.txtDestinationName)
        Me.Controls.Add(Me.btnAddDestination)
        Me.Name = "AddDestination"
        Me.Text = "AddDestination"
        CType(Me.numLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDestinationPrice As Label
    Friend WithEvents lblDestinationLength As Label
    Friend WithEvents lblDestinationName As Label
    Friend WithEvents txtDestinationName As TextBox
    Friend WithEvents btnAddDestination As Button
    Friend WithEvents numLength As NumericUpDown
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents btnCancelDestination As Button
End Class
