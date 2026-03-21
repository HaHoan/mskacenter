using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Question
{
    public int Id { get; set; }

    public int? TestId { get; set; }

    public string? Content { get; set; }

    public string? AudioUrl { get; set; }

    public int? Score { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual ICollection<QuestionImage> QuestionImages { get; set; } = new List<QuestionImage>();

    public virtual ICollection<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();

    public virtual Test? Test { get; set; }
}
