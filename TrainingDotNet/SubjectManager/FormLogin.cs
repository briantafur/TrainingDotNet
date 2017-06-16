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
    public partial class FormLogin : Form
    {

        public static UserController control = new UserController();
        User user;
        /// <summary>
        /// 
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Thread thread = new System.Threading.Thread
                (new System.Threading.ThreadStart(openRegisterUserForm));
            thread.SetApartmentState
                (System.Threading.ApartmentState.STA);
            this.Close();
            thread.Start();
        }
        private void openRegisterUserForm()
        {
            FormRegisterUser form = new FormRegisterUser();
            form.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Username and Password required");
                return;
            }
            String username = tbUsername.Text;
            String password = tbPassword.Text;
            user = control.login(username, password);
            if (user != null)
            {
                Thread thread = new System.Threading.Thread
                (new System.Threading.ThreadStart(openListOfSubjects));
                thread.SetApartmentState
                    (System.Threading.ApartmentState.STA);
                this.Close();
                thread.Start();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void openListOfSubjects()
        {
            FormListOfSubjects form = new FormListOfSubjects(user);
            form.ShowDialog();
        }
    }
}
