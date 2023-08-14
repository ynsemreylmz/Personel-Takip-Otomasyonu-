using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
	public class ExcelExport
	{
		public static void ExportExcel(DataGridView grid,string name="Excel Sayfası")
		{
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
			Microsoft.Office.Interop.Excel._Workbook workBook = app.Workbooks.Add(Type.Missing);
			Microsoft.Office.Interop.Excel._Worksheet workSheet = null;
			app.Visible = true;
			workSheet = workBook.Sheets["sayfa1"];
			workSheet = workBook.ActiveSheet;
			workSheet.Name = name;

			for(int i = 1; i < grid.Columns.Count+1; i++)
			{
				workSheet.Cells[1, i] = grid.Columns[i-1].HeaderText;
			}

			for(int i = 0;i < grid.Rows.Count - 1; i++)
			{
				for(int j=0;j < grid.Columns.Count;j++)
				{

					workSheet.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
				}
				
			}
		}
	}
}
