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

        public Datastore Datastore { get; set; }
        public FormRedigeraUppgift(Datastore datastore)
        {
            InitializeComponent();
            Datastore = datastore;

            foreach (Uppgift upp in Datastore.uppgifter)
            {
                comboBoxVisaUppgifter.Items.Add(upp);
            }
            foreach (Kurs K in Datastore.kurser)
            {
                comboBoxValjKurs.Items.Add(K.ToString());
            }

        }


        private void btnValjUppgift_Click(object sender, EventArgs e)
        {
            // För att se ifall en kurs är vald
            string U = comboBoxVisaUppgifter.Text;

            if (comboBoxVisaUppgifter.SelectedItem == null)
            {

            }
            else
            {
                // När man trycker på knappen letar scriptet upp rätt uppgift och fyller i fälten.
                foreach (Uppgift upp in Datastore.uppgifter)
                {
                    // Om uppgiftsID är samma som står i boxen så läggs uppgifterna från det objektet in i boxarna. 

                    if (upp.uppgiftsID == comboBoxVisaUppgifter.SelectedItem.ToString().Substring(0, 4))
                    {
                        textBoxUppgiftNamn.Text = upp.uppgiftsNamn;
                        if (upp.kurs != null)
                        {
                            comboBoxValjKurs.Text = upp.kurs.ToString();
                        }
                        
                        richTextBoxUppgiftsBeskrivning.Text = upp.beskrivning;
                    }
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
            //Kollar så att inte rutan är tom.
            if (String.IsNullOrWhiteSpace(comboBoxVisaUppgifter.Text))
            {
                MessageBox.Show("Välj ett uppgiftsID i den översta dropdownmenyn.");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Vill du spara:\nNamn till: " + textBoxUppgiftNamn.Text + "\nKurs till: " + comboBoxValjKurs.Text + "\nBeskrivning till: " + richTextBoxUppgiftsBeskrivning.Text + "?", "Stämmer detta?", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {

                    Close();

                }
                else if (Svar == DialogResult.Yes)
                {
                    foreach (Uppgift upp in Datastore.uppgifter)
                    {
                        //Om uppgiftsID är samma som står i boxen så läggs uppgifterna från boxarna in i det objektet. 
                        if (upp.uppgiftsID == comboBoxVisaUppgifter.SelectedItem.ToString().Substring(0, 4))
                        {
                            
                            foreach (Kurs kurs in Datastore.kurser)
                            {
                                if (kurs == upp.kurs)
                                {
                                    kurs.KursUppgifter.Remove(upp);
                                }
                            }


                            upp.uppgiftsNamn = textBoxUppgiftNamn.Text;

                            foreach (Kurs kurs in Datastore.kurser)
                            {
                                if (kurs.kursID == comboBoxValjKurs.SelectedItem.ToString().Substring(0, 6))
                                {
                                    upp.kurs = kurs;
                                }
                            }

                            upp.beskrivning = richTextBoxUppgiftsBeskrivning.Text;


                            foreach(Kurs kurs in Datastore.kurser)
                            {
                                if (kurs == upp.kurs)
                                {
                                    kurs.KursUppgifter.Add(upp);
                                }
                            }


                            Close();
                        }
                    }
                }
            }

        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tillbakaknapp
            this.Close();
        }

        private void comboBoxValjKurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
