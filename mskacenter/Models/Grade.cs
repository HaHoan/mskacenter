using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Grade
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CenterId { get; set; }

    public virtual Center? Center { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
