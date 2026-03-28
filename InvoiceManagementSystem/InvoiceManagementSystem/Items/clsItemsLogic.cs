using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Items
{
    /// <summary>
    /// Contains business logic for the Items Window.
    /// </summary>
    public class clsItemsLogic
    {
        private clsItemsSQL _sql = new clsItemsSQL();

        /// <summary>
        /// Will retrieve all items for the DataGrid.
        /// </summary>
        public void GetItems()
        {
            // Prototype only:
            // This method will call SelectAllItems in clsItemsSQL
            // and use clsDataAccess to execute the SQL and return the results.
        }

        /// <summary>
        /// Will validate and add an item.
        /// </summary>
        public void AddItem(string sDescription, string sCost)
        {
            // Prototype only:
            // This method will validate user input, call InsertItem in clsItemsSQL,
            // and execute the SQL through clsDataAccess.
        }

        /// <summary>
        /// Will validate and update an item.
        /// </summary>
        public void UpdateItem(string sItemCode, string sDescription, string sCost)
        {
            // Prototype only:
            // This method will validate input and call UpdateItem in clsItemsSQL.
        }

        /// <summary>
        /// Will determine whether an item can be deleted.
        /// </summary>
        public void DeleteItem(string sItemCode)
        {
            // Prototype only:
            // This method will first check SelectInvoicesUsingItem in clsItemsSQL.
            // If invoices are found, the item will not be deleted.
            // Otherwise, DeleteItem in clsItemsSQL will be executed.
        }
    }
}
