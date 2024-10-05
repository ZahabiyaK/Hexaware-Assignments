using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BuisnessLayer.Repository
{
    public class CourseRepository : ICourseRepository
    {
        Course c = new Course();
        public CourseRepository(int course_id,string course_name,string course_code, string instructor) { 
            c.CourseID = course_id;
            c.CourseName = course_name;
            c.CourseCode = course_code;
            c.InstructorName = instructor;
        }

        public void AssignTeacher(Teacher teacher)
        {
            
        }
        public void UpdateCourseInfo(string courseCode, string courseName, string instructor)
        {
            c.CourseCode=courseCode;
            c.CourseName=courseName;
            c.InstructorName=instructor;
        }
        public void DisplayCourseInfo()
        {
            Console.WriteLine("Displaying Course Information:");
            Console.WriteLine($"{c.CourseID}\t{c.CourseName}\t{c.CourseCode}\t{c.InstructorName}");
        }

        public void GetEnrollments()
        {
            
        }

        public void GetTeacher()
        {
            
        }

        
    }
}
