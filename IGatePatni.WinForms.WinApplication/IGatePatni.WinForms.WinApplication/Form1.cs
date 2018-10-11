using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGatePatni.WinForms.WinApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + txtname.Text + " !!!");
        }

        private void btnwelcome_MouseEnter(object sender, EventArgs e)
        {
            //sender is source of event ie: btnwelcome button.
            Button b = sender as Button;
            b.BackColor = Color.Yellow;
            b.ForeColor = Color.OrangeRed;
        }

        private void btnwelcome_MouseLeave(object sender, EventArgs e)
        {
            //sender is source of event ie: btnwelcome button.
            Button b = sender as Button;
            b.BackColor = SystemColors.Control;
            b.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnclose.Click += new EventHandler(btnclose_Click);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtname_MouseHover(object sender, EventArgs e)
        {
            TextBox b = sender as TextBox;
            b.BackColor = Color.Yellow;

        }
    }
}
