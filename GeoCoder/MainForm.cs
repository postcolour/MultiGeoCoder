using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace MultiGeoCoder
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Main procedure
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procedure to insert adresses from clipboard to datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.Shift && e.KeyCode == Keys.Insert) | (e.Control && e.KeyCode == Keys.V))
            {
                // Do Paste void
                Paste();
            }
            // Delete row on press "Delete" button
            if(e.KeyCode == Keys.Delete)
            {
                // Do delete void
                Delete();
            }
        }

        /// Paste routine
        private void Paste()
        {
            char[] rowSpl = { '\r', '\n' };
            char[] colSpl = { '\t' };

            IDataObject data_clipboard = Clipboard.GetDataObject();
            string string_clipboard = (string)data_clipboard.GetData(DataFormats.Text);

            // Split into lines
            string[] rows_clipboard = string_clipboard.Split(rowSpl, StringSplitOptions.RemoveEmptyEntries);

            // Index of current cell in the adresses datagrid
            int r = dataGrid.SelectedCells[0].RowIndex;

            if(dataGrid.Rows.Count - r < rows_clipboard.Length)
            {
                dataGrid.Rows.Add(r + rows_clipboard.Length - dataGrid.Rows.Count);
            }
            for(int iRow = 0; iRow < rows_clipboard.Length; iRow++)
            {
                string values_rows = rows_clipboard[iRow].Split(colSpl).GetValue(0).ToString();
                dataGrid.Rows[r + iRow].Cells[0].Value = values_rows;
            }
        }

        /// Delete routine
        private void Delete()
        {
            if(dataGrid.Rows.Count > 1)
            {
                if(dataGrid.CurrentRow.IsNewRow == true)
                {
                    // do nothing
                }
                else
                {
                    foreach(DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        dataGrid.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        /// <summary>
        /// Main form load procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // set name form with program version
            this.Text = "MultiGeoCoder - " + Application.ProductVersion.ToString();

            string[] sPos = { "pos", "Latitude and Longitude Coordinates" };
            string[] sAddressLine = { "AddressLine", ">Free format address representation. An address can have more than one line. The order of the AddressLine elements must be preserved." };
            string[] sCountryName = { "CountryName", "Specification of the name of a country" };
            string[] sPostalCodeNumber = { "PostalCodeNumber", "Specification of a postcode. The postcode is formatted according to country-specific rules. Example: SW3 0A8-1A, 600074, 2067" };
            string[] sAdministrativeAreaName = { "AdministrativeAreaName", "Name of the administrative area. eg. MI in USA, NSW in Australia" };
            string[] sSubAdministrativeAreaName = { "SubAdministrativeAreaName", "Specification of a sub-administrative area. An example of a sub-administrative areas is a county. " +
                                                    "There are two places where the name of an administrative area can be specified and in this case, one becomes sub-administrative area" };
            string[] sDependentLocalityName = { "DependentLocalityName", "Dependent localities are Districts within cities/towns, locality divisions, postal divisions of cities, " +
                                                "suburbs, etc. DependentLocality is a recursive element, but no nesting deeper than two exists (Locality-DependentLocality-DependentLocality)"};
            string[] sLocalityName = { "LocalityName", "Locality is one level lower than adminisstrative area. Eg.: cities, reservations and any other built-up areas." };
            string[] sThoroughfareName = { "ThoroughfareName", "Specification of the name of a Thoroughfare (also dependant street name): street name, canal name, etc" };
            string[] sThoroughfareNumber = { "ThoroughfareNumber", "Eg.: 23 Archer street or 25/15 Zero Avenue, etc" };
            string[] sThoroughfareNumberPrefix = { "ThoroughfareNumberPrefix", "Prefix before the number. A in A12 Archer Street" };
            string[] sThoroughfareNumberSuffix = { "ThoroughfareNumberSuffix", "Suffix after the number. A in 12A Archer Street" };
            string[] sPremiseNumber = { "PremiseNumber", "Specification of a single premise, for example a house or a building. The premise as a whole" +
                                        " has a unique premise (house) number or a premise name.  There could be more than one premise in a street referenced" +
                                        " in an address. For example a building address near a major shopping centre or raiwlay station" };

            string[] sAddressMembers = { sPos[0], sAddressLine[0], sCountryName[0], sPostalCodeNumber[0], sAdministrativeAreaName[0], sSubAdministrativeAreaName[0], sDependentLocalityName[0],
                                         sLocalityName[0], sThoroughfareName[0], sThoroughfareNumber[0], sThoroughfareNumberPrefix[0], sThoroughfareNumberSuffix[0], sPremiseNumber[0] };
            string[] sAddressMembersHint = { sPos[1], sAddressLine[1], sCountryName[1], sPostalCodeNumber[1], sAdministrativeAreaName[1], sSubAdministrativeAreaName[1], sDependentLocalityName[1],
                                         sLocalityName[1], sThoroughfareName[1], sThoroughfareNumber[1], sThoroughfareNumberPrefix[0], sThoroughfareNumberSuffix[0], sPremiseNumber[1] };
            // add all address members in datagrid
            for(int i = 0; i < sAddressMembers.Length; i++)
            {
                AddressMembersDataGridView.Rows.Add();
                AddressMembersDataGridView.Rows[i].Cells[1].Value = sAddressMembers[i];
                AddressMembersDataGridView.Rows[i].Cells[1].ToolTipText = sAddressMembersHint[i];
            }
            // checkbox default values and hints
            foreach(DataGridViewRow row in AddressMembersDataGridView.Rows)
            {
                row.Cells[AddressMemberCheck.Name].Value = true;
                row.Cells[AddressMemberCheck.Name].ToolTipText = "Add field in results";
            }
            EnableRunTxtBox();
        }

        /// <summary>
        /// Exit button procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Occurs when the "Run" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunButton_Click(object sender, EventArgs e)
        {
            // Set the maximum value of ProgressBar
            WorkProgressBar.Maximum = dataGrid.Rows.Count;
            // Disable all controls on form
            enableControls(this.Controls, false);
            // Run new thread
            backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Enable or Disable all controls
        /// </summary>
        /// <param name="Controls"></param>
        private void enableControls(Control.ControlCollection Controls, Boolean b)
        {
            foreach(Control c in Controls)
            {
                c.Enabled = b;
                if(c is MenuStrip)
                {
                    foreach(ToolStripMenuItem item in ((MenuStrip)c).Items)
                    {
                        foreach(ToolStripItem e in item.DropDownItems)
                            e.Enabled = b;
                        item.Enabled = b;
                    }
                }
                if(c.HasChildren)
                {
                    enableControls(c.Controls, b);
                }
            }
        }

        /// <summary>
        /// Occurs when the "..." button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Excel Workbook 97-2003 Files | *.xls|Excel Workbook Files | *.xlsx";
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Occurs when button OK is clicked in the "save as..." dialog window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveAsTextBox.ReadOnly = false;
            if(saveFileDialog.FilterIndex == 1)
            {
                if(saveFileDialog.FileName.EndsWith(".xls"))
                {
                    SaveAsTextBox.Text = saveFileDialog.FileName.ToString();
                }
                else
                {
                    SaveAsTextBox.Text = saveFileDialog.FileName.ToString() + ".xls";
                }
            }
            else
            {
                if(saveFileDialog.FileName.EndsWith(".xlsx"))
                {
                    SaveAsTextBox.Text = saveFileDialog.FileName.ToString();
                }
                else
                {
                    SaveAsTextBox.Text = saveFileDialog.FileName.ToString() + ".xlsx";
                }
            }
            SaveAsTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Occurs when button "?" is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Occurs when BackgroundWorker is running 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string sAddress;
            ExcelApp excelApp = new ExcelApp();

            try
            {
                // Use for each xml node in WebRequest
                int i = 0;
                // Check the checkbox in the AddressMemeberCheck column
                foreach(DataGridViewRow addrRow in AddressMembersDataGridView.Rows)
                {
                    // If checked, insert that into head cell of column in the excel worksheet
                    if(Convert.ToBoolean(addrRow.Cells[AddressMemberCheck.Name].Value) == true)
                    {
                        excelApp._workSheet.Cells[1, i + 1] = addrRow.Cells[AddressMember.Name].Value.ToString();
                        i++;
                    }
                }
                string[] sAddressMember = new string[i];
                int d = 0;
                foreach(DataGridViewRow addrRow in AddressMembersDataGridView.Rows)
                {
                    if(Convert.ToBoolean(addrRow.Cells[AddressMemberCheck.Name].Value) == true)
                    {
                        sAddressMember[d] = addrRow.Cells[AddressMember.Name].Value.ToString();
                        d++;
                    }
                }
                // Need for add rows number in the excel workbook and percentage of ReportProgress bar
                int a = 1;
                // Big itteration
                foreach(DataGridViewRow row in dataGrid.Rows)
                {
                    if(row.Cells[AddressName.Name].Value != null)
                    {
                        sAddress = row.Cells[AddressName.Name].Value.ToString();
                        URLRequest req = new URLRequest();
                        req.WebRequestGet(ref sAddress);
                        XDocument xmlAddr = XDocument.Parse(sAddress);

                        // Itteration on each element of address members collection
                        int b = xmlAddr.Descendants().Count();
                        int c = 0;
                        string[] sElement = new string[b];
                        string[] sElementValue = new string[b];
                        foreach(XElement element in xmlAddr.Descendants())
                        {
                            sElement[c] = element.Name.LocalName.ToString();
                            if(element.HasElements)
                            {
                                sElementValue[c] = string.Empty;
                            }
                            else
                            {
                                sElementValue[c] = element.Value.ToString();
                            }
                            c++;
                        }
                        // Write all adresses elements into excel workbook
                        for(int g = 0; g < i; g++)
                        {
                            for(int f = 0; f < b; f++)
                            {
                                if(sAddressMember[g] == sElement[f])
                                {
                                    excelApp._workSheet.Cells[a + 1, g + 1] = sElementValue[f];
                                }
                            }
                        }
                        backgroundWorker.ReportProgress(a);
                        a++;
                    }
                    else
                    {
                        backgroundWorker.ReportProgress(a);
                        a++;
                    }
                }
                // Save file in the selected format.
                if(saveFileDialog.FilterIndex == 2)
                {
                    excelApp._workBook.SaveAs(SaveAsTextBox.Text, Excel.XlFileFormat.xlOpenXMLWorkbook);
                }
                else
                {
                    excelApp._workBook.SaveAs(SaveAsTextBox.Text, Excel.XlFileFormat.xlExcel8);
                }  
                excelApp._workBook.Close();
                excelApp._excelApp.Quit();
                excelApp._excelApp = null;
                excelApp._workBook = null;
                excelApp._workBook = null;
                MessageBox.Show("File saved!");
            }
            catch(Exception ex)
            {
                // Show user error information
                excelApp._workBook.Close();
                excelApp._excelApp.Quit();
                excelApp._excelApp = null;
                excelApp._workBook = null;
                excelApp._workBook = null;
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Occurs when BackgroundWorker change progress 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            WorkProgressBar.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Occurs when BackgroundWorker complete own process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Enable all controls on form
            enableControls(this.Controls, true);
        }

        /// <summary>
        /// Occurs when the SaveAsTextBox.TextChanged property value changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableRunTxtBox();
        }

        /// <summary>
        /// Procedure to enable or deseable Run button
        /// </summary>
        void EnableRunTxtBox()
        {
            if(SaveAsTextBox.Text == "")
            {
                RunButton.Enabled = false;
            }
            else
            {
                RunButton.Enabled = true;
            }
        }

        /// <summary>
        /// Copy selected cells into clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }


        /// <summary>
        /// Copy selected cells into clipboard and clear all of them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyToClipboard();

            // Clear selected cells
            foreach(DataGridViewCell cell in dataGrid.SelectedCells)
                cell.Value = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do Paste void
            Paste();
        }

        /// <summary>
        /// Delete all selected rows in datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Do Delete void
            Delete();
        }

        /// <summary>
        /// Occurs when right mouse button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right & dataGrid.SelectedCells.Count > 0)
            {
                // Show context menu
                DataGridContextMenu.Show(dataGrid, e.Location);
            }
        }

        /// Copy to clipboard procedure
        private void CopyToClipboard()
        {
            // Copy to clipboard
            DataObject dataObj = dataGrid.GetClipboardContent();
            if(dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }
    }
}

