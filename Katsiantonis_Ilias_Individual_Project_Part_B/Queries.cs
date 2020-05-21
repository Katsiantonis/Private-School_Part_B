using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class Queries
    {
        public static string connectionstring = "Data Source =localhost;Initial Catalog = PrivateSchool_DatabaseSQL; Integrated Security = SSPI;";



        public static void TotalofStudents()
        {
            List<Student> students = new List<Student>();
            string query = @"Select * from Student";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Student s = new Student(
                        Convert.ToInt32(reader["SID"]),
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        Convert.ToDateTime(reader["DateOfBirth"]),
                        Convert.ToInt32(reader["TuitionFees"])

                        );
                    students.Add(s);
                }

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t<<< Students >>>");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                foreach (var item in students)
                {
                    item.Output();

                }
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n");

            }
        }








        public static void TotalofTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();
            string query = @"Select * from Trainer";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Trainer t = new Trainer(
                        Convert.ToInt32(reader["TID"]),
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Subject"].ToString()

                        );
                    trainers.Add(t);
                }
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t<<< Trainers >>>");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                foreach (var item in trainers)
                {

                    item.Output();
                }
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n");
            }
        }






        public static void TotalofAssignments()
        {
            List<Assignment> assignments = new List<Assignment>();
            string query = @"Select * from Assignment";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Assignment a = new Assignment(
                        Convert.ToInt32(reader["AID"]),
                        reader["Title"].ToString(),
                        reader["Description"].ToString(),
                        Convert.ToDateTime(reader["SubDate"]),
                        Convert.ToInt32(reader["OralMark"]),
                        Convert.ToInt32(reader["TotalMark"])
                        );
                    assignments.Add(a);
                }
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\t<<< Assignments >>>");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                foreach (var item in assignments)
                {
                    item.Output();
                }
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n");
            }
        }







        public static void TotalofCourses()
        {
            List<Course> courses = new List<Course>();
            string query = @"Select * from Course";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Course c = new Course(
                        Convert.ToInt32(reader["CID"]),
                        reader["Title"].ToString(),
                        reader["Stream"].ToString(),
                        reader["Type"].ToString(),
                        Convert.ToDateTime(reader["StartDate"]),
                        Convert.ToDateTime(reader["EndDate"])
                        );

                    courses.Add(c);
                }
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t<<< Courses >>>");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                foreach (var item in courses)
                {
                    item.Output();
                }
                Console.WriteLine("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n");
            }
        }








        public static void TotalStudentsPerCourse()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = @"SELECT FirstName, LastName, Title, Type FROM STUDENT
                                  INNER JOIN ASSIGNMENT_PER_STUDENT_PER_COURSE ON STUDENT.SID = ASSIGNMENT_PER_STUDENT_PER_COURSE.SID 
                                  INNER JOIN COURSE ON ASSIGNMENT_PER_STUDENT_PER_COURSE.CID = COURSE.CID;";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t<<< Students per Course >>>");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                while (reader.Read())
                {
                    Console.WriteLine($" {"FirstName: " + reader[0].ToString(),-30} | {"LastName: " + reader[1].ToString(),-40} | {"Course Title: " + reader[2].ToString(),-30} | {"Course Type: " + reader[3].ToString(),-18} | ");
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }

        }









        public static void TotalTrainersPerCourse()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = @"SELECT FirstName, LastName, Subject, Title, Type FROM TRAINER 
                                 INNER JOIN TRAINER_PER_COURSE ON TRAINER.TID = TRAINER_PER_COURSE.TID 
                                 INNER JOIN COURSE ON TRAINER_PER_COURSE.CID = COURSE.CID;";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t<<< Trainers per Course >>>");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                while (reader.Read())
                {
                    Console.WriteLine($"{"FirstName: " + reader[0].ToString(),-30} | {"LastName: " + reader[1].ToString(),-40} | {"Subject: " + reader[2].ToString(),-30} | {"Course Title: " + reader[3].ToString(),-30} | {"Course Type: " + reader[4].ToString(),-25} |");
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }
        }




        public static void TotalAssignmentsPerCourse()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = @"SELECT DISTINCT ASSIGNMENT.Title, Description, COURSE.Title, COURSE.Type FROM ASSIGNMENT
                                 INNER JOIN ASSIGNMENT_PER_STUDENT_PER_COURSE ON ASSIGNMENT.AID = ASSIGNMENT_PER_STUDENT_PER_COURSE.AID 
                                 INNER JOIN COURSE ON ASSIGNMENT_PER_STUDENT_PER_COURSE.CID = COURSE.CID";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();


                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t<<< Assignments per Course  >>>");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                while (reader.Read())
                {
                    Console.WriteLine($"{"Title: " + reader[0].ToString(),-30} | {"Description: " + reader[1].ToString(),-40} | {"Course Title: " + reader[2].ToString(),-35} | {"Course Type: " + reader[3].ToString(),-25} | ");
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }
        }





        public static void TotalAssignmentsPerStudentPerCourse()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = @"SELECT DISTINCT ASSIGNMENT.Title, ASSIGNMENT.Description, COURSE.Title, COURSE.Type, STUDENT.FirstName, STUDENT.LastName FROM ASSIGNMENT 
                                 INNER JOIN ASSIGNMENT_PER_STUDENT_PER_COURSE ON ASSIGNMENT.AID = ASSIGNMENT_PER_STUDENT_PER_COURSE.AID 
                                 INNER JOIN COURSE ON ASSIGNMENT_PER_STUDENT_PER_COURSE.CID = COURSE.CID 
                                 INNER JOIN STUDENT on ASSIGNMENT_PER_STUDENT_PER_COURSE.SID = STUDENT.SID;";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t<<< Assignment per Student per Course >>>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                while (reader.Read())
                {
                    Console.WriteLine($"{"Title: " + reader[0].ToString(),-30} | {"Description: " + reader[1].ToString(),-35} | {"Course Title: " + reader[2].ToString(),-30} | {"Course Type: " + reader[3].ToString(),-25} | {"FirstName: " + reader[4].ToString(),-30} | {"LastName: " + reader[5].ToString(),-35} |");
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }
        }








        public static void TotalofStudentsWithMultipleCourses()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = @"select DISTINCT STUDENT.SID, FirstName, LastName, DateOfBirth from STUDENT
                                 INNER JOIN ASSIGNMENT_PER_STUDENT_PER_COURSE ON STUDENT.SID = ASSIGNMENT_PER_STUDENT_PER_COURSE.SID 
                                 INNER JOIN COURSE ON ASSIGNMENT_PER_STUDENT_PER_COURSE.CID = COURSE.CID 
                                 GROUP BY FirstName, LastName, STUDENT.SID, DateOfBirth 
                                 HAVING COUNT(DISTINCT ASSIGNMENT_PER_STUDENT_PER_COURSE.CID) > 1;";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t<<< STUDENTS WHO OWE MORE THAN ONE COURSES >>> \n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                while (reader.Read())
                {
                    Console.WriteLine($"{"SID: " + reader[0].ToString(),-15} | {"FirstName: " + reader[1].ToString(),-30} | {"LastName: " + reader[2].ToString(),-35} | {"Date Of Birth: " + reader[3].ToString(),-40} |");
                }
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }
        }
    }
}
