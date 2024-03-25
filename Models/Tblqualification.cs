using System;
using System.Collections.Generic;

namespace MVCCORE_EXAMPORTAL_Final.Models;

public partial class Tblqualification
{
    public int QualificationId { get; set; }

    public string? Qualification { get; set; }

    public virtual ICollection<TbluserQualification> TbluserQualifications { get; set; } = new List<TbluserQualification>();
}
