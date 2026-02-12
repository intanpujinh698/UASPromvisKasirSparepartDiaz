Imports System.IO

Public Class Form1
    Private Sub ComboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboItem.SelectedIndexChanged
        Try
            Dim path As String = Application.StartupPath & "\stok.txt"
            Dim isiFile() As String = File.ReadAllLines(path)
            For Each baris As String In isiFile
                Dim data() As String = baris.Split(","c)

                If data(0).Trim() = ComboItem.Text Then
                    TxtHarga.Text = data(1).Trim()
                    Exit For
                End If
            Next
        Catch ex As Exception
            TxtHarga.Text = 0
        End Try
    End Sub

    Private Sub MuatDataDariFile()
        Try
            Dim path As String = Application.StartupPath & "\stok.txt"

            If File.Exists(path) Then
                Dim isiFile() As String = File.ReadAllLines(path)
                ComboItem.Items.Clear()

                For Each baris As String In isiFile
                    If baris.Contains(",") Then

                        Dim namaBarang As String = baris.Split(","c)(0)
                        ComboItem.Items.Add(namaBarang)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data!")
        End Try
    End Sub

    Private Sub IsiDaftarBarang()
        Try
            Dim path As String = Application.StartupPath & "\stok.txt"

            If File.Exists(path) Then
                Dim daftar() As String = File.ReadAllLines(path)

                ComboItem.Items.Clear()

                For Each item As String In daftar
                    ComboItem.Items.Add(item)
                Next
            Else
                MessageBox.Show("File stok.txt tidak ditemukan di Folder Debug!")
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi Kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        MuatDataDariFile()
    End Sub

    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click
        Dim total As Integer = 0

        For i As Integer = 0 To ListBox1.Items.Count - 1

            Dim data As String = ListBox1.Items(i).ToString()
            Dim parts() As String = data.Split("="c)
            Dim subtotal As Integer = CInt(parts(1).Trim())

            total += subtotal

        Next

        TxtSubTotal.Text = total

        ' Hitung diskon
        Dim diskon As Integer = CInt(TxtDiskon.Text)
        Dim totalAkhir As Integer = total - (total * diskon / 100)

        TxtTotal.Text = totalAkhir

        Label2.Text = Format(totalAkhir, "##,##0")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TxtDiskon.Text = 10
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TxtDiskon.Text = 15
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            TxtDiskon.Text = 20
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TxtDiskon.Text = 25
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TxtDiskon.Text = 0
        End If
    End Sub

    Private Sub TxtBayar_Leave(sender As Object, e As EventArgs) Handles TxtBayar.Leave
        TxtKembali.Text = TxtBayar.Text - TxtTotal.Text
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboItem.Text = ""
        TxtHarga.Text = ""
        TxtJumlah.Text = ""
        TxtSubTotal.Text = ""
        TxtDiskon.Text = ""
        TxtTotal.Text = ""
        TxtBayar.Text = ""
        TxtKembali.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        Label12.Text = "Uang Kembali"
        ComboItem.Focus()
        ListBox1.Items.Clear()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If TxtHarga.Text = "" Or TxtJumlah.Text = "" Then
            MessageBox.Show("Jumlah dan Harga harus diisi!")
            Exit Sub
        End If
        Dim harga As Integer = CInt(TxtHarga.Text)
        Dim jumlah As Integer = CInt(TxtJumlah.Text)
        Dim subtotal As Integer = harga * jumlah

        TxtSubTotal.Text = subtotal

        Dim itemText As String = ComboItem.Text & " | " & harga & " x " & jumlah & " = " & subtotal

        ListBox1.Items.Add(itemText)
    End Sub
End Class
