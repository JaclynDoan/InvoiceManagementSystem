using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Main
{
    public class clsMainLogic
    {
        private clsMainSQL main_sql = new clsMainSQL();

        public void UpInvoice(string totalCost, string invoiceNum)
        {
            // Prototype only:
            // This method will call UpdateInvoice in clsMainSQL and execute the SQL through clsDataAccess.
            main_sql.UpdateInvoice(totalCost, invoiceNum);
        }
        public void AddLine(string invoiceNum, string lineItemNum, string itemCode)
        {
            // Prototype only:
            // This method will call InsertLineItems in clsMainSQL and execute the SQL through clsDataAccess.
            main_sql.InsertLineItems(invoiceNum, lineItemNum, itemCode);
        }
        public void AddInvoice(string invoiceDate, string totalCost)
        {
            // Prototype only:
            // This method will call InsertInvoices in clsMainSQL and execute the SQL through clsDataAccess.
            main_sql.InsertInvoices(invoiceDate, totalCost);
        }
        public void GetInvoice(string invoiceNum)
        {
            // Prototype only:
            // This method will call SelectInvoice in clsMainSQL and execute the SQL through clsDataAccess.
            main_sql.SelectInvoice(invoiceNum);
        }
        public void GetAllItemDesc()
        {
            // Prototype only:
            // This method will call SelectAllItemDesc in clsMainSQL and execute the SQL through clsDataAccess.
            main_sql.SelectAllItemDesc();
        }
        public void GetLineItemsItemDesc(string invoiceNum)
        {
            // Prototype only:
            // This method will call SelectLinItemsItemDesc in clsMainSQL and execute the SQL through clsDataAccess.
            main_sql.SelectLinItemsItemDesc(invoiceNum);
        }
        public void RemoveLineItems(string invoiceNum)
        {
            // Prototype only:
            // This method will call DeleteLineItems in clsMainSQL and execute the SQL through clsDataAccess.
            main_sql.DeleteLineItems(invoiceNum);
        }
        
    }
}
