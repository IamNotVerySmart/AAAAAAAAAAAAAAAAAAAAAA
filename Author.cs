using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03._30._2023
{
    internal class Author
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Nationality
        {
            get;
            set;
        }
        public Author()
        {
            FirstName = "";
            LastName = "";
            Nationality = "";
        }
        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} \n Surname: {LastName} \n Nationality: {Nationality}";
        }
    }
}
