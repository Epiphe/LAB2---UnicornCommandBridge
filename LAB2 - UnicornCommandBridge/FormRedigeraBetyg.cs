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
        }

        private void comboBoxValjStudent(object sender, EventArgs e)
        {
            //Dropdown för att välja vilken student som ska få ändrat betyg.

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
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tillbakaknapp
            this.Hide();
        }
    }
}
