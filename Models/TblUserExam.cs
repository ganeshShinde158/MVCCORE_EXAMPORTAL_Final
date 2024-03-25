using System;
using System.Collections.Generic;

namespace MVCCORE_EXAMPORTAL_Final.Models;

public partial class TblUserExam
{
    public int ExamId { get; set; }

    public int? UserId { get; set; }

    public int? TopicId { get; set; }

    public DateTime? ExamDate { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public virtual ICollection<TblUserExamQuestion> TblUserExamQuestions { get; set; } = new List<TblUserExamQuestion>();

    public virtual TblTopic? Topic { get; set; }

    public virtual TbluserDetail? User { get; set; }
}
