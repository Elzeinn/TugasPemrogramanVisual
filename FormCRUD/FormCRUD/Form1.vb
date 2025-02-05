Imports System.Data.Odbc
Imports Microsoft.SqlServer.Server
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form1
    Public conn As MySql.Data.MySqlClient.MySqlConnection
    Public da As New MySqlDataAdapter
    Public ds As DataSet


    Public Sub Koneksi()
        Dim strcon As String

        Try
            strcon = "Server=localhost;user=root;password=;database=db_hutan;SslMode=None;"
            conn = New MySql.Data.MySqlClient.MySqlConnection(strcon)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            MessageBox.Show("Koneksi ke database berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database: " & ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub ViewData()
        Dim user As New DataSet
        Dim sqlGetData As String
        Dim cmdGetData As New MySqlCommand
        Try
            sqlGetData = "select * from t_hutan"
            'bind the connection and query
            With cmdGetData
                .Connection = conn
                .CommandText = sqlGetData
            End With
            da.SelectCommand = cmdGetData
            user.Clear()
            da.Fill(user, "t_user")
            gv_listData.DataSource = (user.Tables("t_user"))
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        ViewData()
        If lbl_role.Text.Equals("user") Then
            btn_delete.Visible = False
        End If
    End Sub

    Public Sub New(ByVal strName As String, ByVal strRole As String)

        ' This call is required by the designer.
        InitializeComponent()
        lbl_role.Visible = False

        lbl_role.Text = strRole
        lbl_nama_user.Text = "Hi, " & strName & " !"

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Dim id As String = TextID.Text
        Dim nama As String = TextNapi.Text
        Dim tglInput As String = TextTglin.Text
        Dim kota As String = TextKota.Text
        Dim provinsi As String = TextProvinsi.Text
        Dim kodepos As String = TextKodepos.Text
        Dim luas As String = TextLuashutan.Text
        Dim namaHutan As String = TextNamahutan.Text
        Dim tanggalSekarang As String = DateTime.Now.ToString("yyyy-MM-dd")
        Dim cmdInsertData As New MySqlCommand

        Try
            If id = "" Or nama = "" Or tglInput = "" Or kota = "" Or provinsi = "" Or kodepos = "" Or luas = "" Or namaHutan = "" Then
                MsgBox("Pastikan Semua Field Terisi")
            Else
                Call Koneksi()
                Dim sqlSimpan As String = "Insert into t_hutan values ('" & id & "','" & nama & "','" & tanggalSekarang & "','" & kota & "','" & provinsi & "','" & kodepos & "','" & luas & "','" & namaHutan & "','" & tanggalSekarang & "')"
                With cmdInsertData
                    .Connection = conn
                    .CommandText = sqlSimpan
                    .ExecuteNonQuery()
                End With
                MsgBox("Data Berhasil Di input")
                Call ViewData()
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

End Class
