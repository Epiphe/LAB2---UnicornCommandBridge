using System;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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
