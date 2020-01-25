using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{

    public partial class Form1 : Form
    {
        internal Datastore Datastore { get; set; }

        //public static List<Student> students = new List<Student>();

        //public static List<Teacher> teachers = new List<Teacher>();

        //public static List<Kurs> kurser = new List<Kurs>();

        //public static List<Uppgift> uppgifter = new List<Uppgift>();


        public Form1(Datastore datastore)
        {
            InitializeComponent();
            Datastore = datastore;

            //// Lägger in studenter i listan
            //students.Add(new Student("S100", "Anders"));
            //students.Add(new Student("S101", "Börje"));
            //students.Add(new Student("S102", "Uffe"));
            //students.Add(new Student("S103", "Koffe"));
            //students.Add(new Student("S104", "Fredrik"));
            //students.Add(new Student("S105", "Johanes"));
            //students.Add(new Student("S106", "Louise"));

            //List<Betyg> sb = new List<Betyg>();

            //foreach (Student stud in students)
            //{
            //    stud.betyg = sb;
            //}

            // Lägger in lärare i listan
            //Teacher Roger = new Teacher("T100", "Roger");
            //teachers.Add(Roger);
            //Teacher Lisa = new Teacher("T101", "Lisa");
            //teachers.Add(Lisa);
            //teachers.Add(new Teacher("T102", "Erik"));
            //teachers.Add(new Teacher("T103", "Pelle"));
            //teachers.Add(new Teacher("T104", "Johan"));
            //teachers.Add(new Teacher("T105", "Magnus"));
            //teachers.Add(new Teacher("T106", "Moa"));
            //teachers.Add(new Teacher("T107", "Lena"));

            // Lägger till Uppgifter i listan
            //List<Betyg> ub = new List<Betyg>();
            //Uppgift Html = new Uppgift("U100", "HTML - Lab1", "Lång uppgiftsbeskrivning om HTML - Lab1 med sammor av text", null, ub);
            //Uppgift vatten = new Uppgift("U101", "Vattenfallsmetoden Lab1", "Lång uppgiftsbeskrivning om uppgiften med vattenvallsmetoden Lab1", null, ub);

            //uppgifter.Add(Html);
            //uppgifter.Add(vatten);


            //List <Teacher> teachA = new List<Teacher>();
            //foreach (Teacher t in teachers)
            //{
            //    teachA.Add(t);
            //}

            //List<Teacher> teachB = new List<Teacher>();
            //foreach (Teacher t in teachers)
            //{
            //    teachB.Add(t);
            //}

            //List<Student> studA = new List<Student>();
            //foreach (Student s in students)
            //{
            //    studA.Add(s);
            //}

            //List<Student> studB = new List<Student>();
            //foreach (Student s in students)
            //{
            //    studB.Add(s);
            //}


            //List<Uppgift> sysupp = new List<Uppgift>();
            //sysupp.Add(vatten);
 

            //// Lägger in kurser i listan
            //Kurs Sys = new Kurs("SysAdm", "System administation", Roger, teachA, studA, sysupp);

            //kurser.Add(Sys);



            //List<Uppgift> webupp = new List<Uppgift>();
            //webupp.Add(Html);

            //Kurs Web = new Kurs("WebDes", "WebbDesign", Lisa, teachB, studB, webupp);

            //kurser.Add(Web);

            /*
            foreach (Student stud in Web.elever)
            {
                stud.kurser.Add(Web);
            }

            foreach (Student stud in Sys.elever)
            {
                stud.kurser.Add(Sys);
            }

            foreach (Teacher teach in Web.larare)
            {
                teach.kurser.Add(Web);
            }
            foreach (Teacher teach in Sys.larare)
            {
                teach.kurser.Add(Sys);
            }
            */
            //Sys.AnsvLarare.UpdateSalary();

            //Html.kurs = Web;
            //vatten.kurs = Sys;
            

        }

        private void btnSkapaStudent_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan mata in en ny student.
            Form2_Create skapaStudentLarare = new Form2_Create(Datastore);
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaLarare_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan mata in en ny stedent.  
            Form2_Create skapaStudentLarare = new Form2_Create(Datastore);
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaKurs_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan lägga in en ny kurs.
            KursForm laggTillKurs = new KursForm(Datastore);
            laggTillKurs.ShowDialog();
        }

        private void btnSkapaUppgift_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan skapa en uppgift. 
            FormUppgift laggTillUppgift = new FormUppgift(Datastore);
            laggTillUppgift.ShowDialog();
        }

        private void btnRedigeraStudent_Click(object sender, EventArgs e)
        {
            //Knappen öppnar menyn för att redigera lärare och studenter. 
            FormRedStudentLarare redStudentEllerLarare = new FormRedStudentLarare(Datastore);
            redStudentEllerLarare.ShowDialog();
        }

        private void btnRedigeraLarare_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraKurs_Click(object sender, EventArgs e)
        {
            //Knappen öppnar menyn för att redigera en kurs. 
            FormRedigeraKurs redigeraKurs = new FormRedigeraKurs(Datastore);
            redigeraKurs.ShowDialog();
        }

        private void btnRedigeraUppgift_Click(object sender, EventArgs e)
        {
            FormRedigeraUppgift redigeraUppgift = new FormRedigeraUppgift(Datastore);
            redigeraUppgift.ShowDialog();
        }

        private void btnSattaBetyg_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan sätta betyg på en uppgift. 
            FormSattaBetyg sattaBetyg = new FormSattaBetyg(Datastore);
            sattaBetyg.ShowDialog();
        }

        private void btnRedigeraBetyg_Click(object sender, EventArgs e)
        {
            //Knapp för att komma till redigera betyg formuläret.
            FormRedigeraBetyg redigeraBetyg = new FormRedigeraBetyg(Datastore);
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
