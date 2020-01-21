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
    public partial class FormRedigeraBetyg : Form
    {
        public FormRedigeraBetyg()
        {
            
            InitializeComponent();
            
            foreach (Student stud in Form1.students)
            {
                comboBox1.Items.Add(stud.användarId + ", " + stud.namn);
            }

            textBox1.MaxLength = 1;

        }

        private void comboBoxValjStudent(object sender, EventArgs e)
        {
            //Dropdown för att välja vilken student som ska få ändrat betyg.

            comboBox2.Items.Clear();

            foreach (Student stud in Form1.students)
            {
                if (stud.användarId == comboBox1.SelectedItem.ToString().Substring(0, 4))
                {                    
                    foreach (string b in stud.betyg)
                    {
                        string ID = b.Substring(0, 4);

                        foreach (Uppgift upp in Form1.uppgifter)
                        {
                            if (upp.uppgiftsID == ID)
                            {
                                comboBox2.Items.Add(upp);
                                
                            }
                        }

                        //comboBox2.Items.Add(b);
                    }

                }

            }

        }

        private void comboBoxValjUppgift(object sender, EventArgs e)
        {
            //Dropdown för att välja vilken uppgift där betyget ska ändras. 

            foreach (Student stud in Form1.students)
            {
                if (stud.användarId == comboBox1.SelectedItem.ToString().Substring(0, 4))
                {
                    foreach (string b in stud.betyg)
                    {
                        if (b.Substring(0, 4) == comboBox2.SelectedItem.ToString().Substring(0, 4))
                        {
                            label5.Text = b.ToString().Substring(5);
                        }
                    }
                }

            }
        }

        private void textBoxNuvarandeBetyg_TextChanged(object sender, EventArgs e)
        {
            //Visar studentens nuvarande betyg.
        }

        private void textBoxSattBetyg(object sender, EventArgs e)
        {
            //Textbox för inmatning av det nya betyget. 
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            //Knapp för att spara det nya betyget.
            string Nytt = textBox1.Text;

            if (textBox1.Equals(""))
            {
                MessageBox.Show("Skriv in det nya betyget innan du sparar.");
            }
            else
            {
                DialogResult Svar;
                Svar = MessageBox.Show("Vill du ändra betyget på: " + comboBox2.SelectedItem + "\nTill: " + textBox1.Text, "Stämmer detta ", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {

                    Close();

                }
                else if (Svar == DialogResult.Yes)
                {
                    string sID = comboBox1.SelectedItem.ToString().Substring(0, 4);
                    string uID = comboBox2.SelectedItem.ToString().Substring(0, 4);
                    //string old = comboBox2.Text;
                    string ny = textBox1.Text;

                    string nytt = uID + " " + ny;



                    foreach (Student stud in Form1.students)
                    {
                        //Går igenom alla studenter och letar upp den som ska ändras via användarID som den hittar i substring(0,4)
                        if (stud.användarId == sID)
                        {
                            for (int i = 0; i < stud.betyg.Count; i++)
                            {
                                if (uID == stud.betyg[i].Substring(0, 4))
                                {
                                    stud.betyg[i] = nytt;
                                }
                            }
                               
                            //Ändrar namnet och stänger formuläret.
                            
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormRedigeraBetyg_Load(object sender, EventArgs e)
        {

        }
    }
}
