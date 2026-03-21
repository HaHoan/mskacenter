using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class StudentAnswer
{
    public int Id { get; set; }

    public int? StudentTestId { get; set; }

    public int? QuestionId { get; set; }

    public string? AnswerContent { get; set; }

    public bool? IsCorrect { get; set; }

    public virtual Question? Question { get; set; }

    public virtual StudentTest? StudentTest { get; set; }
}
