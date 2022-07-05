using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Address_Book_MultiThreading
{
    public class Address_Book_System_Controller
    {
        public static string connectionString = "Data Source = DESKTOP-VMLSH89\\SQLEXPRESS;Database = Address_Book_Service;Trusted_Connection=true";
        public List<Book_Definition_Model> contacts = new List<Book_Definition_Model>();
        public void addNewContact(List<Book_Definition_Model> contact)
        {
            foreach(Book_Definition_Model book_Definition_Model in contact)
            {
                this.createNewRecord(book_Definition_Model);
                Console.WriteLine("Person added:" + book_Definition_Model.FirstName);
            }
        }
        public void addNewContactWithMultiThreading(List<Book_Definition_Model> contact)
        {
            foreach (Book_Definition_Model book_Definition_Model in contact)
            {
                Task thread = new Task(() =>
                {
                    this.createNewRecord(book_Definition_Model);
                    Console.WriteLine("Person added : " + book_Definition_Model.FirstName);
                });
            }
        }
        public void createNewRecord(Book_Definition_Model contact)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            lock(this)
            {
                using(connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("StoreProcedureAddressBook", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                    command.Parameters.AddWithValue("@LastName", contact.LastName);
                    command.Parameters.AddWithValue("@Address", contact.Address);
                    command.Parameters.AddWithValue("@City", contact.City);
                    command.Parameters.AddWithValue("@State", contact.State);
                    command.Parameters.AddWithValue("@Zip", contact.Zip);
                    command.Parameters.AddWithValue("@Phone_no", contact.Phone_no);
                    command.Parameters.AddWithValue("@Email", contact.Email);
                    command.Parameters.AddWithValue("@name", contact.name);
                    command.Parameters.AddWithValue("@Type", contact.Persontype);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Records are created successfully.");
                    connection.Close();
                }
            }
        }
    }
}
