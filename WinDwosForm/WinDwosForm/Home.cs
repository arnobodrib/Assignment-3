using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDwosForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string password = textPassword.Text;

            labelShow.Text = name  +" And "+ password;
            MessageBox.Show(labelShow.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
