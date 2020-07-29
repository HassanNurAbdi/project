Public Class Form1
    Dim transactions As New transaction
    Dim home As New home
    Dim daily As New Daily
    Dim yearly As New Yearly
    Dim monthly As New Monthly


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formcenter(home)
        pnlSubMenuReport.Visible = False
        btnAbout.Location = New Point(13, 425)
        pnlOnButtonAbout.Location = New Point(1, 425)
        pnlhomebutton()
        lbldate.Text = Now.ToString("D")
        btnRestoreDown.Visible = False

    End Sub

    Public Sub formcenter(formdhexdhig As Object)
        If Me.pnlCenter.Controls.Count > 0 Then
            Me.pnlCenter.Controls.RemoveAt(0)
        End If
        Dim fh As New Form
        fh = formdhexdhig
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        Me.pnlCenter.Controls.Add(fh)
        Me.pnlCenter.Tag = fh
        fh.Show()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        formcenter(home)
        pnlhomebutton()


    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        formcenter(transaction)
        pnltransactionbutton()
        transactions.showTransactions()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        If pnlSubMenuReport.Visible = False Then
            pnlSubMenuReport.Visible = True
            pnlOnButtonAbout.Location = New Point(1, 601)
            btnAbout.Location = New Point(13, 601)
            pnlReportbutton()

        Else
            pnlSubMenuReport.Visible = False
            btnAbout.Location = New Point(13, 425)
            pnlOnButtonAbout.Location = New Point(1, 425)
            pnlReportbutton()

        End If
      
    End Sub

    Private Sub btndaily_Click(sender As Object, e As EventArgs) Handles btndaily.Click
        formcenter(Daily)
        pnlsubDaily()
        'daily.showDailyTransaction()
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        formcenter(Monthly)
        pnlsubMonthly()

    End Sub

    Private Sub btnyearly_Click(sender As Object, e As EventArgs) Handles btnyearly.Click
        formcenter(Yearly)
        pnlsubyearly()

    End Sub


    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        formcenter(About)
        pnlAboutbutton()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        closeApplication()

    End Sub

    Public Sub closeApplication()
        Application.Exit()
    End Sub


    Private Sub pnlhomebutton()
        pnlOnButtonHome.Visible = True
        pnlOnButtonTransaction.Visible = False
        pnlOnButtonReport.Visible = False
        pnlOnButtonAbout.Visible = False
        pnldaily.Visible = False
        pnlmonthly.Visible = False
        pnlyearly.Visible = False
    End Sub


    Public Sub pnltransactionbutton()
        pnlOnButtonHome.Visible = False
        pnlOnButtonTransaction.Visible = True
        pnlOnButtonReport.Visible = False
        pnlOnButtonAbout.Visible = False
        pnldaily.Visible = False
        pnlmonthly.Visible = False
        pnlyearly.Visible = False
    End Sub

    Private Sub pnlReportbutton()
        pnlOnButtonHome.Visible = False
        pnlOnButtonTransaction.Visible = False
        pnlOnButtonReport.Visible = True
        pnlOnButtonAbout.Visible = False
        pnldaily.Visible = False
        pnlmonthly.Visible = False
        pnlyearly.Visible = False
    End Sub

    Private Sub pnlAboutbutton()
        pnlOnButtonHome.Visible = False
        pnlOnButtonTransaction.Visible = False
        pnlOnButtonReport.Visible = False
        pnlOnButtonAbout.Visible = True
        pnldaily.Visible = False
        pnlmonthly.Visible = False
        pnlyearly.Visible = False
    End Sub

    Private Sub pnlsubDaily()
        pnlOnButtonHome.Visible = False
        pnlOnButtonTransaction.Visible = False
        pnlOnButtonReport.Visible = True
        pnlOnButtonAbout.Visible = False
        pnldaily.Visible = True
        pnlmonthly.Visible = False
        pnlyearly.Visible = False
        pnlSearch.Visible = False
    End Sub

    Private Sub pnlsubMonthly()
        pnlOnButtonHome.Visible = False
        pnlOnButtonTransaction.Visible = False
        pnlOnButtonReport.Visible = True
        pnlOnButtonAbout.Visible = False
        pnldaily.Visible = False
        pnlmonthly.Visible = True
        pnlyearly.Visible = False
        pnlSearch.Visible = False
    End Sub

    Private Sub pnlsubyearly()
        pnlOnButtonHome.Visible = False
        pnlOnButtonTransaction.Visible = False
        pnlOnButtonReport.Visible = True
        pnlOnButtonAbout.Visible = False
        pnldaily.Visible = False
        pnlmonthly.Visible = False
        pnlyearly.Visible = True
        pnlSearch.Visible = False
    End Sub

    Private Sub pnlSubSearchDate()
        pnlOnButtonHome.Visible = False
        pnlOnButtonTransaction.Visible = False
        pnlOnButtonReport.Visible = True
        pnlOnButtonAbout.Visible = False
        pnldaily.Visible = False
        pnlmonthly.Visible = False
        pnlyearly.Visible = False
        pnlSearch.Visible = True
    End Sub


    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
        btnMax.Visible = False
        btnRestoreDown.Visible = True
        Me.ShowInTaskbar = True
    End Sub

    Private Sub btnRestoreDown_Click(sender As Object, e As EventArgs) Handles btnRestoreDown.Click
        Me.WindowState = FormWindowState.Normal
        btnRestoreDown.Visible = False
        btnMax.Visible = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        formcenter(SearchForm)
        pnlSubSearchDate()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cn.Close()
        cmd.Connection = cn
        cmd.CommandText = "truncate table TransactionShow"
        Dim ans = MessageBox.Show("Are you sure to delete all record ?", "Confirmation", MessageBoxButtons.OKCancel)
        If ans = Windows.Forms.DialogResult.Cancel Then
            Return
        End If
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MessageBox.Show("All Transaction Deleted")
    End Sub

    Private Sub pnltopleftside_Paint(sender As Object, e As PaintEventArgs) Handles pnltopleftside.Paint

    End Sub
End Class
