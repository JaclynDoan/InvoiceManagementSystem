using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Items
{
    /// <summary>
    /// Contains SQL statements for the Items window.
    /// </summary>
    internal class clsItemsSQL
    {
        /// <summary>
        /// Gets all items for display in the Items window.
        /// </summary>
        public string SelectAllItems()
        {
            return "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc ORDER BY ItemCode";
        }

        /// <summary>
        /// Inserts a new item into the def table.
        /// </summary>
        public string InsertItem(string sDescription, string sCost)
        {
            return $"INSERT INTO ItemDesc (ItemDesc, Cost) VALUES ('{sDescription}', {sCost})";
        }

        /// <summary>
        /// Updates the description and cost for an existing item.
        /// </summary>
        public string UpdateItem(string sItemCode, string sDescription, string sCost)
        {
            return $"UPDATE ItemDesc SET ItemDesc = '{sDescription}', Cost = {sCost} WHERE ItemCode = {sItemCode}";
        }

        /// <summary>
        /// Deletes an item from the def table.
        /// </summary>
        public string DeleteItem(string sItemCode)
        {
            return $"DELETE FROM ItemDesc WHERE ItemCode = {sItemCode}";
        }

        /// <summary>
        /// Checks whether an item is used on any invoices.
        /// </summary>
        public string SelectInvoicesUsingItem(string sItemCode)
        {
            return $"SELECT DISTINCT InvoiceNum FROM LineItems WHERE ItemCode = {sItemCode}";
        }
    }
}
