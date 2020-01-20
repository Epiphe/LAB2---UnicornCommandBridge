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


        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Stänger detta fönster. 
            this.Close();
        }

        private void btnLaggTillKurs_Click(object sender, EventArgs e)
        {
            //Spara kurs knapp.



            string kursId = kursID.Text;
            string kursNamn = KursNamn.Text;

            Teacher ansvLarare = (Teacher) comboBoxAnsvLarare.SelectedItem;

            List<Teacher> larare = new List<Teacher>();
            List<Student> elever = new List<Student>();
            List<Uppgift> kursUppgifter = new List<Uppgift>();


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
            else if (ansvLarare == null)
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

                    for (int i = 0; i < listBoxLarare.Items.Count; i++)
                    {
                        Teacher T = (Teacher)listBoxLarare.Items[i];
                        larare.Add(T);
                    }

                    for (int i = 0; i < listBoxStudent.Items.Count; i++)
                    {
                        Student S = (Student)listBoxStudent.Items[i];
                        elever.Add(S);
                    }


                    Kurs ny = new Kurs ();
                    ny.kursID = kursId;
                    ny.kursNamn = kursNamn;
                    ny.AnsvLarare = ansvLarare;
                    ny.larare = larare;
                    ny.elever = elever;
                    ny.kursUppgifter = kursUppgifter;
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
