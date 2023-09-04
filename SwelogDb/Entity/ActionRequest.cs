using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class ActionRequest
{
    public string OrderNumber { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string? ActionType { get; set; }

    public string? RequestType { get; set; }

    public int? EmploymentNumber { get; set; }

    public string? ReferenceId { get; set; }

    public string? DepartmentNumber { get; set; }

    public string? ResourceNumber { get; set; }

    public string? ToolNumber { get; set; }

    public short? ToolSerialNumber { get; set; }

    public string? ToolReactivateType { get; set; }

    public string? ProjectNumber { get; set; }

    public string? FreeText { get; set; }

    public string? MeetingNo { get; set; }

    public string? Status { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string? MfgOrderNumber { get; set; }

    public string? MfgItemNumber { get; set; }

    public int? MfgLotNumber { get; set; }

    public string? AuditStamp { get; set; }

    public virtual ICollection<ActionRequestDetail> ActionRequestDetails { get; } = new List<ActionRequestDetail>();
}
