using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class LessonContent
{
    public int Id { get; set; }

    public int? LessonId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? VideoUrl { get; set; }

    public virtual Lesson? Lesson { get; set; }
}
