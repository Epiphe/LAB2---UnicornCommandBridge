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
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Knapp för att stänga fönstret och komma tillbaka till huvudmenyn. 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxValjStudent(object sender, EventArgs e)
        {
            //dropdown med en lista på alla stundeter.
            students();
        }

        private void textBoxRedStudentNamn(object sender, EventArgs e)
        {
            //Här visas namnet på den valda studenten. 
        }

        private void comboBoxValjLarare(object sender, EventArgs e)
        {
            //dropdown med en lista på alla lärare. 
        }

        private void textBoxRedLarernamn(object sender, EventArgs e)
        {
            //Här visas namnet på den valda läraren.
        }
    }
}
