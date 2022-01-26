using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ContactRecord
{
    public class ContactRepository
    {
        MySqlConnection conn;
        public static List<ContactEntity> Students = new List<ContactEntity>();
        public ContactRepository(MySqlConnection connection)
        {
            conn = connection;
        }
        public bool AddContactInfo(int id, string name, string phoneNo, string eMail, string officeAddress)
        {
            try
            {
                conn.Open();
                string addContactInfo = "Insert into contactInformation (id, name, phoneNo, eMail, officeAddress)values ('" + id + "', '" + name + "', '" + phoneNo + "', '" + eMail + "', '" + officeAddress + "')";
                MySqlCommand command = new MySqlCommand(addContactInfo, conn);
                Console.WriteLine("Contact Added Sucessfully!");
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }
        public ContactEntity FindContact(string eMail)
        {
            ContactEntity student = null;
            try
            {
                conn.Open();
                string studentQuery = "Select id, name, phoneNo, eMail, officeAddress from contactInformation where eMail = '" + eMail + "'";
                MySqlCommand command = new MySqlCommand(studentQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string phoneNo = reader.GetString(2);
                        string officeAddress = reader.GetString(4);
                        student = new ContactEntity(id, name, phoneNo, eMail, officeAddress);
                    }
                    Console.WriteLine($"Contact Id: {reader[0]}, Contact Name: {reader[1]}, Contact No.: {reader[2]}, E-mail: {reader[3]}, Office Address: {reader[4]}");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return student;
        }
        public bool UpdateContactInfo(int id, string name, string phoneNO, string eMail, string officeAddress)
        {
            var student = FindContact(eMail);
            if (student == null)
            {
                Console.WriteLine($"Contact with E-mail: {eMail} does not exist");
            }
            try
            {
                conn.Open();
                string updateContactQuery = "update contactInformation set id ='" + id + "', name = '" + name + "' , phoneNo = '" + phoneNO + "', officeAddress = '" + officeAddress + "' where eMail = '" + eMail + "'";
                MySqlCommand command = new MySqlCommand(updateContactQuery, conn);
                int Count = command.ExecuteNonQuery();
                Console.WriteLine("Contact Update Sucessful!");
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }
        public bool DeleteContact(string name)
        {
            if (name == null)
            {
                Console.WriteLine($"Contact with Name: {name} does not exist");
            }
            try
            {
                conn.Open();
                string deleteContactQuery = "delete from contactInformation where name = '" + name + "'";
                MySqlCommand command = new MySqlCommand(deleteContactQuery, conn);
                Console.WriteLine("Contact Deleted Sucessfully!");
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }
        public void ListAllContacts()
        {
            List<ContactEntity> Contacts = new List<ContactEntity>();
            try
            {
                conn.Open();
                string contactQuery = "Select id, name, phoneNo, eMail, officeAddress from contactInformation";
                MySqlCommand command = new MySqlCommand(contactQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Contact Id: {reader[0]}, Contact Name: {reader[1]}, Contact No.: {reader[2]}, E-mail: {reader[3]}, Office Address: {reader[4]}");
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}