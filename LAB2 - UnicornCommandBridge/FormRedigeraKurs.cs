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

            //foreach (Kurs k in Form1.kurser)
            //{
            //    comboBoxKurser.Items.Add(k.ToString());
            //}
            comboBoxKurser.DataSource = Form1.kurser;
            comboBoxLaggTillLarare.DataSource = Form1.teachers;
            comboBoxLaggTillStud.DataSource = Form1.students;


            textBoxKursID.MaxLength = 6;

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

            string ID = textBoxKursID.Text;
            string namn = txtBoxLaggTillKursNamn.Text;
            Teacher teach = null;


                for(int i = 0; i < Form1.kurser.Count; i++)
                {
                    if (Form1.kurser[i].kursID == comboBoxKurser.SelectedItem.ToString().Substring(0, 6))
                    {

                        // Spara ID
                        if (ID.Length == 0)
                        {
                            
                        }
                        else if (ID.Length < 6)
                        {
                            MessageBox.Show("Kurs ID måste vara 6 tecken");
                        }
                        else
                        {
                            Form1.kurser[i].kursID = ID;
                        }

                        // Spara Namn
                        if (namn.Length == 0)
                        {
                            
                        }
                        else
                        {
                            Form1.kurser[i].kursNamn = namn;
                        }

                        teach = (Teacher)comboBoxAnsvLarare.SelectedItem;

                        // Spara larare
                        if (teach == null)
                        {
                            
                        }
                        else
                        {
                            Form1.kurser[i].AnsvLarare = teach;
                        }
                    }
                      
                }
            Close();

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
            

            foreach (Kurs kurs in Form1.kurser)
            {
                if (kurs.kursID == textBoxKursID.Text)
                {

                    for (int i = 0; i < listBoxLaggTillLarare.Items.Count; i++)
                    {
                        Teacher T = (Teacher)listBoxLaggTillLarare.Items[i];
                        kurs.larare.Add(T);
                    }

                    for (int i = 0; i < listBoxLaggTillStud.Items.Count; i++)
                    {
                        Student S = (Student)listBoxLaggTillStud.Items[i];
                        kurs.elever.Add(S);
                    }

                }

            }

            Close();
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

            foreach (Kurs kurs in Form1.kurser)
            {
                if (kurs.kursID == comboBoxKurser.SelectedItem.ToString().Substring(0, 6))
                {
                    if (comboBoxVisaLarareIKursen.SelectedItem == null)
                    {

                    }
                    else
                    {
                        kurs.larare.Remove((Teacher)comboBoxVisaLarareIKursen.SelectedItem);
                    }

                    if (comboBoxVisaStudenterIKursen.SelectedItem == null)
                    {

                    }
                    else
                    {
                        kurs.elever.Remove((Student)comboBoxVisaStudenterIKursen.SelectedItem);
                    }

                    if (comboBoxVisaUppgifterIKursen.SelectedItem == null)
                    {

                    }
                    else
                    {
                        kurs.kursUppgifter.Remove((Uppgift)comboBoxVisaUppgifterIKursen.SelectedItem);
                        foreach (Uppgift upp in Form1.uppgifter)
                        {
                            if (upp.uppgiftsID == comboBoxVisaUppgifterIKursen.SelectedItem.ToString().Substring(0, 4))
                            {
                                upp.kurs = null;
                            }

                        }
                    }
                }
            }
            Close();
        }

        private void LaddaKurs_Click(object sender, EventArgs e)
        {
            comboBoxAnsvLarare.Items.Clear();
            comboBoxVisaLarareIKursen.Items.Clear();
            comboBoxVisaStudenterIKursen.Items.Clear();
            comboBoxVisaUppgifterIKursen.Items.Clear();

            foreach (Kurs kurs in Form1.kurser)
            {
                if (kurs.kursID == comboBoxKurser.SelectedItem.ToString().Substring(0, 6))
                {
                    textBoxKursID.Text = kurs.kursID;
                    txtBoxLaggTillKursNamn.Text = kurs.kursNamn;

                    for (int i = 0; i < kurs.larare.Count; i++)
                    {
                        comboBoxVisaLarareIKursen.Items.Add(kurs.larare[i]);
                    }
                    for (int i = 0; i < kurs.elever.Count; i++)
                    {
                        comboBoxVisaStudenterIKursen.Items.Add(kurs.elever[i]);
                    }
                    if (kurs.kursUppgifter == null)
                    {

                    }
                    else
                    {
                        for (int u = 0; u < kurs.kursUppgifter.Count; u++)
                        {
                            comboBoxVisaUppgifterIKursen.Items.Add(kurs.kursUppgifter[u]);
                        }
                    }

                    foreach (Teacher t in Form1.teachers)
                    {
                        comboBoxAnsvLarare.Items.Add(t);
                    }
                    comboBoxAnsvLarare.Text = kurs.AnsvLarare.ToString();

                }
            }
                
            


            foreach (Kurs kurs in Form1.kurser)
            {
                if (kurs.kursID == comboBoxKurser.ToString().Substring(0, 6))
                {

                    for (int i = 0; i < kurs.larare.Count; i++)
                    {
                        comboBoxVisaLarareIKursen.Items.Add(kurs.larare[i]);
                    }

                }

            }

        }

        private void LaggTillListaLarare_Click(object sender, EventArgs e)
        {
            listBoxLaggTillLarare.Items.Add(comboBoxLaggTillLarare.SelectedItem);
        }

        private void LaggTillListaStud_Click(object sender, EventArgs e)
        {
            listBoxLaggTillStud.Items.Add(comboBoxLaggTillStud.SelectedItem);
        }

        private void FormRedigeraKurs_Load(object sender, EventArgs e)
        {

        }
    }
}
