Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Yearly

    Private Sub Yearly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_yearly_Report()

    End Sub



    Sub ComboBox_yearly_Report()

        Try
            cn.Close()
            cboYearly.Items.Clear()
            cmd = New SqlCommand("select distinct year(Date) as YearlyReport from TransactionShow", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            'cboYearly.Items.Add("Year")
            'cboYearly.SelectedIndex = 0
            While dr.Read
                cboYearly.Items.Add(dr.Item("YearlyReport"))
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    'Private Sub cboYearly_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearly.SelectedIndexChanged

    '    Try
    '        cn.Close()
    '        Datagridview1.Rows.Clear()
    '        cmd = New SqlCommand("select Date,descriptions,Purpose,Paid,Recieve,SUM(Recieve-Paid) over (order by Date,Descriptions) as RunningBalance from CashTable where year(Date)=('" & cboYearly.SelectedItem & "')", cn)
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
    '        cmd = New SqlCommand("select Date,descriptions,Purpose,Paid,Recieve,  SUM(Recieve-Paid) over (order by Date,descriptions) as RunningBalance from CashTable where descriptions like'" & txtSearch.Text & "%' order by Date,descriptions ", cn)
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



    Sub totalBalance()
        Try
            cn.Close()
            cmd = New SqlCommand("select SUM(Recieve-Paid) over (order by Date,Description) as RunningBalance from TransactionShow where year(date)=('" & cboYearly.SelectedItem & "') ", cn)
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
            cmd = New SqlCommand("select sum((-1)*Paid) as totalPaid from TransactionShow where year(date)=('" & cboYearly.SelectedItem & "') ", cn)
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
        cn.Close()
        cmd = New SqlCommand("select sum(Recieve) as totalRecieve from TransactionShow where year(date)=('" & cboYearly.SelectedItem & "')", cn)
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            lblReceive.Text = "$" & dr!totalRecieve
        End While
        dr.Close()
        cn.Close()
    End Sub



    'Private Sub btnPrint_Click(sender As Object, e As EventArgs)
    '    PrintDocument1.DefaultPageSettings.Landscape = True
    '    iprint()
    'End Sub

    'Private bitmap As Bitmap
    'Private Sub iprint()
    '    Dim height As Integer = DataGridView1.Height
    '    DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
    '    bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
    '    Datagridview1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.Datagridview1.Width, Me.Datagridview1.Height))
    '    PrintPreviewDialog1.Document = PrintDocument1
    '    PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
    '    PrintPreviewDialog1.ShowDialog()
    '    DataGridView1.Height = height

    'End Sub

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    e.Graphics.DrawImage(bitmap, 0, 0)

    'End Sub

    Private Sub cboYearly_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearly.SelectedIndexChanged
        Dim rd As New ReportDocument
        rd.Load("D:\just semesters\Financial System Software (CCORD)\Financial System Software (CCORD)\YearlyReports.rpt ")
        'CrystalReportViewer1.SelectionFormula = "{TransactionShow.Date}= '" & cboDaily.SelectedItem.ToString & "'"
        CrystalReportViewer1.Refresh()
        rd.SetParameterValue("YearlyReports", cboYearly.Text)
        CrystalReportViewer1.ReportSource = rd
        CrystalReportViewer1.Refresh()
        totalAllPaid()
        totalAllRecieve()
        totalBalance()
    End Sub


    Sub showreport()
        Dim rd As New ReportDocument
        rd.Load("D:\just semesters\Financial System Software (CCORD)\Financial System Software (CCORD)\YearlyReport.rpt")
        'CrystalReportViewer1.SelectionFormula = "{TransactionShow.Date}= '" & cboDaily.SelectedItem.ToString & "'"
        'rd.SetParameterValue("YearlyReport", cboYearly.Text)
        CrystalReportViewer1.ReportSource = rd
        CrystalReportViewer1.Refresh()
       

    End Sub
End Class