Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class FormLogin
    Public conn As MySql.Data.MySqlClient.MySqlConnection
    Public da As New MySqlDataAdapter
    Public ds As DataSet
    Public cmd As New MySqlCommand

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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim enteredUsername As String = tb_user.Text
        Dim enteredPassword As String = tb_pass.Text
        Dim user As New DataTable
        Dim sql As String

        Try
            If enteredUsername = "" And enteredPassword = "" Then
                MsgBox("Password or Username Tidak Boleh Kosong!")

            Else
                sql = "select nama, role from t_user where user ='" & enteredUsername & "' and password = '" & enteredPassword & "'"
                With cmd
                    .Connection = conn
                    .CommandText = sql
                End With
                da.SelectCommand = cmd
                da.Fill(user)
                If user.Rows.Count > 0 Then
                    MessageBox.Show("Login Berhasil!", "Informasi !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Dim form As New Form1(user.Rows(0).Item(0), user.Rows(0).Item(1))
                    form.Show()
                Else
                    MessageBox.Show("Login Gagal. Username atau password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub
End Class
