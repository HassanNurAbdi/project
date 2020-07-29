Imports System.Data.SqlClient
Public Class SearchForm


    Private Sub Chart_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'totalAllCash()
        totalAllPaid()
        totalAllRecieve()
        totalBalance()
        'totalAllMember()
        'fillChart()
    End Sub


   


    Sub totalBalance()
        cn.Close()
        'cboDescription.Items.Clear()
        cmd = New SqlCommand("select SUM(Recieve-Paid) over (order by Date,Descriptions) as RunningBalance from CashTable", cn)
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            lblBalance.Text = "$" & dr!RunningBalance
        End While
        dr.Close()
        cn.Close()

    End Sub


    Sub totalAllPaid()
        cn.Close()
        cmd = New SqlCommand("select sum((-1)*Paid) as totalPaid from CashTable", cn)
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            lblPaid.Text = "$" & dr!totalPaid
        End While
        dr.Close()
        cn.Close()
    End Sub

    Sub totalAllRecieve()
        cn.Close()
        cmd = New SqlCommand("select sum(Recieve) as totalRecieve from CashTable", cn)
        cn.Open()
        dr = cmd.ExecuteReader
        While dr.Read
            lblReceive.Text = "$" & dr!totalRecieve
        End While
        dr.Close()
        cn.Close()
    End Sub


    'Sub totalAllCash()
    '    cn.Close()
    '    cmd = New SqlCommand("select sum(Recieve+Paid) as totalCash from CashTable", cn)
    '    cn.Open()
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        lblCash.Text = "$" & dr!totalCash
    '    End While
    '    dr.Close()
    '    cn.Close()
    'End Sub


    'Sub totalAllMember()
    '    cn.Close()
    '    cmd = New SqlCommand("select count(descriptions) as totalMembers from ccord_Desc", cn)
    '    cn.Open()
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        lblMember.Text = dr!totalMembers
    '    End While
    '    dr.Close()
    '    cn.Close()
    'End Sub

    'Private Sub fillChart()
    '    'Dim counter As Integer = 1
    '    'ds = New DataSet()
    '    'cn.Open()
    '    'While counter <= 12

    '    '    Da = New SqlDataAdapter("select MONTH(Date) as date,sum(Recieve)as recieve,sum(Paid) as paid from cashtable where month(date)=('" & counter & "') group by date", cn)
    '    '    Da.Fill(ds)
    '    '    Chart1.DataSource = ds
    '    '    Chart1.Series("showPaid").Points.AddXY("jan", "paid")
    '    '    Chart1.Series("showRecieve").Points.AddXY("feb", "recieve")
    '    '    counter = counter + 1

    '    'End While
    '    'cn.Close()

    '    cn.Open()
    '    cmd.Connection = cn
    '    cmd.CommandText = "select month(Date),sum(Recieve)as recieve,sum(Paid) as paid from cashtable group by date"
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        Chart1.Series("showPaid").Points.AddXY("date", "paid")
    '        Chart1.Series("showRecieve").Points.AddXY("date", "recieve")
    '    End While
    '    cn.Close()
    'End Sub


    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        Try
            cn.Close()
            Datagridview1.Rows.Clear()
            cmd = New SqlCommand("select Date,lower(descriptions)As Descriptions,Purpose,Paid,Recieve,  SUM(Recieve-Paid) over (order by Date,descriptions) as RunningBalance from CashTable where date between'" & DateTimePicker1.Value & "'and '" & DateTimePicker2.Value & "' order by Date,descriptions ", cn)
            cn.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                Datagridview1.Rows.Add(dr!Date, dr!descriptions, dr!Purpose, dr!Paid, dr!Recieve, dr!RunningBalance)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class