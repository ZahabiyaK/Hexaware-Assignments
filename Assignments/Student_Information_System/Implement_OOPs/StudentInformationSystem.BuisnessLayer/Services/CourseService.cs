using StudentInformationSystem.BuisnessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BuisnessLayer.Services
{
    public class CourseService:ICourseService
    {
        ICourseRepository _courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public void AssignTeacher(Teacher teacher)
        {
            _courseRepository.AssignTeacher(teacher);
        }
        public void UpdateCourseInfo(string courseCode, string courseName, string instructor)
        {
            _courseRepository.UpdateCourseInfo(courseCode, courseName, instructor);
        }
        public void DisplayCourseInfo()
        {
            _courseRepository.DisplayCourseInfo();
        }
        public void GetEnrollments()
        {
           _courseRepository.GetEnrollments();
        }

        public void GetTeacher()
        {
            _courseRepository.GetTeacher();
        }
    }
}
