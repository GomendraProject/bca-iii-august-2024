using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bca_iii_aug_2024
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.Load += RegisterForm_Load;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            registerBtn.Click += RegisterBtn_Click;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var username = usernameTxt.Text;
            var password = passwordTxt.Text;

            MessageBox.Show(username + " Pwd: " + password);
        }
    }
}
