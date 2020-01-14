using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{

    public partial class Form1 : Form
    {


        public static List<Student> students = new List<Student>();
        Student A = new Student("S100", "Anders");
        Student B = new Student("S101", "Börje");


        public static List<Teacher> teachers = new List<Teacher>();
        Teacher C = new Teacher("T100", "Roger");
        Teacher D = new Teacher("T101", "Lisa");

        public static List<Kurs> kurser = new List<Kurs>();
        Kurs E = new Kurs("SysAd", "System administation", "Lisa");
        Kurs F = new Kurs("WebDes", "WebbDesign", "Roger");

        public Form1()
        {
            InitializeComponent();
            students.Add(A);
            students.Add(B);
            teachers.Add(C);
            teachers.Add(D);
            kurser.Add(E);
            kurser.Add(F);
        }

        private void btnSkapaStudent_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan mata in en ny student.
            Form2_Create skapaStudentLarare = new Form2_Create();
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaLarare_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan mata in en ny stedent.  
            Form2_Create skapaStudentLarare = new Form2_Create();
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaKurs_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan lägga in en ny kurs.
            KursForm laggTillKurs = new KursForm();
            laggTillKurs.ShowDialog();
        }

        private void btnSkapaUppgift_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan skapa en uppgift. 
            FormUppgift laggTillUppgift = new FormUppgift();
            laggTillUppgift.ShowDialog();
        }

        private void btnRedigeraStudent_Click(object sender, EventArgs e)
        {
            //Knappen öppnar menyn för att redigera lärare och studenter. 
            FormRedStudentLarare redStudentEllerLarare = new FormRedStudentLarare();
            redStudentEllerLarare.ShowDialog();
        }

        private void btnRedigeraLarare_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraKurs_Click(object sender, EventArgs e)
        {
            //Knappen öppnar menyn för att redigera en kurs. 
            FormRedigeraKurs redigeraKurs = new FormRedigeraKurs();
            redigeraKurs.ShowDialog();
        }

        private void btnRedigeraUppgift_Click(object sender, EventArgs e)
        {
            FormRedigeraUppgift redigeraUppgift = new FormRedigeraUppgift();
            redigeraUppgift.ShowDialog();
        }

        private void btnSattaBetyg_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan sätta betyg på en uppgift. 
            FormSattaBetyg sattaBetyg = new FormSattaBetyg();
            sattaBetyg.ShowDialog();
        }

        private void btnRedigeraBetyg_Click(object sender, EventArgs e)
        {
            //Knapp för att komma till redigera betyg formuläret.
            FormRedigeraBetyg redigeraBetyg = new FormRedigeraBetyg();
            redigeraBetyg.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Easter egg.
            MessageBox.Show("Unicorns unite!");
        }
    }
}
