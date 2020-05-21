using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsiantonis_Ilias_Individual_Project_Part_B
{
    class Trainer
    {
        //Δημιουργώ τα properties του trainer
        public int TID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Subject { get; set; }


        //Δημιουργώ τον constructor του trainer
        public Trainer(int TID, string FirstName, string LastName, string Subject)
        {
            this.TID = TID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Subject = Subject;
        }


        //Δημιουργώ μέσω μεθόδου, τη συμπεριφορά του trainer
        public void Output()
        {
            Console.WriteLine($" TID: {TID,-10} |  Name:   {FirstName,-25}  |  Surname:    {LastName,-35} |  Subject:   {Subject,-37}  |");
        }
    }
}

