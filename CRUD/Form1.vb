Imports MySql.Data.MySqlClient

Public Class Form1

    Sub TampilkanData()
        konek()

        da = New MySqlDataAdapter("SELECT * FROM mahasiswa", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        DGW.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            DGW.Rows.Add(dt.Rows(i).Item(0))
            DGW.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            DGW.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            DGW.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            DGW.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
        Next
        Diskonek()

    End Sub
    Private Sub BKeluar_Click(sender As Object, e As EventArgs) Handles BKeluar.Click
        Me.Close()
    End Sub

    Private Sub BKosong_Click(sender As Object, e As EventArgs) Handles BKosong.Click
        TNIM.Text = ""
        TNama.Text = ""
        RPria.Checked = False
        RWanita.Checked = False
        Program_Studi.Text = ""
        TAlamat.Text = ""
        TNIM.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()

    End Sub

    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click
        Dim JK As String
        If RPria.Checked = True Then
            JK = "Pria"
        ElseIf RWanita.Checked = True Then
            JK = "Wanita"
        End If

        'Uji jika ketemu = True, maka edit data, selain itu simpan baru'
        If Ketemu = True Then
            'ubah'
            Try
                konek()

                cmd = New MySqlCommand("UPDATE mahasiswa SET Nama = ' " & TNama.Text & "', Jenis_Kelamin = '" & JK & "', Program_Studi ='" & Program_Studi.Text & "' , Alamat = '" & TAlamat.Text & "' WHERE NIM = '" & TNIM.Text & "' ", Koneksi)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil diUpdate")
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'Simpan Baru'
            Try
                konek()

                cmd = New MySqlCommand("INSERT INTO mahasiswa (NIM, Nama, Jenis_Kelamin, Program_Studi, Alamat) VALUES ( '" & TNIM.Text & "','" & TNama.Text & "','" & JK & "','" & Program_Studi.Text & "','" & TAlamat.Text & "' ) ", Koneksi)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses!")
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        TampilkanData()
        BKosong_Click(sender, e)
    End Sub


    Private Sub TNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNIM.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                konek()

                Dim JK As String

                cmd = New MySqlCommand("SELECT * FROM mahasiswa WHERE NIM = '" & TNIM.Text & "' ", Koneksi)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    TNIM.Text = dr.Item(0)
                    TNama.Text = dr.Item(1)
                    JK = dr.Item(2)
                    If JK = "Pria" Then
                        RPria.Checked = True
                    ElseIf JK = "Wanita" Then
                        RWanita.Checked = True
                    End If
                    Program_Studi.Text = dr.Item(3)
                    TAlamat.Text = dr.Item(4)
                    MsgBox("Data Ditemukan")
                    Ketemu = True
                Else
                    MsgBox("Maaf, Data Tidak ditemukan")
                    TNIM.Focus()
                    Ketemu = False
                End If
                Diskonek()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BHapus_Click(sender As Object, e As EventArgs) Handles BHapus.Click
        Dim JK As String
        If RPria.Checked = True Then
            JK = "Pria"
        ElseIf RWanita.Checked = True Then
            JK = "Wanita"
        End If
        If Ketemu = True Then
            Try
                konek()
                If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data ini ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cmd = New MySqlCommand("DELETE FROM mahasiswa WHERE NIM = '" & TNIM.Text & "' ", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil diHapus")
                    Diskonek()
                    TampilkanData()
                    BKosong_Click(sender, e)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class
