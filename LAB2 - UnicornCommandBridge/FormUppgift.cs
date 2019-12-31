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
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Tar dig tillbaka till huvudmenyn.
            this.Hide();
        }
    }
}
