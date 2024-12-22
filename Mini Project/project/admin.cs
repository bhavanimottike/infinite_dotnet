using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project
{
    class Admin
    {
        public static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("____________________________________");

                Console.WriteLine("Admin Options:");
                Console.WriteLine("ENETER 1 FOR  Add Train");
                Console.WriteLine("ENTER 2 FOR Delete Train");
                Console.WriteLine("ENTER 3 FOR Modify Train");
                Console.WriteLine("ENTER 4 FOR Exit....BACK TO MENU");
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("____________________________________");

                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("____________________________________");


                switch (choice)
                {
                    case 1:
                        AddTrain();
                        break;
                    case 2:
                        DeleteTrain();
                        break;
                    case 3:
                        ModifyTrain();
                        break;
                    case 4:

                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private static void AddTrain()
        {
            Console.WriteLine("____________________________________");

            Console.Write("Enter Train Number: ");
            int trainNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Train Name: ");
            string trainName = Console.ReadLine();
            Console.Write("Enter Source: ");
            string source = Console.ReadLine();
            Console.Write("Enter Destination: ");
            string destination = Console.ReadLine();
            Console.WriteLine("enter date (YYYY-MM-DD)");
            DateTime dateofTrain = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("____________________________________");





            string query = "INSERT INTO Trains (TrainNumber, TrainName, Source, Destination,dateofTrain) " +
               "VALUES (@TrainNumber, @TrainName, @Source, @Destination,@dateofTrain)";
            try
            {
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    cmd.Parameters.AddWithValue("@TrainName", trainName);
                    cmd.Parameters.AddWithValue("@Source", source);
                    cmd.Parameters.AddWithValue("@Destination", destination);
                    cmd.Parameters.AddWithValue("@dateofTrain", dateofTrain);
                    connection.Close();
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(SqlException EX)
            {
                Console.WriteLine("ERROR OCCURED:{0}", EX.Message);
                return;

            }

           
            //Console.Write("Enter AvailableSeats: ");
            //int AvailableSeats = int.Parse(Console.ReadLine());
            //Console.Write("Enter PricePerTicket: ");
            //decimal PricePerTicket = decimal.Parse(Console.ReadLine());

            query = "INSERT INTO classes (TrainNumber, Class,AvailableSeats, PricePerTicket) " +
              "VALUES (@TrainNumber, @Class, @AvailableSeats, @PricePerTicket)";

            Console.WriteLine("enter no of classes,maximum 3");
            int numofclasses = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numofclasses; i++) 
            {
                Console.WriteLine("Enter Train Class: (1st class ,2nd class, sleeper are available)");
                string Class = Console.ReadLine();
                Console.WriteLine("Enter AvailableSeats: ");
                int AvailableSeats = int.Parse(Console.ReadLine());
                Console.Write("Enter PricePerTicket: ");
                decimal PricePerTicket = decimal.Parse(Console.ReadLine());
              
                using (SqlConnection connection = DatabaseHelper.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    cmd.Parameters.AddWithValue("@Class", Class);
                    cmd.Parameters.AddWithValue("@AvailableSeats", AvailableSeats);
                    cmd.Parameters.AddWithValue("@PricePerTicket", PricePerTicket);
                    connection.Close();
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            Console.WriteLine("___________________________");

            Console.WriteLine("Train added successfully.");
            Console.WriteLine("_____________________________");

        }

        private static void DeleteTrain()
        {
            Console.WriteLine("____________________________________");

            Console.WriteLine("Enter Train Number or Train Name to delete: ");
            Console.WriteLine("____________________________________");

            string input = Console.ReadLine();
            string query = "UPDATE Trains SET IsDeleted = 1 WHERE TrainNumber = @Input OR TrainName = @Input ";

            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {




                cmd.Parameters.AddWithValue("@Input", input);
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
            }




            Console.WriteLine("_________________________________");

            Console.WriteLine("Train soft-deleted successfully.");
            Console.WriteLine("_________________________________");

        }

        private static void ModifyTrain()
        {
            Console.Write("Enter Train Number to modify: ");
            int trainNumber = int.Parse(Console.ReadLine());


            Console.WriteLine("What would you like to modify? enter number to choose");
            Console.WriteLine("____________________________________");
            Console.WriteLine("PRESS 1 TO   MODIFY  NAME");
            Console.WriteLine("PRESS 2 TO MODIFY Source");
            Console.WriteLine("PRESS 3 TO MODIFY DESTINATION");
            Console.WriteLine("PRESS 4 TO MODIFY DATE OF TRAIN");
            Console.WriteLine("Enter your choice: ");
            Console.WriteLine("____________________________________");

            int choice = int.Parse(Console.ReadLine());

            string query = "";
            string column = "";
            switch (choice)
            {
                case 1:
                    column = "TrainName";
                    break;
                case 2:
                    column = "Source";
                    break;
                case 3:
                    column = "Destination";
                    break;
                case 4:
                    column="dateofTrain";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.Write($"Enter new value for {column}: ");
            string newValue = Console.ReadLine();

            query = $"UPDATE Trains SET {column} = @NewValue WHERE TrainNumber = @TrainNumber";
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {




                cmd.Parameters.AddWithValue("@NewValue",newValue);
                cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("____________________________________");
            Console.WriteLine("Train details updated successfully.");
            Console.WriteLine("____________________________________");

        }
         
    }
    
}

