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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapaStudent_Click(object sender, EventArgs e)
        {
            //Knappen öppnar ett formulär där du kan mata in en ny student.
            Form2_Create skapaStudentLarare = new Form2_Create();
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaLarare_Click(object sender, EventArgs e)
        {
            Form2_Create skapaStudentLarare = new Form2_Create();
            skapaStudentLarare.ShowDialog();
        }

        private void btnSkapaKurs_Click(object sender, EventArgs e)
        {
            KursForm laggTillKurs = new KursForm();
            laggTillKurs.ShowDialog();
        }

        private void btnSkapaUppgift_Click(object sender, EventArgs e)
        {
            FormUppgift laggTillUppgift = new FormUppgift();
            laggTillUppgift.ShowDialog();
        }

        private void btnRedigeraStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraLarare_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraKurs_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraUppgift_Click(object sender, EventArgs e)
        {

        }

        private void btnSattaBetyg_Click(object sender, EventArgs e)
        {

        }

        private void btnRedigeraBetyg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unicorns unite!");
        }
    }
}
