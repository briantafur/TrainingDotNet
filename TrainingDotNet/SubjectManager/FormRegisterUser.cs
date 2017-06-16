using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectManager
{
    public partial class FormRegisterUser : Form
    {
        public FormRegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbUsername.Text)
                || String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Fill the empty boxes");
                return;
            }
            if (!tbPassword.Text.Equals(tbConfirmPassword.Text))
            {
                MessageBox.Show("Password doesn't match");
                return;
            }
            String name = tbName.Text;
            String username = tbUsername.Text;
            String password = tbPassword.Text;
            User user = new User(name, username, password);
            if (FormLogin.control.addUser(user))
            {
                MessageBox.Show("User succesful added");
            }
            else
            {
                MessageBox.Show("Username already taken");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Thread thread = new System.Threading.Thread
                (new System.Threading.ThreadStart(openLoginForm));
            thread.SetApartmentState
                (System.Threading.ApartmentState.STA);
            this.Close();
            thread.Start();
        }
        private void openLoginForm()
        {
            FormLogin form = new FormLogin();
            form.ShowDialog();
        }
    }
}
