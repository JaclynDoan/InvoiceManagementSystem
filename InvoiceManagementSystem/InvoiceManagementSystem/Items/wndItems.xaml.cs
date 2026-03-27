using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InvoiceManagementSystem.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        /// <summary>
        /// This variable will be set to true if any item is added, updated, or deleted.
        /// The Main Window will check this variable after the Items Window closes.
        /// If true, the Main Window will refresh its item combo box and any displayed item names.
        /// </summary>
        public bool bItemsUpdated = false;

        public wndItems()
        {
            InitializeComponent();

            // Prototype only:
            // When the window loads, business logic will be called to retrieve all items
            // from the database and bind them to the DataGrid.
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Prototype only:
            // Logic class will validate the description and cost entered by the user.
            // If valid, logic class will call clsItemsSQL to get the INSERT statement
            // and clsDataAccess will execute it.
            // After a successful add, bItemsUpdated will be set to true
            // so the Main Window knows it must refresh its item combo box.
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Prototype only:
            // Logic class will update only the description and cost.
            // The item code will not be changed because it is the primary key.
            // After update succeeds, bItemsUpdated will be set to true.
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Prototype only:
            // Before deleting an item, logic class will check whether the item
            // exists on any invoices.
            // If it does, the item will not be deleted and the user will be shown
            // which invoices currently use that item.
            // If the delete succeeds, bItemsUpdated will be set to true.
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
