using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace project
{
    class Customer
    {
        public static void CustomerMenu()
        {
            while (true)
            {
                Console.WriteLine("____________________________________");
                Console.WriteLine("Customer Options:");
                Console.WriteLine("PRESS 1 TO DISPLAY AVAILABLE TRAINSS");
                Console.WriteLine("PRESS 2 FOR Book Ticket");
                Console.WriteLine("PRESS 3 . FOR View Booking Details");
                Console.WriteLine("PRESS 4. FOR Cancel Ticket");
                Console.WriteLine("PRESS 5. FOR  Exit");
                Console.WriteLine("____________________________________");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("____________________________________");


                switch (choice)
                {
                    case 1:
                        availableTrains();
                        break;

                    case 2:
                        BookTicket();
                        break;
                    case 3:
                        ViewBookingDetails();
                        break;
                    case 4:
                        CancelTicket();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }

        private static void BookTicket()
        {
            Console.WriteLine("____________________________________");

            Console.Write("Enter Source: ");
            string source = Console.ReadLine();
            Console.Write("Enter Destination: ");
            string destination = Console.ReadLine();
            Console.WriteLine("enter date (YYYY-MM-DD)");
            DateTime dateofTrain = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Number of Tickets: ");
            int ticketsNeeded = int.Parse(Console.ReadLine());
            Console.WriteLine("____________________________________");


            // Query for matching trains
            string query = "SELECT TrainNumber, TrainName FROM Trains WHERE Source = @Source AND Destination = @Destination AND IsDeleted = 0 AND dateofTrain=@dateofTrain";
            Console.WriteLine("\nAvailable Trains:");

            using (var con = DatabaseHelper.GetConnection())
            {
                using (var cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@Source", source);
                    cmd.Parameters.AddWithValue("@Destination", destination);
                    cmd.Parameters.AddWithValue("@dateofTrain", dateofTrain);
                    bool hastrain = false;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hastrain = true;
                            Console.WriteLine("Train number : {0}  ,Train Name : {1},", reader["TrainNumber"], reader["TrainName"]);
                        }
                    }
                    if(!hastrain)
                    {
                        Console.WriteLine("NO TRAINS AVAILABLE FOR THE SELECTED ROUTE");
                        return;
                    }

                            


                }



                Console.Write("Enter Train Number to Book: ");
                int trainNumber = int.Parse(Console.ReadLine());

                // Query for classes
                query = "SELECT Class, AvailableSeats, PricePerTicket FROM Classes WHERE TrainNumber = @TrainNumber";
                Console.WriteLine("\nAvailable Classes:");



                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    bool hasclass = false;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hasclass = true;
                            Console.WriteLine($"Class: {reader["Class"]}, Available Seats: {reader["AvailableSeats"]}, Price: {reader["PricePerTicket"]}");

                        }

                    }
                    if(!hasclass)
                    {
                        Console.WriteLine("____________________________________________");

                        Console.WriteLine("NO AVAILABLE CLASSES FOR THE SELECTED TRAIN");
                        Console.WriteLine("____________________________________________");

                        return;
                    }
                }
            

                Console.Write("Enter Class (1st Class, 2nd Class, Sleeper): ");
               string selectedClass = Console.ReadLine();
               //Console.Write("Enter Number of Tickets: ");
               //int ticketsNeeded = int.Parse(Console.ReadLine());

            // Check availability and price
               query = "SELECT AvailableSeats, PricePerTicket FROM Classes WHERE TrainNumber = @TrainNumber AND Class = @Class";
              int availableSeats = 0;
              decimal pricePerTicket = 0;



                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    cmd.Parameters.AddWithValue("@Class", selectedClass);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            availableSeats = (int)reader["AvailableSeats"];
                            pricePerTicket = (decimal)reader["PricePerTicket"];


                        }
                        if (ticketsNeeded > availableSeats)
                        {
                            Console.WriteLine("Not enough seats available!");
                            return;
                        }

                        decimal totalPrice = ticketsNeeded * pricePerTicket;
                        reader.Close();

                        for (int i = 0; i < ticketsNeeded; i++)
                        {
                            Console.Write($"Enter Name for Passenger {i + 1}: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Age: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Gender: ");
                            string gender = Console.ReadLine();
                            string insertQuery = "INSERT INTO Customers (Name, Age, Gender, TrainNumber, Class, SeatsBooked, totalPrice) " +
                                                 "VALUES (@Name, @Age, @Gender, @TrainNumber, @Class, @SeatsBooked, @pricePerTicket)";

                           
                            using (SqlConnection connection = DatabaseHelper.GetConnection())
                            using (var inserCmd = new SqlCommand(insertQuery, con))
                            {
                                inserCmd.Parameters.AddWithValue("@Name", name);
                                inserCmd.Parameters.AddWithValue("@Age", age);
                                inserCmd.Parameters.AddWithValue("@Gender", gender);
                                inserCmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                                inserCmd.Parameters.AddWithValue("@Class", selectedClass);
                                inserCmd.Parameters.AddWithValue("@SeatsBooked", ticketsNeeded);
                                inserCmd.Parameters.AddWithValue("@pricePerTicket", pricePerTicket);

                                connection.Close();
                                
                                inserCmd.ExecuteNonQuery();

                              
                                }

                           


                        }

                        // Update available seats
                        string updateQuery = "UPDATE Classes SET AvailableSeats = AvailableSeats - @TicketsNeeded WHERE TrainNumber = @TrainNumber AND Class = @Class";
                        using (SqlConnection connection = DatabaseHelper.GetConnection())

                        using (var updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@TicketsNeeded", ticketsNeeded);
                            updateCmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                            updateCmd.Parameters.AddWithValue("@Class", selectedClass);
                            connection.Close();
                            connection.Open();

                            updateCmd.ExecuteNonQuery();


                        }
                        

                        Console.WriteLine($"\nBooking Confirmed! Total Price: {totalPrice:C}");
                        Console.WriteLine("the number of tickets bookes {0}", ticketsNeeded);
                    }
                
                Console.WriteLine();

            }


        
    }

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {

               
                    

                    using (var selectCmd = new SqlCommand("GET_CUSTOMERDETAILS", con))
                    {
                        selectCmd.Parameters.AddWithValue("@ticketsNeeded", ticketsNeeded);
                        selectCmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = selectCmd.ExecuteReader();
                        while (reader.Read())
                        {
                        Console.WriteLine("______________________________________________________");

                        Console.WriteLine("CustomerID |\tName |\tAge |\tGender|\ttrain|\tclass");
                        Console.WriteLine($"{reader["CustomerID"]}      |{reader["Name"]}       |{reader["Age"]}    |{reader["Gender"]} |{reader["TrainNumber"]}    |{reader["Class"]}");

                            Console.WriteLine("___________________________________________________");
                        }





                    }
                
                }

            


        }

        private static void ViewBookingDetails()
        {
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            string query = @"SELECT C.Name, C.Age, C.Gender, T.TrainName, C.Class, C.SeatsBooked, C.TotalPrice 
                         FROM Customers C
                         JOIN Trains T ON C.TrainNumber = T.TrainNumber
                         WHERE C.CustomerID = @CustomerID";

            using (var con = DatabaseHelper.GetConnection())
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Console.WriteLine($"\nName: {reader["Name"]}, Age: {reader["Age"]}, Gender: {reader["Gender"]}");
                            Console.WriteLine($"Train: {reader["TrainName"]}, Class: {reader["Class"]}");
                            Console.WriteLine($"Seats Booked: {reader["SeatsBooked"]}, Total Price: {reader["TotalPrice"]:C}");
                        }
                        else
                        {
                            Console.WriteLine("____________________________________");

                            Console.WriteLine("No booking found for the given Customer ID.");
                            Console.WriteLine("____________________________________");

                        }

                    }
                }
                   
            }
        }

        private static void CancelTicket()
        {
            Console.WriteLine("how many tickets want to cancel");
            int cal_tic = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < cal_tic; i++)
            {


              
                Console.Write("Enter Customer ID: ");
                int customerId = int.Parse(Console.ReadLine());
                string select_query = "SELECT TrainNumber,Class from customers where customerid = @customerid";
                int trainnumber = 0;
                string ticketclass = string.Empty;



                using (var con = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand(select_query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                trainnumber = (int)reader["trainnumber"];
                                ticketclass = (string)reader["Class"];
                            }
                            else
                            {
                                Console.WriteLine("customer id not fount...");
                                    continue;
                            }
                        }
                    }
                    string deleteQuery = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                    using (var cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);
                        cmd.ExecuteNonQuery();
                    }

                    string update_query = "UPDATE CLASSES SET AVAILABLESEATS =AVAILABLESEATS+1 WHERE trainnumber=@trainnumber and Class =@Class";
                    {
                        using (var cmd = new SqlCommand(update_query, con))
                        {

                            cmd.Parameters.AddWithValue("@trainnumber", trainnumber);
                            cmd.Parameters.AddWithValue("@Class", ticketclass);

                            cmd.ExecuteNonQuery();
                        }




                    }

                    Console.WriteLine("_______________________________________________");

                    Console.WriteLine($"Booking Cancelled for customer id {customerId}. ");
                    Console.WriteLine("_______________________________________________");



                }
            }
            Console.WriteLine("all requested tickets have been  Cancelled. Refund will be processed within 3 working days.");


        }

        private static void availableTrains()
         {
            using (SqlConnection con= DatabaseHelper.GetConnection())
            {
                using (var updateCmd = new SqlCommand("Get_availableTrains", con))
                {
                    updateCmd.CommandType = CommandType.StoredProcedure;
                    //updateCmd.ExecuteNonQuery();
                    //updateCmd.ExecuteScalar();


                    Console.WriteLine("TrainNumber |\tTrainName |\tSource |\tDestination|\tdateofTrain");
                    SqlDataReader reader = updateCmd.ExecuteReader();
                    while (reader.Read())
                    {

                        Console.WriteLine($"{reader["TrainNumber"]}  |{reader["TrainName"]}     |{reader["Source"]}    |{reader["Destination"]} |{reader["dateofTrain"]}");

                        Console.WriteLine("________________________________________________________________________");
                    }
                }
            }





        }
        //Console.WriteLine("Train number : {0}  ,Train Name : {1},", reader["TrainNumber"], reader["TrainName"]);

    }
}


