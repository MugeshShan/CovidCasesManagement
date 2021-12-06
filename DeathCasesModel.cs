using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidCaseManagement
{
    public class DeathCasesModel
    {
        public int Hospital_Id { get; set; }

        public string Hospital_Name { get; set; }

        public string Date { get; set; }

        public int Male_Death_Count { get; set; }

        public int Female_Death_Count { get; set; }

        public int Child_Death_Count { get; set; }
    }
}
