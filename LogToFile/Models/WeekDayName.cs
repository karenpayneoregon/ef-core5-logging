﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace LogToFile.Models
{
    public partial class WeekDayName
    {
        public WeekDayName()
        {
            CourseDays = new HashSet<CourseDay>();
        }

        public int WeekId { get; set; }
        public string DayName { get; set; }

        public virtual ICollection<CourseDay> CourseDays { get; set; }
    }
}