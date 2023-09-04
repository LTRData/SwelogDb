using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NewDeliveryPlanHdrImport
{
    public int IdHeader { get; set; }

    public int ProcessId { get; set; }

    public int? IdMessage { get; set; }

    public string? CustomerId { get; set; }

    public string? EdiCustomerId { get; set; }

    public string? DeliveryPlanId { get; set; }

    public DateTime? PlanDate { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUpto { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerSuppNo { get; set; }

    public string? LpkAvskod { get; set; }

    public string? DeladdrId { get; set; }

    public string? DeladdrRefName { get; set; }

    public string? DeladdrMottkod { get; set; }

    public string? DeladdrPortkod { get; set; }

    public string? DeladdrForrkod { get; set; }

    public string? CustomerReference { get; set; }

    public string? PlanType { get; set; }

    public string? AuditStamp { get; set; }

    public string? PlanStatus { get; set; }

    public string? CustomerItemNumber { get; set; }

    public string? ItemNumber { get; set; }

    public DateTime? LatestRcvdDeliveryDate { get; set; }

    public int? BackOrderQuantity { get; set; }

    public int? CumulativeQuantity { get; set; }

    public DateTime? AccumStartDate { get; set; }

    public string? ErrorCustomerMissingYn { get; set; }

    public string? ErrorUnknownItemYn { get; set; }

    public string? WarningInvalidDeladdrYn { get; set; }

    public string? WarningNewDeladdrYn { get; set; }

    public string? WarningMissmatchInAccumYearYn { get; set; }

    public int? ItemPackingInstructionsExi { get; set; }

    public string? ReadYn { get; set; }

    public string? DeleteYn { get; set; }

    public string? TransferYn { get; set; }
}
