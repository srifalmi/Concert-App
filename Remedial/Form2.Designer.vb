<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.cmb2 = New System.Windows.Forms.ComboBox()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.after = New System.Windows.Forms.TextBox()
        Me.before = New System.Windows.Forms.TextBox()
        Me.tbbeban = New System.Windows.Forms.TextBox()
        Me.tbalamat = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(34, 277)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 23)
        Me.exitbtn.TabIndex = 22
        Me.exitbtn.Text = "Quit"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(34, 218)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 23)
        Me.btnhitung.TabIndex = 21
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(34, 164)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 20
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'cmb2
        '
        Me.cmb2.FormattingEnabled = True
        Me.cmb2.Items.AddRange(New Object() {"400Kwh", "900Kwh", "1200Kwh"})
        Me.cmb2.Location = New System.Drawing.Point(328, 166)
        Me.cmb2.Name = "cmb2"
        Me.cmb2.Size = New System.Drawing.Size(127, 21)
        Me.cmb2.TabIndex = 19
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Items.AddRange(New Object() {"111", "112", "113", "114"})
        Me.cmb1.Location = New System.Drawing.Point(328, 76)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(127, 21)
        Me.cmb1.TabIndex = 18
        '
        'tbtotal
        '
        Me.tbtotal.Location = New System.Drawing.Point(328, 301)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.Size = New System.Drawing.Size(127, 20)
        Me.tbtotal.TabIndex = 16
        '
        'after
        '
        Me.after.Location = New System.Drawing.Point(328, 268)
        Me.after.Name = "after"
        Me.after.Size = New System.Drawing.Size(127, 20)
        Me.after.TabIndex = 15
        '
        'before
        '
        Me.before.Location = New System.Drawing.Point(328, 234)
        Me.before.Name = "before"
        Me.before.Size = New System.Drawing.Size(127, 20)
        Me.before.TabIndex = 14
        '
        'tbbeban
        '
        Me.tbbeban.Location = New System.Drawing.Point(328, 197)
        Me.tbbeban.Name = "tbbeban"
        Me.tbbeban.Size = New System.Drawing.Size(127, 20)
        Me.tbbeban.TabIndex = 17
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(328, 134)
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(127, 20)
        Me.tbalamat.TabIndex = 13
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(328, 106)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(127, 20)
        Me.tbnama.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(181, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total Pembayaran"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Pemakaian Bulan Ini"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(181, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pemakaian Sebelumnya"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Biaya Beban"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Daya Listrik/Kwh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode Pembayaran"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Perpetua Titling MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(305, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Bayar Listrik kuy :)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(34, 345)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(710, 172)
        Me.ListView1.TabIndex = 24
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Remedial.My.Resources.Resources.hasley
        Me.PictureBox3.Location = New System.Drawing.Point(525, 59)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(208, 241)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Remedial.My.Resources.Resources.martin
        Me.PictureBox2.Location = New System.Drawing.Point(525, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(208, 241)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Remedial.My.Resources.Resources.khalid
        Me.PictureBox1.Location = New System.Drawing.Point(525, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 241)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Remedial.My.Resources.Resources.hard
        Me.PictureBox4.Location = New System.Drawing.Point(525, 59)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(208, 241)
        Me.PictureBox4.TabIndex = 23
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(525, 59)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(208, 241)
        Me.PictureBox5.TabIndex = 25
        Me.PictureBox5.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(771, 529)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.cmb2)
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.tbtotal)
        Me.Controls.Add(Me.after)
        Me.Controls.Add(Me.before)
        Me.Controls.Add(Me.tbbeban)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitbtn As Button
    Friend WithEvents btnhitung As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents cmb2 As ComboBox
    Friend WithEvents cmb1 As ComboBox
    Friend WithEvents tbtotal As TextBox
    Friend WithEvents after As TextBox
    Friend WithEvents before As TextBox
    Friend WithEvents tbbeban As TextBox
    Friend WithEvents tbalamat As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
