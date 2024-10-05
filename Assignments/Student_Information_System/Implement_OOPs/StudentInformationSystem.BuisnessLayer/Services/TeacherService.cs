﻿using StudentInformationSystem.BuisnessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.BuisnessLayer.Services
{
    internal class TeacherService : ITeacherService
    {
        ITeacherRepository _teacherRepository;
        public TeacherService(TeacherRepository teacherRepository) { 
            _teacherRepository = teacherRepository;
        }

        public void DisplayTeacherInfo()
        {
            _teacherRepository.DisplayTeacherInfo();
        }

        public void GetAssignedCourses()
        {
            _teacherRepository.GetAssignedCourses();
        }

        public void UpdateTeacherInfo(string name, string email)
        {
            _teacherRepository.UpdateTeacherInfo(name, email);
        }
    }
}
