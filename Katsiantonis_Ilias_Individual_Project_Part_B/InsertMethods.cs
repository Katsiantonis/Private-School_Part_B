using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class InsertMethods
    {
        public static string connectionstring = "Data Source =localhost;Initial Catalog = PrivateSchool_DatabaseSQL; Integrated Security = SSPI;";




        // ----------StudentInsertion----------
        public static void StudentInsertion()
        {


            Console.Write("  Enter First Name:  ");
            string FirstName = Console.ReadLine();
            Console.Write("  Enter Lastname:  ");
            string LastName = Console.ReadLine();
            Console.Write("  In a form like this (year, month, day), e.g. 2006-04-22 \n" +
                          "  Enter your Date of Birth:  ");
            DateTime DateofBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("  Enter Tuition Fees:  ");
            int TuitionFees = Convert.ToInt32(Console.ReadLine());

            InsertMethods.Insertstudent(FirstName, LastName, DateofBirth, TuitionFees);


        }


        public static void Insertstudent(string fn, string Sn, DateTime bd, int tf)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO STUDENT (FirstName, LastName, DateOfBirth,TuitionFees) VALUES(@FirstName, @LastName, @DateOfBirth, @TuitionFees)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@FirstName", fn);
            cmd.Parameters.AddWithValue("@LastName", Sn);
            cmd.Parameters.AddWithValue("@DateOfBirth", bd);
            cmd.Parameters.AddWithValue("@TuitionFees", tf);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n  The entry was Successful");
                Console.WriteLine("  Press Enter to see the table with the Students");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR. Something went wrong" + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

        // ----------TrainerInsertion----------
        public static void TrainerInsertion()
        {
            Console.Write("\n\n\n  Enter trainer's first name:  ");
            string FirstName = Console.ReadLine();
            Console.Write("  Enter trainer's last name:  ");
            string LastName = Console.ReadLine();
            Console.Write("  Enter trainer's Subject:  ");
            string Subject = Console.ReadLine();

            InsertMethods.InsertsTrainer(FirstName, LastName, Subject);
        }

        public static void InsertsTrainer(string fn, string Sn, string su)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO TRAINER (FirstName, LastName, Subject) VALUES(@FirstName, @LastName, @Subject)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@FirstName", fn);
            cmd.Parameters.AddWithValue("@LastName", Sn);
            cmd.Parameters.AddWithValue("@Subject", su);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n  The entry was Successful");
                Console.WriteLine("  Press Enter to see the table with the Trainers\n\n");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR. Something went wrong" + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

        // ----------AssignmentInsertion----------
        public static void AssignmentInsertion()
        {
            Console.Write("\n\n\n  Enter Assigment Title:  ");
            string Title = Console.ReadLine();
            Console.Write("  Enter Assigment description:  ");
            string Description = Console.ReadLine();
            Console.Write("  In a form like this (year, month, day), e.g. 2006-04-22 \n" +
                          "  Enter Assignment Date:  ");
            DateTime SubDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("  Enter an Oral Mark Points from 0 to 100:  ");
            int OralMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("  Enter the Total Mark Points:  ");
            int TotalMark = Convert.ToInt32(Console.ReadLine());

            InsertMethods.InsertAssignment(Title, Description, SubDate, OralMark, TotalMark);
        }

        public static void InsertAssignment(string ti, string de, DateTime sd, int om, int tm)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO ASSIGNMENT (Title, Description, SubDate, OralMark, TotalMark) VALUES(@Title, @Description, @SubDate, @OralMark, @TotalMark)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Title", ti);
            cmd.Parameters.AddWithValue("@Description", de);
            cmd.Parameters.AddWithValue("@SubDate", sd);
            cmd.Parameters.AddWithValue("@OralMark", om);
            cmd.Parameters.AddWithValue("@TotalMark", tm);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n  The entry was Successful");
                Console.WriteLine("  Press Enter to see the table with the Assignments\n\n");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR. Something went wrong" + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

        // ----------CourseInsertion----------
        public static void CourseInsertion()
        {
            Console.Write("\n\n\n  Enter Course Title (etc C# Sharp,Java or JavaScript):  ");
            string Title = Console.ReadLine();
            Console.Write("  Enter Course Stream:  ");
            string Stream = Console.ReadLine();
            Console.Write("  Enter Course type (etc Full Time or Part Time):  ");
            string Type = Console.ReadLine();
            Console.Write("  In a form like this (year, month, day), e.g. 2006-04-22 \n" +
                          "  Enter Start Date of the Course:  ");
            DateTime StartDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("  Enter End Date of the Course:  ");
            DateTime EndDate = Convert.ToDateTime(Console.ReadLine());


            InsertMethods.InsertCourse(Title, Stream, Type, StartDate, EndDate);
        }

        public static void InsertCourse(string ti, string st, string ty, DateTime sd, DateTime ed)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO COURSE (Title, Stream, Type, StartDate, EndDate) VALUES(@Title, @Stream, @Type, @StartDate, @EndDate)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Title", ti);
            cmd.Parameters.AddWithValue("@Stream", st);
            cmd.Parameters.AddWithValue("@Type", ty);
            cmd.Parameters.AddWithValue("@StartDate", sd);
            cmd.Parameters.AddWithValue("@EndDate", ed);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n  The entry was Successful");
                Console.WriteLine("  Press Enter to see the table with the Courses\n\n");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR. Something went wrong" + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

        // ----------StudentPerCourseInsertion----------
        public static void StudentPerCourseInsertion()
        {

            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofStudents();
            Console.WriteLine("\n\nCheck from the table above the SID's from all students");
            Console.WriteLine("Enter the SID of your choice");
            int SID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofCourses();
            Console.WriteLine("\n\nCheck from the table above the CID's from all courses");
            Console.WriteLine("Enter the CID of your choice");
            int CID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofAssignments();
            Console.WriteLine("\n\nCheck from the table above the AID's from all assignments");
            Console.WriteLine("Enter the AID of your choice");
            int AID = Convert.ToInt32(Console.ReadLine());

            InsertMethods.InsertstudentCourse(SID, CID, AID);
        }

        public static void InsertstudentCourse(int studentid, int courseid, int assignmentid)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO ASSIGNMENT_PER_STUDENT_PER_COURSE (SID, CID, AID) VALUES(@SID, @CID, @AID)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@SID", studentid);
            cmd.Parameters.AddWithValue("@CID", courseid);
            cmd.Parameters.AddWithValue("@AID", assignmentid);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n  The entry was Successful");
                Console.WriteLine("  Press Enter to see the table with the Students per Course\n\n");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR. Something went wrong" + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

        // ----------TrainerPerCourseInsertion----------
        public static void TrainerPerCourseInsertion()
        {
            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofTrainers();
            Console.WriteLine("\n\nCheck from the table above the TID's from all trainers");
            Console.WriteLine("Enter the TID of your choice");
            int TID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofCourses();
            Console.WriteLine("\n\nCheck from the table above the CID's from all courses");
            Console.WriteLine("Enter the CID of your choice");
            int CID = Convert.ToInt32(Console.ReadLine());

            InsertMethods.InsertTrainerCourse(TID, CID);
        }

        public static void InsertTrainerCourse(int trainerid, int courseid)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO TRAINER_PER_COURSE (TID, CID) VALUES(@TID, @CID)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@TID", trainerid);
            cmd.Parameters.AddWithValue("@CID", courseid);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n  The entry was Successful");
                Console.WriteLine("  Press Enter to see the table with the Trainers per Course\n\n");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR. Something went wrong" + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }

        // ----------StudentPerCourseInsertion----------
        public static void AssignmentPerStudentPerCourseInsertion()
        {
            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofAssignments();
            Console.WriteLine("\n\nCheck from the table above the AID's from all assignments");
            Console.WriteLine("Enter the AID of your choice");
            int AID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofStudents();
            Console.WriteLine("\n\nCheck from the table above the SID's from all students");
            Console.WriteLine("Enter the SID of your choice");
            int SID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\n\n\n");
            Queries.TotalofCourses();
            Console.WriteLine("\n\nCheck from the table above the CID's from all courses");
            Console.WriteLine("Enter the CID of your choice");
            int CID = Convert.ToInt32(Console.ReadLine());

            InsertMethods.InsertstudentCourse(AID, SID, CID);
        }

        public static void InsertAssignmentPerstudentCourse(int assignmentid, int studentid, int courseid)
        {
            SqlConnection con = new SqlConnection(connectionstring);

            string query = "INSERT INTO ASSIGNMENT_PER_STUDENT_PER_COURSE (AID, SID, CID) VALUES(@AID, @SID, @CID)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@AID", assignmentid);
            cmd.Parameters.AddWithValue("@SID", studentid);
            cmd.Parameters.AddWithValue("@CID", courseid);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n  The entry was Successful");
                Console.WriteLine("  Press Enter to see the table with the Assignments per Student per Course\n\n");
            }
            catch (SqlException e)
            {
                Console.WriteLine("ERROR. Something went wrong" + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}
