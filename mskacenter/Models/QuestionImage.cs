using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class QuestionImage
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string? ImageUrl { get; set; }

    public virtual Question? Question { get; set; }
}
