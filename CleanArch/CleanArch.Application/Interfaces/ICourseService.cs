using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Interfaces
{
    interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
