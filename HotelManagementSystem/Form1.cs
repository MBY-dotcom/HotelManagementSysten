using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Label_exit_MouseEnter(object sender, EventArgs e)
        {
            Label_exit.ForeColor = Color.Red;
        }

        private void Label_exit_MouseLeave(object sender, EventArgs e)
        {
            Label_exit.ForeColor = Color.Orange;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
