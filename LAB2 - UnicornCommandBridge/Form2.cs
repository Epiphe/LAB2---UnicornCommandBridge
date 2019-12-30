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
    public partial class Form2_Create : Form
    {
        public Form2_Create()
        {
            InitializeComponent();
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            //När du trycker på knappen så döljs fönstret. 
            this.Hide();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            //Här är knappen för att spara det som står skrivet i fälten namn och uniktId.
        }
    }
}
