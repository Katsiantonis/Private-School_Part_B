using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class Student
    {
        //Δημιουργώ τα properties του student
        public int SID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public double? TuitionFees { get; set; }






        //Δημιουργώ τον constructor του student
        public Student(int SID, string FirstName, string LastName, DateTime DateOfBirth, double? TuitionFees)
        {
            this.SID = SID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.TuitionFees = TuitionFees;



        }
        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά του student
        public void Output()
        {
            Console.WriteLine($"  SID: {SID,-10} | Name:   {FirstName,-25}  |  Surname:    {LastName,-35} |  Date of Birth:    {DateOfBirth,-30}  | Tuition Fees:    {TuitionFees,-5} $ |");
        }
    }
}