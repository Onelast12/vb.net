<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblBerat = New Label()
        lblTinggi = New Label()
        txtBerat = New TextBox()
        txtTinggi = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        lblHasil = New Label()
        lblKategori = New Label()
        SuspendLayout()
        ' 
        ' lblBerat
        ' 
        lblBerat.AutoSize = True
        lblBerat.Location = New Point(135, 49)
        lblBerat.Name = "lblBerat"
        lblBerat.Size = New Size(90, 20)
        lblBerat.TabIndex = 0
        lblBerat.Text = "Berat Badan"
        ' 
        ' lblTinggi
        ' 
        lblTinggi.AutoSize = True
        lblTinggi.Location = New Point(135, 99)
        lblTinggi.Name = "lblTinggi"
        lblTinggi.Size = New Size(97, 20)
        lblTinggi.TabIndex = 1
        lblTinggi.Text = "Tinggi Badan"
        ' 
        ' txtBerat
        ' 
        txtBerat.Location = New Point(282, 49)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(125, 27)
        txtBerat.TabIndex = 2
        ' 
        ' txtTinggi
        ' 
        txtTinggi.Location = New Point(283, 92)
        txtTinggi.Name = "txtTinggi"
        txtTinggi.Size = New Size(125, 27)
        txtTinggi.TabIndex = 3
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(135, 149)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(94, 29)
        btnHitung.TabIndex = 4
        btnHitung.Text = "Hitung IMT"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(314, 352)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(135, 211)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(71, 20)
        lblHasil.TabIndex = 6
        lblHasil.Text = "Hasil IMT"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(135, 261)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(95, 20)
        lblKategori.TabIndex = 7
        lblKategori.Text = "Kategori IMT"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblKategori)
        Controls.Add(lblHasil)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtTinggi)
        Controls.Add(txtBerat)
        Controls.Add(lblTinggi)
        Controls.Add(lblBerat)
        Name = "Form1"
        Text = "Kesehatan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBerat As Label
    Friend WithEvents lblTinggi As Label
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents txtTinggi As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblHasil As Label
    Friend WithEvents lblKategori As Label

End Class
