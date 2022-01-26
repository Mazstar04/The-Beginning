using System;

namespace ContactRecord
{
    public class ContactEntity
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string OfficeAddress { get; set; }
        public ContactEntity(int id, string name, string phoneNo, string eMail, string officeAddress)
        {
            Id = id;
            Name = name;
            Email = eMail;
            PhoneNo = phoneNo;
            OfficeAddress = officeAddress;
        }
    }
}