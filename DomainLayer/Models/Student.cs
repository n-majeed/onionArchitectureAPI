using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Student : BaseEntity
    {
        public string name { get; set; }
        public int rollNo { get; set; }
        public int marks { get; set; }
    }
}
