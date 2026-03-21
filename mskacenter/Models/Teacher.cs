using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class Teacher
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Name { get; set; }

    public virtual User? User { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
