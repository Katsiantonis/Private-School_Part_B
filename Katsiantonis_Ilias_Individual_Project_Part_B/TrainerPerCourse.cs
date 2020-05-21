using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class TrainerPerCourse
    {
        public int TID { get; set; }
        public int CID { get; set; }

        public TrainerPerCourse() { }
        public TrainerPerCourse(int TID, int CID)
        {
            this.TID = TID;
            this.CID = CID;
        }
    }
}