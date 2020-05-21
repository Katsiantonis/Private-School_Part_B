using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class Menu
    {
        public static void RunMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t   WELCOME TO OUR AMAZING PRIVATE SCHOOL ");
            Console.WriteLine("  \t\t\t\t\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine(" \t\t\t\t\t\t\t\t  <<<      S.U.P.E.R.H.E.R.O.E.S      >>>\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.White;

            string answer = "";
            do
            {
                Console.WriteLine("\t\t\t\t\t\t\tPlease choose a number to decide what will be your next step:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\t\t\t\t\t\tPress 0 to exit\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\t\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t\t\t\t\t\t\tPress 1 to insert a student\n");
                Console.Write("\t\t\t\t\t\t\tPress 2 to insert a trainer\n");
                Console.Write("\t\t\t\t\t\t\tPress 3 to insert an assignment\n");
                Console.Write("\t\t\t\t\t\t\tPress 4 to insert a course\n");
                Console.Write("\t\t\t\t\t\t\tPress 5 to insert a student in a course\n");
                Console.Write("\t\t\t\t\t\t\tPress 6 to insert a trainer in a course\n");
                Console.Write("\t\t\t\t\t\t\tPress 7 to insert an assignment in a student and in a course\n");
                Console.Write("\t\t\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\t\t\t\t\t\tPress 8 to see all the tables\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                answer = Console.ReadLine();


                if (answer == "0")
                {
                    Environment.Exit(0);
                }

                else if (answer == "1")
                {
                    InsertMethods.StudentInsertion();
                    Queries.TotalofStudents();
                }
                else if (answer == "2")
                {
                    InsertMethods.TrainerInsertion();
                    Queries.TotalofTrainers();
                }
                else if (answer == "3")
                {
                    InsertMethods.AssignmentInsertion();
                    Queries.TotalofAssignments();
                }
                else if (answer == "4")
                {
                    InsertMethods.CourseInsertion();
                    Queries.TotalofCourses();
                }
                else if (answer == "5")
                {
                    InsertMethods.StudentPerCourseInsertion();
                    Queries.TotalStudentsPerCourse();
                }
                else if (answer == "6")
                {
                    InsertMethods.TrainerPerCourseInsertion();
                    Queries.TotalTrainersPerCourse();
                }
                else if (answer == "7")
                {
                    InsertMethods.AssignmentPerStudentPerCourseInsertion();
                    Queries.TotalAssignmentsPerStudentPerCourse();
                }
                else if (answer == "8")
                {
                    Queries.TotalofStudents();
                    Queries.TotalofTrainers();
                    Queries.TotalofAssignments();
                    Queries.TotalofCourses();
                    Queries.TotalStudentsPerCourse();
                    Queries.TotalTrainersPerCourse();
                    Queries.TotalAssignmentsPerCourse();
                    Queries.TotalAssignmentsPerStudentPerCourse();
                    Queries.TotalofStudentsWithMultipleCourses();
                }
            } while (answer != "" || answer != null);
        }
    }
}