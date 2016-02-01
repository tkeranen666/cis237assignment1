using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        // Create fields for arrays.
        private int id;
        private string description;
        private string pack;

        // Set properties for fields.
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Pack
        {
            get { return pack; }
            set { pack = value; }
        }

        // Three parameter constructor.
        public WineItem(int id, string description, string pack)
        {
            this.id = id;
            this.description = description;
            this.pack = pack;
        }

        // Override method.
        public override string ToString()
        {
            return this.id.ToString() + " " + this.description + " " + this.pack;
        }

    }
}
