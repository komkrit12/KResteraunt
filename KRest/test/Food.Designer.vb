<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Food
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb_foodid = New System.Windows.Forms.Label()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.txt_cos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmb_food = New System.Windows.Forms.ComboBox()
        Me.LbIDFood = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FoodID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodTypeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.btn_del)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(348, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 84)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "จัดการ"
        '
        'lb_foodid
        '
        Me.lb_foodid.AutoSize = True
        Me.lb_foodid.Location = New System.Drawing.Point(120, 29)
        Me.lb_foodid.Name = "lb_foodid"
        Me.lb_foodid.Size = New System.Drawing.Size(16, 26)
        Me.lb_foodid.TabIndex = 73
        Me.lb_foodid.Text = "-"
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Location = New System.Drawing.Point(105, 45)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(0, 26)
        Me.lb_id.TabIndex = 72
        '
        'txt_cos
        '
        Me.txt_cos.Font = New System.Drawing.Font("Angsana New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cos.Location = New System.Drawing.Point(125, 154)
        Me.txt_cos.Name = "txt_cos"
        Me.txt_cos.Size = New System.Drawing.Size(100, 25)
        Me.txt_cos.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 26)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "ราคา"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Angsana New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(125, 68)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 25)
        Me.txt_name.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 26)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "ประเภทอาหาร"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 26)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "ชื่ออาหาร"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_food)
        Me.GroupBox1.Controls.Add(Me.LbIDFood)
        Me.GroupBox1.Controls.Add(Me.lb_foodid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_cos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 208)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เพื่มรายการสินค้า"
        '
        'Cmb_food
        '
        Me.Cmb_food.FormattingEnabled = True
        Me.Cmb_food.Location = New System.Drawing.Point(125, 104)
        Me.Cmb_food.Name = "Cmb_food"
        Me.Cmb_food.Size = New System.Drawing.Size(100, 34)
        Me.Cmb_food.TabIndex = 75
        '
        'LbIDFood
        '
        Me.LbIDFood.AutoSize = True
        Me.LbIDFood.Location = New System.Drawing.Point(18, 29)
        Me.LbIDFood.Name = "LbIDFood"
        Me.LbIDFood.Size = New System.Drawing.Size(67, 26)
        Me.LbIDFood.TabIndex = 74
        Me.LbIDFood.Text = "รหัสอาหาร"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FoodID, Me.FoodName, Me.FoodPrice, Me.FoodTypeName})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(323, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(449, 193)
        Me.DataGridView1.TabIndex = 75
        '
        'FoodID
        '
        Me.FoodID.DataPropertyName = "FoodID"
        Me.FoodID.HeaderText = "รหัสอาหาร"
        Me.FoodID.Name = "FoodID"
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
        'FoodTypeName
        '
        Me.FoodTypeName.DataPropertyName = "FoodTypeName"
        Me.FoodTypeName.HeaderText = "ประเภทอาหาร"
        Me.FoodTypeName.Name = "FoodTypeName"
        '
        'btn_clear
        '
        Me.btn_clear.BackgroundImage = Global.KRest.My.Resources.Resources.images__4_1
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.Location = New System.Drawing.Point(334, 21)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(52, 51)
        Me.btn_clear.TabIndex = 3
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = Global.KRest.My.Resources.Resources.Bl_
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Location = New System.Drawing.Point(27, 19)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(57, 53)
        Me.btn_add.TabIndex = 0
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.BackgroundImage = Global.KRest.My.Resources.Resources.delete_big
        Me.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_del.Location = New System.Drawing.Point(135, 18)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(59, 54)
        Me.btn_del.TabIndex = 2
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.BackgroundImage = Global.KRest.My.Resources.Resources.images__3_
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit.Location = New System.Drawing.Point(237, 21)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(52, 51)
        Me.btn_edit.TabIndex = 1
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Food
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Food"
        Me.Text = "Food"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents lb_foodid As System.Windows.Forms.Label
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents txt_cos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LbIDFood As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cmb_food As System.Windows.Forms.ComboBox
    Friend WithEvents FoodID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FoodTypeName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
