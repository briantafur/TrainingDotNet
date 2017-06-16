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
    public partial class FormPercentSettings : Form
    {
        User user;

        public FormPercentSettings(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Thread thread = new System.Threading.Thread
                (new System.Threading.ThreadStart(openFormListOfSubjects));
            thread.SetApartmentState
                (System.Threading.ApartmentState.STA);
            this.Close();
            thread.Start();
        }

        private void openFormListOfSubjects()
        {
            FormListOfSubjects form = new FormListOfSubjects(user);
            form.ShowDialog();
        }

    }
}
