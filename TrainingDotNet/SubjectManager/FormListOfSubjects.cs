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
    public partial class FormListOfSubjects : Form
    {
        User user;

        public FormListOfSubjects(User user)
        {
            InitializeComponent();
            this.user = user;
            labelInfo.Text = "Welcome " + user.Name;
            fillTable();
        }

        private void fillTable()
        {
            dataGridSubjects.RowHeadersVisible = false;
            dataGridSubjects.ReadOnly = true;
            dataGridSubjects.AllowUserToAddRows = false;
            dataGridSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridSubjects.Columns.Add("colCod", "Code");
            dataGridSubjects.Columns.Add("colName", "Subject Name");
            dataGridSubjects.Columns.Add("colDef", "Def");
            foreach (Subject item in user.Subjects)
            {
                dataGridSubjects.Rows.Add(new Object[] { item.Code, item.Name, item.calculateFinal() });
            }
        }


        private void btnNewSubject_Click(object sender, EventArgs e)
        {
            Thread thread = new System.Threading.Thread
                (new System.Threading.ThreadStart(openFormNewSubject));
            thread.SetApartmentState
                (System.Threading.ApartmentState.STA);
            this.Close();
            thread.Start();
        }

        private void openFormNewSubject()
        {
            FormNewSubject form = new FormNewSubject(user);
            form.ShowDialog();
        }
    }
}
