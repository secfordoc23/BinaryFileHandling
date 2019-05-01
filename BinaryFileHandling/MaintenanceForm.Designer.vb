<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceForm
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
        Me.productListBox = New System.Windows.Forms.ListBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.productLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'productListBox
        '
        Me.productListBox.FormattingEnabled = True
        Me.productListBox.ItemHeight = 20
        Me.productListBox.Location = New System.Drawing.Point(12, 55)
        Me.productListBox.Name = "productListBox"
        Me.productListBox.Size = New System.Drawing.Size(502, 344)
        Me.productListBox.TabIndex = 0
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(12, 405)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(107, 40)
        Me.addButton.TabIndex = 1
        Me.addButton.Text = "&Add Product"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(125, 405)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(136, 40)
        Me.removeButton.TabIndex = 2
        Me.removeButton.Text = "&Remove Product"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(407, 405)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(107, 40)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'productLabel
        '
        Me.productLabel.AutoSize = True
        Me.productLabel.Location = New System.Drawing.Point(12, 32)
        Me.productLabel.Name = "productLabel"
        Me.productLabel.Size = New System.Drawing.Size(80, 20)
        Me.productLabel.TabIndex = 4
        Me.productLabel.Text = "Products: "
        '
        'MaintenanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 469)
        Me.Controls.Add(Me.productLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.productListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MaintenanceForm"
        Me.Text = "Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents productListBox As ListBox
    Friend WithEvents addButton As Button
    Friend WithEvents removeButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents productLabel As Label
End Class
