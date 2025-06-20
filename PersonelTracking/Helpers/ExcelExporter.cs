using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;
using System.Windows.Forms;

public static class ExcelExporter
{
    // Exports a DataGridView to an Excel file using ClosedXML
    public static void ExportDataGridView(DataGridView dgv, string sheetName, string fileName)
    {
        // Show a message if there's no data to export
        if (dgv.Rows.Count == 0)
        {
            MessageBox.Show("No data to export.");
            return;
        }

        // Create a new Excel workbook
        using (var wb = new XLWorkbook())
        {
            // Add a worksheet with the specified name
            var ws = wb.Worksheets.Add(sheetName);

            // Write column headers to the first row
            int colIndex = 1;
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                if (dgv.Columns[j].Visible) // Skip hidden columns
                {
                    ws.Cell(1, colIndex).Value = dgv.Columns[j].HeaderText;
                    colIndex++;
                }
            }

            // Write data rows starting from row 2
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                colIndex = 1; // Reset column index for each row
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Columns[j].Visible)
                    {
                        // Write the cell value (convert null to empty string safely)
                        ws.Cell(i + 2, colIndex).Value = dgv.Rows[i].Cells[j].Value?.ToString();
                        colIndex++;
                    }
                }
            }

            // Prompt the user to choose save location with a file dialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook|*.xlsx"; // File type filter
            sfd.FileName = $"{fileName}.xlsx";     // Default file name
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Save the Excel file to selected location
                wb.SaveAs(sfd.FileName);

                // Notify user of successful export
                MessageBox.Show("Export completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
