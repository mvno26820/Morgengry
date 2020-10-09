﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Controller
    {
        public List<Book> Books { get; set; }

        public List<Amulet> Amulets { get; set; }

        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
        }

        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
