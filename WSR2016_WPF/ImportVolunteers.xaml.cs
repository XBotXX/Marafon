using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace WSR2016_WPF
{
    /// <summary>
    /// Логика взаимодействия для ImportVolunteers.xaml
    /// </summary>
    public partial class ImportVolunteers : System.Windows.Window
    {
        public ImportVolunteers()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            VolunteerManagement volunteerManagement = new VolunteerManagement();
            volunteerManagement.Show();
            this.Close();
        }

        private void ExitOnMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void LoadBnt_Click(object sender, RoutedEventArgs e)
        {
            //WriteData();
            OpenFile();
        }

        public void OpenFile()
        {
            Excel excel = new Excel(PathTxt.Text.Trim('"'), 1);

            excel.ReadCell(1, 0);
            excel.Close();

        }

        public void WriteData()
        {
            Excel excel = new Excel(@"C:\Users\User\Desktop\Value2.xlsx", 1);

            //excel.WriteToCell(0, 0, "Test2");
            excel.Save();
            excel.SaveAs(@"C:\Users\User\Desktop\Value3.xlsx");
            excel.Close();
        }
    }

    class Excel
    {
        Entities context = new Entities();
        string path = "";
        _Application exel = new _Excel.Application();

        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = exel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public void ReadCell(int i, int j)
        {
            i++;
            j++;
            while(ws.Cells[i, j].Value2 != null)
            {
                context.Volunteer.Add(new Volunteer { 
                    FirstName = ws.Cells[i, j].Value2, 
                    LastName = ws.Cells[i, j + 1].Value2, 
                    CountryCode = ws.Cells[i, j + 2].Value2, 
                    Gender = ws.Cells[i, j + 3].Value2
                });
                i++;
                //j++;
            }
            context.SaveChanges();
        }

        public void WriteToCell(int i, int j, List<RunnerControl> list)
        {
            DateTime date = DateTime.Now;
            i++;
            j++;
            foreach (var s in list)
            {
                ws.Cells[i, j].Value2 = s.Name;
                ws.Cells[i, j + 1].Value2 = s.Surname;
                ws.Cells[i, j + 2].Value2 = s.Email;
                ws.Cells[i, j + 3].Value2 = s.GenderCSV;
                ws.Cells[i, j + 4].Value2 = s.CountryCSV;
                ws.Cells[i, j + 5].Value2 = s.DateOfBith;
                ws.Cells[i, j + 6].Value2 = date.AddYears(-s.DateOfBith.Year).Year;
                ws.Cells[i, j + 7].Value2 = s.Status;
                ws.Cells[i, j + 8].Value2 = s.NuborCSV;
                ws.Cells[i, j + 9].Value2 = s.EventTypeMar;
                i++;
            }
        }

        public void Save()
        {
            wb.Save();
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void Close()
        {
            wb.Close();
        }
    }
}
