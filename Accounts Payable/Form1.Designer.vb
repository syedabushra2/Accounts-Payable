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
        Me.tabActions = New System.Windows.Forms.TabControl()
        Me.tpgAdd = New System.Windows.Forms.TabPage()
        Me.txtInvAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSuppState = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuppName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpInvDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInvNumA = New System.Windows.Forms.TextBox()
        Me.tpgUpdate = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboPayMethod = New System.Windows.Forms.ComboBox()
        Me.dtpPaidDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvNumU = New System.Windows.Forms.TextBox()
        Me.tpgReport = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboRptPay = New System.Windows.Forms.ComboBox()
        Me.btnReportUnpaid = New System.Windows.Forms.Button()
        Me.tpgStats = New System.Windows.Forms.TabPage()
        Me.btnSumMonths = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSumPayMethod = New System.Windows.Forms.Button()
        Me.txtSumTransfer = New System.Windows.Forms.TextBox()
        Me.txtSumCard = New System.Windows.Forms.TextBox()
        Me.txtSumAll = New System.Windows.Forms.TextBox()
        Me.btnSumAll = New System.Windows.Forms.Button()
        Me.lvwArraysDisplay = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colunmHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvwReport = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lvwStats = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSumStates = New System.Windows.Forms.Button()
        Me.tabActions.SuspendLayout()
        Me.tpgAdd.SuspendLayout()
        Me.tpgUpdate.SuspendLayout()
        Me.tpgReport.SuspendLayout()
        Me.tpgStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabActions
        '
        Me.tabActions.Controls.Add(Me.tpgAdd)
        Me.tabActions.Controls.Add(Me.tpgUpdate)
        Me.tabActions.Controls.Add(Me.tpgReport)
        Me.tabActions.Controls.Add(Me.tpgStats)
        Me.tabActions.Location = New System.Drawing.Point(34, 80)
        Me.tabActions.Name = "tabActions"
        Me.tabActions.SelectedIndex = 0
        Me.tabActions.Size = New System.Drawing.Size(486, 688)
        Me.tabActions.TabIndex = 0
        '
        'tpgAdd
        '
        Me.tpgAdd.Controls.Add(Me.txtInvAmount)
        Me.tpgAdd.Controls.Add(Me.Label6)
        Me.tpgAdd.Controls.Add(Me.Label5)
        Me.tpgAdd.Controls.Add(Me.cboSuppState)
        Me.tpgAdd.Controls.Add(Me.Label4)
        Me.tpgAdd.Controls.Add(Me.txtSuppName)
        Me.tpgAdd.Controls.Add(Me.Label3)
        Me.tpgAdd.Controls.Add(Me.dtpInvDate)
        Me.tpgAdd.Controls.Add(Me.btnAdd)
        Me.tpgAdd.Controls.Add(Me.Label1)
        Me.tpgAdd.Controls.Add(Me.txtInvNumA)
        Me.tpgAdd.Location = New System.Drawing.Point(8, 39)
        Me.tpgAdd.Name = "tpgAdd"
        Me.tpgAdd.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgAdd.Size = New System.Drawing.Size(470, 641)
        Me.tpgAdd.TabIndex = 0
        Me.tpgAdd.Text = "Add Invoice"
        Me.tpgAdd.UseVisualStyleBackColor = True
        '
        'txtInvAmount
        '
        Me.txtInvAmount.Location = New System.Drawing.Point(21, 401)
        Me.txtInvAmount.Name = "txtInvAmount"
        Me.txtInvAmount.Size = New System.Drawing.Size(157, 31)
        Me.txtInvAmount.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Supplier State"
        '
        'cboSuppState
        '
        Me.cboSuppState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSuppState.FormattingEnabled = True
        Me.cboSuppState.Location = New System.Drawing.Point(12, 318)
        Me.cboSuppState.Name = "cboSuppState"
        Me.cboSuppState.Size = New System.Drawing.Size(187, 33)
        Me.cboSuppState.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Supplier Name"
        '
        'txtSuppName
        '
        Me.txtSuppName.Location = New System.Drawing.Point(6, 239)
        Me.txtSuppName.Name = "txtSuppName"
        Me.txtSuppName.Size = New System.Drawing.Size(210, 31)
        Me.txtSuppName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Invoice Date"
        '
        'dtpInvDate
        '
        Me.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvDate.Location = New System.Drawing.Point(3, 148)
        Me.dtpInvDate.Name = "dtpInvDate"
        Me.dtpInvDate.Size = New System.Drawing.Size(203, 31)
        Me.dtpInvDate.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(21, 558)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(126, 53)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Invoice#"
        '
        'txtInvNumA
        '
        Me.txtInvNumA.Location = New System.Drawing.Point(12, 53)
        Me.txtInvNumA.Name = "txtInvNumA"
        Me.txtInvNumA.Size = New System.Drawing.Size(163, 31)
        Me.txtInvNumA.TabIndex = 0
        '
        'tpgUpdate
        '
        Me.tpgUpdate.Controls.Add(Me.Label9)
        Me.tpgUpdate.Controls.Add(Me.Label8)
        Me.tpgUpdate.Controls.Add(Me.Label7)
        Me.tpgUpdate.Controls.Add(Me.btnUpdate)
        Me.tpgUpdate.Controls.Add(Me.cboPayMethod)
        Me.tpgUpdate.Controls.Add(Me.dtpPaidDate)
        Me.tpgUpdate.Controls.Add(Me.txtInvNumU)
        Me.tpgUpdate.Location = New System.Drawing.Point(8, 39)
        Me.tpgUpdate.Name = "tpgUpdate"
        Me.tpgUpdate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgUpdate.Size = New System.Drawing.Size(470, 641)
        Me.tpgUpdate.TabIndex = 1
        Me.tpgUpdate.Text = "Update Invoice"
        Me.tpgUpdate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Pay Method"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Paid Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Invoice#"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(66, 528)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(155, 51)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboPayMethod
        '
        Me.cboPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayMethod.FormattingEnabled = True
        Me.cboPayMethod.Items.AddRange(New Object() {"C", "T"})
        Me.cboPayMethod.Location = New System.Drawing.Point(78, 312)
        Me.cboPayMethod.Name = "cboPayMethod"
        Me.cboPayMethod.Size = New System.Drawing.Size(121, 33)
        Me.cboPayMethod.TabIndex = 2
        '
        'dtpPaidDate
        '
        Me.dtpPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaidDate.Location = New System.Drawing.Point(40, 196)
        Me.dtpPaidDate.Name = "dtpPaidDate"
        Me.dtpPaidDate.Size = New System.Drawing.Size(248, 31)
        Me.dtpPaidDate.TabIndex = 1
        '
        'txtInvNumU
        '
        Me.txtInvNumU.Location = New System.Drawing.Point(56, 87)
        Me.txtInvNumU.Name = "txtInvNumU"
        Me.txtInvNumU.Size = New System.Drawing.Size(203, 31)
        Me.txtInvNumU.TabIndex = 0
        '
        'tpgReport
        '
        Me.tpgReport.Controls.Add(Me.Label11)
        Me.tpgReport.Controls.Add(Me.cboRptPay)
        Me.tpgReport.Controls.Add(Me.btnReportUnpaid)
        Me.tpgReport.Location = New System.Drawing.Point(8, 39)
        Me.tpgReport.Name = "tpgReport"
        Me.tpgReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgReport.Size = New System.Drawing.Size(470, 641)
        Me.tpgReport.TabIndex = 2
        Me.tpgReport.Text = "Report"
        Me.tpgReport.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 25)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Report Pay"
        '
        'cboRptPay
        '
        Me.cboRptPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRptPay.FormattingEnabled = True
        Me.cboRptPay.Items.AddRange(New Object() {"C", "T"})
        Me.cboRptPay.Location = New System.Drawing.Point(34, 183)
        Me.cboRptPay.Name = "cboRptPay"
        Me.cboRptPay.Size = New System.Drawing.Size(222, 33)
        Me.cboRptPay.TabIndex = 5
        '
        'btnReportUnpaid
        '
        Me.btnReportUnpaid.Location = New System.Drawing.Point(34, 56)
        Me.btnReportUnpaid.Name = "btnReportUnpaid"
        Me.btnReportUnpaid.Size = New System.Drawing.Size(209, 47)
        Me.btnReportUnpaid.TabIndex = 0
        Me.btnReportUnpaid.Text = "Unpaid Invoices"
        Me.btnReportUnpaid.UseVisualStyleBackColor = True
        '
        'tpgStats
        '
        Me.tpgStats.Controls.Add(Me.btnSumStates)
        Me.tpgStats.Controls.Add(Me.btnSumMonths)
        Me.tpgStats.Controls.Add(Me.Label13)
        Me.tpgStats.Controls.Add(Me.Label12)
        Me.tpgStats.Controls.Add(Me.btnSumPayMethod)
        Me.tpgStats.Controls.Add(Me.txtSumTransfer)
        Me.tpgStats.Controls.Add(Me.txtSumCard)
        Me.tpgStats.Controls.Add(Me.txtSumAll)
        Me.tpgStats.Controls.Add(Me.btnSumAll)
        Me.tpgStats.Location = New System.Drawing.Point(8, 39)
        Me.tpgStats.Name = "tpgStats"
        Me.tpgStats.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgStats.Size = New System.Drawing.Size(470, 641)
        Me.tpgStats.TabIndex = 3
        Me.tpgStats.Text = "Stats"
        Me.tpgStats.UseVisualStyleBackColor = True
        '
        'btnSumMonths
        '
        Me.btnSumMonths.Location = New System.Drawing.Point(83, 318)
        Me.btnSumMonths.Name = "btnSumMonths"
        Me.btnSumMonths.Size = New System.Drawing.Size(134, 71)
        Me.btnSumMonths.TabIndex = 7
        Me.btnSumMonths.Text = "Sum (Months)"
        Me.btnSumMonths.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(303, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 25)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Transfer"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(315, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 25)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Card"
        '
        'btnSumPayMethod
        '
        Me.btnSumPayMethod.Location = New System.Drawing.Point(100, 152)
        Me.btnSumPayMethod.Name = "btnSumPayMethod"
        Me.btnSumPayMethod.Size = New System.Drawing.Size(155, 60)
        Me.btnSumPayMethod.TabIndex = 4
        Me.btnSumPayMethod.Text = "Sum(Pay Method)"
        Me.btnSumPayMethod.UseVisualStyleBackColor = True
        '
        'txtSumTransfer
        '
        Me.txtSumTransfer.Enabled = False
        Me.txtSumTransfer.Location = New System.Drawing.Point(308, 233)
        Me.txtSumTransfer.Name = "txtSumTransfer"
        Me.txtSumTransfer.Size = New System.Drawing.Size(149, 31)
        Me.txtSumTransfer.TabIndex = 3
        '
        'txtSumCard
        '
        Me.txtSumCard.Enabled = False
        Me.txtSumCard.Location = New System.Drawing.Point(308, 152)
        Me.txtSumCard.Name = "txtSumCard"
        Me.txtSumCard.Size = New System.Drawing.Size(156, 31)
        Me.txtSumCard.TabIndex = 2
        '
        'txtSumAll
        '
        Me.txtSumAll.Enabled = False
        Me.txtSumAll.Location = New System.Drawing.Point(197, 41)
        Me.txtSumAll.Name = "txtSumAll"
        Me.txtSumAll.Size = New System.Drawing.Size(156, 31)
        Me.txtSumAll.TabIndex = 1
        '
        'btnSumAll
        '
        Me.btnSumAll.Location = New System.Drawing.Point(29, 31)
        Me.btnSumAll.Name = "btnSumAll"
        Me.btnSumAll.Size = New System.Drawing.Size(143, 51)
        Me.btnSumAll.TabIndex = 0
        Me.btnSumAll.Text = "Sum(All)"
        Me.btnSumAll.UseVisualStyleBackColor = True
        '
        'lvwArraysDisplay
        '
        Me.lvwArraysDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeade, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.colunmHeader7})
        Me.lvwArraysDisplay.HideSelection = False
        Me.lvwArraysDisplay.Location = New System.Drawing.Point(536, 116)
        Me.lvwArraysDisplay.Name = "lvwArraysDisplay"
        Me.lvwArraysDisplay.Size = New System.Drawing.Size(855, 299)
        Me.lvwArraysDisplay.TabIndex = 1
        Me.lvwArraysDisplay.UseCompatibleStateImageBehavior = False
        Me.lvwArraysDisplay.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Invoice#"
        Me.ColumnHeader1.Width = 111
        '
        'ColumnHeade
        '
        Me.ColumnHeade.Text = "Date"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 104
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "State"
        Me.ColumnHeader3.Width = 103
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.Width = 121
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Status"
        Me.ColumnHeader5.Width = 86
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Paid"
        Me.ColumnHeader6.Width = 65
        '
        'colunmHeader7
        '
        Me.colunmHeader7.Text = "Method"
        Me.colunmHeader7.Width = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(355, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contents of Arrays (for display only)"
        '
        'lvwReport
        '
        Me.lvwReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvwReport.HideSelection = False
        Me.lvwReport.Location = New System.Drawing.Point(526, 446)
        Me.lvwReport.Name = "lvwReport"
        Me.lvwReport.Size = New System.Drawing.Size(511, 324)
        Me.lvwReport.TabIndex = 3
        Me.lvwReport.UseCompatibleStateImageBehavior = False
        Me.lvwReport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Invoice#"
        Me.ColumnHeader7.Width = 111
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Date"
        Me.ColumnHeader8.Width = 74
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Name"
        Me.ColumnHeader9.Width = 77
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "State"
        Me.ColumnHeader10.Width = 107
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Amount"
        Me.ColumnHeader11.Width = 131
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(518, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Report Results"
        '
        'lvwStats
        '
        Me.lvwStats.BackColor = System.Drawing.SystemColors.Window
        Me.lvwStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13})
        Me.lvwStats.HideSelection = False
        Me.lvwStats.Location = New System.Drawing.Point(1061, 457)
        Me.lvwStats.Name = "lvwStats"
        Me.lvwStats.Size = New System.Drawing.Size(330, 313)
        Me.lvwStats.TabIndex = 5
        Me.lvwStats.UseCompatibleStateImageBehavior = False
        Me.lvwStats.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Citerion"
        Me.ColumnHeader12.Width = 106
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Total"
        Me.ColumnHeader13.Width = 157
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1071, 429)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 25)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Report Stats"
        '
        'btnSumStates
        '
        Me.btnSumStates.Location = New System.Drawing.Point(68, 462)
        Me.btnSumStates.Name = "btnSumStates"
        Me.btnSumStates.Size = New System.Drawing.Size(157, 73)
        Me.btnSumStates.TabIndex = 8
        Me.btnSumStates.Text = "Sum (States)"
        Me.btnSumStates.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1605, 872)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lvwStats)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lvwReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvwArraysDisplay)
        Me.Controls.Add(Me.tabActions)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Payable"
        Me.tabActions.ResumeLayout(False)
        Me.tpgAdd.ResumeLayout(False)
        Me.tpgAdd.PerformLayout()
        Me.tpgUpdate.ResumeLayout(False)
        Me.tpgUpdate.PerformLayout()
        Me.tpgReport.ResumeLayout(False)
        Me.tpgReport.PerformLayout()
        Me.tpgStats.ResumeLayout(False)
        Me.tpgStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabActions As TabControl
    Friend WithEvents tpgAdd As TabPage
    Friend WithEvents tpgUpdate As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInvNumA As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lvwArraysDisplay As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpInvDate As DateTimePicker
    Friend WithEvents txtInvAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboSuppState As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSuppName As TextBox
    Friend WithEvents ColumnHeade As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents colunmHeader7 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cboPayMethod As ComboBox
    Friend WithEvents dtpPaidDate As DateTimePicker
    Friend WithEvents txtInvNumU As TextBox
    Friend WithEvents tpgReport As TabPage
    Friend WithEvents btnReportUnpaid As Button
    Friend WithEvents lvwReport As ListView
    Friend WithEvents Label10 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents cboRptPay As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tpgStats As TabPage
    Friend WithEvents txtSumAll As TextBox
    Friend WithEvents btnSumAll As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnSumPayMethod As Button
    Friend WithEvents txtSumTransfer As TextBox
    Friend WithEvents txtSumCard As TextBox
    Friend WithEvents btnSumMonths As Button
    Friend WithEvents lvwStats As ListView
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSumStates As Button
End Class
