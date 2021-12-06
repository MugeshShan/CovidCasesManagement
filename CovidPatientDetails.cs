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
    public partial class CovidPatientDetails : Form
    {
        public CovidPatientDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty && comboBox2.Text != "--Select")
            {
                CovidCasesDBEntities db = new CovidCasesDBEntities();
                var hospital = db.Hospital_Details.Where(x => x.Hospital_Name.ToLower() == textBox1.Text.ToLower()).FirstOrDefault();
                var date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                if (comboBox2.Text == "Recovery Count")
                {
                    var hosptialrecoveries = db.Confirmed_Recoveries.Where(x =>x.Hospital_Id == hospital.Id).ToList();
                    var recoveries = new List<RecoveryModel>();
                    foreach(var hospitalrecovery in hosptialrecoveries)
                    {
                        var hospitalDate = hospitalrecovery.Date.ToString("dd/MM/yyyy");
                        if (hospitalDate == date)
                        {
                            var recoveryCount = new RecoveryModel
                            {
                                Hospital_Id = hospital.Id,
                                Hospital_Name = hospital.Hospital_Name,
                                Male_Recovery_Count = hospitalrecovery.Male_Confirmed_Recoveries,
                                Female_Recovery_Count = hospitalrecovery.Female_Confirmed_Recoveries,
                                Child_Recovery_Count = hospitalrecovery.Children_Confirmed_Recoveries,
                                Date = date
                            };
                            recoveries.Add(recoveryCount);
                        }
                    }
                    dataGridView1.DataSource = recoveries;
                }
                if (comboBox2.Text == "Confirmed Count")
                {
                    var hosptialConfirmedCases = db.Confirmed_Cases.Where(x => x.Hospital_Id == hospital.Id).ToList();
                    var confirmedCases = new List<ConfirmedCasesModel>();
                    foreach (var hospitalConfirmed in hosptialConfirmedCases)
                    {
                        var hospitalDate = hospitalConfirmed.Date.ToString("dd/MM/yyyy");
                        if (hospitalDate == date)
                        {
                            var confirmedCount = new ConfirmedCasesModel
                            {
                                Hospital_Id = hospital.Id,
                                Hospital_Name = hospital.Hospital_Name,
                                Male_Confirmed_Count = hospitalConfirmed.Male_Confirmed_Cases,
                                Female_Confirmed_Count = hospitalConfirmed.Female_Confirmed_Cases,
                                Child_Confirmed_Count = hospitalConfirmed.Children_Confirmed_Cases,
                                Date = date
                            };
                            confirmedCases.Add(confirmedCount);
                        }
                    }
                    dataGridView1.DataSource = confirmedCases;
                }

                if (comboBox2.Text == "Death Count")
                {
                    var hosptialDeathCases = db.Confirmed_Deaths.Where(x => x.Hospital_Id == hospital.Id).ToList();
                    var deathCases = new List<DeathCasesModel>();
                    foreach (var hospitalDeath in hosptialDeathCases)
                    {
                        var hospitalDate = hospitalDeath.Date.ToString("dd/MM/yyyy");
                        if (hospitalDate == date)
                        {
                            var deathCount = new DeathCasesModel
                            {
                                Hospital_Id = hospital.Id,
                                Hospital_Name = hospital.Hospital_Name,
                                Male_Death_Count = hospitalDeath.Male_Deaths,
                                Female_Death_Count = hospitalDeath.Female_Deaths,
                                Child_Death_Count = hospitalDeath.Children_Deaths,
                                Date = date
                            };
                            deathCases.Add(deathCount);
                        }
                    }
                    dataGridView1.DataSource = deathCases;
                }

                if (comboBox2.Text == "Testing Count")
                {
                    var testedCases = db.Tested_Individuals.Where(x => x.Hospital_Id == hospital.Id).ToList();
                    var hospitalTestedCases = new List<TestingCountModel>();
                    foreach (var testedcase in testedCases)
                    {
                        var hospitalDate = testedcase.Date.ToString("dd/MM/yyyy");
                        if (hospitalDate == date)
                        {
                            var testedCount = new TestingCountModel
                            {
                                Hospital_Id = hospital.Id,
                                Hospital_Name = hospital.Hospital_Name,
                                Male_Sample_Count = testedcase.Male_Sample_Taken,
                                Female_Sample_Count = testedcase.Female_Sample_Taken,
                                Child_Sample_Count = testedcase.Children_Sample_Taken,
                                Date = date
                            };
                            hospitalTestedCases.Add(testedCount);
                        }
                    }
                    dataGridView1.DataSource = hospitalTestedCases;
                }
            }
            else
            {
                MessageBox.Show("Please give hospital name and details...");
            }
        }
    }
}
