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
    public partial class FormNewSubject : Form
    {
        private User user;

        public FormNewSubject(User user)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbCode.Text) || String.IsNullOrEmpty(tbName.Text)
                || String.IsNullOrEmpty(tbFU1.Text) || String.IsNullOrEmpty(tbFU2.Text)
                || String.IsNullOrEmpty(tbFU3.Text) || String.IsNullOrEmpty(tbP1.Text)
                || String.IsNullOrEmpty(tbP2.Text) || String.IsNullOrEmpty(tbP3.Text))
            {
                MessageBox.Show("All camps are required");
                return;
            }
            try
            {
                if ((Convert.ToDouble(tbFU1.Text) >= 0 && Convert.ToDouble(tbFU1.Text) <= 5)
                && (Convert.ToDouble(tbFU2.Text) >= 0 && Convert.ToDouble(tbFU2.Text) <= 5)
                && (Convert.ToDouble(tbFU3.Text) >= 0 && Convert.ToDouble(tbFU3.Text) <= 5)
                && (Convert.ToDouble(tbP1.Text) >= 0 && Convert.ToDouble(tbP1.Text) <= 5)
                && (Convert.ToDouble(tbP2.Text) >= 0 && Convert.ToDouble(tbP2.Text) <= 5)
                && (Convert.ToDouble(tbP3.Text) >= 0 && Convert.ToDouble(tbP3.Text) <= 5))
                {
                    short code = Convert.ToByte(tbCode.Text);
                    String name = tbName.Text;
                    Subject sub = new Subject(code, name);
                    if (FormLogin.control.addSubjectToUser(user, sub))
                    {
                        double n1 = Convert.ToDouble(tbFU1.Text);
                        double n2 = Convert.ToDouble(tbFU2.Text);
                        double n3 = Convert.ToDouble(tbFU3.Text);
                        double n4 = Convert.ToDouble(tbP1.Text);
                        double n5 = Convert.ToDouble(tbP2.Text);
                        double n6 = Convert.ToDouble(tbP3.Text);
                        Grade g1 = new Grade(n1, 10);
                        Grade g2 = new Grade(n2, 10);
                        Grade g3 = new Grade(n3, 10);
                        Grade g4 = new Grade(n4, 20);
                        Grade g5 = new Grade(n5, 20);
                        Grade g6 = new Grade(n6, 30);
                        LinkedList<Grade> list = new LinkedList<Grade>();
                        list.AddLast(g1);
                        list.AddLast(g2);
                        list.AddLast(g3);
                        list.AddLast(g4);
                        list.AddLast(g5);
                        list.AddLast(g6);
                        FormLogin.control.addGradeToSubject(sub, list);
                        labelInfo.Text = Convert.ToString(sub.calculateFinal());
                        MessageBox.Show("Subject successful registered");
                    }
                    else
                    {
                        MessageBox.Show("Code is already in use");
                    }
                }
                else
                {
                    MessageBox.Show("Insert values between 0 and 5");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter only numerical values in the grades box");
            }
        }
    }
}
