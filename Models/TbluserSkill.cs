﻿using System;
using System.Collections.Generic;

namespace MVCCORE_EXAMPORTAL_Final.Models;

public partial class TbluserSkill
{
    public int SkillId { get; set; }

    public int? UserId { get; set; }

    public string? SkillTitle { get; set; }

    public string? Skills { get; set; }

    public virtual TbluserDetail? User { get; set; }
}
