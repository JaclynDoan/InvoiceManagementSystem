namespace InvoiceManagementSystem.Search
{
    public class clsSearchLogic
    {
        // When the user clicks Select, the selected InvoiceID will be stored
        // in this public property. The Main Window will read this value
        // after the Search Window closes.
        public string SelectedInvoiceID { get; set; }

        private clsSearchSQL _sql = new clsSearchSQL();

        public void LoadFilters()
        {
            // Prototype only:
            // This method will call SQL methods to load invoice numbers,
            // dates, and total costs into the combo boxes.
        }

        public void LoadInvoices()
        {
            // Prototype only:
            // This method will call SelectAllInvoices() in clsSearchSQL
            // and bind the results to the DataGrid.
        }
    }
}
