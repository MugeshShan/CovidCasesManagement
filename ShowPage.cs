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
    public partial class ShowPage : Form
    {
        public ShowPage(DataGridView dataGridView, string pageTitle)
        {
            InitializeComponent();
            label5.Text = pageTitle;
            dataGridView1.DataSource = dataGridView.DataSource;
        }

        public void ShowGrid(DataGridView dataGridView, string pageTitle)
        {
            label5.Text = pageTitle;
            dataGridView1.DataSource = dataGridView;
        }
    }
}
