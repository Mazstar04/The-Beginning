namespace StudentDetails
{
    public class Student
    {
        public string Name;
        public int RollNumber;
        public string PhoneNumber;
        public string Address;

        // public fields created for the student class

        public Student(string name, int rollNumber, string phoneNumber, string address)
        // creating a constructor for the class as collecting valeues for the fields as argument
        {
            Name = name;
            RollNumber = rollNumber;
            PhoneNumber = phoneNumber;
            Address = address;

            //setting the fields value through the constructor arguments
        }


    }
}