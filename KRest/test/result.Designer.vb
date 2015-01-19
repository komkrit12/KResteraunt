<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class result
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodName2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodPrice2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lb_order = New System.Windows.Forms.Label()
        Me.lb_o = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodName2, Me.FoodPrice2, Me.OrderId})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(342, 310)
        Me.DataGridView1.TabIndex = 194
        '
        'FoodName2
        '
        Me.FoodName2.DataPropertyName = "FoodName"
        Me.FoodName2.HeaderText = "ชื่ออาหาร"
        Me.FoodName2.Name = "FoodName2"
        '
        'FoodPrice2
        '
        Me.FoodPrice2.DataPropertyName = "FoodPrice"
        Me.FoodPrice2.HeaderText = "ราคา"
        Me.FoodPrice2.Name = "FoodPrice2"
        '
        'OrderId
        '
        Me.OrderId.DataPropertyName = "OrderId"
        Me.OrderId.HeaderText = "OrderId"
        Me.OrderId.Name = "OrderId"
        '
        'lb_order
        '
        Me.lb_order.AutoSize = True
        Me.lb_order.Location = New System.Drawing.Point(319, 26)
        Me.lb_order.Name = "lb_order"
        Me.lb_order.Size = New System.Drawing.Size(10, 13)
        Me.lb_order.TabIndex = 199
        Me.lb_order.Text = "-"
        '
        'lb_o
        '
        Me.lb_o.AutoSize = True
        Me.lb_o.Location = New System.Drawing.Point(226, 27)
        Me.lb_o.Name = "lb_o"
        Me.lb_o.Size = New System.Drawing.Size(63, 13)
        Me.lb_o.TabIndex = 198
        Me.lb_o.Text = "รหัสใบสั่งซื้อ"
        '
        'result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 409)
        Me.Controls.Add(Me.lb_order)
        Me.Controls.Add(Me.lb_o)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "result"
        Me.Text = "result"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FoodName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodPrice2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_order As System.Windows.Forms.Label
    Friend WithEvents lb_o As System.Windows.Forms.Label
End Class
