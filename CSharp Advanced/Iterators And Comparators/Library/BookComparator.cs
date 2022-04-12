﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            if(firstBook.Title.CompareTo(secondBook.Title) == 0)
            {
                return secondBook.Year.CompareTo(firstBook.Year);
            }
            return firstBook.Title.CompareTo(secondBook.Title);
        }
    }
}
