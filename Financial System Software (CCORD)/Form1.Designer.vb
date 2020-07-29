<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlleftside = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlSubMenuReport = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btndaily = New System.Windows.Forms.Button()
        Me.pnlmonthly = New System.Windows.Forms.Panel()
        Me.btnyearly = New System.Windows.Forms.Button()
        Me.pnldaily = New System.Windows.Forms.Panel()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.pnlyearly = New System.Windows.Forms.Panel()
        Me.pnlOnButtonAbout = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.pnlOnButtonReport = New System.Windows.Forms.Panel()
        Me.pnlOnButtonTransaction = New System.Windows.Forms.Panel()
        Me.pnlOnButtonHome = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pnltopleftside = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.btnRestoreDown = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.pnlleftside.SuspendLayout()
        Me.pnlSubMenuReport.SuspendLayout()
        Me.pnltopleftside.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlleftside
        '
        Me.pnlleftside.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlleftside.Controls.Add(Me.Panel1)
        Me.pnlleftside.Controls.Add(Me.pnlSubMenuReport)
        Me.pnlleftside.Controls.Add(Me.pnlOnButtonAbout)
        Me.pnlleftside.Controls.Add(Me.btnReset)
        Me.pnlleftside.Controls.Add(Me.pnlOnButtonReport)
        Me.pnlleftside.Controls.Add(Me.pnlOnButtonTransaction)
        Me.pnlleftside.Controls.Add(Me.pnlOnButtonHome)
        Me.pnlleftside.Controls.Add(Me.btnAbout)
        Me.pnlleftside.Controls.Add(Me.pnltopleftside)
        Me.pnlleftside.Controls.Add(Me.btnReport)
        Me.pnlleftside.Controls.Add(Me.btnTransaction)
        Me.pnlleftside.Controls.Add(Me.btnHome)
        Me.pnlleftside.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlleftside.Location = New System.Drawing.Point(0, 0)
        Me.pnlleftside.Name = "pnlleftside"
        Me.pnlleftside.Size = New System.Drawing.Size(256, 803)
        Me.pnlleftside.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 601)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(12, 62)
        Me.Panel1.TabIndex = 9
        '
        'pnlSubMenuReport
        '
        Me.pnlSubMenuReport.Controls.Add(Me.btnSearch)
        Me.pnlSubMenuReport.Controls.Add(Me.pnlSearch)
        Me.pnlSubMenuReport.Controls.Add(Me.btndaily)
        Me.pnlSubMenuReport.Controls.Add(Me.pnlmonthly)
        Me.pnlSubMenuReport.Controls.Add(Me.btnyearly)
        Me.pnlSubMenuReport.Controls.Add(Me.pnldaily)
        Me.pnlSubMenuReport.Controls.Add(Me.btnMonthly)
        Me.pnlSubMenuReport.Controls.Add(Me.pnlyearly)
        Me.pnlSubMenuReport.Location = New System.Drawing.Point(6, 423)
        Me.pnlSubMenuReport.Name = "pnlSubMenuReport"
        Me.pnlSubMenuReport.Size = New System.Drawing.Size(247, 172)
        Me.pnlSubMenuReport.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnSearch.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_search_property_32
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(33, 132)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(207, 37)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search Date"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlSearch.Location = New System.Drawing.Point(23, 132)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(10, 37)
        Me.pnlSearch.TabIndex = 14
        '
        'btndaily
        '
        Me.btndaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btndaily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndaily.FlatAppearance.BorderSize = 0
        Me.btndaily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btndaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndaily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btndaily.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_test_results_32
        Me.btndaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndaily.Location = New System.Drawing.Point(33, 3)
        Me.btndaily.Name = "btndaily"
        Me.btndaily.Size = New System.Drawing.Size(207, 37)
        Me.btndaily.TabIndex = 7
        Me.btndaily.Text = "  Daily  Reports"
        Me.btndaily.UseVisualStyleBackColor = False
        '
        'pnlmonthly
        '
        Me.pnlmonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlmonthly.Location = New System.Drawing.Point(23, 46)
        Me.pnlmonthly.Name = "pnlmonthly"
        Me.pnlmonthly.Size = New System.Drawing.Size(10, 37)
        Me.pnlmonthly.TabIndex = 10
        '
        'btnyearly
        '
        Me.btnyearly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnyearly.FlatAppearance.BorderSize = 0
        Me.btnyearly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnyearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyearly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyearly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnyearly.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_us_news_32
        Me.btnyearly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnyearly.Location = New System.Drawing.Point(33, 89)
        Me.btnyearly.Name = "btnyearly"
        Me.btnyearly.Size = New System.Drawing.Size(207, 37)
        Me.btnyearly.TabIndex = 11
        Me.btnyearly.Text = "    Yearly Reports"
        Me.btnyearly.UseVisualStyleBackColor = True
        '
        'pnldaily
        '
        Me.pnldaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnldaily.Location = New System.Drawing.Point(23, 3)
        Me.pnldaily.Name = "pnldaily"
        Me.pnldaily.Size = New System.Drawing.Size(10, 37)
        Me.pnldaily.TabIndex = 8
        '
        'btnMonthly
        '
        Me.btnMonthly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonthly.FlatAppearance.BorderSize = 0
        Me.btnMonthly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnMonthly.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_schedule_32
        Me.btnMonthly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonthly.Location = New System.Drawing.Point(33, 46)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(207, 37)
        Me.btnMonthly.TabIndex = 9
        Me.btnMonthly.Text = "       Monthly  Reports"
        Me.btnMonthly.UseVisualStyleBackColor = True
        '
        'pnlyearly
        '
        Me.pnlyearly.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlyearly.Location = New System.Drawing.Point(23, 89)
        Me.pnlyearly.Name = "pnlyearly"
        Me.pnlyearly.Size = New System.Drawing.Size(10, 37)
        Me.pnlyearly.TabIndex = 12
        '
        'pnlOnButtonAbout
        '
        Me.pnlOnButtonAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlOnButtonAbout.Location = New System.Drawing.Point(1, 669)
        Me.pnlOnButtonAbout.Name = "pnlOnButtonAbout"
        Me.pnlOnButtonAbout.Size = New System.Drawing.Size(12, 62)
        Me.pnlOnButtonAbout.TabIndex = 6
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnReset.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_delete_trash_48
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(13, 601)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(238, 62)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset All"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'pnlOnButtonReport
        '
        Me.pnlOnButtonReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlOnButtonReport.Location = New System.Drawing.Point(0, 357)
        Me.pnlOnButtonReport.Name = "pnlOnButtonReport"
        Me.pnlOnButtonReport.Size = New System.Drawing.Size(12, 62)
        Me.pnlOnButtonReport.TabIndex = 5
        '
        'pnlOnButtonTransaction
        '
        Me.pnlOnButtonTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlOnButtonTransaction.Location = New System.Drawing.Point(1, 289)
        Me.pnlOnButtonTransaction.Name = "pnlOnButtonTransaction"
        Me.pnlOnButtonTransaction.Size = New System.Drawing.Size(12, 62)
        Me.pnlOnButtonTransaction.TabIndex = 4
        '
        'pnlOnButtonHome
        '
        Me.pnlOnButtonHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.pnlOnButtonHome.Location = New System.Drawing.Point(1, 221)
        Me.pnlOnButtonHome.Name = "pnlOnButtonHome"
        Me.pnlOnButtonHome.Size = New System.Drawing.Size(12, 62)
        Me.pnlOnButtonHome.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnAbout.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_about_48
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(12, 669)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(238, 62)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "   About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'pnltopleftside
        '
        Me.pnltopleftside.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.pnltopleftside.Controls.Add(Me.Label1)
        Me.pnltopleftside.Controls.Add(Me.PictureBox2)
        Me.pnltopleftside.Controls.Add(Me.PictureBox1)
        Me.pnltopleftside.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltopleftside.Location = New System.Drawing.Point(0, 0)
        Me.pnltopleftside.Name = "pnltopleftside"
        Me.pnltopleftside.Size = New System.Drawing.Size(256, 215)
        Me.pnltopleftside.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Financial System"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_online_money_transfer_64
        Me.PictureBox2.Location = New System.Drawing.Point(69, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_exchange_64
        Me.PictureBox1.Location = New System.Drawing.Point(4, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnReport.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_combo_charts_48
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(12, 357)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(238, 62)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "      Reports"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnTransaction.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_ledger_48
        Me.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaction.Location = New System.Drawing.Point(13, 289)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(238, 62)
        Me.btnTransaction.TabIndex = 1
        Me.btnTransaction.Text = "              Transactions"
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnHome.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_hddome_48
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(13, 221)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(238, 62)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "  Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlheader.Controls.Add(Me.btnRestoreDown)
        Me.pnlheader.Controls.Add(Me.lbldate)
        Me.pnlheader.Controls.Add(Me.btnExit)
        Me.pnlheader.Controls.Add(Me.btnMin)
        Me.pnlheader.Controls.Add(Me.btnMax)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(256, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(1145, 39)
        Me.pnlheader.TabIndex = 2
        '
        'btnRestoreDown
        '
        Me.btnRestoreDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestoreDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestoreDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestoreDown.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_restore_down_32
        Me.btnRestoreDown.Location = New System.Drawing.Point(1069, 0)
        Me.btnRestoreDown.Name = "btnRestoreDown"
        Me.btnRestoreDown.Size = New System.Drawing.Size(37, 36)
        Me.btnRestoreDown.TabIndex = 2
        Me.btnRestoreDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRestoreDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRestoreDown.UseVisualStyleBackColor = True
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(3, 6)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(363, 29)
        Me.lbldate.TabIndex = 1
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_mudltiply_48
        Me.btnExit.Location = New System.Drawing.Point(1107, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(37, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Image = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_subtract_32
        Me.btnMin.Location = New System.Drawing.Point(1031, 1)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(37, 36)
        Me.btnMin.TabIndex = 1
        Me.btnMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackgroundImage = Global.Financial_System_Software__CCORD_.My.Resources.Resources.icons8_maximize_button_32
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Location = New System.Drawing.Point(1069, 1)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(37, 36)
        Me.btnMax.TabIndex = 2
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'pnlCenter
        '
        Me.pnlCenter.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCenter.Location = New System.Drawing.Point(256, 39)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(1145, 764)
        Me.pnlCenter.TabIndex = 3
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlheader
        Me.BunifuDragControl1.Vertical = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1401, 803)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlheader)
        Me.Controls.Add(Me.pnlleftside)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financial System (CCORD)"
        Me.pnlleftside.ResumeLayout(False)
        Me.pnlSubMenuReport.ResumeLayout(False)
        Me.pnltopleftside.ResumeLayout(False)
        Me.pnltopleftside.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlleftside As System.Windows.Forms.Panel
    Friend WithEvents pnlyearly As System.Windows.Forms.Panel
    Friend WithEvents btnyearly As System.Windows.Forms.Button
    Friend WithEvents pnlmonthly As System.Windows.Forms.Panel
    Friend WithEvents btnMonthly As System.Windows.Forms.Button
    Friend WithEvents pnldaily As System.Windows.Forms.Panel
    Friend WithEvents btndaily As System.Windows.Forms.Button
    Friend WithEvents pnlOnButtonAbout As System.Windows.Forms.Panel
    Friend WithEvents pnlOnButtonReport As System.Windows.Forms.Panel
    Friend WithEvents pnlOnButtonTransaction As System.Windows.Forms.Panel
    Friend WithEvents pnlOnButtonHome As System.Windows.Forms.Panel
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents pnltopleftside As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents btnMax As System.Windows.Forms.Button
    Friend WithEvents pnlCenter As System.Windows.Forms.Panel
    Friend WithEvents pnlSubMenuReport As System.Windows.Forms.Panel
    Friend WithEvents btnRestoreDown As System.Windows.Forms.Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
