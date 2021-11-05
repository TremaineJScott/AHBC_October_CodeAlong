using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFour
{
    public class Author
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }

        private string website;
        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        public Address authorsAddress;
        public Address AuthorsAddress
        {
            get { return authorsAddress; }
            set { authorsAddress = value; }
        }

        public Author(string fullName, string email)
        {
            FullName = fullName;
            EmailAddress = email;
        }

        public Author(string fullName, string email, string webSite, Address address)
        {
            FullName = fullName;
            EmailAddress = email;
            Website = webSite;
            AuthorsAddress = address;
        }
        public Author(string fullname)
        {
            FullName = fullname;
        }

    }
}
