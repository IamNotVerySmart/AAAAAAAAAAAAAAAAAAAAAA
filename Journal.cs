using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03._30._2023
{
    internal class Journal : Item
    {
        public int Number
        {
            get;
            set;
        }
        public Journal() : base()
        {
            Number = 0;
        }
        public Journal( string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"{base.ToString()} \n Number: {Number}";
        }
        public string GenerateBarCode()
        {
            return DateOfIssue.ToString() + "69420";
        }
    }
}
