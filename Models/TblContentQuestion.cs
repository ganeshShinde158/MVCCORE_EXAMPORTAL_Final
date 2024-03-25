using System;
using System.Collections.Generic;

namespace MVCCORE_EXAMPORTAL_Final.Models;

public partial class TblContentQuestion
{
    public int QuestionId { get; set; }

    public int? ContentId { get; set; }

    public string? Question { get; set; }

    public string? Option1 { get; set; }

    public string? Option2 { get; set; }

    public string? Option3 { get; set; }

    public string? Option4 { get; set; }

    public int? CorrectOptionNumber { get; set; }

    public virtual TblTopicContent? Content { get; set; }

    public virtual ICollection<TblUserExamQuestion> TblUserExamQuestions { get; set; } = new List<TblUserExamQuestion>();
}
