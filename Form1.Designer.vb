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
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        ComboItem = New ComboBox()
        TxtHarga = New TextBox()
        TxtJumlah = New TextBox()
        TxtSubTotal = New TextBox()
        TxtDiskon = New TextBox()
        TxtTotal = New TextBox()
        TxtBayar = New TextBox()
        TxtKembali = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        BtnTotal = New Button()
        BtnReset = New Button()
        BtnClose = New Button()
        ListBox1 = New ListBox()
        BtnTambah = New Button()
        Label14 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSalmon
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(887, 97)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Maroon
        Label4.Location = New Point(44, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(304, 32)
        Label4.TabIndex = 2
        Label4.Text = "DIAZ SPAREPART SHOP"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(413, 57)
        Label3.TabIndex = 1
        Label3.Text = "Aplikasi Kasir"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.OldLace
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(548, 35)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(265, 32)
        Panel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(54, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 32)
        Label2.TabIndex = 1
        Label2.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 32)
        Label1.TabIndex = 0
        Label1.Text = "Rp. "
        ' 
        ' ComboItem
        ' 
        ComboItem.FormattingEnabled = True
        ComboItem.Items.AddRange(New Object() {"Oli Mesin", "Oli Gardan", "Busi", "Filter Udara", "Kampas Rem", "Rantai Motor", "Aki Motor", "Lampu Depan"})
        ComboItem.Location = New Point(105, 195)
        ComboItem.Name = "ComboItem"
        ComboItem.Size = New Size(190, 23)
        ComboItem.TabIndex = 1
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(105, 236)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.Size = New Size(190, 23)
        TxtHarga.TabIndex = 2
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(105, 277)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(190, 23)
        TxtJumlah.TabIndex = 3
        ' 
        ' TxtSubTotal
        ' 
        TxtSubTotal.Location = New Point(105, 317)
        TxtSubTotal.Name = "TxtSubTotal"
        TxtSubTotal.Size = New Size(190, 23)
        TxtSubTotal.TabIndex = 4
        ' 
        ' TxtDiskon
        ' 
        TxtDiskon.Location = New Point(105, 429)
        TxtDiskon.Name = "TxtDiskon"
        TxtDiskon.Size = New Size(112, 23)
        TxtDiskon.TabIndex = 6
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Location = New Point(105, 470)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.Size = New Size(190, 23)
        TxtTotal.TabIndex = 7
        ' 
        ' TxtBayar
        ' 
        TxtBayar.Location = New Point(602, 429)
        TxtBayar.Name = "TxtBayar"
        TxtBayar.Size = New Size(190, 23)
        TxtBayar.TabIndex = 8
        ' 
        ' TxtKembali
        ' 
        TxtKembali.Location = New Point(602, 470)
        TxtKembali.Name = "TxtKembali"
        TxtKembali.Size = New Size(190, 23)
        TxtKembali.TabIndex = 9
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(705, 211)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(47, 19)
        RadioButton1.TabIndex = 10
        RadioButton1.TabStop = True
        RadioButton1.Text = "10%"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(705, 236)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(47, 19)
        RadioButton2.TabIndex = 11
        RadioButton2.TabStop = True
        RadioButton2.Text = "15%"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(705, 261)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(47, 19)
        RadioButton3.TabIndex = 12
        RadioButton3.TabStop = True
        RadioButton3.Text = "20%"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(705, 286)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(47, 19)
        RadioButton4.TabIndex = 13
        RadioButton4.TabStop = True
        RadioButton4.Text = "25%"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(705, 311)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(71, 19)
        RadioButton5.TabIndex = 14
        RadioButton5.TabStop = True
        RadioButton5.Text = "NO DISC"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(12, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 21)
        Label5.TabIndex = 15
        Label5.Text = "ITEM"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(12, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 21)
        Label6.TabIndex = 16
        Label6.Text = "Harga"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.Location = New Point(12, 279)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 21)
        Label7.TabIndex = 17
        Label7.Text = "Jumlah"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.Location = New Point(12, 319)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 21)
        Label8.TabIndex = 18
        Label8.Text = "Sub Total"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.Location = New Point(12, 431)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 21)
        Label9.TabIndex = 19
        Label9.Text = "Diskon"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label10.Location = New Point(12, 472)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 21)
        Label10.TabIndex = 20
        Label10.Text = "Total"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label11.Location = New Point(482, 431)
        Label11.Name = "Label11"
        Label11.Size = New Size(98, 21)
        Label11.TabIndex = 21
        Label11.Text = "Uang Bayar"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label12.Location = New Point(462, 472)
        Label12.Name = "Label12"
        Label12.Size = New Size(118, 21)
        Label12.TabIndex = 22
        Label12.Text = "Uang Kembali"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(705, 182)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 15)
        Label13.TabIndex = 23
        Label13.Text = "DISCOUNT"
        ' 
        ' BtnTotal
        ' 
        BtnTotal.Location = New Point(105, 509)
        BtnTotal.Name = "BtnTotal"
        BtnTotal.Size = New Size(75, 23)
        BtnTotal.TabIndex = 24
        BtnTotal.Text = "Total"
        BtnTotal.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(677, 580)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(75, 23)
        BtnReset.TabIndex = 25
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' BtnClose
        ' 
        BtnClose.Location = New Point(771, 580)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(75, 23)
        BtnClose.TabIndex = 26
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(337, 195)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(304, 199)
        ListBox1.TabIndex = 27
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Location = New Point(337, 409)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(88, 31)
        BtnTambah.TabIndex = 28
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(337, 156)
        Label14.Name = "Label14"
        Label14.Size = New Size(169, 25)
        Label14.TabIndex = 29
        Label14.Text = "DAFTAR BELANJA"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(887, 640)
        Controls.Add(Label14)
        Controls.Add(BtnTambah)
        Controls.Add(ListBox1)
        Controls.Add(BtnClose)
        Controls.Add(BtnReset)
        Controls.Add(BtnTotal)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(TxtKembali)
        Controls.Add(TxtBayar)
        Controls.Add(TxtTotal)
        Controls.Add(TxtDiskon)
        Controls.Add(TxtSubTotal)
        Controls.Add(TxtJumlah)
        Controls.Add(TxtHarga)
        Controls.Add(ComboItem)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboItem As ComboBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents TxtDiskon As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtBayar As TextBox
    Friend WithEvents TxtKembali As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnTotal As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Label14 As Label

End Class
