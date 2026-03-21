using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Report
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? ClassId { get; set; }

    public string? Term { get; set; }

    public double? Reading { get; set; }

    public double? Listening { get; set; }

    public double? Speaking { get; set; }

    public double? Grammar { get; set; }

    public double? TotalScore { get; set; }

    public string? Comment { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Student? Student { get; set; }
}
