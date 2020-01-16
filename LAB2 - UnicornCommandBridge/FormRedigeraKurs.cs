using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2___UnicornCommandBridge
{
    public partial class FormRedigeraKurs : Form
    {
        public FormRedigeraKurs()
        {
            InitializeComponent();
            
            comboBoxKurser.DataSource = Form1.kurser;
            /*foreach (Kurs K in Form1.kurser)
            {
                comboBoxValjKurs.Items.Add(K.kursID);
            }
            */
            /*
            foreach (Uppgift upp in Form1.uppgifter)
            {
                comboBoxVisaUppgifterIKursen.Items.Add(upp.uppgiftsID + ", " + upp.uppgiftsNamn);
            }

            foreach (Kurs K in Form1.kurser)
            {
                comboBoxKurser.Items.Add(K.kursID);
            }
            foreach (Student stud in Form1.students)
            {
                comboBoxVisaStudenterIKursen.Items.Add(stud.användarId+", "+stud.namn);
            }
            foreach (Teacher teach in Form1.teachers)
            {
                comboBoxVisaLarareIKursen.Items.Add(teach.användarId + ", " + teach.namn);
            }
            */

        }

        private void comboBoxVisaKurser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dropdown för att visa tillgängliga kurser.



        }

        private void txtBoxVisaKursID(object sender, EventArgs e)
        {
            //Fält som visar valt kursID.
        }

        private void txtBoxAndraKursNamn(object sender, EventArgs e)
        {
            //Fält för att ändra kursnamn.
        }

        private void txtBoxAndraAnsvarigLarare(object sender, EventArgs e)
        {
            //Fält för att ändra ansvarig lärare.
        }

        private void btnAndraKursEllerAnsvarigLarare_Click(object sender, EventArgs e)
        {
            //Knapp för att spara ändrat kursnamn eller ansvarig lärare.
        }

        private void txtBoxLaggTillOvrigaLarare_andraKurs(object sender, EventArgs e)
        {
            //Fält för att lägga till lärare till kursen. 
        }

        private void txtBoxLaggTillStudenter_AndraKurs(object sender, EventArgs e)
        {
            //Fält för att lägga till Student till kursen. 
        }

        private void txtBoxLaggTillUppgift_AndraKurs(object sender, EventArgs e)
        {
            //Fält för att lägga till Uppgift till kursen. 
        }

        private void btnSparaLaggaTillAndraKurs_Click(object sender, EventArgs e)
        {
            //Knapp för att spara ny lärare/Student/Uppgift.
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tillbakaknapp
            this.Close();
        }

        private void comboBoxVisaLarareIKursen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visar vilken lärare som ska tas bort från kursen. 
            
        }

        private void comboBoxVisaStudenterIKursen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visar vilken student som ska tas bort från kursen. 
        }

        private void comboBoxVisaUppgifterIKursen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Visar vilken uppgift som ska tas bort från kursen. 
        }

        private void btnRaderaValdData_Click(object sender, EventArgs e)
        {
            //Knapp som raderar den valda datan.
        }

        private void LaddaKurs_Click(object sender, EventArgs e)
        {
            //Knapp som laddar in en kurs
            /*
            foreach (Kurs k in Form1.kurser)
            {
                //Om uppgiftsID är samma som står i boxen så läggs uppgifterna från det objektet in i boxarna. 
                if (k.kursID == comboBoxKurser.SelectedItem.ToString().Substring(0, 4))
                {
                    comboBoxVisaLarareIKursen.Text = k.larare;
                    comboBoxVisaStudenterIKursen.Text = k.elever;
                    comboBoxVisaUppgifterIKursen.Text = k.kursUppgifter;
                }
            }

            */


            comboBoxAnsvLarare.Items.Clear();
            comboBoxVisaLarareIKursen.Items.Clear();
            comboBoxVisaStudenterIKursen.Items.Clear();
            comboBoxVisaUppgifterIKursen.Items.Clear();
           

            

            
            if (comboBoxKurser.SelectedItem == null)
            {
                return;
            }
            else
            {
                Kurs k = (Kurs)comboBoxKurser.SelectedItem;

                comboBoxVisaLarareIKursen.DataSource = k.larare;
                comboBoxVisaStudenterIKursen.DataSource = k.elever;
                comboBoxVisaUppgifterIKursen.DataSource = k.kursUppgifter;
                comboBoxLaggTillLarare.DataSource = Form1.teachers;
                comboBoxLaggTillStud.DataSource = Form1.students;
                comboBoxLaggTillUppgift.DataSource = Form1.uppgifter;

            }


            foreach (Teacher teach in Form1.teachers)
            {
                comboBoxAnsvLarare.Items.Add(teach.användarId + ", " + teach.namn);
            }


            /*foreach (Teacher teach in comboBoxKurser.SelectedItem.kursTeachers)
            {
                if ()
                {
                    comboBoxVisaLarareIKursen.Items.Add(upp.uppgiftsID + ", " + upp.uppgiftsNamn);
                }
            }*/

        }
    }
}
