Imports System
Imports System.Windows.Forms

Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Try
            ' Ambil input dari TextBox
            Dim berat As Double = Double.Parse(txtBerat.Text)
            Dim tinggiCm As Double = Double.Parse(txtTinggi.Text)

            ' Konversi tinggi dari cm ke meter
            Dim tinggiMeter As Double = tinggiCm / 100

            ' Hitung IMT
            Dim imt As Double = berat / (tinggiMeter * tinggiMeter)

            ' Tampilkan hasil IMT
            lblHasil.Text = "Hasil IMT: " & imt.ToString("F2")

            ' Tentukan kategori IMT
            Dim kategori As String
            If imt < 18.5 Then
                kategori = "Kurus"
            ElseIf imt >= 18.5 AndAlso imt < 24.9 Then
                kategori = "Normal"
            ElseIf imt >= 25 AndAlso imt < 29.9 Then
                kategori = "Gemuk"
            Else
                kategori = "Obesitas"
            End If

            lblKategori.Text = "Kategori IMT: " & kategori
        Catch ex As Exception
            MessageBox.Show("Input tidak valid! Masukkan angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class
