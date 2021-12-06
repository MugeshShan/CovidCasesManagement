using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidCaseManagement
{
    public class TestingCountModel
    {
        public int Hospital_Id { get; set; }

        public string Hospital_Name { get; set; }

        public string Date { get; set; }

        public int Male_Sample_Count { get; set; }

        public int Female_Sample_Count { get; set; }

        public int Child_Sample_Count { get; set; }
    }
}
