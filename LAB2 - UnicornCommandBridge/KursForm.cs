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

            kursID.MaxLength = 6;

            //comboBoxAnsvLarare.DataSource = Form1.teachers;

            //var valjlarare = new List<Teacher>();
            //Form1.teachers.CopyTo(valjlarare);

            //comboBoxValjLarare.DataSource = valjlarare;
            //comboBoxValjStudent.DataSource = Form1.students;


            foreach (Teacher teach in Form1.teachers)
            {
                comboBoxAnsvLarare.Items.Add(teach);
            }

            foreach (Teacher teach in Form1.teachers)
            {
                comboBoxValjLarare.Items.Add(teach);
            }

            foreach (Student stud in Form1.students)
            {
                comboBoxValjStudent.Items.Add(stud);
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

            string AnsvLarare = comboBoxAnsvLarare.SelectedItem.ToString();

            string kursId = kursID.Text;
            string kursNamn = KursNamn.Text;

            List<string> larare = new List<string>();
            List<string> elever = new List<string>();
            List<string> kursUppgifter = new List<string>();

 
            if (kursID.Equals(""))
            {
                MessageBox.Show("Skriv ett kurs ID");
            }
            else if (kursId.Length < 6)
            {
                MessageBox.Show("Kurs ID måste vara 6 tecken");
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
                        larare.Add(selecteditem.ToString());
                    }

                    foreach (Student selecteditem in listBoxStudent.SelectedItems)
                    {
                        elever.Add(selecteditem.ToString());
                    }

                    Kurs ny = new Kurs (kursId, kursNamn, AnsvLarare, larare, elever);


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
