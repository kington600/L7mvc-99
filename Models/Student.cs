using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
//tinfo200:[2021-03-04-kingtonl-dykstra1] - Code being added from the tutorial website 
// student has a one-to-many relationsihp between enrollment and is used to get First, Last and Middle name, along with ID to 
// enroll and prints out the enrollment date
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}