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

        List<Student> students = new List<Student>();
        Student A = new Student("S100", "Anders", );
        Student B = new Student("S101", "Börje");


        public FormRedStudentLarare()
        {
            InitializeComponent();

            students.Add(A);
            students.Add(B);


            foreach (Student stud in students)
            {
                comboBox1.Items.Add(stud.användarId+", "+stud.namn);
            }

            List<Student> GetList()
            { return students; }
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
            //comboBox1.Items.AddRange(students);
            //comboBox1.Items.Add(namn);
            //comboBox1.Items.Add(användarId);


        }

        private void textBoxRedStudentNamn(object sender, EventArgs e)
        {
            //Här visas namnet på den valda studenten. 
            //textBoxLaggTillNamn.Text = comboBox1.Text; FUNGERAR!

        }

        private void comboBoxValjLarare(object sender, EventArgs e)
        {
            //dropdown med en lista på alla lärare. 
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
                   
                    //students.add(new Student(användarId, namn));
                    
                }
            }
        }
    }
}
