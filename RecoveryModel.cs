using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidCaseManagement
{
    public class RecoveryModel
    {
        public int Hospital_Id { get; set; }

        public string Hospital_Name { get; set; }

        public string Date { get; set; }

        public int Male_Recovery_Count { get; set; }

        public int Female_Recovery_Count { get; set; }

        public int Child_Recovery_Count { get; set; }
    }
}
