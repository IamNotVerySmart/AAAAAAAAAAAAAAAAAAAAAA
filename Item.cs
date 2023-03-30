using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03._30._2023
{
    public abstract class Item
    {
        protected int _id;
        protected string _title, _publisher;
        protected DateTime _dateOfIssue;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }
        public DateTime DateOfIssue
        {
            get => _dateOfIssue;
            set => _dateOfIssue = value;
        }
        public Item()
        {
            Id = 0;
            Title = "";
            Publisher = "";
            DateOfIssue = DateTime.Now;
        }
        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"Id: {_id} \n Title: {_title} \n Publisher: {_publisher} \n Date of issue: {_dateOfIssue}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
        public string GenerateBarCode()
        {
            return DateOfIssue.ToString() + "42037";
        }
    }
}
