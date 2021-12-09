using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidCaseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CovidCasesDBEntities db = new CovidCasesDBEntities();
            if(usrnametxt.Text != string.Empty && pswdtxt.Text != string.Empty)
            {
                var user = db.Logins.Where(x => x.Username.Equals(usrnametxt.Text)).SingleOrDefault();
                if(user != null)
                {
                    if (user.Password.Equals(pswdtxt.Text))
                    {
                        MessageBox.Show("Admin login successfull !!");
                        CovidPatientDetails covidPatientDetails = new CovidPatientDetails();
                        covidPatientDetails.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("User name is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Please enter Username or Password");
            }
        }
    }
}
