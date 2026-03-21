using System;
using System.Collections.Generic;

namespace mskacenter.Models;

public partial class TestSchedule
{
    public int Id { get; set; }

    public int? TestId { get; set; }

    public int? ClassId { get; set; }

    public DateTime? OpenTime { get; set; }

    public DateTime? CloseTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Test? Test { get; set; }
}
