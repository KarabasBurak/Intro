﻿using Intro.DataAccess.Abstracts;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course = new Course();
            course.Id = 1;
            course.Name = "C#";
            course.Description = ".Net 8";
            course.Price = 0;

            Course course1 = new Course();
            course1.Id = 2;
            course1.Name = "JAVA";
            course1.Description = "JAVA 17";
            course1.Price = 10;

            Course course2 = new Course();
            course2.Id = 3;
            course2.Name = "Python";
            course2.Description = "Python 3.12";
            course2.Price = 20;

            courses =new List<Course> { course, course1, course2 };
        }
        public List<Course> GetAll()
        {
            // burada db işlemleri yapılır.

            return courses;
        }

        public void Add(Course course)
        {
           courses.Add(course);
        }
    }


}
