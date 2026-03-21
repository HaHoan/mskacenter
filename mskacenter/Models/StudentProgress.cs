using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class StudentProgress
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? LessonId { get; set; }

    public bool? IsCompleted { get; set; }

    public virtual Lesson? Lesson { get; set; }

    public virtual Student? Student { get; set; }
}
