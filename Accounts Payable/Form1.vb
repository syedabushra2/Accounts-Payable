'Program:Accounts Payable
'Author:Aysha
'Written:10/28/25

Public Class Form1
    'Define arrays for holding data
    Dim InvNum(100) As Integer
    Dim InvDate(100) As Date
    Dim SuppName(100) As String
    Dim SuppState(100) As String
    Dim InvAmt(100) As Single
    Dim InvStatus(100) As Boolean 'True:Paid,False:Unpaid
    Dim PaidDate(100) As Date
    Dim PayMethod(100) As Char 'C:Check,T:Bank Transfer

    'Declear (and define) a States Array to hold USA sate code
    Dim States() As String = {"AK", "AL", "AR", "AS", "AZ", "CA", "CO", "CT", "DC", "DE",
 "FL", "GA", "GU", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI",
 "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR",
 "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VI", "VT", "WA", "WI", "WV", "WY"}


    'Define count variable for arrays
    Dim InvCount As Integer = 0 'Increment by 1 when new item is placed in arrays

    'User-defined functions
    Private Function FindInvoice(NumKey As Integer) As Boolean
        'Uses Linear Search Method
        'Returns True if the invoice number NumKey is found
        'Returns False otherwise
        Dim Found As Boolean = False
        For idx As Integer = 0 To InvCount - 1
            If InvNum(idx) = NumKey Then
                Found = True
            End If

        Next
        Return Found
    End Function
    Private Function FindInvoiceloc(NumKey As Integer) As Integer
        'Uses Linear Search method
        'Returns INDEX of invoice# in array if Numkey is found
        ' Returns -1 otherwise
        Dim Position As Integer = -1
        For idx As Integer = 0 To InvCount - 1
            If InvNum(idx) = NumKey Then
                Position = idx
            End If
        Next
        Return Position
    End Function

    'User-defined procedures
    Private Sub ShowArrayOnListview()
        'Populate the listview with the array contents
        'For display purposes only
        lvwArraysDisplay.Items.Clear() 'Wipe listview before display
        For idx As Integer = 0 To InvCount - 1
            Dim row = lvwArraysDisplay.Items.Add(InvNum(idx))
            row.SubItems.Add(InvDate(idx))
            row.SubItems.Add(SuppName(idx))
            row.SubItems.Add(SuppState(idx))
            row.SubItems.Add(InvAmt(idx))
            row.SubItems.Add(InvStatus(idx))
            row.SubItems.Add(PaidDate(idx))
            row.SubItems.Add(PayMethod(idx))
        Next
    End Sub
    Private Sub SaveDataInArrays2File()
        'Save data across all arrays to data file
        'with data for each invoice as a row in the data file

        '1. Open File to Write
        Dim outfile As IO.StreamWriter
        outfile = IO.File.CreateText("invoices.txt")

        '2. Write Data in Arrays to File
        For idx As Integer = 0 To InvCount - 1
            outfile.WriteLine(InvNum(idx) & ControlChars.Tab &
            InvDate(idx) & ControlChars.Tab &
                 SuppName(idx) & ControlChars.Tab &
                 SuppState(idx) & ControlChars.Tab &
               InvAmt(idx) & ControlChars.Tab &
          InvStatus(idx) & ControlChars.Tab &
           PaidDate(idx) & ControlChars.Tab &
            PayMethod(idx))
        Next
        '3. Close File
        outfile.Close()

    End Sub
    Private Sub ReadDataFromFileIntoArrays()
        ' Read dataIfrom file one row at a time
        'Split the line into data items and populate the arrays
        'Count the number of rows read as InvCount
        '0. Preparation
        Dim idx As Integer = 0

        '1. Open File
        Dim infile As IO.StreamReader
        infile = IO.File.OpenText("invoices.txt")

        '2. Read Data from File (and process)
        'Repeat process until there is no more rows to read
        Do Until infile.Peek = -1

            'Read next row of data as record
            Dim record = infile.ReadLine()

            'Split record into separate data fields using Tab as delimite
            'Parse converts string data type into required data type
            Dim fields = record.Split(ControlChars.Tab)

            'Place split data field values into arrays
            InvNum(idx) = (fields(0))
            InvDate(idx) = Date.Parse(fields(1))
            SuppName(idx) = fields(2)
            SuppState(idx) = fields(3)
            InvAmt(idx) = Single.Parse(fields(4))
            InvStatus(idx) = Boolean.Parse(fields(5))
            PaidDate(idx) = Date.Parse(fields(6))
            PayMethod(idx) = Char.Parse(fields(7))
            'Ready for next row
            idx += 1

        Loop
        '3. Close File
        infile.Close()

        '4. Finish
        InvCount = idx
        Call ShowArrayOnListview()

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load data in file into arrays
        Call ReadDataFromFileIntoArrays()

        'Populate the combobox with USA codes
        For sidx As Integer = 0 To States.Length - 1
            cboSuppState.Items.Add(States(sidx))

        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Gather invoice data from input boxes
        Dim NewInvNum As Integer = Val(txtInvNumA.Text)
        Dim NewInvDate As Date = FormatDateTime(dtpInvDate.Value, DateFormat.ShortDate)

        Dim NewSuppName As String = txtSuppName.Text
        Dim NewSuppState As String = cboSuppState.Text
        Dim NewInvAmount As Single = Val(txtInvAmount.Text)

        'Add new invoice to arrays
        'Allow new invoice into arrays if it is not found
        '1. Validate input data
        If NewInvNum > 0 And NewSuppName <> String.Empty And
            NewSuppState <> String.Empty And NewInvAmount > 0 Then
            '2. Check if invoice is duplicate
            If FindInvoice(NewInvNum) = True Then
                'Duplicate entry: Do not add invoice
                MessageBox.Show("Duplicate invoice!")
            Else
                'Unique entry: Add new invoice
                InvNum(InvCount) = NewInvNum
                InvDate(InvCount) = NewInvDate
                SuppName(InvCount) = NewSuppName
                SuppState(InvCount) = NewSuppState
                InvAmt(InvCount) = NewInvAmount
                InvStatus(InvCount) = False 'Unpaid at this time

                InvCount += 1
                'Display arrays on listview
                Call ShowArrayOnListview()
            End If

        Else
            MessageBox.Show("Missing input!")

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Gather invoice data from input boxes
        Dim UpdInvNum As Integer = Val(txtInvNumU.Text)
        Dim UpdPaidDate As Date = FormatDateTime(dtpPaidDate.Value, DateFormat.ShortDate)
        Dim UpdPayMethod As String = cboPayMethod.Text
        'Update payment details for existing invoice
        'Allow update only if the invoice is found in the array
        '1. Validate input data
        If UpdInvNum > 0 And UpdPayMethod <> String.Empty Then
            '2. Check if invoice is already available in array
            Dim pos As Integer = FindInvoiceLoc(UpdInvNum)
            If pos > -1 Then

                'invoice found!

                '3. Update the invoice details

                PaidDate(pos) = UpdPaidDate

                PayMethod(pos) = UpdPayMethod

                InvStatus(pos) = True 'ínvoice now paid
                'Display arrays on listview
                Call ShowArrayOnListview()
            End If

        Else

            'invoice not found!

            MessageBox.Show("Missing Input")
        End If



    End Sub

    Private Sub btnReportUnpaid_Click(sender As Object, e As EventArgs) Handles btnReportUnpaid.Click
        'Report all unpaid invoices
        'Uses linear search to identify invoices with Status = False
        'Multiple results possible - results shown in listview
        '1. Clear listview for new results

        lvwReport.Items.Clear()
        '2. Linear search
        For idx As Integer = 0 To InvCount - 1

            '2A. Check if invoice status is false

            If InvStatus(idx) = False Then

                'invoice is unpaid

                Dim row = lvwReport.Items.Add(InvNum(idx))
                row.SubItems.Add(SuppName(idx))
                row.SubItems.Add(SuppState(idx))
                row.SubItems.Add(InvAmt(idx))
            Else
                MessageBox.Show("All paid!")
            End If
        Next

    End Sub

    Private Sub cboRptPay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRptPay.SelectedIndexChanged
        'Report Invoices based on Payment Method
        'Uses Linear Search to find Invoices in PayNethod array with method = selected method
        'Multiple invoices may be found - Results displayed in ListView
        lvwReport.Items.Clear() 'Clear ListView before displaying report
        'Invoice Found with selected Payment Method - Display in ListView
        For idx As Integer = 0 To InvCount - 1
            If PayMethod(idx) = cboRptPay.Text Then

                Dim row = lvwReport.Items.Add(InvNum(idx))
                row.SubItems.Add(InvDate(idx))
                row.SubItems.Add(SuppName(idx))
                row.SubItems.Add(SuppState(idx))
                row.SubItems.Add(InvAmt(idx))
                row.SubItems.Add(InvStatus(idx))
            End If
        Next


    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call SaveDataInArrays2File()

    End Sub

    Private Sub btnSumAll_Click(sender As Object, e As EventArgs) Handles btnSumAll.Click
        'Compute the sum of invoice amount for all invoices
        Dim Total As Single = 0
        For idx As Integer = 0 To InvCount - 1
            Total += InvAmt(idx)
        Next
        txtSumAll.Text = Total

    End Sub

    Private Sub btnSumPayMethod_Click(sender As Object, e As EventArgs) Handles btnSumPayMethod.Click
        'Compute the sum of invoice amount for all invoices
        'by payment method
        'Two totals will be computed, one for Card, one for Transfer
        Dim TotalC As Single = 0
        Dim TotalT As Single = 0
        For idx As Integer = 0 To InvCount - 1
            Select Case PayMethod(idx)
                Case "C"
                    TotalC += InvAmt(idx)
                Case "T"
                    TotalT += InvAmt(idx)
            End Select
        Next
        txtSumCard.Text = TotalC
        txtSumTransfer.Text = TotalT

    End Sub

    Private Sub btnSumMonths_Click(sender As Object, e As EventArgs) Handles btnSumMonths.Click
        'Compute the sum of invoice amount for all invoices
        'by month of invoice date
        'Month number used as index into MonthTotal array to
        'add invoice amounts

        'Initialize
        lvwStats.Items.Clear()

        Dim MonthTotal() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        ' Compute
        For idx As Integer = 0 To InvCount - 1
            'Extract month number from invoice date
            Dim midx As Integer = Month(InvDate(idx))
            'Use month number as index in MonthTotal array to add
            MonthTotal(midx - 1) += InvAmt(idx)
        Next
        ' Display
        For m As Integer = 0 To 11
            Dim row As ListViewItem = lvwStats.Items.Add(m + 1)
            row.SubItems.Add(MonthTotal(m))
        Next
    End Sub

    Private Sub btnSumStates_Click(sender As Object, e As EventArgs) Handles btnSumStates.Click
        'Compute the sum of invoice amount across all invoices
        'by state code of supplier
        'Index of state code on the States array used as
        'index into StateTotal array
        'Initialize
        lvwStats.Items.Clear()
        Dim StateTotal(States.Length) As Single
        For s As Integer = 0 To States.Length - 1
            StateTotal(s) = 0
        Next
        Dim sidx As Integer = -1 'assume state code does not match

        'Compute
        For idx As Integer = 0 To InvCount - 1
            'Lookup index of state code on States array
            For s As Integer = 0 To States.Length - 1
                If SuppState(idx) = States(s) Then
                    sidx = s
                End If

            Next
            'Use index of state code as index into StateTotal array
            StateTotal(sidx) += InvAmt(idx)

        Next
        'Display
        For s As Integer = 0 To States.Length - 1
            Dim row As ListViewItem = lvwStats.Items.Add(States(s))
            row.SubItems.Add(StateTotal(s))
        Next
    End Sub

End Class
