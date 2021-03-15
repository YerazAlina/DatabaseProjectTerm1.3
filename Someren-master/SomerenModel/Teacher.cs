using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Number { get; set; } // LecturerNumber, e.g. 47198

        public string Supervisor { get; set; }

        public DateTime BirthDate { get; set; } //???
    }
}
