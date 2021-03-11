namespace ContosoUniversity.Models

//tinfo200:[2021-03-04-kingtonl-dykstra1] - Code being added from the tutorial website 
// Enrollment is a navigational property which has a one to many relationship with Student and Course
// gets the Enrollment, Course and Student ID and checks for prerequisits to allow for the student to enroll for courses 
// using existing grade scores
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}