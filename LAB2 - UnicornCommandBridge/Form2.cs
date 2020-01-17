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
    public partial class Form2_Create : Form
    {
        public Form2_Create()
        {
            InitializeComponent();
            StudentID.MaxLength = 4;
            TeacherID.MaxLength = 4;

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //När du trycker på knappen så döljs fönstret. 
            this.Hide();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            //Här är knappen för att spara det som står skrivet i fälten namn och uniktId.
            string användarId = StudentID.Text;
            string namn = ElevNamn.Text;
            bool OK = true;
            foreach (Student stud in Form1.students)
            {
                //Går igenom alla studenter och letar upp den som ska ändras via användarID som den hittar i substring(0,4) Hmm funkar bara sålänge man inte får fler än 999 studenter men i det här programmet får det vara.
                if (stud.användarId == StudentID.Text.ToString().Substring(0, 4))
                {

                    OK = false;

                    Close();
                }
            }

            if (användarId.Equals(""))
            {
                MessageBox.Show("Skriv ett användar ID");
            }
            else if (användarId.Length < 4)
            {
                MessageBox.Show("Användar ID måste vara 4 tecken");
            }
            else if (OK == false)
            {
                MessageBox.Show("Det ID:et finns redan");
            }
            else if (namn.Equals(""))
            {
                MessageBox.Show("Skriv ett Namn");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Användar ID: " + användarId + " Namn: " + namn, "Stämmer detta?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    Close();
                }
                else if (Svar == DialogResult.Yes)
                {

                    
                    Form1.students.Add(new Student(användarId, namn));

                    Close();
                }
            }
            
        }

        private void textBoxLaggTillNamn_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBoxLaggTillId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string användarId = TeacherID.Text;
            string namn = TeacherName.Text;
            bool OK = true;
            
              foreach (Teacher tech in Form1.teachers)
              {
                //Går igenom alla studenter och letar upp den som ska ändras via användarID som den hittar i substring(0,4) Hmm funkar bara sålänge man inte får fler än 999 studenter men i det här programmet får det vara.
                if (tech.användarId == TeacherID.Text.ToString().Substring(0, 4))
                {

                    OK = false;

                    Close();
                }
              }

            if (användarId.Equals(""))
            {
                MessageBox.Show("Skriv ett användar ID");
            }
            else if (användarId.Length < 4)
            {
                MessageBox.Show("Användar ID måste vara 4 tecken");
            }
            else if (OK == false)
            {
                MessageBox.Show("Det ID:et finns redan");
            }
            else if (namn.Equals(""))
            {
                MessageBox.Show("Skriv ett Namn");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Användar ID: " + användarId + " Namn: " + namn, "Stämmer detta?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    Close();
                }
                else if (Svar == DialogResult.Yes)
                {

                    Form1.teachers.Add(new Teacher(användarId, namn));

                    Close();
                }
            }


        }
    }
}
