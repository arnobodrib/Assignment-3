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
    public partial class Deshboard : Form
    {
        public Deshboard()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string item = comboBoxItem.Text;
            if (item == "")
            {
                MessageBox.Show("Select an Item");

            }
            else
            {
                MessageBox.Show(item);
            }
        }
    }
}
