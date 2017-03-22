using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Excel=Microsoft.Office.Interop.Excel;
using System.ComponentModel;

namespace MyTeamApp
{
    class MyExcel
    {
        public static string DB_PATH = @"";
        public static BindingList<Employee> EmpList = new BindingList<Employee>();
        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;
        private static int lastRow=0;
        public static void InitializeExcel()
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explict cast is not required here
            lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }
        public static BindingList<Employee> ReadMyExcel()
        {
            EmpList.Clear();
            for (int index = 2; index <= lastRow; index++)
            {
                System.Array MyValues = (System.Array)MySheet.get_Range("A" + index.ToString(), "D" + index.ToString()).Cells.Value;                
                EmpList.Add(new Employee { 
                                            Name = MyValues.GetValue(1,1).ToString(),
                                            Employee_ID = MyValues.GetValue(1,2).ToString(),
                                            Email_ID = MyValues.GetValue(1,3).ToString(),
                                            Number = MyValues.GetValue(1,4).ToString()
                                        });
            }
            return EmpList;
        }
        public static void WriteToExcel(Employee emp)
        {
            try
            {
                lastRow += 1;
                MySheet.Cells[lastRow, 1] = emp.Name;
                MySheet.Cells[lastRow, 2] = emp.Employee_ID;
                MySheet.Cells[lastRow, 3] = emp.Email_ID;
                MySheet.Cells[lastRow, 4] = emp.Number;
                EmpList.Add(emp);
                MyBook.Save();
            }
            catch (Exception ex)
            { }

        }

        public static List<Employee> FilterEmpList(string searchValue, string searchExpr)
        {
            List<Employee> FilteredList = new List<Employee>();
            switch (searchValue.ToUpper())
            {
                case "NAME":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Name.ToLower().Contains(searchExpr));
                    break;
                case "MOBILE_NO":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Number.ToLower().Contains(searchExpr));
                    break;
                case "EMPLOYEE_ID":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Employee_ID.ToLower().Contains(searchExpr));
                    break;
                case "EMAIL_ID":
                    FilteredList = EmpList.ToList().FindAll(emp => emp.Email_ID.ToLower().Contains(searchExpr));
                    break;
                default:
                    break;
            }
            return FilteredList;
        }
        public static void CloseExcel()
        {
            MyBook.Saved = true;
            MyApp.Quit();

        }
        
    }
    
}
