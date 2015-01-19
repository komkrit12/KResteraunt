<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayOrder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.lb_change = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_recieve = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lb_sum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_search = New System.Windows.Forms.ComboBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_invid = New System.Windows.Forms.Label()
        Me.FoodName2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodPrice2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sum_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_pay)
        Me.GroupBox1.Controls.Add(Me.lb_change)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_recieve)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lb_sum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 336)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 177)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลการชำระ"
        '
        'btn_pay
        '
        Me.btn_pay.Location = New System.Drawing.Point(429, 96)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(77, 52)
        Me.btn_pay.TabIndex = 6
        Me.btn_pay.Text = "ยืนยันการชำระ"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'lb_change
        '
        Me.lb_change.AutoSize = True
        Me.lb_change.Location = New System.Drawing.Point(193, 116)
        Me.lb_change.Name = "lb_change"
        Me.lb_change.Size = New System.Drawing.Size(18, 20)
        Me.lb_change.TabIndex = 5
        Me.lb_change.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "จำนวนเงินทอน"
        '
        'txt_recieve
        '
        Me.txt_recieve.Location = New System.Drawing.Point(197, 69)
        Me.txt_recieve.Name = "txt_recieve"
        Me.txt_recieve.Size = New System.Drawing.Size(118, 26)
        Me.txt_recieve.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "จำนวนเงินที่ได้รับ"
        '
        'lb_sum
        '
        Me.lb_sum.AutoSize = True
        Me.lb_sum.Location = New System.Drawing.Point(193, 30)
        Me.lb_sum.Name = "lb_sum"
        Me.lb_sum.Size = New System.Drawing.Size(18, 20)
        Me.lb_sum.TabIndex = 1
        Me.lb_sum.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "จำนวนเงินที่ต้องชำระ"
        '
        'cmb_search
        '
        Me.cmb_search.FormattingEnabled = True
        Me.cmb_search.Location = New System.Drawing.Point(488, 45)
        Me.cmb_search.Name = "cmb_search"
        Me.cmb_search.Size = New System.Drawing.Size(121, 21)
        Me.cmb_search.TabIndex = 2
        '
        'DataGrid
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodName2, Me.FoodPrice2, Me.unit, Me.sum_p})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.Location = New System.Drawing.Point(72, 85)
        Me.DataGrid.Name = "DataGrid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.Size = New System.Drawing.Size(544, 235)
        Me.DataGrid.TabIndex = 194
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "เลขที่ใบเสร็จ"
        '
        'lb_invid
        '
        Me.lb_invid.AutoSize = True
        Me.lb_invid.Location = New System.Drawing.Point(166, 48)
        Me.lb_invid.Name = "lb_invid"
        Me.lb_invid.Size = New System.Drawing.Size(10, 13)
        Me.lb_invid.TabIndex = 196
        Me.lb_invid.Text = "-"
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
        Me.FoodPrice2.HeaderText = "ราคาต่อหน่วย"
        Me.FoodPrice2.Name = "FoodPrice2"
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "จำนวน"
        Me.unit.Name = "unit"
        '
        'sum_p
        '
        Me.sum_p.DataPropertyName = "sum_p"
        Me.sum_p.HeaderText = "ราคารวม"
        Me.sum_p.Name = "sum_p"
        '
        'PayOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 540)
        Me.Controls.Add(Me.lb_invid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.cmb_search)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PayOrder"
        Me.Text = "PayOrder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_change As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_recieve As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_sum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_pay As System.Windows.Forms.Button
    Friend WithEvents cmb_search As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_invid As System.Windows.Forms.Label
    Friend WithEvents FoodName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodPrice2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sum_p As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
