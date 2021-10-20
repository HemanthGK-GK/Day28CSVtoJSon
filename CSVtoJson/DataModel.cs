using System;
using System.Collections.Generic;
using System.Text;

namespace CSVtoJson
{
    class DataModel
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phnum { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "\nFirstName :" + Fname +
                   "\nLastName :" + Lname +
                   "\nCity :" + City +
                   "\nState :" + State +
                   "\nZipcode :" + Zipcode +
                   "\nPhoneNum :" + Phnum +
                   "\nEmail :" + Email;
        }
    }
}
