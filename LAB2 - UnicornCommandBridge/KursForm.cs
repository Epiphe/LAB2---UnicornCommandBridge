using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{
    public partial class KursForm : Form
    {
        public KursForm()
        {
            InitializeComponent();

            comboBoxAnsvLarare.DataSource = Form1.teachers;
            comboBoxValjLarare.DataSource = Form1.teachers;
            comboBoxValjStudent.DataSource = Form1.students;

            /*
            foreach (Teacher teach in Form1.teachers)
            {
                comboBoxAnsvLarare.Items.Add(teach.användarId + ", " + teach.namn);
            }

            foreach (Teacher teach in Form1.teachers)
            {
                comboBoxValjLarare.Items.Add(teach.användarId + ", " + teach.namn);
            }

            foreach (Student stud in Form1.students)
            {
                comboBoxValjStudent.Items.Add(stud.användarId + ", " + stud.namn);
            }

            /*foreach (Uppgift teach in Form1.uppgifter)
            {
                comboBoxAnsvLarare.Items.Add(teach.användarId + ", " + teach.namn);
            }*/
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Stänger detta fönster. 
            this.Close();
        }

        private void btnLaggTillKurs_Click(object sender, EventArgs e)
        {
            //Spara kurs knapp.

            var t = (Teacher)comboBoxAnsvLarare.SelectedItem;

            string kursId = kursID.Text;
            string kursNamn = KursNamn.Text;
            
            Teacher AnsvLarare = t;
            List<Teacher> larare = new List<Teacher>();
            List<Student> elever = new List<Student>();
            List<Uppgift> kursUppgifter = new List<Uppgift>();

 
            if (kursID.Equals(""))
            {
                MessageBox.Show("Skriv ett kurs ID");
            }
            else if (kursNamn.Equals(""))
            {
                MessageBox.Show("Skriv ett kurs namn");
            }
            else if (AnsvLarare.Equals(""))
            {
                MessageBox.Show("Välj en ansvarig lärare");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Kurs ID: " + kursId + " Kurs namn: " + kursNamn, "Stämmer detta?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    Close();
                }
                else if (Svar == DialogResult.Yes)
                {

                    foreach (Teacher selecteditem in listBoxLarare.SelectedItems)
                    {
                        larare.Add(selecteditem);
                    }

                    foreach (Student selecteditem in listBoxStudent.SelectedItems)
                    {
                        elever.Add(selecteditem);
                    }

                    Kurs ny = new Kurs (kursId, kursNamn, larare, elever);
                    ny.AnsvLarare = t;

                    Form1.kurser.Add(ny);

                    Close();
                }
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxValjLarare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLaggTillLarare_Click(object sender, EventArgs e)
        {
            //Lägger till den lärare som är vald i komboboxen till listan.
            listBoxLarare.Items.Add(comboBoxValjLarare.SelectedItem);
        }

        private void listBoxLarare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxValjStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLaggTillStudent_Click(object sender, EventArgs e)
        {
            //Lägger till den student som är vald i komboboxen till listan.
            listBoxStudent.Items.Add(comboBoxValjStudent.SelectedItem);
        }

        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kursID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
