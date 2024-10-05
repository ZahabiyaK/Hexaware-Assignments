using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.BuisnessLayer.Repository
{
    internal interface IEnrollmentRepository
    {
        void GetStudent();
        void GetCourse();
    }
}
