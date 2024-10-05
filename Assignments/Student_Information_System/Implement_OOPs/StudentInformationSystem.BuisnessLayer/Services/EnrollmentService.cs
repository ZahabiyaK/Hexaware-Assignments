using StudentInformationSystem.BuisnessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.BuisnessLayer.Services
{
    internal class EnrollmentService : IEnrollmentService
    {
        IEnrollmentRepository _enrollmentRepository;
        public EnrollmentService(EnrollmentRepository enrollmentRepository) {
            _enrollmentRepository = enrollmentRepository;
        }
        public void GetCourse()
        {
            _enrollmentRepository.GetCourse();
        }

        public void GetStudent()
        {
            _enrollmentRepository.GetStudent();
        }
    }
}
