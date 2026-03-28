namespace InvoiceManagementSystem.Search
{
    public class clsSearchSQL
    {
        // SQL ONLY — NO BUSINESS LOGIC

        public string SelectAllInvoices()
        {
            return "SELECT InvoiceNum, InvoiceDate, TotalCost FROM Invoices";
        }

        public string SelectInvoicesByNumber(string num)
        {
            return $"SELECT * FROM Invoices WHERE InvoiceNum = {num}";
        }

        public string SelectInvoiceDates()
        {
            return "SELECT DISTINCT InvoiceDate FROM Invoices ORDER BY InvoiceDate";
        }

        public string SelectInvoiceTotals()
        {
            return "SELECT DISTINCT TotalCost FROM Invoices ORDER BY TotalCost";
        }
    }
}
