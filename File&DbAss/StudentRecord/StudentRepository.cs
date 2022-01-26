using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StudentRecord
{
    public class StudentRepository
    {
        MySqlConnection conn;
        public static List<StudentEntity> Students = new List<StudentEntity>();
        public StudentRepository(MySqlConnection connection)
        {
            conn = connection;
        }
        public bool AddStudentInfo(string firstName, string lastName, string eMail, string phoneNo, int age, string studentClass)
        {
            try
            {
                conn.Open();
                string addStudentInfo = "Insert into studentInformation (firstName, lastName, eMail, phoneNo, age, class)values ('" + firstName + "', '" + lastName + "', '" + eMail + "', '" + phoneNo + "', '" + age + "', '" + studentClass + "')";
                MySqlCommand command = new MySqlCommand(addStudentInfo, conn);
                Console.WriteLine("Student Information Added Sucessfully!");
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
        public StudentEntity FindStudent(string eMail)
        {
            StudentEntity student = null;
            try
            {
                conn.Open();
                string studentQuery = "Select firstName, lastName, eMail, phoneNo, age, class from studentInformation where eMail = '" + eMail + "'";
                MySqlCommand command = new MySqlCommand(studentQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        string firstName = reader.GetString(0);
                        string lastName = reader.GetString(1);
                        string phoneNo = reader.GetString(3);
                        int age = reader.GetInt32(4);
                        string studentClass = reader.GetString(5);
                        student = new StudentEntity(firstName, lastName, eMail, phoneNo, age, studentClass);
                    }
                    Console.WriteLine($"Student First Name: {reader[0]}  Student Last Name: {reader[1]}");
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return student;
        }
        public void ListAllEmails()
        {
            List<StudentEntity> students = new List<StudentEntity>();
            try
            {
                conn.Open();
                string studentQuery = "Select firstName, lastName, eMail, phoneNo, age, class from studentInformation";
                MySqlCommand command = new MySqlCommand(studentQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[2]);
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool UpdateStudentInfo(string firstName, string eMail, int age)
        {
            var student = FindStudent(eMail);
            if (student == null)
            {
                Console.WriteLine($"Student with {eMail} does not exist");
            }
            try
            {
                conn.Open();
                string updateStudentQuery = "update studentInformation set firstName ='" + firstName + "', age = '" + age + "' where eMail = '" + eMail + "'";
                MySqlCommand command = new MySqlCommand(updateStudentQuery, conn);
                Console.WriteLine("Student Update Sucessful!");
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
        public bool DeleteStudent(string lastName)
        {
            if (lastName == null)
            {
                Console.WriteLine($"student with Last Name: {lastName} does not exist");
            }
            try
            {
                conn.Open();
                string deleteStudentQuery = "delete from studentInformation where lastName = '" + lastName + "'";
                Console.WriteLine("Student Information Deleted Sucessfully!");
                MySqlCommand command = new MySqlCommand(deleteStudentQuery, conn);
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
        public void Above18Years()
        {
            int noOfStudentsGreaterThan18 = 0;
            try
            {
                conn.Open();
                string studentQuery = "select age from studentInformation where age > 18";
                MySqlCommand command = new MySqlCommand(studentQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();  
                while (reader.Read())
                {
                    noOfStudentsGreaterThan18++;
                }
                Console.WriteLine($"No. of people greater than 18years = {noOfStudentsGreaterThan18}");
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }
        public void ListOfJss1Students()
        {
            try
            {
                conn.Open();
                string studentQuery = "select firstName, lastName, eMail, phoneNo, age, class from studentInformation where class = 'jss1';";
                MySqlCommand command = new MySqlCommand(studentQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"First Name: {reader[0]}, Last Name: {reader[1]}, E-mail: {reader[2]}, Phone No.: {reader[3]}, Age: {reader[4]}, Class {reader[5]}");
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }
    }
}