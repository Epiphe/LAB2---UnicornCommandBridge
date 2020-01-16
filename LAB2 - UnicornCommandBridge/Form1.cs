using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{

    public partial class Form1 : Form
    {


        public static List<Student> students = new List<Student>();
        Student Anders = new Student("S100", "Anders");
        Student Borje = new Student("S101", "Börje");
        Student Uffe = new Student("S102", "Uffe");
        Student Koffe = new Student("S103", "Koffe");
        Student Fredrik = new Student("S104", "Fredrik");
        Student Johanes = new Student("S105", "Johanes");



        public static List<Teacher> teachers = new List<Teacher>();
        Teacher Roger = new Teacher("T100", "Roger");
        Teacher Lisa = new Teacher("T101", "Lisa");
        Teacher Erik = new Teacher("T102", "Erik");
        Teacher Pelle = new Teacher("T103", "Pelle");
        Teacher Johan = new Teacher("T104", "Johan");
        Teacher Magnus = new Teacher("T105", "Magnus");
        Teacher Moa = new Teacher("T106", "Moa");
        Teacher Lena = new Teacher("T107", "Lena");


        public static List<Kurs> kurser = new List<Kurs>();
        Kurs Sys = new Kurs("SysAd", "System administation", teachers, students);
        Kurs Web = new Kurs("WebDes", "WebbDesign", teachers, students);
        

        public static List<Uppgift> uppgifter = new List<Uppgift>();
        Uppgift Html = new Uppgift("U100", "HTML - Lab1","Lång uppgiftsbeskrivning om HTML - Lab1 med sammor av text", "WebDes");
        Uppgift Vatten = new Uppgift("U101","Vattenfallsmetoden Lab1", "Lång uppgiftsbeskrivning om uppgiften med vattenvallsmetoden Lab1", "SysAd");

        public Form1()
        {
            InitializeComponent();
            
            students.Add(Anders);
            students.Add(Borje);
            teachers.Add(Roger);
            teachers.Add(Lisa);
            Sys.AnsvLarare = Roger;
            Web.AnsvLarare = Lisa;
            kurser.Add(Sys);
            kurser.Add(Web);
            uppgifter.Add(Html);
            uppgifter.Add(Vatten);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
