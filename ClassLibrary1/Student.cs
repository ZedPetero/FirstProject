using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : BaseClass
    {
        public string? StudentId { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string? Email { get; set; }
        public int ContactNumber { get; set; }

    }
}
