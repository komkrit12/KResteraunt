<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Typedep
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DepID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_iddepart = New System.Windows.Forms.Label()
        Me.txt_departname = New System.Windows.Forms.TextBox()
        Me.lb_depart = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(292, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 270)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ประเภทแผนก"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepID, Me.DepName})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(251, 235)
        Me.DataGridView1.TabIndex = 0
        '
        'DepID
        '
        Me.DepID.DataPropertyName = "DepID"
        Me.DepID.HeaderText = "รหัส"
        Me.DepID.Name = "DepID"
        '
        'DepName
        '
        Me.DepName.DataPropertyName = "DepName"
        Me.DepName.HeaderText = "ประเภท"
        Me.DepName.Name = "DepName"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lb_iddepart)
        Me.GroupBox1.Controls.Add(Me.txt_departname)
        Me.GroupBox1.Controls.Add(Me.lb_depart)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 270)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "แผนก"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "รหัสแผนก"
        '
        'lb_iddepart
        '
        Me.lb_iddepart.AutoSize = True
        Me.lb_iddepart.Location = New System.Drawing.Point(80, 26)
        Me.lb_iddepart.Name = "lb_iddepart"
        Me.lb_iddepart.Size = New System.Drawing.Size(10, 13)
        Me.lb_iddepart.TabIndex = 12
        Me.lb_iddepart.Text = "-"
        Me.lb_iddepart.Visible = False
        '
        'txt_departname
        '
        Me.txt_departname.Location = New System.Drawing.Point(83, 54)
        Me.txt_departname.Name = "txt_departname"
        Me.txt_departname.Size = New System.Drawing.Size(100, 20)
        Me.txt_departname.TabIndex = 11
        '
        'lb_depart
        '
        Me.lb_depart.AutoSize = True
        Me.lb_depart.Location = New System.Drawing.Point(3, 54)
        Me.lb_depart.Name = "lb_depart"
        Me.lb_depart.Size = New System.Drawing.Size(74, 13)
        Me.lb_depart.TabIndex = 10
        Me.lb_depart.Text = "ประเภทแผนก"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.btn_del)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Location = New System.Drawing.Point(612, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 270)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "จัดการ"
        '
        'btn_clear
        '
        Me.btn_clear.BackgroundImage = Global.KRest.My.Resources.Resources.images__4_2
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.Location = New System.Drawing.Point(37, 188)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(45, 42)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = Global.KRest.My.Resources.Resources.download__6_
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Location = New System.Drawing.Point(37, 40)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(45, 41)
        Me.btn_add.TabIndex = 4
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.BackgroundImage = Global.KRest.My.Resources.Resources.delete_big
        Me.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_del.Location = New System.Drawing.Point(37, 138)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(45, 42)
        Me.btn_del.TabIndex = 6
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.BackgroundImage = Global.KRest.My.Resources.Resources.images__3_
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit.Location = New System.Drawing.Point(37, 87)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(45, 42)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Typedep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Typedep"
        Me.Text = "Typedep"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_iddepart As System.Windows.Forms.Label
    Friend WithEvents txt_departname As System.Windows.Forms.TextBox
    Friend WithEvents lb_depart As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents DepID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
