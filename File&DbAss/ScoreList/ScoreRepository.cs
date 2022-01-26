using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ScoreRecord
{
    public class ScoreRepository
    {
        MySqlConnection conn;
        public static List<ScoreEntity> Scores = new List<ScoreEntity>();
        public ScoreRepository(MySqlConnection connection)
        {
            conn = connection;
        }
        public bool AddScores(string studentName, int englishScore, int mathScore, int economicScore)
        {
            try
            {
                conn.Open();
                string addScore = "Insert into scoreInformation (studentName, englishScore, mathScore, economicScore)values ('" + studentName + "', '" + englishScore + "', '" + mathScore + "', '" + economicScore + "')";
                MySqlCommand command = new MySqlCommand(addScore, conn);
                Console.WriteLine("Score Added Sucessfully!");
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
        public ScoreEntity FindStudentScore(string studentName)
        {
            ScoreEntity student = null;
            try
            {
                conn.Open();
                string studentQuery = "Select studentName, englishScore, mathScore, economicScore from scoreInformation where studentName = '" + studentName + "'";
                MySqlCommand command = new MySqlCommand(studentQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        int englishScore = reader.GetInt32(1);
                        int mathScore = reader.GetInt32(2);
                        int economicScore = reader.GetInt32(3);
                        student = new ScoreEntity(studentName, englishScore, mathScore, economicScore);
                    }
                    Console.WriteLine($"Student Name: {reader[0]}, English Score: {reader[1]}, Maths Score: {reader[2]}, Economics Score: {reader[3]}");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return student;
        }
        public bool UpdateStudentScore(string studentName, int englishScore, int mathScore, int economicScore)
        {
            var student = FindStudentScore(studentName);
            if (student == null)
            {
                Console.WriteLine($"Student with Name: {studentName} does not exist");
            }
            try
            {
                conn.Open();
                string updateScoreQuery = "update scoreInformation set englishScore ='" + englishScore + "', mathScore = '" + mathScore + "' , economicScore = '" + economicScore + "' where studentName = '" + studentName + "'";
                MySqlCommand command = new MySqlCommand(updateScoreQuery, conn);
                int Count = command.ExecuteNonQuery();
                Console.WriteLine("Student Score Update Sucessful!");
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
        public bool DeleteStudentRecord(string studentName)
        {
            if (studentName == null)
            {
                Console.WriteLine($"Student with Name: {studentName} does not exist");
            }
            try
            {
                conn.Open();
                string deleteStudentQuery = "delete from scoreInformation where studentName = '" + studentName + "'";
                MySqlCommand command = new MySqlCommand(deleteStudentQuery, conn);
                Console.WriteLine("Student Record Deleted Sucessfully!");
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
        public void ListAllRecords()
        {
            List<ScoreEntity> Scores = new List<ScoreEntity>();
            try
            {
                conn.Open();
                string scoreQuery = "Select studentName, englishScore, mathScore, economicScore from scoreInformation";
                MySqlCommand command = new MySqlCommand(scoreQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Student Name: {reader[0]}, English Score: {reader[1]}, Maths Score: {reader[2]}, Economics Score: {reader[3]}");
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void OverallBestStudent()
        {
            // List<ScoreEntity> Scores = new List<ScoreEntity>();
            try
            {
                conn.Open();
                string scoreQuery = "Select studentName, englishScore, mathScore, economicScore from scoreInformation where englishScore+mathScore+economicScore > '" + 0 + "'";
                MySqlCommand command = new MySqlCommand(scoreQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                List<int> TotalScore = new List<int>();
                Dictionary<string, int> studentScore = new Dictionary<string, int>();
                while (reader.Read())
                {
                    int totalScore = Convert.ToInt32(reader[1]) + Convert.ToInt32(reader[2]) + Convert.ToInt32(reader[3]);
                    studentScore.Add(Convert.ToString(reader[0]), totalScore);
                }
                reader.Close();
                conn.Close();
                string student = "";
                int hightest = 0;
                foreach(string key in studentScore.Keys){
                    if (studentScore[key] > hightest ){
                        hightest = studentScore[key];
                        student = key;
                    }
                }
                Console.WriteLine($"The student with the highest score is {student} with score {hightest}");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void NumberOfStudentsAboveAverage()
        {
            try
            {
                int average = 0;
                conn.Open();
                string scoreQuery = "Select studentName, englishScore, mathScore, economicScore from scoreInformation where englishScore+mathScore+economicScore > '" + 100 + "'";
                MySqlCommand command = new MySqlCommand(scoreQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    average++;
                }
                Console.WriteLine($"The number of Students that have their total score above average is: {average}");
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