# Accounts-Payable
VB.NET accounts payable system using arrays to track invoices, update payment status, and compute invoice statistics by payment method, month, and supplier state.
# Accounts Payable Management System (VB.NET, Arrays)

This project is a VB.NET Windows Forms application that manages a company's accounts payables using arrays. It allows users to add invoices, update payment status, search for unpaid invoices, filter transactions by payment method or date range, and compute summary statistics on invoice amounts.

All invoice data is stored in parallel arrays in memory and can be saved to / loaded from a data file.

---

## Features

### Core Functionality

- **Add new invoices**
  - Capture: Invoice#, InvoiceDate, SupplierName, SupplierState, SupplierAddress (State), InvoiceAmount, InvoiceStatus, PaidDate, and PaymentMethod.
  - Store each field in a corresponding array element (parallel arrays).

- **Update invoice status to "Paid"**
  - Look up an invoice by Invoice#.
  - Change `InvoiceStatus` to `"Paid"`.
  - Record `PaidDate`.
  - Record `PaymentMethod` (e.g., Card or Check).

- **Report all unpaid invoices**
  - List all invoices where `InvoiceStatus <> "Paid"`.
  - Display multiple matching invoices (not yet paid).

- **Report all invoices paid by a given payment method**
  - Filter invoices by `PaymentMethod` (e.g., Card or Check).
  - Display all matching paid invoices.

- **Report all invoices paid between two dates**
  - Accept a start date and an end date.
  - Show all invoices with `PaidDate` within the specified date range.

---

## Data Handling (Arrays + File I/O)

- Uses **parallel arrays** to store invoice data:
  - `InvoiceNumber(i)`
  - `InvoiceDate(i)`
  - `SupplierName(i)`
  - `SupplierState(i)`
  - `InvoiceAmount(i)`
  - `InvoiceStatus(i)`
  - `PaidDate(i)`
  - `PaymentMethod(i)`

- **File save (at closing)**
  - Writes all array data to a text file so that invoices can be persisted between sessions.

- **File load (at opening)**
  - Reads the text file at startup and repopulates the arrays.

---

## Summary Analytics

The extended version of the application includes several summary and aggregation features:

1. **All invoices (overall)**
   - Compute the **sum**, **average**, **maximum**, and **minimum** of invoice amounts for all invoices.

2. **Invoices paid by Card**
   - Compute the **sum**, **average**, **maximum**, and **minimum** of invoice amounts for all invoices where `PaymentMethod = "Card"`.

3. **Sum of invoice amount by payment method**
   - Group invoice amounts by `PaymentMethod` (e.g., Card vs. Check).
   - Compute the total invoice amount for each payment method.

4. **Sum of invoice amount by month of invoice date**
   - Use the month of `InvoiceDate` to group invoices (e.g., January, February, etc.).
   - Compute the total invoice amount for each month.

5. **Sum of invoice amount by supplier state**
   - Group invoices by `SupplierState`.
   - Compute total invoice amount for each state.

All analytics are implemented using **loop structures** over the arrays.

---

## Technologies Used

- **Language:** VB.NET  
- **Framework:** Windows Forms  
- **Data Structures:** Parallel arrays for invoice fields  
- **File I/O:** Reading and writing text files for persistence  
- **IDE:** Visual Studio

---

## How to Run

1. Clone or download this repository.
2. Open the `.sln` file in **Visual Studio**.
3. Build the solution.
4. Run the Windows Forms application.
5. Use the form to:
   - Add invoices
   - Mark invoices as paid
   - Run reports and summary calculations
