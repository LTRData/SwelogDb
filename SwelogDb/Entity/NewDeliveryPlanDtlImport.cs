using System;
using System.Collections.Generic;

namespace SwelogDb.Entity;

public partial class NewDeliveryPlanDtlImport
{
    public int IdDetail { get; set; }

    public int? IdHeader { get; set; }

    public int ProcessId { get; set; }

    public string? CustomerId { get; set; }

    public string? DeliveryPlanId { get; set; }

    public string? ItemNo { get; set; }

    public string? DeliveryAddressId { get; set; }

    public string? DeladdrFixedYn { get; set; }

    public DateTime? DeliveryDatetime { get; set; }

    public decimal? RequiredQty { get; set; }

    public string? OrderStatus { get; set; }

    public string? PlanStatus { get; set; }

    public string? AuditStamp { get; set; }

    public string? CustomerOrderNo { get; set; }

    public string? OrderNumber { get; set; }

    public string? ConsigLocation { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? ContractOrderType { get; set; }

    public string? ErrorUnknownOrderYn { get; set; }

    public string? WarningMissmatchInAccumYearYn { get; set; }

    public string? WarningNewDeladdrYn { get; set; }

    public string? DeladdrId { get; set; }

    public int? ItemPackingInstructionsExi { get; set; }

    public string? PartConsigment { get; set; }

    public decimal? AutodeductedQty { get; set; }

    public int IdNewDeliveryPlanDtlImport { get; set; }

    public string? PicklistNumber { get; set; }

    public short? PicklistDtlLineNo { get; set; }

    public string? Callno { get; set; }
}
