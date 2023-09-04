using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class DefectReport
{
    public int DefectId { get; set; }

    public DateTime? DateOfReport { get; set; }

    public string? ModuleId { get; set; }

    public string? ProgramId { get; set; }

    public string? DefectType { get; set; }

    public string? Priority { get; set; }

    public string? DefectDescription { get; set; }

    public string? WindowName { get; set; }

    public string? Programmer { get; set; }

    public string? Tester { get; set; }

    public string? ActionId { get; set; }

    public string? ActionBy { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionTaken { get; set; }

    public string? TesterId { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ActionTbl? Action { get; set; }

    public virtual DefectType? DefectTypeNavigation { get; set; }

    public virtual Module? Module { get; set; }

    public virtual Priority? PriorityNavigation { get; set; }

    public virtual Program? Program { get; set; }
}
