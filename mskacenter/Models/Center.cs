using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Center
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
