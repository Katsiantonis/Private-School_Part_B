using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class Course
    {
        //Δημιουργώ τα properties του course
        public int CID { get; set; }

        public string Title { get; set; }

        public string Stream { get; set; }

        public string Type { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }



        //Δημιουργώ τον constructor του course
        public Course(int CID, string Title, string Stream, string Type, DateTime? StartDate, DateTime? EndDate)
        {
            this.CID = CID;
            this.Title = Title;
            this.Stream = Stream;
            this.Type = Type;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }


        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά του course
        public void Output()
        {
            Console.WriteLine($"  CID: {CID,-10} | Title:  {Title,-25}  |  Stream: {Stream,-37}   | Τype: {Type,-12} |");
        }
    }
}
