using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Book
    {
        // shortcut (type prop and then press tab) for auto-implemented properties (get/set)
        public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        // constructor overloading
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public Book(string itemId, string title) :
            this(itemId, title, 0)
        {

        }

        public Book(string itemId) :
            this(itemId, "", 0)
        {

        }

        // everything gets convertet into string via override ToString method
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price;
        }
    }
}