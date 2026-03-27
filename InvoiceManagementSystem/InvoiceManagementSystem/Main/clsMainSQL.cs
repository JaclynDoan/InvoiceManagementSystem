using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Main
{
    public class clsMainSQL
    {
        // Methods only for SQL statements, just return the strings, no code executed
        // will be executed in clsMainLogic
        // comment how windows are going to interface
        // if item window is closed, main checks if items where updated, if so, main will refresh item combo box and any displayed item names
        // main window checks to see if an incoice was actually selected then load that invoice into main window

        public string UpdateInvoice(string totalCost, string invoiceNum)
        {
            return "UPDATE Invoices SET TotalCost = " + totalCost + " WHERE InvoiceNum = " + invoiceNum;
        }
        public string InsertLineItems(string invoiceNum, string lineItemNum, string itemCode)
        {
            return "INSERT INTO LineItems (InvoiceMun, LineItemNum, ItemCode) VALUES (" + invoiceNum + ", " + lineItemNum + ", " + itemCode + ")";
        }
        public string InsertInvoices(string invoiceDate, string totalCost)
        {
            return "INSERT INTO Invoices (InvoiceDate, TotalCost) VALUES (" + invoiceDate + ", " + totalCost + ")";
        }
        public string SelectInvoice(string invoiceNum)
        {
            return "SELECT InvoiceNum, InvoiceDate, TotalCost FROM Invoices WHERE InvoiceNum = " + invoiceNum;
        }
        public string SelectAllItemDesc()
        {
            return "SELECT ItemCode, ItemDesc, Cost FROM ItemDesc";
        }
        public string SelectLinItemsItemDesc(string invoiceNum)
        {
            return "SELECT LineItems.ItemCode, ItemDesc.ItemDesc, ItemDesc.Cost FROM LineItems, ItemDesc WHERE LineItems.ItemCode = ItemDesc.ItemCode AND LineItems.InvoiceNum = " + invoiceNum;
        }
        public string DeleteLineItems(string invoiceNum)
        {
            return "DELETE FROM LineItems WHERE InvoiceNum = " + invoiceNum;
        }
    }
}
