using ScMaSy_ice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScMaSy_ice.Models
{
    public class Dashboard : dbConnection
    {
        // Fields && Proprieties
        public int NumberOfStudents { get; private set; }
        public int NumberOfPrimaryStudents { get; private set; }
        public int NumberOfMiddleSchoolStudents { get; private set; } // Collège
        public int NumberOfHighSchoolStudents { get ; private set; } // Lycée
        public int NumberOfTeacher { get ; private set; }
        public Decimal TotalIncome { get ; private set; }
        public Dashboard()
        {

        }

        public void GetNumberItems()
        {

        }
    }
}
