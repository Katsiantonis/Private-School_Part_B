using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu.RunMenu();

            Queries.TotalofStudents();
            Queries.TotalofTrainers();
            Queries.TotalofAssignments();
            Queries.TotalofCourses();
            Queries.TotalStudentsPerCourse();
            Queries.TotalTrainersPerCourse();
            Queries.TotalAssignmentsPerCourse();
            Queries.TotalAssignmentsPerStudentPerCourse();
            Queries.TotalofStudentsWithMultipleCourses();           

            Console.ReadKey();
        }
    }
}
