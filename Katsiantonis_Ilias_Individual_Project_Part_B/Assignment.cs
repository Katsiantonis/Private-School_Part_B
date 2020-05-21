using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class Assignment
    {
        //Δημιουργώ τα properties του assignment
        public int AID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? SubDate { get; set; }

        public double? OralMark { get; set; }

        public double? TotalMark { get; set; }



        //Δημιουργώ τον constructor του assignment
        public Assignment(int AID, string Title, string Description, DateTime SubDate, int OralMark, int TotalMark)
        {
            this.AID = AID;
            this.Title = Title;
            this.Description = Description;
            this.SubDate = SubDate;
            this.OralMark = OralMark;
            this.TotalMark = TotalMark;
        }


        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά του assignment
        public void Output()
        {
            Console.WriteLine($" AID: {AID,-10} |  Title:  {Title,-25}  |  Description: {Description,-34} | Submission Date: {SubDate,-32}  | Oral Mark: {OralMark,-8} % | Total Mark: {TotalMark,-8} % |");
        }
    }
}