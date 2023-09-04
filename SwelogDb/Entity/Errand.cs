using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class Errand
{
    public int IdErrand { get; set; }

    public string? ErrandDescription { get; set; }

    public string? ErrandCategory { get; set; }

    public string? ErrandStatus { get; set; }

    public string? SpecificationPath { get; set; }

    public string? CustomerId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? PerformedBy { get; set; }

    public short? Priority { get; set; }

    public decimal? EstimatedTime { get; set; }

    public string? VersionNumber { get; set; }

    public string? Comments { get; set; }

    public string? OrderNumber { get; set; }

    public short? OrderLineNumber { get; set; }

    public decimal? SellingPrice { get; set; }

    public DateTime? StatusChangeDatetime { get; set; }

    public string? TestComments { get; set; }

    public DateTime? InvoiceReportDate { get; set; }

    public string? SubIdErrand { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? CustomerReferenceName { get; set; }

    public bool? CreatedFromMail { get; set; }

    public decimal? EstimatedTestingTime { get; set; }

    public string? LocationDescription { get; set; }

    public string? PositionDescription { get; set; }

    public string? PerformedAction { get; set; }

    public string? ItemNumber { get; set; }

    public bool? Publish { get; set; }

    public DateTime? StatusDevDatetime { get; set; }

    public DateTime? PlannedCompletionDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string? AuditStamp { get; set; }

    public int? TodoPriorityNo { get; set; }

    public int? CrmSerialNumber { get; set; }

    public string? CrmId { get; set; }

    public int? SpecificationStatus { get; set; }

    public int? ErrandModuleId { get; set; }

    public int? ErrandSubModuleId { get; set; }

    public string? AdditionalResponsible { get; set; }

    public bool? News { get; set; }
}
