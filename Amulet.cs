using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Amulet
    {
        // for notes, see "Books" class
        public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public Amulet(string itemId, Level quality) :
            this(itemId, quality, "")
        {

        }

        public Amulet(string itemId) :
            this(itemId, (Level)1, "")
        {

        }

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
    }
}
