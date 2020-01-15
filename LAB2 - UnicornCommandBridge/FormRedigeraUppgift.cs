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
    public partial class FormRedigeraUppgift : Form
    {
        public FormRedigeraUppgift()
        {
            InitializeComponent();

            foreach (Uppgift upp in Form1.uppgifter)
            {
                comboBoxVisaUppgifter.Items.Add(upp.uppgiftsID + ", " + upp.uppgiftsNamn);
            }

            foreach (Kurs K in Form1.kurser)
            {
                comboBoxValjKurs.Items.Add(K.kursID);
            }
        }

        private void btnValjUppgift_Click(object sender, EventArgs e)
        {
            //När man trycker på knappen letar scriptet upp rätt uppgift och fyller i fälten.
            foreach (Uppgift upp in Form1.uppgifter)
            {
                //Om uppgiftsID är samma som står i boxen så läggs uppgifterna från det objektet in i boxarna. 
                if (upp.uppgiftsID == comboBoxVisaUppgifter.SelectedItem.ToString().Substring(0, 4))
                {
                    textBoxUppgiftNamn.Text = upp.uppgiftsNamn;
                    comboBoxValjKurs.Text = upp.kursId;
                    richTextBoxUppgiftsBeskrivning.Text = upp.beskrivning;
                }
            }
        }

        private void comboBoxVisaKurser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dropdownmeny för att välja uppgift via uppgiftsID.

        }

        private void textBoxUppgiftNamn_TextChanged(object sender, EventArgs e)
        {
            //Namnen på uppgiften. 
        }

        private void richTextBoxUppgiftsBeskrivning_TextChanged(object sender, EventArgs e)
        {
            //Beskrivningen av uppgiften. 
        }

        private void btnSparaUppgift_Click(object sender, EventArgs e)
        {
            //Knapp för att spara ändringarna. 
            foreach (Uppgift upp in Form1.uppgifter)
            {
                //Om uppgiftsID är samma som står i boxen så läggs uppgifterna från boxarna in i det objektet. 
                if (upp.uppgiftsID == comboBoxVisaUppgifter.SelectedItem.ToString().Substring(0, 4))
                {
                    upp.uppgiftsNamn = textBoxUppgiftNamn.Text;
                    upp.kursId = comboBoxValjKurs.Text;
                    upp.beskrivning = richTextBoxUppgiftsBeskrivning.Text;
                    Close();
                }
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tillbakaknapp
            this.Hide();
        }

        private void comboBoxValjKurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
