using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Course
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
