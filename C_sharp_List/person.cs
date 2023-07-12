using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_List
{
    internal class person
    {
        public int id;
        public string name;
        public string gender;
        public string specialization;

        public person(int id, string name,string gender, string specialization)
        {
            this.id = id;
            this.name = name;
            this.specialization = specialization;
        }
    }
}
