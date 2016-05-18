using System;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace MultiGeoCoder
{
    /// <summary>
    /// Generate Excel Application with workbook and worksheet
    /// </summary>
    public class ExcelApp
    {
        public Excel.Application _excelApp;
        public Excel.Workbook _workBook;
        public Excel.Worksheet _workSheet;

        public ExcelApp()
        {
            // Initialize Excel Application
            Excel.Application excelApp = new Excel.Application();
            _excelApp = excelApp;

            // Version of installed Excel (not using!)
            string version = _excelApp.Version;
            decimal result;
            if(decimal.TryParse(version, out result))
            {
                decimal dversion = decimal.Parse(version);
            }
            else
            {
                decimal dversion = decimal.Parse(version, CultureInfo.InvariantCulture);
            }
            

            // Make the object invisible.
            excelApp.Visible = false;

            //for overwrite the existing excel (if exist) without asking the user
            excelApp.DisplayAlerts = false;

            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            Excel.Workbook workBook = excelApp.Workbooks.Add();
            _workBook = workBook;

            // Uses a single workSheet.
            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            _workSheet = workSheet;
        }

    }
}
