using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidCaseManagement
{
    public class ConfirmedCasesModel
    {
        public int Hospital_Id { get; set; }

        public string Hospital_Name { get; set; }

        public string Date { get; set; }

        public int Male_Confirmed_Count { get; set; }

        public int Female_Confirmed_Count { get; set; }

        public int Child_Confirmed_Count { get; set; }
    }
}
