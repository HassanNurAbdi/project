Imports System.Data.SqlClient
Public Class UserLogin
    Dim f As New Form1

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
        btnMax.Visible = False
        btnRestoreDown.Visible = True
        Me.ShowInTaskbar = True
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestoreDown_Click(sender As Object, e As EventArgs) Handles btnRestoreDown.Click
        Me.WindowState = FormWindowState.Normal
        btnRestoreDown.Visible = False
        btnMax.Visible = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            cn.Close()
            cmd = New SqlCommand("select * from LoginTable where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "' ", cn)
            cn.Open()
            Da = New SqlDataAdapter(cmd)
            table = New DataTable
            Da.Fill(table)
            If table.Rows.Count() = 1 Then
                'MessageBox.Show("Login Successfully")
                Me.Hide()
                Splaashvb.Show()
            Else
                MessageBox.Show("Username and Password are invalid")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub


    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Now.ToString("D")
        btnRestoreDown.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Dim ans = MessageBox.Show("Are you sure to exit ?", "Confirmation", MessageBoxButtons.OKCancel)
            If ans = Windows.Forms.DialogResult.OK Then
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txtPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
        End If
    End Sub
End Class