using EducationCenterDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebniyCenter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            using (var db = new DatabaseContext())
            {
                db.StudentModels.Add(new StudentModel()
                {
                    FIO = "aaabbb",
                    Adress = "jizzax",
                    Phone = "12345",
                    ParentFIO = "ddddd",
                    Remark = "ttttttttt",
                    Status = (StudentStatus)Enum.Parse(typeof(StudentStatus), "Active", true),
                    IsFirstLessonFreeUsed = true
            }) ;
               
                db.SaveChanges();

                foreach (var student in db.StudentModels)
                {
                    Console.WriteLine(student.FIO);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
