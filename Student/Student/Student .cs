using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {   
        private String Name;
        private String Id;
        public String name
        {
            set
            {
                Name = "value";
            }
            get
            {
                return Name;
            }
        }

        public String id
        {
            set
            {
                Id = "value";
            }
            get
            {
                return Id;
            }
        }
    }
}
