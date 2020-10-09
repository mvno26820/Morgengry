using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            double valueOfAmulet = 0;

            switch (amulet.Quality)
            {
                case (Level)0:
                    valueOfAmulet = 12.5;
                    break;
                case (Level)1:
                    valueOfAmulet = 20.0;
                    break;
                case (Level)2:
                    valueOfAmulet = 27.5;
                    break;
                default:
                    Console.WriteLine("Didn't work...");
                    break;
            }

            return valueOfAmulet;
        }
    }
}