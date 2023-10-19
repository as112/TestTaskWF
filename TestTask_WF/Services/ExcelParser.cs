using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask_WF.Models;
using Microsoft.Office.Interop.Excel;

namespace TestTask_WF.Services
{
	public class ExcelParser
	{
		public (List<Modes>, List<Steps>) Parse(string filePath)
		{
			
			List<Steps> stepsList = new List<Steps>();
			List<Modes> modesList = new List<Modes>();

			Application excelApp = new Application();
			Workbook workbook = excelApp.Workbooks.Open(filePath);
			Worksheet worksheet = (Worksheet)workbook.Sheets[2];

			int rowCount = worksheet.UsedRange.Rows.Count;

			for (int row = 2; row <= rowCount; row++)
			{
				Steps step = new Steps
				{
					Id = Convert.ToInt32(worksheet.Cells[row, 1].Value),
					ModeId = Convert.ToInt32(worksheet.Cells[row, 2].Value),
					Timer = Convert.ToInt32(worksheet.Cells[row, 3].Value),
					Destination = worksheet.Cells[row, 4].Value,
					Speed = Convert.ToInt32(worksheet.Cells[row, 5].Value),
					Type = worksheet.Cells[row, 6].Value,
					Volume = Convert.ToInt32(worksheet.Cells[row, 7].Value)
				};

				if(step.Id != 0)
				{
					stepsList.Add(step);	
				}
			}

			worksheet = (Worksheet)workbook.Sheets[1];
			rowCount = worksheet.UsedRange.Rows.Count;

			for (int row = 2; row <= rowCount; row++)
			{
				Modes mode = new Modes
				{
					Id = Convert.ToInt32(worksheet.Cells[row, 1].Value),
					Name = worksheet.Cells[row, 2].Value,
					MaxBottleNumber = Convert.ToInt32(worksheet.Cells[row, 3].Value),
					MaxUsedTips = Convert.ToInt32(worksheet.Cells[row, 4].Value)
				};

				if(mode.Id != 0)
				{
					modesList.Add(mode);
				}

			}

			workbook.Close(false);
			excelApp.Quit();

			return (modesList, stepsList);
		}
	}
}
