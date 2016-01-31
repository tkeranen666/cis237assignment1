using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private int id;
        private string description;
        private string pack;

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

        public WineItem(int id, string description, string pack)
        {
            this.id = id;
            this.description = description;
            this.pack = pack;
        }

        public override string ToString()
        {
            return this.id.ToString() + " " + this.description + " " + this.pack;
        }

    }
}
