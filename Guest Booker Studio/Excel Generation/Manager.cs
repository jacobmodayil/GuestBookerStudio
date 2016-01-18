using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;
namespace ExcelGeneration
{
    public class Manager
    {
        Excel.Application exxapp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet; 
        public void ExportToExcel(object[,] data)
        {
            const int left = 1;
            const int top = 1;
            int height = data.GetLength(0);
            int width = data.GetLength(1);
            int bottom = top + height-1;
            int right = left + width-1;
            object misValue = System.Reflection.Missing.Value;
            exxapp = new Excel.Application();
            xlWorkBook = exxapp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets.get_Item(1);
            xlWorkSheet.Name = "CustomerDetails";
            exxapp.ScreenUpdating = false;
            if (height == 0 || width == 0)
                return;
            var rg = xlWorkSheet.Range[xlWorkSheet.Cells[top, left], xlWorkSheet.Cells[bottom, right]];
            rg.Value = data;
            // Set borders
            for (int i = 1; i <= 4; i++)
                rg.Borders[i].LineStyle = 1;
            // Set auto columns width
            rg.EntireColumn.AutoFit();
            // Set header view
            var rgHeader = xlWorkSheet.Range[xlWorkSheet.Cells[top, left], xlWorkSheet.Cells[top, right]];
            rgHeader.Font.Bold = true;
            rgHeader.Interior.Color = 189 * (int)Math.Pow(16, 4) + 129 * (int)Math.Pow(16, 2) + 78; // #4E81BD
            //const int left1 = 1;
            //const int top1 = 1;
            //int height1 = data1.GetLength(0);
            //int width1 = data1.GetLength(1);
            //int bottom1 = top1 + height1 - 1;
            //int right1 = left1 + width1 - 1;

            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets.get_Item(2);
            //xlWorkSheet.Name = "References";
            //exxapp.ScreenUpdating = false;
            //if (height1 == 0 || width1 == 0)
            //    return;
            //var rg1 = xlWorkSheet.Range[xlWorkSheet.Cells[top1, left1], xlWorkSheet.Cells[bottom1, right1]];
            //rg1.Value = data1;
            //// Set borders
            //for (int i = 1; i <= 4; i++)
            //    rg1.Borders[i].LineStyle = 1;

            //// Set auto columns width
            //rg1.EntireColumn.AutoFit();

            //// Set header view
            //var rgHeader1 = xlWorkSheet.Range[xlWorkSheet.Cells[top1, left1], xlWorkSheet.Cells[top1, right1]];
            //rgHeader1.Font.Bold = true;
            //rgHeader1.Interior.Color = 189 * (int)Math.Pow(16, 4) + 129 * (int)Math.Pow(16, 2) + 78; // #4E81BD

            // Show excel app
            exxapp.ScreenUpdating = true;
            exxapp.Visible = true;

            Marshal.ReleaseComObject(rg);
            Marshal.ReleaseComObject(rgHeader);
            //Marshal.ReleaseComObject(rg1);
            //Marshal.ReleaseComObject(rgHeader1);
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(exxapp);

            rg = null;
            rgHeader = null;
            //rg1 = null;
            //rgHeader1 = null;
            xlWorkSheet = null;
            xlWorkBook = null;
            exxapp = null;
            GC.Collect();
        }
    }
}
