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
        Me.TextNamahutan = New System.Windows.Forms.TextBox()
        Me.TextLuashutan = New System.Windows.Forms.TextBox()
        Me.TextKodepos = New System.Windows.Forms.TextBox()
        Me.TextProvinsi = New System.Windows.Forms.TextBox()
        Me.TextKota = New System.Windows.Forms.TextBox()
        Me.TextNapi = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gv_listData = New System.Windows.Forms.DataGridView()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextTglin = New System.Windows.Forms.DateTimePicker()
        Me.lbl_nama_user = New System.Windows.Forms.Label()
        CType(Me.gv_listData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextNamahutan
        '
        Me.TextNamahutan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextNamahutan.Location = New System.Drawing.Point(202, 395)
        Me.TextNamahutan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextNamahutan.Name = "TextNamahutan"
        Me.TextNamahutan.Size = New System.Drawing.Size(221, 22)
        Me.TextNamahutan.TabIndex = 64
        '
        'TextLuashutan
        '
        Me.TextLuashutan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextLuashutan.Location = New System.Drawing.Point(202, 355)
        Me.TextLuashutan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextLuashutan.Name = "TextLuashutan"
        Me.TextLuashutan.Size = New System.Drawing.Size(81, 22)
        Me.TextLuashutan.TabIndex = 63
        '
        'TextKodepos
        '
        Me.TextKodepos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextKodepos.Location = New System.Drawing.Point(202, 315)
        Me.TextKodepos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextKodepos.Name = "TextKodepos"
        Me.TextKodepos.Size = New System.Drawing.Size(221, 22)
        Me.TextKodepos.TabIndex = 62
        '
        'TextProvinsi
        '
        Me.TextProvinsi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextProvinsi.Location = New System.Drawing.Point(202, 275)
        Me.TextProvinsi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextProvinsi.Name = "TextProvinsi"
        Me.TextProvinsi.Size = New System.Drawing.Size(221, 22)
        Me.TextProvinsi.TabIndex = 61
        '
        'TextKota
        '
        Me.TextKota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextKota.Location = New System.Drawing.Point(202, 235)
        Me.TextKota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextKota.Name = "TextKota"
        Me.TextKota.Size = New System.Drawing.Size(221, 22)
        Me.TextKota.TabIndex = 60
        '
        'TextNapi
        '
        Me.TextNapi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextNapi.Location = New System.Drawing.Point(202, 155)
        Me.TextNapi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextNapi.Name = "TextNapi"
        Me.TextNapi.Size = New System.Drawing.Size(221, 22)
        Me.TextNapi.TabIndex = 58
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_exit.BackColor = System.Drawing.Color.White
        Me.btn_exit.Location = New System.Drawing.Point(35, 756)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(101, 34)
        Me.btn_exit.TabIndex = 57
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.BackColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(322, 507)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(101, 34)
        Me.btn_delete.TabIndex = 56
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_edit.BackColor = System.Drawing.Color.White
        Me.btn_edit.Location = New System.Drawing.Point(35, 507)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(101, 34)
        Me.btn_edit.TabIndex = 55
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_input
        '
        Me.btn_input.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_input.BackColor = System.Drawing.Color.White
        Me.btn_input.Location = New System.Drawing.Point(39, 445)
        Me.btn_input.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(384, 34)
        Me.btn_input.TabIndex = 54
        Me.btn_input.Text = "INPUT"
        Me.btn_input.UseVisualStyleBackColor = False
        '
        'TextID
        '
        Me.TextID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextID.Location = New System.Drawing.Point(202, 116)
        Me.TextID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(221, 22)
        Me.TextID.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 397)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "NAMA HUTAN"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 21)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "LUAS HUTAN"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 21)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "KODE POS"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "PROVINSI"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "KOTA"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 22)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "TGL. INPUT"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "NAMA PENGINPUT"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "ID"
        '
        'gv_listData
        '
        Me.gv_listData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gv_listData.BackgroundColor = System.Drawing.Color.White
        Me.gv_listData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_listData.Location = New System.Drawing.Point(509, 78)
        Me.gv_listData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gv_listData.Name = "gv_listData"
        Me.gv_listData.RowHeadersWidth = 51
        Me.gv_listData.RowTemplate.Height = 24
        Me.gv_listData.Size = New System.Drawing.Size(884, 712)
        Me.gv_listData.TabIndex = 36
        '
        'lbl_role
        '
        Me.lbl_role.AutoSize = True
        Me.lbl_role.Location = New System.Drawing.Point(32, 39)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(0, 16)
        Me.lbl_role.TabIndex = 65
        Me.lbl_role.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.FormCRUD.My.Resources.Resources.bg_green
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.FormCRUD.My.Resources.Resources.hutanku21
        Me.PictureBox2.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(254, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(464, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(967, 825)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(298, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 21)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Hektar"
        '
        'TextTglin
        '
        Me.TextTglin.CustomFormat = "yyyy-MM-dd"
        Me.TextTglin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TextTglin.Location = New System.Drawing.Point(202, 193)
        Me.TextTglin.Name = "TextTglin"
        Me.TextTglin.Size = New System.Drawing.Size(221, 22)
        Me.TextTglin.TabIndex = 70
        '
        'lbl_nama_user
        '
        Me.lbl_nama_user.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_nama_user.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nama_user.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama_user.Location = New System.Drawing.Point(506, 24)
        Me.lbl_nama_user.Name = "lbl_nama_user"
        Me.lbl_nama_user.Size = New System.Drawing.Size(214, 37)
        Me.lbl_nama_user.TabIndex = 71
        Me.lbl_nama_user.Text = "Hi, User"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FormCRUD.My.Resources.Resources.bg_green
        Me.ClientSize = New System.Drawing.Size(1429, 818)
        Me.Controls.Add(Me.lbl_nama_user)
        Me.Controls.Add(Me.TextTglin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_role)
        Me.Controls.Add(Me.TextNamahutan)
        Me.Controls.Add(Me.TextLuashutan)
        Me.Controls.Add(Me.TextKodepos)
        Me.Controls.Add(Me.TextProvinsi)
        Me.Controls.Add(Me.TextKota)
        Me.Controls.Add(Me.TextNapi)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_input)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gv_listData)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM AUDIT HUTAN"
        CType(Me.gv_listData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextNamahutan As TextBox
    Friend WithEvents TextLuashutan As TextBox
    Friend WithEvents TextKodepos As TextBox
    Friend WithEvents TextProvinsi As TextBox
    Friend WithEvents TextKota As TextBox
    Friend WithEvents TextNapi As TextBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents TextID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gv_listData As DataGridView
    Friend WithEvents lbl_role As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextTglin As DateTimePicker
    Friend WithEvents lbl_nama_user As Label
End Class
