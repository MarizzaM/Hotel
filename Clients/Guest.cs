using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    public class Guest
    {
        private int id;
        private string name;

        public Guest(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int GetId() {
            return this.id;
        }
        public string GetName() {
            return this.name;
        }

        public override string ToString()
        {
            GetId();
            GetName();
            return $"{id}: {name}";
        }
    }
}
