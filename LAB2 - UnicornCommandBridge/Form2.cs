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
        public Datastore Datastore { get; set; }

        public Form2_Create(Datastore datastore)
        {
            InitializeComponent();
            StudentID.MaxLength = 4;
            TeacherID.MaxLength = 4;

            Datastore = datastore;
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //När du trycker på knappen så döljs fönstret. 
            this.Close();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            //(Spara Student) Här är knappen för att spara det som står skrivet i fälten namn och uniktId.
            string användarId = StudentID.Text;
            string namn = ElevNamn.Text;
            bool OK = true;
            
            foreach (Student stud in Datastore.students)
            {
                if (stud.användarId == användarId)
                {
                    OK = false;
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
                MessageBox.Show("Välj ett unikt ID");
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

                    
                    Datastore.students.Add(new Student(användarId, namn));



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
            //(Spara Lärare)
            string användarId = TeacherID.Text;
            string namn = TeacherName.Text;
            bool OK = true;

            foreach (Teacher teach in Datastore.teachers)
            {
                if (teach.användarId == användarId)
                {
                    OK = false;
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
                MessageBox.Show("Välj ett unikt ID");
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

                    Datastore.teachers.Add(new Teacher(användarId, namn));

                    Close();
                }
            }


        }

        private void Form2_Create_Load(object sender, EventArgs e)
        {

        }
    }
}
