using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class StudentSubmission
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? TestId { get; set; }

    public string? FileUrl { get; set; }

    public double? Score { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Test? Test { get; set; }
}
