Imports System.Data.SqlClient
Public Class transaction

    Dim i As Integer

    Private Sub transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showTransactions()
        totalBalance()
        totalAllRecieve()
        totalAllPaid()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        iprint()
    End Sub

    Private bitmap As Bitmap
    Private Sub iprint()
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        Datagridview1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.Datagridview1.Width, Me.Datagridview1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)

    End Sub


    Public Sub showTransactions()
        Try
            cn.Close()
            Datagridview1.Rows.Clear()
            cmd = New SqlCommand("select id,Date,lower(description)As Descriptions,Purpose,Paid,Recieve,  SUM(Recieve-Paid) over (order by Date,Description) as RunningBalance from TransactionShow order by Date,Description ", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                Datagridview1.Rows.Add(dr!id, dr!Date, dr!Descriptions, dr!Purpose, dr!Paid, dr!Recieve, dr!RunningBalance)
            End While
            dr.Close()
            cn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Char.IsControl(e.KeyChar) Then Exit Sub
        If Char.IsWhiteSpace(e.KeyChar) Then Exit Sub

        If Not Char.IsLetter(e.KeyChar) Then
            ErrorProvider1.SetError(CType(sender, Control), "Please enter only letter !!!")
        Else
            ErrorProvider1.SetError(txtSearch, "")
        End If
    End Sub






    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            cn.Close()
            Datagridview1.Rows.Clear()
            cmd = New SqlCommand("select id,Date,lower(description)As Descriptions,Purpose,Paid,Recieve,  SUM(Recieve-Paid) over (order by Date,description) as RunningBalance from TransactionShow where description like'" & txtSearch.Text & "%' order by Date,description ", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                Datagridview1.Rows.Add(dr!id, dr!Date, dr!descriptions, dr!Purpose, dr!Paid, dr!Recieve, dr!RunningBalance)
            End While
            ' ''txtSearch.Clear()
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
      
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            cn.Close()
            Datagridview1.Rows.Clear()
            cmd = New SqlCommand("select ID,Date,lower(description)As Descriptions,Purpose,Paid,Recieve,  SUM(Recieve-Paid) over (order by Date,Description) as RunningBalance from TransactionShow where Date='" & DateTimePicker1.Value & "' order by Date,Description ", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                Datagridview1.Rows.Add(dr!id, dr!Date, dr!descriptions, dr!Purpose, dr!Paid, dr!Recieve, dr!RunningBalance)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub

    Sub totalBalance()
        Try
            cn.Close()
            'cboDescription.Items.Clear()
            cmd = New SqlCommand("select SUM(Recieve-Paid) over (order by Date,Description) as RunningBalance from TransactionShow", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                lblBalance.Text = "$" & dr!RunningBalance
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

    End Sub


    Sub totalAllPaid()
        Try
            cn.Close()
            cmd = New SqlCommand("select sum((-1)*Paid) as totalPaid from TransactionShow", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                lblPaid.Text = "$" & dr!totalPaid
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Sub totalAllRecieve()
        Try
            cn.Close()
            cmd = New SqlCommand("select sum(Recieve) as totalRecieve from TransactionShow", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                lblRecieve.Text = "$" & dr!totalRecieve
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
     
    End Sub



    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        showTransactions()
    End Sub

    Private Sub Datagridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datagridview1.CellClick
        clear()
        'cn.Close()
        i = Datagridview1.CurrentRow.Index
        'i = Convert.ToInt32(Datagridview1.SelectedCells.Item(0).Value.ToString())
        'cmd.Connection = cn
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "select * from TransactionShow where id=" & i & ""
        'cn.Open()
        'dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        'While dr.Read
        '    Dateupdate.Value = dr.GetString(1).ToString
        '    cboDesc.Text = dr.GetString(2).ToString
        '    txtPurpose.Text = dr.GetString(3).ToString
        '    txtPaid.Text = dr.GetString(4).ToString
        '    txtRecieve.Text = dr.GetString(5).ToString
        'End While
        Dateupdate.Value = Datagridview1.Item(1, i).Value
        cboDesc.Text = Datagridview1.Item(2, i).Value
        txtPurpose.Text = Datagridview1.Item(3, i).Value
        txtPaid.Text = Datagridview1.Item(4, i).Value
        txtRecieve.Text = Datagridview1.Item(5, i).Value
    End Sub

 

    Sub clear()
        txtPaid.Clear()
        txtRecieve.Clear()
        cboDesc.Items.Clear()
        txtPurpose.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            cn.Close()
            cmd = New SqlCommand("update TransactionShow set Date='" & Dateupdate.Value & "',description='" & cboDesc.Text & "',Purpose='" & txtPurpose.Text & "',Paid='" & txtPaid.Text & "',Recieve='" & txtRecieve.Text & "' where id=(" & Datagridview1.Item(0, i).Value & ")", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("updated record")
            'totalBalance()
            'clear()
            'cboDescription.Text = String.Empty
            'DateTimePicker1.Value = Now.ToString("D")
            showTransactions()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            cn.Close()
            cmd = New SqlCommand("delete from TransactionShow where id=" & Datagridview1.Item(0, i).Value & "", cn)
            Dim ans = MessageBox.Show("Are you sure to delete this record ?", "Confirmation", MessageBoxButtons.OKCancel)
            If ans = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("delete record")
            showTransactions()
            'totalBalance()
            clear()
            'cboDescription.Text = String.Empty
            'DateTimePicker1.Value = Now.ToString("D")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class