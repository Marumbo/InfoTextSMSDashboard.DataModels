using System;
using System.Collections.Generic;
using System.Text;

namespace InfoTextSMSDashboard.DataModels.Models
{
    public class ContactsDTO
    {
        public int? ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AddedBy { get; set; }
        public string Organization { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? GroupId { get; set; }

    }
}
