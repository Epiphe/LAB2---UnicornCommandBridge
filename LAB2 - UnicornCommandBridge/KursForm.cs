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
            this.Hide();
        }

        private void btnLaggTillKurs_Click(object sender, EventArgs e)
        {
            //Spara kurs knapp.

            string kursId = kursID.Text;
            string kursNamn = KursNamn.Text;
            string AnsvLarare = comboBoxAnsvLarare.SelectedItem.ToString();
            List<String> larare = new List<String>();

            foreach (object selecteditem in listBoxLarare.SelectedItems)
            {
                larare.Add(selecteditem.ToString());
            }
 




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


                    //Form1.students.Add(new Student(användarId, namn));

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
    }
}
