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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginBtn.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }

    public class User
    {
        // visibility datatype name

        // Field
        public int UserId;
        private string Status;

        // Property
        public string Username { get; set; }
        // Methods

        public int GetUserId()
        {
            return UserId;
        }
    }

    public class SpecialUser : User
    {

    }
}
