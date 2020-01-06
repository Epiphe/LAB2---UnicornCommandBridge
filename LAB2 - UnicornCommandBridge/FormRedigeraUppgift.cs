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
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tillbakaknapp
            this.Hide();
        }
    }
}
