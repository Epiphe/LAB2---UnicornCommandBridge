using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //List<Student> students = new List<Student>();
            //Student A = new Student("S100", "Anders");
            //Student B = new Student("S101", "Börje");
            //students.Add(A);
            //students.Add(B);

            List<Teacher> teachers = new List<Teacher>();
            Teacher TA = new Teacher("T100", "Lisa");
            Teacher TB = new Teacher("T101","Hasse");
            teachers.Add(TA);
            teachers.Add(TB);



        }

       
    }
}
