using System;
using System.Collections.Generic;

namespace MVCCORE_EXAMPORTAL_Final.Models;

public partial class TbluserObjective
{
    public int ObjectiveId { get; set; }

    public int? UserId { get; set; }

    public string? Objective { get; set; }

    public virtual TbluserDetail? User { get; set; }
}
