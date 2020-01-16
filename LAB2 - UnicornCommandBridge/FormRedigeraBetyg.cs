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

            /*foreach (Uppgift upp in Form1.uppgifter)
            {
                comboBox2.Items.Add(upp.uppgiftsID + ", " + upp.uppgiftsNamn);
            }
            */





        }

        private void comboBoxValjStudent(object sender, EventArgs e)
        {
            //Dropdown för att välja vilken student som ska få ändrat betyg.
            foreach (Student stud in Form1.students)
            {
                if (stud.användarId == comboBox1.SelectedItem.ToString().Substring(0, 4))
                {
                    
                    foreach (string b in stud.betyg)
                    {
                        comboBox2.Items.Add(b);
                    }
                }



            }

        }

        private void comboBoxValjUppgift(object sender, EventArgs e)
        {
            //Dropdown för att välja vilken uppgift där betyget ska ändras. 
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
                Svar = MessageBox.Show("Vill du ändra namnet på: " + comboBox2.SelectedItem + "\nTill: " + textBox1, "Stämmer detta ", MessageBoxButtons.YesNo);
                if (Svar == DialogResult.No)
                {

                    Close();

                }
                else if (Svar == DialogResult.Yes)
                {

                    foreach (Student stud in Form1.students)
                    {
                        //Går igenom alla studenter och letar upp den som ska ändras via användarID som den hittar i substring(0,4) Hmm funkar bara sålänge man inte får fler än 999 studenter men i det här programmet får det vara.
                        if (stud.användarId == comboBox1.SelectedItem.ToString().Substring(0, 4))
                        {
                            foreach(string b in stud.betyg)
                            {
                                if(comboBox2.SelectedItem.ToString().Substring(0,4) == b.Substring(0, 4))
                                {
                                    

                                    string gammalt = b.Remove(b.Length - 1, 1) + Nytt;

                                   
                                    for (int i = 0; i <stud.betyg.Length; i++)
                                    {

                                    }
                                    {
                                        if (q.Substring(0, 4) == b.Substring(0, 4))
                                        {

                                            stud.betyg.Add(gammalt);
                                            stud.betyg.Remove(q);

                                        }

                                    }
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
            this.Hide();
        }
    }
}
