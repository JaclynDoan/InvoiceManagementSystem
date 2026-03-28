using System.Windows;

namespace InvoiceManagementSystem.Search
{
    public partial class wndSearch : Window
    {
        private clsSearchLogic _logic = new clsSearchLogic();

        public wndSearch()
        {
            InitializeComponent();

            // Prototype only:
            // When the window loads, logic will populate the combo boxes
            // and load all invoices into the DataGrid.
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            // When the user clicks Select, the selected InvoiceID will be stored
            // in clsSearchLogic.SelectedInvoiceID.
            // The Main Window will read this value after this window closes.

            if (dgInvoices.SelectedItem != null)
            {
                dynamic row = dgInvoices.SelectedItem;
                _logic.SelectedInvoiceID = row.InvoiceNum.ToString();
            }

            this.DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // User canceled — no InvoiceID will be returned.
            this.DialogResult = false;
            this.Close();
        }

        // The Main Window will open this Search Window using ShowDialog().
        // After the window closes, Main will check DialogResult and then
        // read _logic.SelectedInvoiceID to know which invoice was chosen.
    }
}
