using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Lesson
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public string? Name { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<LessonContent> LessonContents { get; set; } = new List<LessonContent>();

    public virtual ICollection<StudentProgress> StudentProgresses { get; set; } = new List<StudentProgress>();

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
