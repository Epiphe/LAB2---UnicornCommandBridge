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
    public partial class FormUppgift : Form
    {
        public FormUppgift()
        {
            InitializeComponent();

            foreach (Kurs kurs in Form1.kurser)
            {
                comboBox1.Items.Add(kurs.kursId + ", " + kurs.kursNamn);
            }
        }

        private void FormUppgift_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSparaUppgift_Click(object sender, EventArgs e)
        {
            //Spara ny uppgift.

            string uppgiftsID = textBoxUppgiftsID.Text;
            string uppgiftsNamn = textBoxUppgiftsnamn.Text;
            string kursID = comboBox1.SelectedItem.ToString();
            string beskrivning = richTextBoxUppgiftsBeskrivning.Text;



            if (uppgiftsID.Equals(""))
            {
                MessageBox.Show("Skriv ett uppgifts ID");
            }
            else if (beskrivning.Equals(""))
            {
                MessageBox.Show("Skriv en beskrivning");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Uppgifts ID: " + uppgiftsID +"\nNamn: "+ uppgiftsNamn +"\nKurs: " + kursID + "\nBeskrivning: \n" + beskrivning, "Stämmer detta?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {
                    Close();
                }
                else if (Svar == DialogResult.Yes)
                {


                    //Kurs.Add(new Uppgift(uppgiftsID, beskrivning));

                    Close();
                }
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tar dig tillbaka till huvudmenyn.
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Uppgift upp in Form1.uppgifter)
            {
                comboBox1.Items.Add(upp.uppgiftsID + ", " + upp.uppgiftsNamn);
            }
        }
    }
}
