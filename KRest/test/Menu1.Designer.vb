<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_summit = New System.Windows.Forms.Button()
        Me.btn_table = New System.Windows.Forms.Button()
        Me.btn_appen = New System.Windows.Forms.Button()
        Me.btn_drink = New System.Windows.Forms.Button()
        Me.btn_streak = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodName2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodPrice2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.select_del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OrderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FoodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.select_food = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lb_o = New System.Windows.Forms.Label()
        Me.lb_order = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.เมนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IkpkoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานตามใบเสรจToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานระบชวงToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานสนวนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานตามเดอนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.พมพใบเสรจToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.พมพตามชวงเวลาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.พมพทงวนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_emp = New System.Windows.Forms.ToolStripMenuItem()
        Me.จดการอาหารToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ออกจากระบบToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lb_table = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_pay = New System.Windows.Forms.Button()
        Me.btn_updateorder = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_summit
        '
        Me.btn_summit.Location = New System.Drawing.Point(482, 427)
        Me.btn_summit.Name = "btn_summit"
        Me.btn_summit.Size = New System.Drawing.Size(100, 48)
        Me.btn_summit.TabIndex = 173
        Me.btn_summit.Text = "ยืนยันการสั่ง"
        Me.btn_summit.UseVisualStyleBackColor = True
        '
        'btn_table
        '
        Me.btn_table.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_table.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_table.Location = New System.Drawing.Point(293, 337)
        Me.btn_table.Name = "btn_table"
        Me.btn_table.Size = New System.Drawing.Size(107, 83)
        Me.btn_table.TabIndex = 172
        Me.btn_table.Text = "เปิดโต๊ะ"
        Me.btn_table.UseVisualStyleBackColor = False
        '
        'btn_appen
        '
        Me.btn_appen.BackColor = System.Drawing.Color.Yellow
        Me.btn_appen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_appen.Location = New System.Drawing.Point(293, 256)
        Me.btn_appen.Name = "btn_appen"
        Me.btn_appen.Size = New System.Drawing.Size(107, 81)
        Me.btn_appen.TabIndex = 145
        Me.btn_appen.Text = "ของทานเล่น"
        Me.btn_appen.UseVisualStyleBackColor = False
        '
        'btn_drink
        '
        Me.btn_drink.BackColor = System.Drawing.Color.Fuchsia
        Me.btn_drink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_drink.Location = New System.Drawing.Point(293, 175)
        Me.btn_drink.Name = "btn_drink"
        Me.btn_drink.Size = New System.Drawing.Size(107, 86)
        Me.btn_drink.TabIndex = 141
        Me.btn_drink.Text = "เครื่องดื่ม"
        Me.btn_drink.UseVisualStyleBackColor = False
        '
        'btn_streak
        '
        Me.btn_streak.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_streak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_streak.Location = New System.Drawing.Point(293, 103)
        Me.btn_streak.Name = "btn_streak"
        Me.btn_streak.Size = New System.Drawing.Size(108, 75)
        Me.btn_streak.TabIndex = 139
        Me.btn_streak.Text = "สเต๊ก"
        Me.btn_streak.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(399, 78)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = "รายการอาหาร"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodName2, Me.FoodPrice2, Me.select_del, Me.OrderId})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Location = New System.Drawing.Point(399, 103)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Size = New System.Drawing.Size(292, 317)
        Me.DataGridView1.TabIndex = 193
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
        'select_del
        '
        Me.select_del.DataPropertyName = "ยกเลิก"
        Me.select_del.HeaderText = "ยกเลิก"
        Me.select_del.Name = "select_del"
        Me.select_del.Text = "ยกเลิก"
        Me.select_del.UseColumnTextForButtonValue = True
        Me.select_del.Width = 50
        '
        'OrderId
        '
        Me.OrderId.DataPropertyName = "OrderId"
        Me.OrderId.HeaderText = "OrderId"
        Me.OrderId.Name = "OrderId"
        '
        'DataGridView2
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodName, Me.FoodPrice, Me.select_food})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.Location = New System.Drawing.Point(0, 103)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.Size = New System.Drawing.Size(293, 317)
        Me.DataGridView2.TabIndex = 194
        '
        'FoodName
        '
        Me.FoodName.DataPropertyName = "FoodName"
        Me.FoodName.HeaderText = "ชื่ออาหาร"
        Me.FoodName.Name = "FoodName"
        '
        'FoodPrice
        '
        Me.FoodPrice.DataPropertyName = "FoodPrice"
        Me.FoodPrice.HeaderText = "ราคา"
        Me.FoodPrice.Name = "FoodPrice"
        '
        'select_food
        '
        Me.select_food.HeaderText = "เลือก"
        Me.select_food.Name = "select_food"
        Me.select_food.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.select_food.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.select_food.Text = "เลือก"
        Me.select_food.UseColumnTextForButtonValue = True
        Me.select_food.Width = 50
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(399, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 78)
        Me.Button2.TabIndex = 195
        Me.Button2.Text = "รายการที่สั่ง"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lb_o
        '
        Me.lb_o.AutoSize = True
        Me.lb_o.Location = New System.Drawing.Point(598, 50)
        Me.lb_o.Name = "lb_o"
        Me.lb_o.Size = New System.Drawing.Size(63, 13)
        Me.lb_o.TabIndex = 196
        Me.lb_o.Text = "รหัสใบสั่งซื้อ"
        '
        'lb_order
        '
        Me.lb_order.AutoSize = True
        Me.lb_order.Location = New System.Drawing.Point(667, 50)
        Me.lb_order.Name = "lb_order"
        Me.lb_order.Size = New System.Drawing.Size(10, 13)
        Me.lb_order.TabIndex = 197
        Me.lb_order.Text = "-"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เมนToolStripMenuItem, Me.IkpkoToolStripMenuItem, Me.พมพใบเสรจToolStripMenuItem, Me.m_emp, Me.จดการอาหารToolStripMenuItem, Me.ออกจากระบบToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 198
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'เมนToolStripMenuItem
        '
        Me.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem"
        Me.เมนToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.เมนToolStripMenuItem.Text = "เมนู"
        '
        'IkpkoToolStripMenuItem
        '
        Me.IkpkoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.รายงานตามใบเสรจToolStripMenuItem, Me.รายงานระบชวงToolStripMenuItem, Me.รายงานสนวนToolStripMenuItem, Me.รายงานตามเดอนToolStripMenuItem})
        Me.IkpkoToolStripMenuItem.Name = "IkpkoToolStripMenuItem"
        Me.IkpkoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.IkpkoToolStripMenuItem.Text = "รายงาน"
        '
        'รายงานตามใบเสรจToolStripMenuItem
        '
        Me.รายงานตามใบเสรจToolStripMenuItem.Name = "รายงานตามใบเสรจToolStripMenuItem"
        Me.รายงานตามใบเสรจToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.รายงานตามใบเสรจToolStripMenuItem.Text = "รายงานตามใบเสร็จ"
        '
        'รายงานระบชวงToolStripMenuItem
        '
        Me.รายงานระบชวงToolStripMenuItem.Name = "รายงานระบชวงToolStripMenuItem"
        Me.รายงานระบชวงToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.รายงานระบชวงToolStripMenuItem.Text = "รายงานระบุช่วง"
        '
        'รายงานสนวนToolStripMenuItem
        '
        Me.รายงานสนวนToolStripMenuItem.Name = "รายงานสนวนToolStripMenuItem"
        Me.รายงานสนวนToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.รายงานสนวนToolStripMenuItem.Text = "รายงานสิ้นวัน"
        '
        'รายงานตามเดอนToolStripMenuItem
        '
        Me.รายงานตามเดอนToolStripMenuItem.Name = "รายงานตามเดอนToolStripMenuItem"
        Me.รายงานตามเดอนToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.รายงานตามเดอนToolStripMenuItem.Text = "รายงานตามเดือน"
        '
        'พมพใบเสรจToolStripMenuItem
        '
        Me.พมพใบเสรจToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.พมพตามชวงเวลาToolStripMenuItem, Me.พมพทงวนToolStripMenuItem})
        Me.พมพใบเสรจToolStripMenuItem.Name = "พมพใบเสรจToolStripMenuItem"
        Me.พมพใบเสรจToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.พมพใบเสรจToolStripMenuItem.Text = "พิมพ์ใบเสร็จ"
        '
        'พมพตามชวงเวลาToolStripMenuItem
        '
        Me.พมพตามชวงเวลาToolStripMenuItem.Name = "พมพตามชวงเวลาToolStripMenuItem"
        Me.พมพตามชวงเวลาToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.พมพตามชวงเวลาToolStripMenuItem.Text = "พิมพ์ตามช่วงเวลา"
        '
        'พมพทงวนToolStripMenuItem
        '
        Me.พมพทงวนToolStripMenuItem.Name = "พมพทงวนToolStripMenuItem"
        Me.พมพทงวนToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.พมพทงวนToolStripMenuItem.Text = "พิมพ์ทั้งวัน"
        '
        'm_emp
        '
        Me.m_emp.Name = "m_emp"
        Me.m_emp.Size = New System.Drawing.Size(91, 20)
        Me.m_emp.Text = "จัดการพนักงาน"
        '
        'จดการอาหารToolStripMenuItem
        '
        Me.จดการอาหารToolStripMenuItem.Name = "จดการอาหารToolStripMenuItem"
        Me.จดการอาหารToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.จดการอาหารToolStripMenuItem.Text = "จัดการอาหาร"
        '
        'ออกจากระบบToolStripMenuItem
        '
        Me.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem"
        Me.ออกจากระบบToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ"
        '
        'lb_table
        '
        Me.lb_table.AutoSize = True
        Me.lb_table.Location = New System.Drawing.Point(667, 74)
        Me.lb_table.Name = "lb_table"
        Me.lb_table.Size = New System.Drawing.Size(10, 13)
        Me.lb_table.TabIndex = 200
        Me.lb_table.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(598, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "เลขโต๊ะ"
        '
        'btn_pay
        '
        Me.btn_pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_pay.Location = New System.Drawing.Point(600, 427)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(90, 48)
        Me.btn_pay.TabIndex = 201
        Me.btn_pay.Text = "ชำระเงิน"
        Me.btn_pay.UseVisualStyleBackColor = True
        '
        'btn_updateorder
        '
        Me.btn_updateorder.Location = New System.Drawing.Point(293, 427)
        Me.btn_updateorder.Name = "btn_updateorder"
        Me.btn_updateorder.Size = New System.Drawing.Size(98, 48)
        Me.btn_updateorder.TabIndex = 202
        Me.btn_updateorder.Text = "แก้ไขรายการอาหาร"
        Me.btn_updateorder.UseVisualStyleBackColor = True
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(693, 529)
        Me.Controls.Add(Me.btn_updateorder)
        Me.Controls.Add(Me.btn_pay)
        Me.Controls.Add(Me.lb_table)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lb_order)
        Me.Controls.Add(Me.lb_o)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_summit)
        Me.Controls.Add(Me.btn_table)
        Me.Controls.Add(Me.btn_appen)
        Me.Controls.Add(Me.btn_drink)
        Me.Controls.Add(Me.btn_streak)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Menu1"
        Me.Text = "เมนู"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_summit As System.Windows.Forms.Button
    Friend WithEvents btn_table As System.Windows.Forms.Button
    Friend WithEvents btn_appen As System.Windows.Forms.Button
    Friend WithEvents btn_drink As System.Windows.Forms.Button
    Friend WithEvents btn_streak As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lb_o As System.Windows.Forms.Label
    Friend WithEvents lb_order As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents เมนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IkpkoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานตามใบเสรจToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานระบชวงToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานสนวนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานตามเดอนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents พมพใบเสรจToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents พมพตามชวงเวลาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents พมพทงวนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_emp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents จดการอาหารToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ออกจากระบบToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoodName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents select_food As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents FoodName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodPrice2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents select_del As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents OrderId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lb_table As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_pay As System.Windows.Forms.Button
    Friend WithEvents btn_updateorder As System.Windows.Forms.Button
End Class
