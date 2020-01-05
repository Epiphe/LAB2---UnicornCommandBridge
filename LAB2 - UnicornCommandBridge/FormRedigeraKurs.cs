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
            this.Hide();
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
    }
}
