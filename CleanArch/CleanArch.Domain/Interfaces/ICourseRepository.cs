using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;

namespace CleanArch.Domain.Interfaces
{
    interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
