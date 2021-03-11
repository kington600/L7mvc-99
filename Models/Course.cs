using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-04-kingtonl-dykstra1] - Code being added from the tutorial website
    // course is used with Enrollment, to obtain the course ID, name of course and the amount of credits course is worth
    // has a one to many relationship with enrollment
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}