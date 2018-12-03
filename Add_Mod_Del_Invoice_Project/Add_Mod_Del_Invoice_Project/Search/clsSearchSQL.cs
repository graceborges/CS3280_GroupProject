using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Mod_Del_Invoice_Project.Search
{
    class clsSearchSQL
    {
        //private clsDataAccess db = new clsDataAccess();
       
            

        /// <summary>
        /// Search for the invoice by invoiceID
        /// </summary>
        /// <param name="sInvoiceID"></param>
        /// <returns></returns>
        public string SelectInvoiceByID (string sInvoiceID)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceNum = " + sInvoiceID;

            return sSQL;
        }

        /// <summary>
        /// Search for the invoice by date
        /// </summary>
        /// <param name="sDate"></param>
        /// <returns></returns>
        public string SelectInvoiceByDate (string sDate)
        {
            string sSQL = "SELECT * FROM Invoices WHERE InvoiceDate = " + sDate;

            return sSQL;
        }


        /// <summary>
        /// search for invoice by the equipmentID
        /// </summary>
        /// <param name="sEquipmentID"></param>
        /// <returns></returns>
        public string SelectInvoiceByItem (string sEquipmentID)
        {
            string sSQL = "SELECT * FROM Invoices WHERE EquipmentID = " + sEquipmentID;

            return sSQL; 
        }
    }
}
