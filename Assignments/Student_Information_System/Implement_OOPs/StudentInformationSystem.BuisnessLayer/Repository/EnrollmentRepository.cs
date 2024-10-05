using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BuisnessLayer.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        Enrollment e = new Enrollment();
        public EnrollmentRepository(int enroll_id, int student_id,int course_id, DateTime enrollDate)
        {
            e.EnrollmentID = enroll_id;
            e.StudentID = student_id;
            e.CourseID = course_id;
            e.EnrollmentDate = enrollDate;
        }
        public void GetCourse()
        {
            
        }

        public void GetStudent()
        {
            
        }
    }
}
