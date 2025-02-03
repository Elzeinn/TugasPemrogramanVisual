Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Form1
    Public conn As MySql.Data.MySqlClient.MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet

    Public Sub Koneksi()
        Dim strcon As String
        Try
            strcon = "Server=localhost;user=root;password=;database=crud;SslMode=None;"
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


    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredUsername As String = username.Text
        Dim enteredPassword As String = username.Text

        Try
            Dim cmd As New MySqlCommand("SELECT username, password FROM user WHERE username = @username AND password = @password", conn)
            cmd.Parameters.AddWithValue("@username", enteredUsername)
            cmd.Parameters.AddWithValue("@password", enteredPassword)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Process.Start("D:\ElzCode\Tugas-Kuliah\PJJ - PEMROGRAMAN VISUAL\FormCRUD\FormCRUD\bin\Debug\FormCRUD.exe")
            Else
                MessageBox.Show("Login Gagal. Username atau password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub
End Class
