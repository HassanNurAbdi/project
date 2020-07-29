Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Daily

    'Public RD As New ReportDocument
    Private Sub Daily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'showDailyTransaction()
        totalBalance()
        totalAllRecieve()
        totalAllPaid()
        ComboBox_daily_Report()


        Dim rd As New ReportDocument
        rd.Load("D:\just semesters\Financial System Software (CCORD)\Financial System Software (CCORD)\DailyReports.rpt")
        CrystalReportViewer1.ReportSource = rd




    End Sub

    'Public Sub showDailyTransaction()
    '    Try
    '        cn.Close()
    '        Datagridview1.Rows.Clear()
    '        cmd = New SqlCommand("select Date,lower(descriptions)As Descriptions,Purpose,Paid,Recieve,SUM(Recieve-Paid) over (order by Date,Descriptions) as RunningBalance from CashTable where Date>=DATEADD(DAY,-1,GETDATE())", cn)
    '        cn.Open()
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            Datagridview1.Rows.Add(dr!Date, dr!Descriptions, dr!Purpose, dr!Paid, dr!Recieve, dr!RunningBalance)
    '        End While
    '        totalDailyBalance()
    '        totalDailyPaid()
    '        totalDailyRecieve()
    '        dr.Close()
    '        cn.Close()
    ''    Catch ex As Exception
    ''        MessageBox.Show(ex.Message)
    ''    End Try


    'End Sub


    Sub totalBalance()
        Try
            cn.Close()
            lblBalance.Text = ""
            cmd = New SqlCommand("select SUM(Recieve-Paid) over (order by Date,Description) as RunningBalance from TransactionShow where date=('" & cboDaily.SelectedItem & "') ", cn)
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
            lblPaid.Text = ""
            cmd = New SqlCommand("select sum((-1)*Paid) as totalPaid from TransactionShow where date=('" & cboDaily.SelectedItem & "') ", cn)
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
            lblRecieve.Text = ""
            cmd = New SqlCommand("select sum(Recieve) as totalRecieve from TransactionShow where date=('" & cboDaily.SelectedItem & "')", cn)
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



    Sub ComboBox_daily_Report()
        Try
            cn.Close()
            cboDaily.Items.Clear()
            cmd = New SqlCommand("select distinct Date as DailyReport from TransactionShow", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            'cboDaily.Items.Add("Days")
            'cboDaily.SelectedIndex = 0
            While dr.Read
                cboDaily.Items.Add(dr.Item("DailyReport"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub totalDailyBalance()
        Try
            cn.Close()
            lblBalance.Text = ""
            cmd = New SqlCommand("select SUM(Recieve-Paid) over (order by Date,Description) as RunningBalance from TransactionShow where Date>=DATEADD(DAY,-1,GETDATE())", cn)
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


    Sub totalDailyPaid()

        Try
            cn.Close()
            lblPaid.Text = ""
            cmd = New SqlCommand("select sum((-1)*Paid) as totalPaid from TransactionShow where Date>=DATEADD(DAY,-1,GETDATE()) ", cn)
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

    Sub totalDailyRecieve()
        Try
            cn.Close()
            lblRecieve.Text = ""
            cmd = New SqlCommand("select sum(Recieve) as totalRecieve from TransactionShow where Date>=DATEADD(DAY,-1,GETDATE())", cn)
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




    'Private Sub cboDaily_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDaily.SelectedIndexChanged
    '    Try
    '        cn.Close()
    '        Datagridview1.Rows.Clear()
    '        cmd = New SqlCommand("select Date,lower(descriptions)As Descriptions,Purpose,Paid,Recieve,SUM(Recieve-Paid) over (order by Date,Descriptions) as RunningBalance from CashTable where day(Date)=('" & cboDaily.SelectedItem & "')", cn)
    '        cn.Open()
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            Datagridview1.Rows.Add(dr!Date, dr!Descriptions, dr!Purpose, dr!Paid, dr!Recieve, dr!RunningBalance)
    '        End While
    '        totalAllPaid()
    '        totalAllRecieve()
    '        totalBalance()
    '        dr.Close()
    '        cn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    'Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
    '    If Char.IsControl(e.KeyChar) Then Exit Sub
    '    If Char.IsWhiteSpace(e.KeyChar) Then Exit Sub

    '    If Not Char.IsLetter(e.KeyChar) Then
    '        ErrorProvider1.SetError(CType(sender, Control), "Please enter only letter!!!")
    '    Else
    '        ErrorProvider1.SetError(txtSearch, "")
    '    End If
    'End Sub

    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    '    Try
    '        cn.Close()
    '        Datagridview1.Rows.Clear()
    '        cmd = New SqlCommand("select Date,lower(descriptions)As Descriptions,Purpose,Paid,Recieve,  SUM(Recieve-Paid) over (order by Date,descriptions) as RunningBalance from CashTable where descriptions like'" & txtSearch.Text & "%' order by Date,descriptions ", cn)
    '        cn.Open()
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            Datagridview1.Rows.Add(dr!Date, dr!descriptions, dr!Purpose, dr!Paid, dr!Recieve, dr!RunningBalance)
    '        End While
    '        dr.Close()
    '        cn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    '    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
    '        PrintDocument1.DefaultPageSettings.Landscape = True
    '        iprint()
    '    End Sub

    '    Private bitmap As Bitmap
    '    Private Sub iprint()
    '        Dim height As Integer = DataGridView1.Height
    '        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
    '        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
    '        Datagridview1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.Datagridview1.Width, Me.Datagridview1.Height))
    '        PrintPreviewDialog1.Document = PrintDocument1
    '        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
    '        PrintPreviewDialog1.ShowDialog()
    '        DataGridView1.Height = height

    '    End Sub

    '    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '        e.Graphics.DrawImage(bitmap, 0, 0)

    '    End Sub


    '    Private Sub btnFromTo_Click(sender As Object, e As EventArgs)


    '    End Sub

    Private Sub cboDaily_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDaily.SelectedIndexChanged

        Dim rd As New ReportDocument
        rd.Load("D:\just semesters\Financial System Software (CCORD)\Financial System Software (CCORD)\DailyReports.rpt")
        'CrystalReportViewer1.SelectionFormula = "{TransactionShow.Date}= '" & cboDaily.SelectedItem.ToString & "'"
        rd.SetParameterValue("DailyReports", cboDaily.Text)
        CrystalReportViewer1.ReportSource = rd
        CrystalReportViewer1.Refresh()

        totalAllPaid()
        totalAllRecieve()
        totalBalance()

    End Sub

End Class