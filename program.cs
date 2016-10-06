using System;
using System.Collections.Generic;
using ConsoleWithDb;

namespace myusers
{
    public class program
    {
        public static void Main()
        {
            Create();
            Delete();
            Update();
        }
    

        // Create Method
        public static void Create()
        {
                Console.WriteLine("New Person is going to be Created");
                Console.Write("user's first name: ");
                string FirstName = Console.ReadLine();
                Console.Write("user's last name: ");
                string LastName = Console.ReadLine();
                Console.Write("User's Fav Number");
                string Favourite_Number = Console.ReadLine();
                int Fav_Number = Int32.Parse(Favourite_Number); // Converting into integer 
                string query = $"INSERT INTO users (FirstName, LastName, FavouriteNumber) VALUES('{FirstName}', '{LastName}', '{Fav_Number}')";
                DbConnector.ExecuteQuery(query);
        }

        // Delete Function
        public static void Delete()
        {
            Console.WriteLine("Enter the Id of the person whom do you want to delete");
            string userId = Console.ReadLine();
            int user_id = Int32.Parse(userId);
            string query = $"DELETE FROM users WHERE id = {user_id}";
            DbConnector.ExecuteQuery(query);
        }

        //Update Rows
        public static void Update()
        {
            Console.WriteLine("What is the Id of the user that you want to edit");
            string userId = Console.ReadLine();
            int user_id = Int32.Parse(userId);
            Console.WriteLine("Users new First name");
            string First_Name = Console.ReadLine();
            Console.WriteLine("Users new Lastname");
            string Last_Name = Console.ReadLine();
            Console.WriteLine("user's new favourite number");
            string fav_num = Console.ReadLine();
            int favourite_number = Int32.Parse(fav_num);
            string query = $"UPDATE users SET FirstName = '{First_Name}',LastName = '{Last_Name}', FavouriteNumber = '{fav_num}' WHERE id = {user_id}";
            DbConnector.ExecuteQuery(query);
        }
    }
}