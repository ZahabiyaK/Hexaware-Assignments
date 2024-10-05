using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.BuisnessLayer.Services
{
    internal interface ITeacherService
    {
        void UpdateTeacherInfo(string name, string email);
        void DisplayTeacherInfo();
        void GetAssignedCourses();
    }
}
