using System;
using System.Collections.Generic;

namespace MVCCORE_EXAMPORTAL_Final.Models;

public partial class Tblgender
{
    public int GenderId { get; set; }

    public string? Gender { get; set; }

    public virtual ICollection<TbluserDetail> TbluserDetails { get; set; } = new List<TbluserDetail>();
}
