using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class StudentTest
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? TestId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? SubmitTime { get; set; }

    public double? Score { get; set; }

    public virtual Student? Student { get; set; }

    public virtual ICollection<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();

    public virtual Test? Test { get; set; }
}
