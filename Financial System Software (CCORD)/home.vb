Imports System.Data.SqlClient
Public Class home

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalBalance()
        DateTimePicker1.Value = Now.ToString()
        txtPurpose.Enabled = False
    End Sub


    Private Sub cboDescription_Enter(sender As Object, e As EventArgs) Handles cboDescription.Enter
        Try
            cn.Close()
            cboDescription.Items.Clear()
            cmd = New SqlCommand("select distinct lower(Description)as Description from TransactionShow order by description", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                cboDescription.Items.Add(dr!Description)
            End While
            txtPurpose.Enabled = True
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtDescription.Text = Nothing Then
            MessageBox.Show("enter description")
        ElseIf txtDescription.Text <> cboDescription.Text Then
            Try
                cn.Close()
                cmd = New SqlCommand("insert into TransactionShow(description)values('" & txtDescription.Text & "')", cn)
                cboDescription.Items.Add(txtDescription.Text)
                cboDescription.SelectedItem = txtDescription.Text
                txtPurpose.Enabled = True
                txtDescription.Clear()
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()


            Catch ex As Exception
                MessageBox.Show("this description already exist.......")
            End Try

        Else
            Try
                ErrorProvider1.SetError(txtDescription, "enter descriptions")
                cn.Close()
                cmd = New SqlCommand("select lower(Description) as Descriptions from TransactionShow where descriptions=LOWER('" & txtDescription.Text & "') order by description", cn)
                txtDescription.Clear()
                cn.Open()
                dr = cmd.ExecuteReader
                While dr.Read
                    cboDescription.Items.Add(dr!Description)
                End While
                txtPurpose.Enabled = True
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDescription.Text = Nothing And cboDescription.Text = Nothing And txtPaid.Text = Nothing And txtReceive.Text = Nothing And txtPurpose.Text = Nothing Then
            MessageBox.Show("unsaved please enter the records")
        Else
            Try
                cn.Close()
                cmd = New SqlCommand("insert into TransactionShow(Date,description,Purpose,Paid,Recieve)values('" & DateTimePicker1.Value & "','" & cboDescription.Text & "','" & txtPurpose.Text & "','" & txtPaid.Text & "','" & txtReceive.Text & "')", cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                MessageBox.Show("saved record")
                totalBalance()
                clear()
                cboDescription.Text = String.Empty
                DateTimePicker1.Value = Now.ToString("D")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Sub totalBalance()
        Try
            cn.Close()
            'cboDescription.Items.Clear()
            cmd = New SqlCommand("select SUM(Recieve-Paid) over (order by Date,Description) as RunningBalance from TransactionShow", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                lblbalance.Text = "$" & dr!RunningBalance
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       

    End Sub


    Sub clear()
        txtDescription.Clear()
        txtPurpose.Clear()
        txtPaid.Clear()
        txtReceive.Clear()
    End Sub

    Private Sub txtPurpose_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPurpose.MouseClick
        If txtDescription.Text = Nothing And cboDescription.Text = Nothing Then
            MessageBox.Show("please enter descriptionName ")
            ErrorProvider1.SetError(cboDescription, "please choose description Name")
        Else
            ErrorProvider1.SetError(cboDescription, "")
        End If
    End Sub

    Private Sub txtPaid_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPaid.MouseClick
        If txtDescription.Text = Nothing And cboDescription.Text = Nothing Then
            MessageBox.Show("please enter descriptionName ")
            ErrorProvider1.SetError(cboDescription, "please choose description Name")
        Else
            ErrorProvider1.SetError(cboDescription, "")
        End If
    End Sub

    Private Sub txtReceive_MouseClick(sender As Object, e As MouseEventArgs) Handles txtReceive.MouseClick
        If txtDescription.Text = Nothing And cboDescription.Text = Nothing Then
            MessageBox.Show("please enter descriptionName ")
            ErrorProvider1.SetError(cboDescription, "please choose description Name")
        Else
            ErrorProvider1.SetError(cboDescription, "")
        End If

    End Sub

End Class