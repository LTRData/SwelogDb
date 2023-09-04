using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ToDoDetail
{
    public int IdToDoDetail { get; set; }

    public string? ModuleId { get; set; }

    public string? SourceId { get; set; }

    public string? SubId { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? UserId { get; set; }

    public string? RecType { get; set; }

    public decimal? RecValue { get; set; }

    public string? Comments { get; set; }

    public string? AuditStamp { get; set; }
}
