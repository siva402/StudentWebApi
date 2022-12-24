using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentdetails.Dtos.Student
{
    public class GetStudentDto
    {
        public int Id { get; set; }
        public string? GivenName { get; set; }
        public string? LastName { get; set; } 
        public int Age { get; set; } 
        public ClassYear Class { get; set; } 

    }
}