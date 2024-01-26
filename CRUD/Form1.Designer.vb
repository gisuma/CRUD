<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TNIM = New System.Windows.Forms.TextBox()
        Me.TNama = New System.Windows.Forms.TextBox()
        Me.TAlamat = New System.Windows.Forms.TextBox()
        Me.RPria = New System.Windows.Forms.RadioButton()
        Me.RWanita = New System.Windows.Forms.RadioButton()
        Me.BKosong = New System.Windows.Forms.Button()
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.BHapus = New System.Windows.Forms.Button()
        Me.BKeluar = New System.Windows.Forms.Button()
        Me.Program_Studi = New System.Windows.Forms.ComboBox()
        Me.DGW = New System.Windows.Forms.DataGridView()
        Me.CNIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CJP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAlamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM                   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name                :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin    :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Program Studi   :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat              :"
        '
        'TNIM
        '
        Me.TNIM.Location = New System.Drawing.Point(139, 27)
        Me.TNIM.Name = "TNIM"
        Me.TNIM.Size = New System.Drawing.Size(381, 20)
        Me.TNIM.TabIndex = 5
        '
        'TNama
        '
        Me.TNama.Location = New System.Drawing.Point(139, 53)
        Me.TNama.Name = "TNama"
        Me.TNama.Size = New System.Drawing.Size(381, 20)
        Me.TNama.TabIndex = 6
        '
        'TAlamat
        '
        Me.TAlamat.Location = New System.Drawing.Point(140, 138)
        Me.TAlamat.Multiline = True
        Me.TAlamat.Name = "TAlamat"
        Me.TAlamat.Size = New System.Drawing.Size(507, 84)
        Me.TAlamat.TabIndex = 8
        '
        'RPria
        '
        Me.RPria.AutoSize = True
        Me.RPria.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RPria.Location = New System.Drawing.Point(171, 79)
        Me.RPria.Name = "RPria"
        Me.RPria.Size = New System.Drawing.Size(43, 17)
        Me.RPria.TabIndex = 9
        Me.RPria.Text = "Pria"
        Me.RPria.UseVisualStyleBackColor = True
        '
        'RWanita
        '
        Me.RWanita.AutoSize = True
        Me.RWanita.Location = New System.Drawing.Point(244, 79)
        Me.RWanita.Name = "RWanita"
        Me.RWanita.Size = New System.Drawing.Size(59, 17)
        Me.RWanita.TabIndex = 10
        Me.RWanita.Text = "Wanita"
        Me.RWanita.UseVisualStyleBackColor = True
        '
        'BKosong
        '
        Me.BKosong.Location = New System.Drawing.Point(139, 246)
        Me.BKosong.Name = "BKosong"
        Me.BKosong.Size = New System.Drawing.Size(75, 23)
        Me.BKosong.TabIndex = 11
        Me.BKosong.Text = "Kosongkan"
        Me.BKosong.UseVisualStyleBackColor = True
        '
        'BSimpan
        '
        Me.BSimpan.Location = New System.Drawing.Point(244, 246)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BSimpan.TabIndex = 12
        Me.BSimpan.Text = "Simpan"
        Me.BSimpan.UseVisualStyleBackColor = True
        '
        'BHapus
        '
        Me.BHapus.Location = New System.Drawing.Point(350, 246)
        Me.BHapus.Name = "BHapus"
        Me.BHapus.Size = New System.Drawing.Size(75, 23)
        Me.BHapus.TabIndex = 13
        Me.BHapus.Text = "Hapus"
        Me.BHapus.UseVisualStyleBackColor = True
        '
        'BKeluar
        '
        Me.BKeluar.Location = New System.Drawing.Point(445, 246)
        Me.BKeluar.Name = "BKeluar"
        Me.BKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BKeluar.TabIndex = 14
        Me.BKeluar.Text = "Keluar"
        Me.BKeluar.UseVisualStyleBackColor = True
        '
        'Program_Studi
        '
        Me.Program_Studi.FormattingEnabled = True
        Me.Program_Studi.Items.AddRange(New Object() {"S1 - Teknik Informatika", "S1 - Teknik Industri", "S1 - Teknik Elektro"})
        Me.Program_Studi.Location = New System.Drawing.Point(139, 102)
        Me.Program_Studi.Name = "Program_Studi"
        Me.Program_Studi.Size = New System.Drawing.Size(381, 21)
        Me.Program_Studi.TabIndex = 15
        '
        'DGW
        '
        Me.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGW.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNIM, Me.CNama, Me.CJP, Me.CPS, Me.CAlamat})
        Me.DGW.Location = New System.Drawing.Point(3, 288)
        Me.DGW.Name = "DGW"
        Me.DGW.Size = New System.Drawing.Size(644, 181)
        Me.DGW.TabIndex = 16
        '
        'CNIM
        '
        Me.CNIM.HeaderText = "NIM"
        Me.CNIM.Name = "CNIM"
        Me.CNIM.Width = 150
        '
        'CNama
        '
        Me.CNama.HeaderText = "Nama"
        Me.CNama.Name = "CNama"
        Me.CNama.Width = 150
        '
        'CJP
        '
        Me.CJP.HeaderText = "Jenis Kelamin"
        Me.CJP.Name = "CJP"
        Me.CJP.Width = 50
        '
        'CPS
        '
        Me.CPS.HeaderText = "Program Studi"
        Me.CPS.Name = "CPS"
        Me.CPS.Width = 150
        '
        'CAlamat
        '
        Me.CAlamat.HeaderText = "Alamat"
        Me.CAlamat.Name = "CAlamat"
        Me.CAlamat.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 481)
        Me.Controls.Add(Me.DGW)
        Me.Controls.Add(Me.Program_Studi)
        Me.Controls.Add(Me.BKeluar)
        Me.Controls.Add(Me.BHapus)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.BKosong)
        Me.Controls.Add(Me.RWanita)
        Me.Controls.Add(Me.RPria)
        Me.Controls.Add(Me.TAlamat)
        Me.Controls.Add(Me.TNama)
        Me.Controls.Add(Me.TNIM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TNIM As TextBox
    Friend WithEvents TNama As TextBox
    Friend WithEvents TAlamat As TextBox
    Friend WithEvents RPria As RadioButton
    Friend WithEvents RWanita As RadioButton
    Friend WithEvents BKosong As Button
    Friend WithEvents BSimpan As Button
    Friend WithEvents BHapus As Button
    Friend WithEvents BKeluar As Button
    Friend WithEvents Program_Studi As ComboBox
    Friend WithEvents DGW As DataGridView
    Friend WithEvents CNIM As DataGridViewTextBoxColumn
    Friend WithEvents CNama As DataGridViewTextBoxColumn
    Friend WithEvents CJP As DataGridViewTextBoxColumn
    Friend WithEvents CPS As DataGridViewTextBoxColumn
    Friend WithEvents CAlamat As DataGridViewTextBoxColumn
End Class
