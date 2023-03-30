﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_03._30._2023
{
    internal class Book : Item
    {
        public int PageCount
        {
            get;
            set;
        }
        public IList<Author> Authors
        {
            get;
            set;
        }
        public Book( string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base( title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }
        public override string ToString()
        {
            return $"{base.ToString()} \n Page count: {PageCount} \n Author: {Authors}";
        }
        public string GenerateBarCode()
        {
            return DateOfIssue.ToString() + "692137";
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
