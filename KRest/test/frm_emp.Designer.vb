<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_emp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtt_date = New System.Windows.Forms.DateTimePicker()
        Me.Cmb_dep = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EMID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMIDCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPDep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMHouseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMMOO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMSoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMRoad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMDistrict = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMProvince = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPostCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMBirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMDatein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbid = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.txt_surname = New System.Windows.Forms.TextBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_postal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_province = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_tambol = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_rd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_soi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_moo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_citizenid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtt_date)
        Me.GroupBox1.Controls.Add(Me.Cmb_dep)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Lbid)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lb_id)
        Me.GroupBox1.Controls.Add(Me.txt_surname)
        Me.GroupBox1.Controls.Add(Me.txt_pwd)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_tel)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_postal)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_province)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_city)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_tambol)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_rd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_soi)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_moo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_no)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_citizenid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 530)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "จัดการพนักงาน"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "วันเกิด"
        '
        'dtt_date
        '
        Me.dtt_date.Location = New System.Drawing.Point(80, 161)
        Me.dtt_date.Name = "dtt_date"
        Me.dtt_date.Size = New System.Drawing.Size(200, 20)
        Me.dtt_date.TabIndex = 67
        '
        'Cmb_dep
        '
        Me.Cmb_dep.FormattingEnabled = True
        Me.Cmb_dep.Location = New System.Drawing.Point(80, 192)
        Me.Cmb_dep.Name = "Cmb_dep"
        Me.Cmb_dep.Size = New System.Drawing.Size(200, 21)
        Me.Cmb_dep.TabIndex = 66
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 373)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 165)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "พนักงาน"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMID, Me.EMName, Me.EMLName, Me.EMIDCard, Me.EMPDep, Me.DepName, Me.EMPhone, Me.EMPassword, Me.EMHouseNumber, Me.EMMOO, Me.EMSoi, Me.EMRoad, Me.EMDistrict, Me.EMCity, Me.EMProvince, Me.EMPostCode, Me.EMBirth, Me.EMDatein})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(721, 129)
        Me.DataGridView1.TabIndex = 0
        '
        'EMID
        '
        Me.EMID.DataPropertyName = "EMID"
        Me.EMID.HeaderText = "รหัสพนักงาน"
        Me.EMID.Name = "EMID"
        '
        'EMName
        '
        Me.EMName.DataPropertyName = "EMName"
        Me.EMName.HeaderText = "ชื่อ"
        Me.EMName.Name = "EMName"
        '
        'EMLName
        '
        Me.EMLName.DataPropertyName = "EMLName"
        Me.EMLName.HeaderText = "นามสกุล"
        Me.EMLName.Name = "EMLName"
        '
        'EMIDCard
        '
        Me.EMIDCard.DataPropertyName = "EMIDCard"
        Me.EMIDCard.HeaderText = "เลขประจำตัวประชาชน"
        Me.EMIDCard.Name = "EMIDCard"
        '
        'EMPDep
        '
        Me.EMPDep.DataPropertyName = "EMPDep"
        Me.EMPDep.HeaderText = "เลขที่แผนก"
        Me.EMPDep.Name = "EMPDep"
        '
        'DepName
        '
        Me.DepName.DataPropertyName = "DepName"
        Me.DepName.HeaderText = "ชื่อแผนก"
        Me.DepName.Name = "DepName"
        '
        'EMPhone
        '
        Me.EMPhone.DataPropertyName = "EMPhone"
        Me.EMPhone.HeaderText = "เบอร์โทรศัพท์"
        Me.EMPhone.Name = "EMPhone"
        '
        'EMPassword
        '
        Me.EMPassword.DataPropertyName = "EMPassword"
        Me.EMPassword.HeaderText = "Password"
        Me.EMPassword.Name = "EMPassword"
        '
        'EMHouseNumber
        '
        Me.EMHouseNumber.DataPropertyName = "EMHouseNumber"
        Me.EMHouseNumber.HeaderText = "บ้านเลขที่"
        Me.EMHouseNumber.Name = "EMHouseNumber"
        '
        'EMMOO
        '
        Me.EMMOO.DataPropertyName = "EMMOO"
        Me.EMMOO.HeaderText = "หมู่"
        Me.EMMOO.Name = "EMMOO"
        '
        'EMSoi
        '
        Me.EMSoi.DataPropertyName = "EMSoi"
        Me.EMSoi.HeaderText = "ซอย"
        Me.EMSoi.Name = "EMSoi"
        '
        'EMRoad
        '
        Me.EMRoad.DataPropertyName = "EMRoad"
        Me.EMRoad.HeaderText = "ถนน"
        Me.EMRoad.Name = "EMRoad"
        '
        'EMDistrict
        '
        Me.EMDistrict.DataPropertyName = "EMDistrict"
        Me.EMDistrict.HeaderText = "ตำบล"
        Me.EMDistrict.Name = "EMDistrict"
        '
        'EMCity
        '
        Me.EMCity.DataPropertyName = "EMCity"
        Me.EMCity.HeaderText = "อำเภอ"
        Me.EMCity.Name = "EMCity"
        '
        'EMProvince
        '
        Me.EMProvince.DataPropertyName = "EMProvince"
        Me.EMProvince.HeaderText = "จังหวัด"
        Me.EMProvince.Name = "EMProvince"
        '
        'EMPostCode
        '
        Me.EMPostCode.DataPropertyName = "EMPostCode"
        Me.EMPostCode.HeaderText = "รหัสไปรษณีย์"
        Me.EMPostCode.Name = "EMPostCode"
        '
        'EMBirth
        '
        Me.EMBirth.DataPropertyName = "EMBirth"
        Me.EMBirth.HeaderText = "วันเกิด"
        Me.EMBirth.Name = "EMBirth"
        '
        'EMDatein
        '
        Me.EMDatein.DataPropertyName = "EMDatein"
        Me.EMDatein.HeaderText = "วันเข้างาน"
        Me.EMDatein.Name = "EMDatein"
        '
        'Lbid
        '
        Me.Lbid.AutoSize = True
        Me.Lbid.Location = New System.Drawing.Point(90, 29)
        Me.Lbid.Name = "Lbid"
        Me.Lbid.Size = New System.Drawing.Size(10, 13)
        Me.Lbid.TabIndex = 65
        Me.Lbid.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Controls.Add(Me.btn_del)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Location = New System.Drawing.Point(627, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(109, 218)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "จัดการ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "ชื่อ"
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Location = New System.Drawing.Point(90, 48)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(0, 13)
        Me.lb_id.TabIndex = 63
        '
        'txt_surname
        '
        Me.txt_surname.Location = New System.Drawing.Point(80, 89)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.Size = New System.Drawing.Size(200, 20)
        Me.txt_surname.TabIndex = 62
        '
        'txt_pwd
        '
        Me.txt_pwd.Location = New System.Drawing.Point(444, 266)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.Size = New System.Drawing.Size(165, 20)
        Me.txt_pwd.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Pasword"
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(444, 227)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(165, 20)
        Me.txt_tel.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(331, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "เบอร์โทรศัพท์"
        '
        'txt_postal
        '
        Me.txt_postal.Location = New System.Drawing.Point(444, 194)
        Me.txt_postal.Name = "txt_postal"
        Me.txt_postal.Size = New System.Drawing.Size(165, 20)
        Me.txt_postal.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(331, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "รหัสไปรษณีย์"
        '
        'txt_province
        '
        Me.txt_province.Location = New System.Drawing.Point(444, 158)
        Me.txt_province.Name = "txt_province"
        Me.txt_province.Size = New System.Drawing.Size(165, 20)
        Me.txt_province.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(331, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "จังหวัด"
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(444, 123)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(165, 20)
        Me.txt_city.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(331, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "อำเภอ/แขวง"
        '
        'txt_tambol
        '
        Me.txt_tambol.Location = New System.Drawing.Point(444, 85)
        Me.txt_tambol.Name = "txt_tambol"
        Me.txt_tambol.Size = New System.Drawing.Size(165, 20)
        Me.txt_tambol.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(331, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "ตำบล/เขต"
        '
        'txt_rd
        '
        Me.txt_rd.Location = New System.Drawing.Point(444, 50)
        Me.txt_rd.Name = "txt_rd"
        Me.txt_rd.Size = New System.Drawing.Size(165, 20)
        Me.txt_rd.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "ถนน"
        '
        'txt_soi
        '
        Me.txt_soi.Location = New System.Drawing.Point(80, 300)
        Me.txt_soi.Name = "txt_soi"
        Me.txt_soi.Size = New System.Drawing.Size(200, 20)
        Me.txt_soi.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "ซอย"
        '
        'txt_moo
        '
        Me.txt_moo.Location = New System.Drawing.Point(80, 266)
        Me.txt_moo.Name = "txt_moo"
        Me.txt_moo.Size = New System.Drawing.Size(200, 20)
        Me.txt_moo.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "หมู่"
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(80, 227)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(200, 20)
        Me.txt_no.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "บ้านเลขที่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "แผนก"
        '
        'txt_citizenid
        '
        Me.txt_citizenid.Location = New System.Drawing.Point(80, 122)
        Me.txt_citizenid.Name = "txt_citizenid"
        Me.txt_citizenid.Size = New System.Drawing.Size(200, 20)
        Me.txt_citizenid.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "รหัสประจำตัว"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(80, 54)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(200, 20)
        Me.txt_name.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "นามสกุล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "รหัสพนักงาน"
        '
        'btn_clear
        '
        Me.btn_clear.BackgroundImage = Global.KRest.My.Resources.Resources.images__4_2
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.Location = New System.Drawing.Point(27, 167)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(45, 42)
        Me.btn_clear.TabIndex = 3
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.BackgroundImage = Global.KRest.My.Resources.Resources.download__6_
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.Location = New System.Drawing.Point(27, 19)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(45, 41)
        Me.btn_add.TabIndex = 0
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.BackgroundImage = Global.KRest.My.Resources.Resources.delete_big
        Me.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_del.Location = New System.Drawing.Point(27, 117)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(45, 42)
        Me.btn_del.TabIndex = 2
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.BackgroundImage = Global.KRest.My.Resources.Resources.images__3_
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit.Location = New System.Drawing.Point(27, 66)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(45, 42)
        Me.btn_edit.TabIndex = 1
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'frm_emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_emp"
        Me.Text = "ssss"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents txt_surname As System.Windows.Forms.TextBox
    Friend WithEvents txt_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_tel As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_postal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_province As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_city As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_tambol As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_rd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_soi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_moo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_no As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_citizenid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbid As System.Windows.Forms.Label
    Friend WithEvents Cmb_dep As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents EMID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMLName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMIDCard As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPDep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMHouseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMMOO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMSoi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMRoad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMDistrict As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMProvince As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPostCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMBirth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMDatein As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
