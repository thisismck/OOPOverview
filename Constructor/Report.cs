using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Report
    {
        public string ExcelFilePath { get; set; }

        public Report(string excelFilePath)
        {
            if(string.IsNullOrEmpty(excelFilePath))
            {
                throw new ArgumentNullException("Excel file path cannot be null or empty.");
            }
            else if (!excelFilePath.EndsWith(".xlsx"))
            {
                throw new ArgumentException("Excel file path must end with .xlsx.");
            }
            else if (!File.Exists(excelFilePath))
            {
                throw new FileNotFoundException("Excel file not found.");
            }
            ExcelFilePath = excelFilePath;
        }
    }
}
