using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Student
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public int? ClassId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<StudentProgress> StudentProgresses { get; set; } = new List<StudentProgress>();

    public virtual ICollection<StudentSubmission> StudentSubmissions { get; set; } = new List<StudentSubmission>();

    public virtual ICollection<StudentTest> StudentTests { get; set; } = new List<StudentTest>();

    public virtual User? User { get; set; }
}
