Public Class Form2
    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        PictureBox3.Visible = False
        PictureBox2.Visible = False
        PictureBox4.Visible = False
        PictureBox1.Visible = False
        PictureBox5.Visible = False
        If cmb1.Text = "111" Then
            tbnama.Text = "Khalid"
            tbalamat.Text = "Fanindo"
            PictureBox1.Visible = True
        ElseIf cmb1.Text = "112" Then
            tbnama.Text = "Martin Garrix"
            tbalamat.Text = "London"
            PictureBox2.Visible = True
        ElseIf cmb1.Text = "113" Then
            tbnama.Text = "Halsey"
            tbalamat.Text = "Finlandia"
            PictureBox3.Visible = True
        ElseIf cmb1.Text = "114" Then
            tbnama.Text = "Hardwell"
            tbalamat.Text = "Peru"
            PictureBox4.Visible = True

        End If
    End Sub

    Private Sub cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb2.SelectedIndexChanged
        If cmb2.Text = "400Kwh" Then
            tbbeban.Text = "15000"
        ElseIf cmb2.Text = "900Kwh" Then
            tbbeban.Text = "30000"
        ElseIf cmb2.Text = "1200Kwh" Then
            tbbeban.Text = "50000"
        End If
    End Sub
    Sub clear()
        cmb1.Text = ""
        cmb2.Text = ""
        tbbeban.Text = ""
        tbalamat.Text = ""
        tbnama.Text = ""
        tbtotal.Text = ""
        before.Text = ""
        after.Text = ""

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call clear()
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        tbtotal.Text = ((Val(after.Text) - Val(before.Text)) * 125) + Val(tbbeban.Text)

        Dim arr(7) As String
        arr(0) = cmb1.Text
        arr(1) = tbnama.Text
        arr(2) = tbalamat.Text
        arr(3) = cmb2.Text
        arr(4) = tbbeban.Text
        arr(5) = before.Text
        arr(6) = after.Text
        arr(7) = tbtotal.Text


        Dim item As ListViewItem
        item = New ListViewItem
        item = ListView1.Items.Add(arr(0))
        item.SubItems.Add(arr(1))
        item.SubItems.Add(arr(2))
        item.SubItems.Add(arr(3))
        item.SubItems.Add(arr(4))
        item.SubItems.Add(arr(5))
        item.SubItems.Add(arr(6))
        item.SubItems.Add(arr(7))

        cmb1.Text = ""
        tbnama.Text = ""
        tbalamat.Text = ""
        tbbeban.Text = ""
        tbtotal.Text = ""
        after.Text = ""
        cmb2.Text = ""
        before.Text = ""
        tbnama.Focus()


    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Kode Pelanggan", 115)
        ListView1.Columns.Add("Nama", 115)
        ListView1.Columns.Add("Alamat", 115)
        ListView1.Columns.Add("Daya Listrik", 115)
        ListView1.Columns.Add("Biaya Beban", 115)
        ListView1.Columns.Add("Pemakaian Sebelumnya", 115)
        ListView1.Columns.Add("Pemakaian Sesudahnya", 115)
        ListView1.Columns.Add("Total Pembayaran", 115)
        cmb1.Text = ""
        tbnama.Focus()
    End Sub
End Class