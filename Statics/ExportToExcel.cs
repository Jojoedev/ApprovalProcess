using ApprovalProcess.Models;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApprovalProcess.Statics
{
    public static class ExportToExcel
    {
        public static void ToExcel()
        {
            var file = new FileInfo(@"C:\Users\HP\Desktop\Log2\REPORT.xlsx");
            using(ExcelPackage excel = new ExcelPackage(file))
            {
                ExcelWorksheet sheet = excel.Workbook.Worksheets["sheet1"];

                var ConnectString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Database=Requests; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand command = new SqlCommand("select * from dbo.Requests", conn);

                SqlDataAdapter da = new SqlDataAdapter(command);
                
                DataTable dataTable = new DataTable();

                da.Fill(dataTable);

                int count = dataTable.Rows.Count;
                sheet.Cells.LoadFromDataTable(dataTable, true);
                
                string fileName = "NewReport";
                
                fileName +=Guid.NewGuid();
                

                FileInfo excelFile = new FileInfo(@$"C:\Users\HP\Desktop\Log2\{fileName}.xlsx");
                excel.SaveAs(excelFile);

            }

        }

        public static bool OrderStatus(Request request)
        {
            if (request.RequestedDate < DateTime.Today)
            {
                return false;
            }
            return true;
        }
    }
}
