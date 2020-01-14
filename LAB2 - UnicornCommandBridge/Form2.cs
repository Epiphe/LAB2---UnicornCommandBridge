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
            


            if (användarId.Equals(""))
            {
                MessageBox.Show("Skriv ett användar ID");
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

                    
                    //students.add(new Student(användarId, namn));
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

            if (användarId.Equals(""))
            {
                MessageBox.Show("Skriv ett användar ID");
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
                    new Teacher(användarId, namn);

                    Close();
                }
            }


        }
    }
}
