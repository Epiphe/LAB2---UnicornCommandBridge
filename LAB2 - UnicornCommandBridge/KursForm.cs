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
    public partial class KursForm : Form
    {
        public KursForm()
        {
            InitializeComponent();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //Stänger detta fönster. 
            this.Hide();
        }

        private void btnLaggTillKurs_Click(object sender, EventArgs e)
        {
            //Spara kurs knapp.
        }
    }
}
