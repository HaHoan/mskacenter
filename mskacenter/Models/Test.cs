using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Test
{
    public int Id { get; set; }

    public int? LessonId { get; set; }

    public string? Name { get; set; }

    public int? TotalScore { get; set; }

    public int? Duration { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Lesson? Lesson { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<StudentSubmission> StudentSubmissions { get; set; } = new List<StudentSubmission>();

    public virtual ICollection<StudentTest> StudentTests { get; set; } = new List<StudentTest>();

    public virtual ICollection<TestSchedule> TestSchedules { get; set; } = new List<TestSchedule>();
}
