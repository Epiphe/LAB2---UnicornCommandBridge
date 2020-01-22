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
    public partial class FormRedStudentLarare : Form
    {
       
        public FormRedStudentLarare()
        {
            InitializeComponent();

            comboBox1.DataSource = Form1.students;
            comboBox2.DataSource = Form1.teachers;


        }


    private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Knapp för att stänga fönstret och komma tillbaka till huvudmenyn. 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void comboBoxValjStudent(object sender, EventArgs e)
        {
            //dropdown med en lista på alla stundeter.
            textBoxLaggTillNamn.Text = comboBox1.SelectedItem.ToString().Substring(5);



        }

        private void textBoxRedStudentNamn(object sender, EventArgs e)
        {
            //Här visas namnet på den valda studenten. 
            


        }

        private void comboBoxValjLarare(object sender, EventArgs e)
        {
            //dropdown med en lista på alla lärare. 

            textBox1.Text = comboBox2.SelectedItem.ToString().Substring(5);

            foreach (Teacher teach in Form1.teachers)
            {
                if (teach.användarId == comboBox2.SelectedItem.ToString().Substring(0, 4))
                {
                    teach.UpdateSalary();

                    Betalt.Text = teach.salary.ToString();


                }
            }
        }

        private void textBoxRedLarernamn(object sender, EventArgs e)
        {
            //Här visas namnet på den valda läraren.
        }

        private void btnSparaRedStudent_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            string textboxValue = textBoxLaggTillNamn.Text;

            if (textboxValue.Equals(""))
            {
                MessageBox.Show("Skriv in det nya namnet innan du sparar.");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Vill du ändra namnet på: " + comboBox1.SelectedItem + "\nTill: "+ textboxValue,"Stämmer detta ", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    
                    Close();
     
                }
                else if (Svar == DialogResult.Yes)
                {

                    foreach (Student stud in Form1.students)
                    {
                        //Går igenom alla studenter och letar upp den som ska ändras via användarID som den hittar i substring(0,4) Hmm funkar bara sålänge man inte får fler än 999 studenter men i det här programmet får det vara.
                        if (stud.användarId == comboBox1.SelectedItem.ToString().Substring(0, 4))
                        {
                            //Ändrar namnet och stänger formuläret.
                            stud.namn = textboxValue;
                            Close();
                        }
                    }
                }
            }
        }

        private void BtnSparaRedLarare_Click(object sender, EventArgs e)
        {
            string textboxValue = textBox1.Text;

            if (textboxValue.Equals(""))
            {
                MessageBox.Show("Skriv in det nya namnet innan du sparar.");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Vill du ändra namnet på: " + comboBox2.SelectedItem + "\nTill: " + textboxValue, "Stämmer detta ", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {

                    Close();

                }
                else if (Svar == DialogResult.Yes)
                {

                    foreach (Teacher teach in Form1.teachers)
                    {
                        //Går igenom alla lärare och letar upp den som ska ändras via användarID som den hittar i substring(0,4). Hmm funkar bara sålänge man inte får fler än 999 studenter men i det här programmet får det vara.
                        if (teach.användarId == comboBox2.SelectedItem.ToString().Substring(0, 4))
                        {
                            //Ändrar namnet och stänger formuläret.
                            teach.namn = textboxValue;

                            Close();
                        }

                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVisaLon_Click(object sender, EventArgs e)
        {

        }
    }
}
