using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class AssignmentPerStudentPerCourse
    {
        public int CID { get; set; }
        public int AID { get; set; }
        public int SID { get; set; }

        public AssignmentPerStudentPerCourse()
        {
        }
        public AssignmentPerStudentPerCourse(int CID, int AID, int SID)
        {
            this.CID = CID;
            this.AID = AID;
            this.SID = SID;
        }

    }
}