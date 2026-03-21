using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Class
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? GradeId { get; set; }

    public virtual Grade? Grade { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<TestSchedule> TestSchedules { get; set; } = new List<TestSchedule>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
